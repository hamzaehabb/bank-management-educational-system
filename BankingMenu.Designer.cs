using System.Windows.Forms.DataVisualization.Charting;
using BankingServices.classes;

namespace BankingServices
{
    partial class BankingMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankingMenu));
            ChartArea chartArea3 = new ChartArea();
            Legend legend3 = new Legend();
            Series series3 = new Series();
            sidebar = new Panel();
            transfer_button = new Button();
            accounts_button = new Button();
            customer_button = new Button();
            dashboard_button = new Button();
            logo = new PictureBox();
            dashboard = new Panel();
            dashboardmain = new Panel();
            transferpanel = new Panel();
            transferTitle = new Label();
            fromAccountLabel = new Label();
            fromAccountTextBox = new TextBox();
            toAccountLabel = new Label();
            toAccountTextBox = new TextBox();
            transferAmountLabel = new Label();
            transferAmountBox = new NumericUpDown();
            transferExecuteButton = new Button();
            transferStatusLabel = new Label();
            moneychart = new Chart();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            label14 = new Label();
            wealth_lbl = new Label();
            panel4 = new Panel();
            pictureBox5 = new PictureBox();
            label16 = new Label();
            label17 = new Label();
            totalaccs = new Panel();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            total_lbl = new Label();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            cardTotalCustomers = new Panel();
            picIcon = new PictureBox();
            lblTitle = new Label();
            lblValue = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            viewaccount = new Panel();
            amountwith_textbox = new NumericUpDown();
            amountdep_textbox = new NumericUpDown();
            back_button = new Button();
            label4 = new Label();
            accsdata = new DataGridView();
            transactions_buttons = new DataGridViewButtonColumn();
            rate_numric = new NumericUpDown();
            label12 = new Label();
            savingcheck = new CheckBox();
            label11 = new Label();
            createaccount_button = new Button();
            label10 = new Label();
            withdraw_button = new Button();
            label9 = new Label();
            deposit_button = new Button();
            aftname_label = new Label();
            aftemail_label = new Label();
            label7 = new Label();
            aftaddress_label = new Label();
            aftphone_label = new Label();
            label8 = new Label();
            account_panel = new Panel();
            totaltrans_lbl = new Label();
            label13 = new Label();
            recenttrans = new DataGridView();
            transactions_panel = new Panel();
            back_trans = new Button();
            actnumber_lbl = new Label();
            acc_number = new Label();
            transactionsgrid = new DataGridView();
            customerspanel = new Panel();
            crcustomer_button = new Button();
            phone_textbox = new TextBox();
            address_textbox = new TextBox();
            email_textbox = new TextBox();
            name_textbox = new TextBox();
            phone_label = new Label();
            adress_label = new Label();
            email_label = new Label();
            name_label = new Label();
            data_customers = new DataGridView();
            btnView = new DataGridViewButtonColumn();
            saveFileDialog1 = new SaveFileDialog();
            sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            dashboard.SuspendLayout();
            dashboardmain.SuspendLayout();
            transferpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)transferAmountBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)moneychart).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            totalaccs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            cardTotalCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picIcon).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            viewaccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)amountwith_textbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)amountdep_textbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accsdata).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rate_numric).BeginInit();
            account_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)recenttrans).BeginInit();
            transactions_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)transactionsgrid).BeginInit();
            customerspanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_customers).BeginInit();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(20, 50, 90);
            sidebar.Controls.Add(transfer_button);
            sidebar.Controls.Add(accounts_button);
            sidebar.Controls.Add(customer_button);
            sidebar.Controls.Add(dashboard_button);
            sidebar.Controls.Add(logo);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Margin = new Padding(6);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(597, 1827);
            sidebar.TabIndex = 0;
            // 
            // transfer_button
            // 
            transfer_button.BackColor = Color.FromArgb(20, 50, 90);
            transfer_button.FlatAppearance.BorderSize = 0;
            transfer_button.FlatStyle = FlatStyle.Flat;
            transfer_button.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            transfer_button.ForeColor = Color.White;
            transfer_button.Image = (Image)resources.GetObject("transfer_button.Image");
            transfer_button.ImageAlign = ContentAlignment.MiddleLeft;
            transfer_button.Location = new Point(26, 988);
            transfer_button.Margin = new Padding(6);
            transfer_button.Name = "transfer_button";
            transfer_button.Padding = new Padding(32, 0, 0, 0);
            transfer_button.Size = new Size(531, 102);
            transfer_button.TabIndex = 3;
            transfer_button.Text = "   Transfers";
            transfer_button.TextAlign = ContentAlignment.MiddleLeft;
            transfer_button.TextImageRelation = TextImageRelation.ImageBeforeText;
            transfer_button.UseVisualStyleBackColor = false;
            transfer_button.Click += transfer_button_Click;
            // 
            // accounts_button
            // 
            accounts_button.BackColor = Color.FromArgb(20, 50, 90);
            accounts_button.FlatAppearance.BorderSize = 0;
            accounts_button.FlatStyle = FlatStyle.Flat;
            accounts_button.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            accounts_button.ForeColor = Color.White;
            accounts_button.Image = (Image)resources.GetObject("accounts_button.Image");
            accounts_button.ImageAlign = ContentAlignment.MiddleLeft;
            accounts_button.Location = new Point(26, 851);
            accounts_button.Margin = new Padding(6);
            accounts_button.Name = "accounts_button";
            accounts_button.Padding = new Padding(32, 0, 0, 0);
            accounts_button.Size = new Size(531, 102);
            accounts_button.TabIndex = 2;
            accounts_button.Text = "   Transactions";
            accounts_button.TextAlign = ContentAlignment.MiddleLeft;
            accounts_button.TextImageRelation = TextImageRelation.ImageBeforeText;
            accounts_button.UseVisualStyleBackColor = false;
            accounts_button.Click += accounts_button_Click;
            // 
            // customer_button
            // 
            customer_button.BackColor = Color.FromArgb(20, 50, 90);
            customer_button.FlatAppearance.BorderSize = 0;
            customer_button.FlatStyle = FlatStyle.Flat;
            customer_button.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            customer_button.ForeColor = Color.White;
            customer_button.Image = (Image)resources.GetObject("customer_button.Image");
            customer_button.ImageAlign = ContentAlignment.MiddleLeft;
            customer_button.Location = new Point(26, 709);
            customer_button.Margin = new Padding(6);
            customer_button.Name = "customer_button";
            customer_button.Padding = new Padding(32, 0, 0, 0);
            customer_button.Size = new Size(531, 102);
            customer_button.TabIndex = 1;
            customer_button.Text = "   Customers";
            customer_button.TextAlign = ContentAlignment.MiddleLeft;
            customer_button.TextImageRelation = TextImageRelation.ImageBeforeText;
            customer_button.UseVisualStyleBackColor = false;
            customer_button.Click += customer_button_Click;
            // 
            // dashboard_button
            // 
            dashboard_button.BackColor = Color.FromArgb(20, 50, 90);
            dashboard_button.FlatAppearance.BorderSize = 0;
            dashboard_button.FlatStyle = FlatStyle.Flat;
            dashboard_button.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dashboard_button.ForeColor = Color.White;
            dashboard_button.Image = (Image)resources.GetObject("dashboard_button.Image");
            dashboard_button.ImageAlign = ContentAlignment.MiddleLeft;
            dashboard_button.Location = new Point(26, 562);
            dashboard_button.Margin = new Padding(6);
            dashboard_button.Name = "dashboard_button";
            dashboard_button.Padding = new Padding(32, 0, 0, 0);
            dashboard_button.Size = new Size(531, 102);
            dashboard_button.TabIndex = 0;
            dashboard_button.Text = "   Dashboard";
            dashboard_button.TextAlign = ContentAlignment.MiddleLeft;
            dashboard_button.TextImageRelation = TextImageRelation.ImageBeforeText;
            dashboard_button.UseVisualStyleBackColor = false;
            dashboard_button.Click += dashboard_button_Click;
            // 
            // logo
            // 
            logo.BackgroundImageLayout = ImageLayout.Center;
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(74, 25);
            logo.Margin = new Padding(6);
            logo.Name = "logo";
            logo.Size = new Size(416, 392);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 0;
            logo.TabStop = false;
            // 
            // dashboard
            // 
            dashboard.Controls.Add(dashboardmain);
            dashboard.Controls.Add(customerspanel);
            dashboard.Controls.Add(transferpanel);
            dashboard.Controls.Add(viewaccount);
            dashboard.Controls.Add(account_panel);
            dashboard.Controls.Add(transactions_panel);
            dashboard.Dock = DockStyle.Fill;
            dashboard.Location = new Point(597, 0);
            dashboard.Margin = new Padding(6);
            dashboard.Name = "dashboard";
            dashboard.Size = new Size(2123, 1827);
            dashboard.TabIndex = 1;
            // 
            // dashboardmain
            // 
            dashboardmain.Controls.Add(moneychart);
            dashboardmain.Controls.Add(panel1);
            dashboardmain.Controls.Add(panel4);
            dashboardmain.Controls.Add(totalaccs);
            dashboardmain.Controls.Add(panel3);
            dashboardmain.Controls.Add(cardTotalCustomers);
            dashboardmain.Controls.Add(panel2);
            dashboardmain.Dock = DockStyle.Fill;
            dashboardmain.Location = new Point(0, 0);
            dashboardmain.Margin = new Padding(6);
            dashboardmain.Name = "dashboardmain";
            dashboardmain.Size = new Size(2123, 1827);
            dashboardmain.TabIndex = 2;
            // 
            // transferpanel
            // 
            transferpanel.Controls.Add(transferTitle);
            transferpanel.Controls.Add(fromAccountLabel);
            transferpanel.Controls.Add(fromAccountTextBox);
            transferpanel.Controls.Add(toAccountLabel);
            transferpanel.Controls.Add(toAccountTextBox);
            transferpanel.Controls.Add(transferAmountLabel);
            transferpanel.Controls.Add(transferAmountBox);
            transferpanel.Controls.Add(transferExecuteButton);
            transferpanel.Controls.Add(transferStatusLabel);
            transferpanel.Location = new Point(0, 0);
            transferpanel.Margin = new Padding(6);
            transferpanel.Name = "transferpanel";
            transferpanel.Size = new Size(2123, 1827);
            transferpanel.TabIndex = 8;
            // 
            // transferTitle
            // 
            transferTitle.AutoSize = true;
            transferTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            transferTitle.ForeColor = Color.FromArgb(20, 50, 90);
            transferTitle.Location = new Point(744, 62);
            transferTitle.Margin = new Padding(6, 0, 6, 0);
            transferTitle.Name = "transferTitle";
            transferTitle.Size = new Size(473, 81);
            transferTitle.TabIndex = 0;
            transferTitle.Text = "Transfer Money";
            // 
            // fromAccountLabel
            // 
            fromAccountLabel.AutoSize = true;
            fromAccountLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fromAccountLabel.Location = new Point(319, 266);
            fromAccountLabel.Margin = new Padding(6, 0, 6, 0);
            fromAccountLabel.Name = "fromAccountLabel";
            fromAccountLabel.Size = new Size(297, 54);
            fromAccountLabel.TabIndex = 1;
            fromAccountLabel.Text = "From Account:";
            // 
            // fromAccountTextBox
            // 
            fromAccountTextBox.BackColor = Color.White;
            fromAccountTextBox.BorderStyle = BorderStyle.FixedSingle;
            fromAccountTextBox.Font = new Font("Segoe UI", 11F);
            fromAccountTextBox.ForeColor = Color.FromArgb(64, 64, 64);
            fromAccountTextBox.Location = new Point(638, 266);
            fromAccountTextBox.Margin = new Padding(6);
            fromAccountTextBox.Name = "fromAccountTextBox";
            fromAccountTextBox.Size = new Size(742, 56);
            fromAccountTextBox.TabIndex = 2;
            fromAccountTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // toAccountLabel
            // 
            toAccountLabel.AutoSize = true;
            toAccountLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toAccountLabel.Location = new Point(319, 451);
            toAccountLabel.Margin = new Padding(6, 0, 6, 0);
            toAccountLabel.Name = "toAccountLabel";
            toAccountLabel.Size = new Size(242, 54);
            toAccountLabel.TabIndex = 3;
            toAccountLabel.Text = "To Account:";
            // 
            // toAccountTextBox
            // 
            toAccountTextBox.BackColor = Color.White;
            toAccountTextBox.BorderStyle = BorderStyle.FixedSingle;
            toAccountTextBox.Font = new Font("Segoe UI", 11F);
            toAccountTextBox.ForeColor = Color.FromArgb(64, 64, 64);
            toAccountTextBox.Location = new Point(638, 451);
            toAccountTextBox.Margin = new Padding(6);
            toAccountTextBox.Name = "toAccountTextBox";
            toAccountTextBox.Size = new Size(742, 56);
            toAccountTextBox.TabIndex = 4;
            toAccountTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // transferAmountLabel
            // 
            transferAmountLabel.AutoSize = true;
            transferAmountLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            transferAmountLabel.Location = new Point(319, 636);
            transferAmountLabel.Margin = new Padding(6, 0, 6, 0);
            transferAmountLabel.Name = "transferAmountLabel";
            transferAmountLabel.Size = new Size(251, 54);
            transferAmountLabel.TabIndex = 5;
            transferAmountLabel.Text = "Amount ($):";
            // 
            // transferAmountBox
            // 
            transferAmountBox.BorderStyle = BorderStyle.FixedSingle;
            transferAmountBox.DecimalPlaces = 2;
            transferAmountBox.Font = new Font("Segoe UI", 11F);
            transferAmountBox.ForeColor = Color.FromArgb(64, 64, 64);
            transferAmountBox.Location = new Point(638, 636);
            transferAmountBox.Margin = new Padding(6);
            transferAmountBox.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            transferAmountBox.Name = "transferAmountBox";
            transferAmountBox.Size = new Size(744, 56);
            transferAmountBox.TabIndex = 6;
            transferAmountBox.TextAlign = HorizontalAlignment.Center;
            // 
            // transferExecuteButton
            // 
            transferExecuteButton.BackColor = Color.FromArgb(52, 152, 219);
            transferExecuteButton.FlatAppearance.BorderSize = 0;
            transferExecuteButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(31, 97, 141);
            transferExecuteButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(41, 128, 185);
            transferExecuteButton.FlatStyle = FlatStyle.Flat;
            transferExecuteButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            transferExecuteButton.ForeColor = Color.White;
            transferExecuteButton.Location = new Point(769, 791);
            transferExecuteButton.Margin = new Padding(6);
            transferExecuteButton.Name = "transferExecuteButton";
            transferExecuteButton.Size = new Size(425, 102);
            transferExecuteButton.TabIndex = 7;
            transferExecuteButton.Text = "Transfer";
            transferExecuteButton.UseVisualStyleBackColor = false;
            transferExecuteButton.Click += transfer_execute_Click;
            // 
            // transferStatusLabel
            // 
            transferStatusLabel.AutoSize = true;
            transferStatusLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            transferStatusLabel.ForeColor = Color.FromArgb(52, 152, 219);
            transferStatusLabel.Location = new Point(319, 1025);
            transferStatusLabel.Margin = new Padding(6, 0, 6, 0);
            transferStatusLabel.Name = "transferStatusLabel";
            transferStatusLabel.Size = new Size(0, 50);
            transferStatusLabel.TabIndex = 9;
            // 
            // moneychart
            // 
            chartArea3.Name = "ChartArea1";
            moneychart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            moneychart.Legends.Add(legend3);
            moneychart.Location = new Point(64, 305);
            moneychart.Margin = new Padding(6);
            moneychart.Name = "moneychart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            moneychart.Series.Add(series3);
            moneychart.Size = new Size(1927, 1402);
            moneychart.TabIndex = 7;
            moneychart.Text = "Money Growth";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(wealth_lbl);
            panel1.Location = new Point(1439, 62);
            panel1.Margin = new Padding(6);
            panel1.Name = "panel1";
            panel1.Size = new Size(552, 205);
            panel1.TabIndex = 5;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.InitialImage = (Image)resources.GetObject("pictureBox4.InitialImage");
            pictureBox4.Location = new Point(32, 41);
            pictureBox4.Margin = new Padding(6);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(128, 123);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10F);
            label14.ForeColor = Color.DimGray;
            label14.Location = new Point(181, 51);
            label14.Margin = new Padding(6, 0, 6, 0);
            label14.Name = "label14";
            label14.Size = new Size(205, 46);
            label14.TabIndex = 1;
            label14.Text = "Total Money";
            // 
            // wealth_lbl
            // 
            wealth_lbl.AutoSize = true;
            wealth_lbl.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            wealth_lbl.ForeColor = Color.Green;
            wealth_lbl.Location = new Point(176, 92);
            wealth_lbl.Margin = new Padding(6, 0, 6, 0);
            wealth_lbl.Name = "wealth_lbl";
            wealth_lbl.Size = new Size(155, 89);
            wealth_lbl.TabIndex = 2;
            wealth_lbl.Text = "256";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(pictureBox5);
            panel4.Controls.Add(label16);
            panel4.Controls.Add(label17);
            panel4.Location = new Point(1439, 62);
            panel4.Margin = new Padding(6);
            panel4.Name = "panel4";
            panel4.Size = new Size(552, 205);
            panel4.TabIndex = 6;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.White;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.InitialImage = (Image)resources.GetObject("pictureBox5.InitialImage");
            pictureBox5.Location = new Point(32, 41);
            pictureBox5.Margin = new Padding(6);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(128, 123);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 10F);
            label16.ForeColor = Color.DimGray;
            label16.Location = new Point(181, 51);
            label16.Margin = new Padding(6, 0, 6, 0);
            label16.Name = "label16";
            label16.Size = new Size(260, 46);
            label16.TabIndex = 1;
            label16.Text = "Total Customers";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label17.ForeColor = Color.FromArgb(52, 152, 219);
            label17.Location = new Point(176, 92);
            label17.Margin = new Padding(6, 0, 6, 0);
            label17.Name = "label17";
            label17.Size = new Size(155, 89);
            label17.TabIndex = 2;
            label17.Text = "256";
            // 
            // totalaccs
            // 
            totalaccs.BackColor = Color.White;
            totalaccs.Controls.Add(pictureBox2);
            totalaccs.Controls.Add(label3);
            totalaccs.Controls.Add(total_lbl);
            totalaccs.Location = new Point(756, 62);
            totalaccs.Margin = new Padding(6);
            totalaccs.Name = "totalaccs";
            totalaccs.Size = new Size(552, 205);
            totalaccs.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(32, 41);
            pictureBox2.Margin = new Padding(6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(128, 123);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(181, 51);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(239, 46);
            label3.TabIndex = 1;
            label3.Text = "Total Accounts";
            // 
            // total_lbl
            // 
            total_lbl.AutoSize = true;
            total_lbl.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            total_lbl.ForeColor = Color.Black;
            total_lbl.Location = new Point(176, 92);
            total_lbl.Margin = new Padding(6, 0, 6, 0);
            total_lbl.Name = "total_lbl";
            total_lbl.Size = new Size(155, 89);
            total_lbl.TabIndex = 2;
            total_lbl.Text = "256";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(756, 62);
            panel3.Margin = new Padding(6);
            panel3.Name = "panel3";
            panel3.Size = new Size(552, 205);
            panel3.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.InitialImage = (Image)resources.GetObject("pictureBox3.InitialImage");
            pictureBox3.Location = new Point(32, 41);
            pictureBox3.Margin = new Padding(6);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(128, 123);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(181, 51);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(260, 46);
            label5.TabIndex = 1;
            label5.Text = "Total Customers";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(52, 152, 219);
            label6.Location = new Point(176, 92);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(155, 89);
            label6.TabIndex = 2;
            label6.Text = "256";
            // 
            // cardTotalCustomers
            // 
            cardTotalCustomers.BackColor = Color.White;
            cardTotalCustomers.Controls.Add(picIcon);
            cardTotalCustomers.Controls.Add(lblTitle);
            cardTotalCustomers.Controls.Add(lblValue);
            cardTotalCustomers.Location = new Point(64, 62);
            cardTotalCustomers.Margin = new Padding(6);
            cardTotalCustomers.Name = "cardTotalCustomers";
            cardTotalCustomers.Size = new Size(552, 205);
            cardTotalCustomers.TabIndex = 0;
            // 
            // picIcon
            // 
            picIcon.BackColor = Color.White;
            picIcon.Image = (Image)resources.GetObject("picIcon.Image");
            picIcon.InitialImage = (Image)resources.GetObject("picIcon.InitialImage");
            picIcon.Location = new Point(32, 41);
            picIcon.Margin = new Padding(6);
            picIcon.Name = "picIcon";
            picIcon.Size = new Size(128, 123);
            picIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            picIcon.TabIndex = 0;
            picIcon.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 10F);
            lblTitle.ForeColor = Color.DimGray;
            lblTitle.Location = new Point(181, 51);
            lblTitle.Margin = new Padding(6, 0, 6, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(260, 46);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Total Customers";
            // 
            // lblValue
            // 
            lblValue.AutoSize = true;
            lblValue.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblValue.ForeColor = Color.FromArgb(52, 152, 219);
            lblValue.Location = new Point(176, 92);
            lblValue.Margin = new Padding(6, 0, 6, 0);
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(155, 89);
            lblValue.TabIndex = 2;
            lblValue.Text = "256";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(64, 62);
            panel2.Margin = new Padding(6);
            panel2.Name = "panel2";
            panel2.Size = new Size(552, 205);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(32, 41);
            pictureBox1.Margin = new Padding(6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 123);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(181, 51);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(260, 46);
            label1.TabIndex = 1;
            label1.Text = "Total Customers";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(52, 152, 219);
            label2.Location = new Point(176, 92);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(155, 89);
            label2.TabIndex = 2;
            label2.Text = "256";
            // 
            // viewaccount
            // 
            viewaccount.Controls.Add(amountwith_textbox);
            viewaccount.Controls.Add(amountdep_textbox);
            viewaccount.Controls.Add(back_button);
            viewaccount.Controls.Add(label4);
            viewaccount.Controls.Add(accsdata);
            viewaccount.Controls.Add(rate_numric);
            viewaccount.Controls.Add(label12);
            viewaccount.Controls.Add(savingcheck);
            viewaccount.Controls.Add(label11);
            viewaccount.Controls.Add(createaccount_button);
            viewaccount.Controls.Add(label10);
            viewaccount.Controls.Add(withdraw_button);
            viewaccount.Controls.Add(label9);
            viewaccount.Controls.Add(deposit_button);
            viewaccount.Controls.Add(aftname_label);
            viewaccount.Controls.Add(aftemail_label);
            viewaccount.Controls.Add(label7);
            viewaccount.Controls.Add(aftaddress_label);
            viewaccount.Controls.Add(aftphone_label);
            viewaccount.Controls.Add(label8);
            viewaccount.Location = new Point(0, 0);
            viewaccount.Margin = new Padding(6);
            viewaccount.Name = "viewaccount";
            viewaccount.Size = new Size(2116, 1818);
            viewaccount.TabIndex = 10;
            // 
            // amountwith_textbox
            // 
            amountwith_textbox.BorderStyle = BorderStyle.FixedSingle;
            amountwith_textbox.DecimalPlaces = 2;
            amountwith_textbox.Font = new Font("Segoe UI", 11F);
            amountwith_textbox.ForeColor = Color.FromArgb(64, 64, 64);
            amountwith_textbox.Location = new Point(1536, 246);
            amountwith_textbox.Margin = new Padding(6);
            amountwith_textbox.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            amountwith_textbox.Name = "amountwith_textbox";
            amountwith_textbox.Size = new Size(536, 56);
            amountwith_textbox.TabIndex = 43;
            amountwith_textbox.TextAlign = HorizontalAlignment.Center;
            // 
            // amountdep_textbox
            // 
            amountdep_textbox.BorderStyle = BorderStyle.FixedSingle;
            amountdep_textbox.DecimalPlaces = 2;
            amountdep_textbox.Font = new Font("Segoe UI", 11F);
            amountdep_textbox.ForeColor = Color.FromArgb(64, 64, 64);
            amountdep_textbox.Location = new Point(1536, 35);
            amountdep_textbox.Margin = new Padding(6);
            amountdep_textbox.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            amountdep_textbox.Name = "amountdep_textbox";
            amountdep_textbox.Size = new Size(536, 56);
            amountdep_textbox.TabIndex = 42;
            amountdep_textbox.TextAlign = HorizontalAlignment.Center;
            // 
            // back_button
            // 
            back_button.BackColor = Color.FromArgb(52, 152, 219);
            back_button.FlatAppearance.BorderSize = 0;
            back_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(31, 97, 141);
            back_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(41, 128, 185);
            back_button.FlatStyle = FlatStyle.Flat;
            back_button.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            back_button.ForeColor = Color.White;
            back_button.Location = new Point(64, 644);
            back_button.Margin = new Padding(6);
            back_button.Name = "back_button";
            back_button.Size = new Size(425, 92);
            back_button.TabIndex = 41;
            back_button.Text = "<-- Back";
            back_button.UseVisualStyleBackColor = false;
            back_button.Click += back_button_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(1300, 607);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(267, 54);
            label4.TabIndex = 40;
            label4.Text = "Interst Rate :";
            // 
            // accsdata
            // 
            accsdata.AllowUserToAddRows = false;
            accsdata.AllowUserToDeleteRows = false;
            accsdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            accsdata.Columns.AddRange(new DataGridViewColumn[] { transactions_buttons });
            accsdata.Location = new Point(6, 769);
            accsdata.Margin = new Padding(6);
            accsdata.Name = "accsdata";
            accsdata.ReadOnly = true;
            accsdata.RowHeadersWidth = 51;
            accsdata.Size = new Size(2116, 1056);
            accsdata.TabIndex = 1;
            accsdata.CellContentClick += accsdata_CellContentClick;
            // 
            // transactions_buttons
            // 
            transactions_buttons.HeaderText = "Transactions";
            transactions_buttons.MinimumWidth = 6;
            transactions_buttons.Name = "transactions_buttons";
            transactions_buttons.ReadOnly = true;
            transactions_buttons.Text = "View";
            transactions_buttons.ToolTipText = "View";
            transactions_buttons.UseColumnTextForButtonValue = true;
            transactions_buttons.Width = 125;
            // 
            // rate_numric
            // 
            rate_numric.BorderStyle = BorderStyle.FixedSingle;
            rate_numric.DecimalPlaces = 2;
            rate_numric.Font = new Font("Segoe UI", 11F);
            rate_numric.ForeColor = Color.FromArgb(64, 64, 64);
            rate_numric.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            rate_numric.Location = new Point(1598, 609);
            rate_numric.Margin = new Padding(6);
            rate_numric.Name = "rate_numric";
            rate_numric.Size = new Size(255, 56);
            rate_numric.TabIndex = 39;
            rate_numric.TextAlign = HorizontalAlignment.Center;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(53, 23);
            label12.Margin = new Padding(6, 0, 6, 0);
            label12.Name = "label12";
            label12.Size = new Size(158, 54);
            label12.TabIndex = 23;
            label12.Text = "Name :";
            // 
            // savingcheck
            // 
            savingcheck.Appearance = Appearance.Button;
            savingcheck.BackColor = Color.White;
            savingcheck.FlatAppearance.CheckedBackColor = Color.FromArgb(52, 152, 219);
            savingcheck.FlatStyle = FlatStyle.Flat;
            savingcheck.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            savingcheck.ForeColor = Color.FromArgb(52, 152, 219);
            savingcheck.Location = new Point(1245, 510);
            savingcheck.Margin = new Padding(6);
            savingcheck.Name = "savingcheck";
            savingcheck.Size = new Size(340, 82);
            savingcheck.TabIndex = 38;
            savingcheck.Text = "Savings Account";
            savingcheck.TextAlign = ContentAlignment.MiddleCenter;
            savingcheck.UseVisualStyleBackColor = false;
            savingcheck.CheckedChanged += savingcheck_CheckedChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(53, 199);
            label11.Margin = new Padding(6, 0, 6, 0);
            label11.Name = "label11";
            label11.Size = new Size(147, 54);
            label11.TabIndex = 24;
            label11.Text = "Email :";
            // 
            // createaccount_button
            // 
            createaccount_button.BackColor = Color.FromArgb(52, 152, 219);
            createaccount_button.FlatAppearance.BorderSize = 0;
            createaccount_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(31, 97, 141);
            createaccount_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(41, 128, 185);
            createaccount_button.FlatStyle = FlatStyle.Flat;
            createaccount_button.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            createaccount_button.ForeColor = Color.White;
            createaccount_button.Location = new Point(1598, 504);
            createaccount_button.Margin = new Padding(6);
            createaccount_button.Name = "createaccount_button";
            createaccount_button.Size = new Size(425, 92);
            createaccount_button.TabIndex = 37;
            createaccount_button.Text = "Create Account";
            createaccount_button.UseVisualStyleBackColor = false;
            createaccount_button.Click += createaccount_button_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(4, 381);
            label10.Margin = new Padding(6, 0, 6, 0);
            label10.Name = "label10";
            label10.Size = new Size(197, 54);
            label10.TabIndex = 25;
            label10.Text = "Address :";
            // 
            // withdraw_button
            // 
            withdraw_button.BackColor = Color.FromArgb(52, 152, 219);
            withdraw_button.FlatAppearance.BorderSize = 0;
            withdraw_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(31, 97, 141);
            withdraw_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(41, 128, 185);
            withdraw_button.FlatStyle = FlatStyle.Flat;
            withdraw_button.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            withdraw_button.ForeColor = Color.White;
            withdraw_button.Location = new Point(1598, 324);
            withdraw_button.Margin = new Padding(6);
            withdraw_button.Name = "withdraw_button";
            withdraw_button.Size = new Size(425, 92);
            withdraw_button.TabIndex = 36;
            withdraw_button.Text = "Withdraw";
            withdraw_button.UseVisualStyleBackColor = false;
            withdraw_button.Click += withdraw_button_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(38, 551);
            label9.Margin = new Padding(6, 0, 6, 0);
            label9.Name = "label9";
            label9.Size = new Size(164, 54);
            label9.TabIndex = 26;
            label9.Text = "Phone :";
            // 
            // deposit_button
            // 
            deposit_button.BackColor = Color.FromArgb(52, 152, 219);
            deposit_button.FlatAppearance.BorderSize = 0;
            deposit_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(31, 97, 141);
            deposit_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(41, 128, 185);
            deposit_button.FlatStyle = FlatStyle.Flat;
            deposit_button.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            deposit_button.ForeColor = Color.White;
            deposit_button.Location = new Point(1598, 111);
            deposit_button.Margin = new Padding(6);
            deposit_button.Name = "deposit_button";
            deposit_button.Size = new Size(425, 92);
            deposit_button.TabIndex = 35;
            deposit_button.Text = "Deposit";
            deposit_button.UseVisualStyleBackColor = false;
            deposit_button.Click += deposit_button_Click;
            // 
            // aftname_label
            // 
            aftname_label.AutoSize = true;
            aftname_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            aftname_label.Location = new Point(234, 23);
            aftname_label.Margin = new Padding(6, 0, 6, 0);
            aftname_label.Name = "aftname_label";
            aftname_label.Size = new Size(323, 54);
            aftname_label.TabIndex = 27;
            aftname_label.Text = "Ibrahim Moataz";
            // 
            // aftemail_label
            // 
            aftemail_label.AutoSize = true;
            aftemail_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            aftemail_label.Location = new Point(234, 199);
            aftemail_label.Margin = new Padding(6, 0, 6, 0);
            aftemail_label.Name = "aftemail_label";
            aftemail_label.Size = new Size(585, 54);
            aftemail_label.TabIndex = 28;
            aftemail_label.Text = "ibrahiim.moatazz@gmail.com";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(1277, 254);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(231, 54);
            label7.TabIndex = 33;
            label7.Text = "Withdraw :";
            // 
            // aftaddress_label
            // 
            aftaddress_label.AutoSize = true;
            aftaddress_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            aftaddress_label.Location = new Point(234, 381);
            aftaddress_label.Margin = new Padding(6, 0, 6, 0);
            aftaddress_label.Name = "aftaddress_label";
            aftaddress_label.Size = new Size(314, 54);
            aftaddress_label.TabIndex = 29;
            aftaddress_label.Text = "48 abo dawoud";
            // 
            // aftphone_label
            // 
            aftphone_label.AutoSize = true;
            aftphone_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            aftphone_label.Location = new Point(234, 551);
            aftphone_label.Margin = new Padding(6, 0, 6, 0);
            aftphone_label.Name = "aftphone_label";
            aftphone_label.Size = new Size(327, 54);
            aftphone_label.TabIndex = 30;
            aftphone_label.Text = "+201022571162";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(1320, 33);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(191, 54);
            label8.TabIndex = 31;
            label8.Text = "Deposit :";
            // 
            // account_panel
            // 
            account_panel.Controls.Add(totaltrans_lbl);
            account_panel.Controls.Add(label13);
            account_panel.Controls.Add(recenttrans);
            account_panel.Location = new Point(0, 0);
            account_panel.Margin = new Padding(6);
            account_panel.Name = "account_panel";
            account_panel.Size = new Size(2125, 1827);
            account_panel.TabIndex = 10;
            // 
            // totaltrans_lbl
            // 
            totaltrans_lbl.AutoSize = true;
            totaltrans_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totaltrans_lbl.Location = new Point(38, 209);
            totaltrans_lbl.Margin = new Padding(6, 0, 6, 0);
            totaltrans_lbl.Name = "totaltrans_lbl";
            totaltrans_lbl.Size = new Size(439, 54);
            totaltrans_lbl.TabIndex = 25;
            totaltrans_lbl.Text = "Total Transactions : 30";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(822, 33);
            label13.Margin = new Padding(6, 0, 6, 0);
            label13.Name = "label13";
            label13.Size = new Size(396, 54);
            label13.TabIndex = 24;
            label13.Text = "Recent Transactions";
            // 
            // recenttrans
            // 
            recenttrans.AllowUserToAddRows = false;
            recenttrans.AllowUserToDeleteRows = false;
            recenttrans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            recenttrans.Location = new Point(2, 674);
            recenttrans.Margin = new Padding(6);
            recenttrans.Name = "recenttrans";
            recenttrans.ReadOnly = true;
            recenttrans.RowHeadersWidth = 51;
            recenttrans.Size = new Size(2119, 1148);
            recenttrans.TabIndex = 0;
            // 
            // transactions_panel
            // 
            transactions_panel.Controls.Add(back_trans);
            transactions_panel.Controls.Add(actnumber_lbl);
            transactions_panel.Controls.Add(acc_number);
            transactions_panel.Controls.Add(transactionsgrid);
            transactions_panel.Location = new Point(0, 0);
            transactions_panel.Margin = new Padding(6);
            transactions_panel.Name = "transactions_panel";
            transactions_panel.Size = new Size(2121, 1822);
            transactions_panel.TabIndex = 44;
            // 
            // back_trans
            // 
            back_trans.BackColor = Color.FromArgb(52, 152, 219);
            back_trans.FlatAppearance.BorderSize = 0;
            back_trans.FlatAppearance.MouseDownBackColor = Color.FromArgb(31, 97, 141);
            back_trans.FlatAppearance.MouseOverBackColor = Color.FromArgb(41, 128, 185);
            back_trans.FlatStyle = FlatStyle.Flat;
            back_trans.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            back_trans.ForeColor = Color.White;
            back_trans.Location = new Point(70, 232);
            back_trans.Margin = new Padding(6);
            back_trans.Name = "back_trans";
            back_trans.Size = new Size(425, 92);
            back_trans.TabIndex = 42;
            back_trans.Text = "<-- Back";
            back_trans.UseVisualStyleBackColor = false;
            back_trans.Click += back_trans_Click;
            // 
            // actnumber_lbl
            // 
            actnumber_lbl.AutoSize = true;
            actnumber_lbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            actnumber_lbl.Location = new Point(646, 70);
            actnumber_lbl.Margin = new Padding(6, 0, 6, 0);
            actnumber_lbl.Name = "actnumber_lbl";
            actnumber_lbl.Size = new Size(350, 81);
            actnumber_lbl.TabIndex = 29;
            actnumber_lbl.Text = "124325324";
            // 
            // acc_number
            // 
            acc_number.AutoSize = true;
            acc_number.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            acc_number.Location = new Point(53, 62);
            acc_number.Margin = new Padding(6, 0, 6, 0);
            acc_number.Name = "acc_number";
            acc_number.Size = new Size(548, 81);
            acc_number.TabIndex = 28;
            acc_number.Text = "Account Number :";
            // 
            // transactionsgrid
            // 
            transactionsgrid.AllowUserToAddRows = false;
            transactionsgrid.AllowUserToDeleteRows = false;
            transactionsgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            transactionsgrid.Location = new Point(2, 484);
            transactionsgrid.Margin = new Padding(6);
            transactionsgrid.Name = "transactionsgrid";
            transactionsgrid.ReadOnly = true;
            transactionsgrid.RowHeadersWidth = 51;
            transactionsgrid.Size = new Size(2114, 1332);
            transactionsgrid.TabIndex = 0;
            // 
            // customerspanel
            // 
            customerspanel.Controls.Add(crcustomer_button);
            customerspanel.Controls.Add(phone_textbox);
            customerspanel.Controls.Add(address_textbox);
            customerspanel.Controls.Add(email_textbox);
            customerspanel.Controls.Add(name_textbox);
            customerspanel.Controls.Add(phone_label);
            customerspanel.Controls.Add(adress_label);
            customerspanel.Controls.Add(email_label);
            customerspanel.Controls.Add(name_label);
            customerspanel.Controls.Add(data_customers);
            customerspanel.Location = new Point(0, 0);
            customerspanel.Margin = new Padding(6);
            customerspanel.Name = "customerspanel";
            customerspanel.Size = new Size(2125, 1822);
            customerspanel.TabIndex = 1;
            // 
            // crcustomer_button
            // 
            crcustomer_button.BackColor = Color.FromArgb(52, 152, 219);
            crcustomer_button.FlatAppearance.BorderSize = 0;
            crcustomer_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(31, 97, 141);
            crcustomer_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(41, 128, 185);
            crcustomer_button.FlatStyle = FlatStyle.Flat;
            crcustomer_button.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            crcustomer_button.ForeColor = Color.White;
            crcustomer_button.Location = new Point(1400, 346);
            crcustomer_button.Margin = new Padding(6);
            crcustomer_button.Name = "crcustomer_button";
            crcustomer_button.Size = new Size(425, 92);
            crcustomer_button.TabIndex = 9;
            crcustomer_button.Text = "Create Customer";
            crcustomer_button.UseVisualStyleBackColor = false;
            crcustomer_button.Click += crcustomer_button_Click;
            // 
            // phone_textbox
            // 
            phone_textbox.BackColor = Color.White;
            phone_textbox.BorderStyle = BorderStyle.FixedSingle;
            phone_textbox.Font = new Font("Segoe UI", 11F);
            phone_textbox.ForeColor = Color.FromArgb(64, 64, 64);
            phone_textbox.Location = new Point(353, 625);
            phone_textbox.Margin = new Padding(6);
            phone_textbox.Name = "phone_textbox";
            phone_textbox.Size = new Size(644, 56);
            phone_textbox.TabIndex = 8;
            // 
            // address_textbox
            // 
            address_textbox.BackColor = Color.White;
            address_textbox.BorderStyle = BorderStyle.FixedSingle;
            address_textbox.Font = new Font("Segoe UI", 11F);
            address_textbox.ForeColor = Color.FromArgb(64, 64, 64);
            address_textbox.Location = new Point(353, 457);
            address_textbox.Margin = new Padding(6);
            address_textbox.Name = "address_textbox";
            address_textbox.Size = new Size(644, 56);
            address_textbox.TabIndex = 7;
            // 
            // email_textbox
            // 
            email_textbox.BackColor = Color.White;
            email_textbox.BorderStyle = BorderStyle.FixedSingle;
            email_textbox.Font = new Font("Segoe UI", 11F);
            email_textbox.ForeColor = Color.FromArgb(64, 64, 64);
            email_textbox.Location = new Point(353, 273);
            email_textbox.Margin = new Padding(6);
            email_textbox.Name = "email_textbox";
            email_textbox.Size = new Size(644, 56);
            email_textbox.TabIndex = 6;
            // 
            // name_textbox
            // 
            name_textbox.BackColor = Color.White;
            name_textbox.BorderStyle = BorderStyle.FixedSingle;
            name_textbox.Font = new Font("Segoe UI", 11F);
            name_textbox.ForeColor = Color.FromArgb(64, 64, 64);
            name_textbox.Location = new Point(353, 96);
            name_textbox.Margin = new Padding(6);
            name_textbox.Name = "name_textbox";
            name_textbox.Size = new Size(644, 56);
            name_textbox.TabIndex = 5;
            // 
            // phone_label
            // 
            phone_label.AutoSize = true;
            phone_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            phone_label.Location = new Point(157, 625);
            phone_label.Margin = new Padding(6, 0, 6, 0);
            phone_label.Name = "phone_label";
            phone_label.Size = new Size(164, 54);
            phone_label.TabIndex = 4;
            phone_label.Text = "Phone :";
            // 
            // adress_label
            // 
            adress_label.AutoSize = true;
            adress_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adress_label.Location = new Point(123, 455);
            adress_label.Margin = new Padding(6, 0, 6, 0);
            adress_label.Name = "adress_label";
            adress_label.Size = new Size(197, 54);
            adress_label.TabIndex = 3;
            adress_label.Text = "Address :";
            // 
            // email_label
            // 
            email_label.AutoSize = true;
            email_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            email_label.Location = new Point(172, 273);
            email_label.Margin = new Padding(6, 0, 6, 0);
            email_label.Name = "email_label";
            email_label.Size = new Size(147, 54);
            email_label.TabIndex = 2;
            email_label.Text = "Email :";
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            name_label.Location = new Point(172, 96);
            name_label.Margin = new Padding(6, 0, 6, 0);
            name_label.Name = "name_label";
            name_label.Size = new Size(158, 54);
            name_label.TabIndex = 1;
            name_label.Text = "Name :";
            // 
            // data_customers
            // 
            data_customers.AllowUserToAddRows = false;
            data_customers.AllowUserToDeleteRows = false;
            data_customers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_customers.Columns.AddRange(new DataGridViewColumn[] { btnView });
            data_customers.Location = new Point(6, 851);
            data_customers.Margin = new Padding(6);
            data_customers.Name = "data_customers";
            data_customers.ReadOnly = true;
            data_customers.RowHeadersWidth = 51;
            data_customers.Size = new Size(2112, 966);
            data_customers.TabIndex = 0;
            data_customers.CellContentClick += data_customers_CellContentClick;
            // 
            // btnView
            // 
            btnView.HeaderText = "Accounts";
            btnView.MinimumWidth = 6;
            btnView.Name = "btnView";
            btnView.ReadOnly = true;
            btnView.Text = "View";
            btnView.UseColumnTextForButtonValue = true;
            btnView.Width = 125;
            // 
            // BankingMenu
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2720, 1827);
            Controls.Add(dashboard);
            Controls.Add(sidebar);
            Margin = new Padding(6);
            Name = "BankingMenu";
            Text = "BankingMenu";
            sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            dashboard.ResumeLayout(false);
            dashboardmain.ResumeLayout(false);
            transferpanel.ResumeLayout(false);
            transferpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)transferAmountBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)moneychart).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            totalaccs.ResumeLayout(false);
            totalaccs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            cardTotalCustomers.ResumeLayout(false);
            cardTotalCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picIcon).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            viewaccount.ResumeLayout(false);
            viewaccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)amountwith_textbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)amountdep_textbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)accsdata).EndInit();
            ((System.ComponentModel.ISupportInitialize)rate_numric).EndInit();
            account_panel.ResumeLayout(false);
            account_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)recenttrans).EndInit();
            transactions_panel.ResumeLayout(false);
            transactions_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)transactionsgrid).EndInit();
            customerspanel.ResumeLayout(false);
            customerspanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)data_customers).EndInit();
            ResumeLayout(false);
        }
        private void btn_Click(object sender, EventArgs e)
        {
            // Reset all buttons to dark blue
            foreach (Control c in sidebar.Controls)
            {
                if (c is Button) c.BackColor = Color.FromArgb(20, 50, 90);
            }
    
            ((Button)sender).BackColor = Color.FromArgb(40, 80, 150);
        }
        private void data_customers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && data_customers.Columns[e.ColumnIndex].Name == "btnView")
            {
                var value = data_customers.Rows[e.RowIndex].Cells["Id"].Value;

                if (value != null && int.TryParse(value.ToString(), out int customerId))
                {
                    Customer selectedCustomer = Customers.FirstOrDefault(c => c.Id == customerId);

                    if (selectedCustomer != null)
                    {
                       ShowAccounts(selectedCustomer);
                    }
                }
            }
        }
       
        #endregion

        private Panel sidebar;
        private Panel dashboard;
        private PictureBox logo;
        private Button dashboard_button;
        private Panel cardTotalCustomers;
        private PictureBox picIcon;
        private Label lblTitle;
        private Label lblValue;
        private Button customer_button;
        private Panel dashboardmain;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Panel customerspanel;
        private DataGridView data_customers;
        private TextBox name_textbox;
        private Label phone_label;
        private Label adress_label;
        private Label email_label;
        private Label name_label;
        private Button crcustomer_button;
        private TextBox phone_textbox;
        private TextBox address_textbox;
        private TextBox email_textbox;
        private Button accounts_button;
        private Panel account_panel;
        private Panel totalaccs;
        private PictureBox pictureBox2;
        private Label label3;
        private Label total_lbl;
        private Panel panel3;
        private PictureBox pictureBox3;
        private Label label5;
        private Label label6;
        private Panel viewaccount;
        private DataGridView accsdata;
        private DataGridViewButtonColumn btnView;
        private Label label4;
        private NumericUpDown rate_numric;
        private Label label12;
        private CheckBox savingcheck;
        private Label label11;
        private Button createaccount_button;
        private Label label10;
        private Button withdraw_button;
        private Label label9;
        private Button deposit_button;
        private Label aftname_label;
        private Label aftemail_label;
        private Label label7;
        private Label aftaddress_label;
        private Label aftphone_label;
        private Label label8;
        private Button back_button;
        private DataGridViewButtonColumn transactions_buttons;
        private NumericUpDown amountwith_textbox;
        private NumericUpDown amountdep_textbox;
        private Panel transactions_panel;
        private Label acc_number;
        private DataGridView transactionsgrid;
        private Label actnumber_lbl;
        private Button back_trans;
        private DataGridView recenttrans;
        private Label totaltrans_lbl;
        private Label label13;
        private Panel panel1;
        private PictureBox pictureBox4;
        private Label label14;
        private Label wealth_lbl;
        private Panel panel4;
        private PictureBox pictureBox5;
        private Label label16;
        private Label label17;
        private Chart moneychart;
        private SaveFileDialog saveFileDialog1;
        private Button transfer_button;
        private Panel transferpanel;
        private Label transferTitle;
        private Label fromAccountLabel;
        private TextBox fromAccountTextBox;
        private Label toAccountLabel;
        private TextBox toAccountTextBox;
        private Label transferAmountLabel;
        private NumericUpDown transferAmountBox;
        private Button transferExecuteButton;
        private Label transferStatusLabel;
    }
}