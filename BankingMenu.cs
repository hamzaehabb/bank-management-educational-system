using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankingServices.classes;
using System.Windows.Forms.DataVisualization.Charting;

namespace BankingServices
{
    public partial class BankingMenu : Form
    {
        BindingList<Customer> Customers = new BindingList<Customer>();
        BindingList<Transaction> Transactions = new BindingList<Transaction>();

        Customer? ShownCustomer = null;
        int TotalAcconts = 0;
        double TotalMoney = 0;

        private System.Windows.Forms.Timer moneyChartTimer;
        private DateTime chartStartTime;

        public BankingMenu()
        {
            InitializeComponent();
            data_customers.DataSource = Customers;
            GetNumberOfCutomers();
            total_lbl.Text = TotalAcconts.ToString();
            GetTotalTransactions();
            wealth_lbl.Text = TotalMoney.ToString("F2");

            InitializeMoneyChart();
            StartMoneyChartTracking();
        }
        // Build the dashboard dynamically at runtime so the designer doesn't crash

        private void InitializeMoneyChart()
        {
            // Clear existing series and setup fresh chart
            moneychart.Series.Clear();
            moneychart.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm";
            moneychart.ChartAreas[0].AxisX.Title = "Time";
            moneychart.ChartAreas[0].AxisY.Title = "Total Money ($)";

            // Create the series for money tracking
            Series moneySeries = new Series("Total Money")
            {
                ChartType = SeriesChartType.Line,
                BorderWidth = 2,
                IsXValueIndexed = false
            };

            moneychart.Series.Add(moneySeries);

            // Store the start time
            chartStartTime = DateTime.Now;

            // Add first data point
            AddMoneyDataPoint();
        }

        private void StartMoneyChartTracking()
        {
            // Create timer that fires every minute (60000 milliseconds)
            moneyChartTimer = new System.Windows.Forms.Timer();
            moneyChartTimer.Interval = 60000; // 1 minute
            moneyChartTimer.Tick += MoneyChartTimer_Tick;
            moneyChartTimer.Start();
        }

        private void MoneyChartTimer_Tick(object sender, EventArgs e)
        {
            AddMoneyDataPoint();
        }

        private void AddMoneyDataPoint()
        {
            if (moneychart.Series.Count > 0)
            {
                Series series = moneychart.Series[0];
                DateTime currentTime = DateTime.Now;

                // Add data point with X-value as time and Y-value as total money
                series.Points.AddXY(currentTime, TotalMoney);

                // Force chart refresh
                moneychart.Invalidate();
            }
        }

        // Build the dashboard dynamically at runtime so the designer doesn't crash


        public void RefreshGrid()
        {
            data_customers.DataSource = null;
            data_customers.DataSource = Customers;
        }
        public void ClearCreateData()
        {
            name_textbox.Text = "";
            email_textbox.Text = "";
            address_textbox.Text = "";
            phone_textbox.Text = "";
        }
        public void GetNumberOfCutomers()
        {
            // Set the label directly without the foreach loop, otherwise it won't execute if the list is empty.
            lblValue.Text = Customers.Count.ToString();
        }

        private void dashboard_button_Click(object sender, EventArgs e)
        {
            dashboardmain.BringToFront();
            GetNumberOfCutomers();

        }

        private void customer_button_Click(object sender, EventArgs e)
        {
            customerspanel.BringToFront();
            RefreshGrid();
        }

        private void crcustomer_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(name_textbox.Text) || string.IsNullOrEmpty(email_textbox.Text) || string.IsNullOrEmpty(address_textbox.Text) || string.IsNullOrEmpty(phone_textbox.Text))
            {
                MessageBox.Show("Please fill in all fields to create a customer.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!phone_textbox.Text.All(c => "+0123456789".Contains(c)))
            {
                MessageBox.Show("Phone number contains invalid characters.",
                    "Phone Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            Customer createdcustomer = new Customer(name_textbox.Text, email_textbox.Text, address_textbox.Text, phone_textbox.Text);
            Customers.Add(createdcustomer);
            RefreshGrid();
            ClearCreateData();
            GetNumberOfCutomers();

        }

        private void accounts_button_Click(object sender, EventArgs e)
        {
            GetTotalTransactions();
            account_panel.BringToFront();
        }
        private void savingcheck_CheckedChanged(object sender, EventArgs e)
        {
            if (savingcheck.Checked)
            {
                // Active: White text on blue background
                savingcheck.BackColor = Color.FromArgb(52, 152, 219);
                savingcheck.ForeColor = Color.White;
                savingcheck.Text = "Savings Account ✓";
            }
            else
            {
                // Inactive: Blue text on white background
                savingcheck.BackColor = Color.White;
                savingcheck.ForeColor = Color.FromArgb(52, 152, 219);
                savingcheck.Text = "Savings Account";
            }
        }
        private void LoadCustomerData(Customer customer)
        {
            aftname_label.Text = customer.Name;
            aftemail_label.Text = customer.Email;
            aftaddress_label.Text = customer.Address;
            aftphone_label.Text = customer.Phone;
        }
        public void ShowAccounts(Customer customer)
        {

            LoadCustomerData(customer);
            viewaccount.BringToFront();
            ShownCustomer = customer;
            RefreshAccounts();

        }
        public void GetTotalTransactions()
        {
            Transactions.Clear();
            foreach (var coustomer in Customers)
            {
                foreach (var account in coustomer.Accounts)
                {
                    foreach (var transaction in account.Transactions)
                    {
                        Transactions.Add(transaction);

                    }
                }
            }
            recenttrans.DataSource = null;
            recenttrans.DataSource = Transactions.OrderByDescending(t => t.Date).Take(10).ToList();
            totaltrans_lbl.Text = "Total Transactions : " + Transactions.Count.ToString();


        }
        public void RefreshAccounts()
        {
            if (ShownCustomer != null)
            {
                // Create a data source that includes account type and interest rate
                var accountsData = ShownCustomer.Accounts.Select(acc => new
                {
                    acc.AccountNumber,
                    acc.Balance,
                    AccountType = acc is SavingsAccount ? "Savings" : "Checking",
                    InterestRate = acc is SavingsAccount ? ((SavingsAccount)acc).InterestRate.ToString("P2") : "-"
                }).ToList();

                accsdata.DataSource = null;
                accsdata.DataSource = accountsData;

            }
        }
        private void createaccount_button_Click(object sender, EventArgs e)
        {
            if (savingcheck.Checked)
            {
                if (ShownCustomer != null)
                {
                    ShownCustomer.Accounts.Add(new SavingsAccount((double)rate_numric.Value));
                    RefreshAccounts();
                    MessageBox.Show($"Savings account created for {ShownCustomer.Name}");
                    TotalAcconts++;
                    total_lbl.Text = TotalAcconts.ToString();
                }
                else
                {
                    MessageBox.Show("No customer selected. Please select a customer to create an account for.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (ShownCustomer != null)
                {
                    ShownCustomer.Accounts.Add(new Account());
                    RefreshAccounts();
                    MessageBox.Show($"Checking account created for {ShownCustomer.Name}");
                    TotalAcconts++;
                    total_lbl.Text = TotalAcconts.ToString();
                }
                else
                {
                    MessageBox.Show("No customer selected. Please select a customer to create an account for.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            ShownCustomer = null;
            customerspanel.BringToFront();

        }

        private void accsdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in the transactions_buttons column
            if (e.RowIndex >= 0 && accsdata.Columns[e.ColumnIndex].Name == "transactions_buttons")
            {
                // Get the account number from the current row
                if (accsdata.Rows[e.RowIndex].Cells["AccountNumber"].Value is int accountNumber)
                {
                    // Find the account in the ShownCustomer's accounts
                    Account? selectedAccount = ShownCustomer?.Accounts.FirstOrDefault(acc => acc.AccountNumber == accountNumber);

                    if (selectedAccount != null)
                    {
                        actnumber_lbl.Text = selectedAccount.AccountNumber.ToString();
                        transactionsgrid.DataSource = null;
                        transactionsgrid.DataSource = selectedAccount.Transactions;
                        transactions_panel.BringToFront();
                    }
                }
            }
        }

        private void deposit_button_Click(object sender, EventArgs e)
        {
            if (ShownCustomer == null)
            {
                MessageBox.Show("No customer selected. Please select a customer first.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (accsdata.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an account to deposit into.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int selectedIndex = accsdata.SelectedRows[0].Index;
            if (selectedIndex < 0 || selectedIndex >= ShownCustomer.Accounts.Count)
            {
                MessageBox.Show("Invalid account selection.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Account selectedAccount = ShownCustomer.Accounts[selectedIndex];



            selectedAccount.Deposit((double)amountdep_textbox.Value);
            RefreshAccounts();
            MessageBox.Show($"Successfully deposited ${(double)amountdep_textbox.Value:F2} to account {selectedAccount.AccountNumber}.", "Deposit Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TotalMoney += (double)amountdep_textbox.Value;
            wealth_lbl.Text = TotalMoney.ToString("F2");
            AddMoneyDataPoint();
        }

        private void withdraw_button_Click(object sender, EventArgs e)
        {
            if (ShownCustomer == null)
            {
                MessageBox.Show("No customer selected. Please select a customer first.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (accsdata.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an account to withdraw from.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int selectedIndex = accsdata.SelectedRows[0].Index;
            if (selectedIndex < 0 || selectedIndex >= ShownCustomer.Accounts.Count)
            {
                MessageBox.Show("Invalid account selection.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Account selectedAccount = ShownCustomer.Accounts[selectedIndex];
            if (selectedAccount.Withdraw((double)amountwith_textbox.Value))
            {

                TotalMoney -= (double)amountwith_textbox.Value;
                wealth_lbl.Text = TotalMoney.ToString("F2");
                AddMoneyDataPoint();
                MessageBox.Show($"Successfully withdrew ${(double)amountwith_textbox.Value:F2} from account {selectedAccount.AccountNumber}.", "Withdrawal Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            RefreshAccounts();

        }

        private void back_trans_Click(object sender, EventArgs e)
        {
            viewaccount.BringToFront();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void transfer_button_Click(object sender, EventArgs e)
        {
            transferpanel.BringToFront();
            RefreshTransferTextBoxes();
        }

        private void RefreshTransferTextBoxes()
        {
            fromAccountTextBox.Clear();
            toAccountTextBox.Clear();
            transferAmountBox.Value = 0;
            transferStatusLabel.Text = "";
        }

        private void transfer_execute_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(fromAccountTextBox.Text))
            {
                MessageBox.Show("Please enter a From Account number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(toAccountTextBox.Text))
            {
                MessageBox.Show("Please enter a To Account number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(fromAccountTextBox.Text, out int fromAccountNum))
            {
                MessageBox.Show("From Account must be a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(toAccountTextBox.Text, out int toAccountNum))
            {
                MessageBox.Show("To Account must be a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (fromAccountNum == toAccountNum)
            {
                MessageBox.Show("Cannot transfer to the same account.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double amount = (double)transferAmountBox.Value;

            if (amount <= 0)
            {
                MessageBox.Show("Please enter a valid amount greater than 0.", "Amount Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Find the accounts
            Account fromAccount = null;
            Account toAccount = null;

            foreach (var customer in Customers)
            {
                foreach (var account in customer.Accounts)
                {
                    if (account.AccountNumber == fromAccountNum)
                        fromAccount = account;
                    if (account.AccountNumber == toAccountNum)
                        toAccount = account;
                }
            }

            if (fromAccount == null)
            {
                MessageBox.Show($"From Account #{fromAccountNum} not found.", "Account Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                transferStatusLabel.ForeColor = Color.Red;
                transferStatusLabel.Text = "✗ From Account not found";
                return;
            }

            if (toAccount == null)
            {
                MessageBox.Show($"To Account #{toAccountNum} not found.", "Account Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                transferStatusLabel.ForeColor = Color.Red;
                transferStatusLabel.Text = "✗ To Account not found";
                return;
            }

            // Perform the transfer
            if (fromAccount.Withdraw(amount))
            {

                toAccount.Deposit(amount);
                TotalMoney -= amount;
                TotalMoney += amount;
                wealth_lbl.Text = TotalMoney.ToString("F2");
                AddMoneyDataPoint();

                MessageBox.Show($"Successfully transferred ${amount:F2} from Account #{fromAccount.AccountNumber} to Account #{toAccount.AccountNumber}.",
                    "Transfer Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                transferStatusLabel.ForeColor = Color.Green;
                transferStatusLabel.Text = $"✓ Transfer completed successfully!";

                RefreshTransferTextBoxes();
            }
            else
            {
                MessageBox.Show("Transfer failed. Insufficient funds in the From Account.", "Transfer Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                transferStatusLabel.ForeColor = Color.Red;
                transferStatusLabel.Text = "✗ Transfer failed - Insufficient funds";
            }
        }

        private void dark_mode_btn_Click(object sender, EventArgs e)
        {

        }
    }
}