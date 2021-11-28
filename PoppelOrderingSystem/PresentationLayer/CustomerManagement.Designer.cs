namespace PoppelOrderingSystem.PresentationLayer
{
    partial class CustomerManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerManagement));
            this.inputLabel = new System.Windows.Forms.Label();
            this.customerInputGroupBox = new System.Windows.Forms.GroupBox();
            this.formatLabel = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.MaskedTextBox();
            this.searchButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.userNotFoundErrorLabel = new System.Windows.Forms.Label();
            this.telephoneRadioButton = new System.Windows.Forms.RadioButton();
            this.customerNumberRadioButton = new System.Windows.Forms.RadioButton();
            this.personalDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.phoneErrorLabel = new System.Windows.Forms.Label();
            this.phoneNumberMaskBox = new System.Windows.Forms.MaskedTextBox();
            this.emailErrorMessageLabel = new System.Windows.Forms.Label();
            this.lastNameErrorMessageLabel = new System.Windows.Forms.Label();
            this.firstNameErrorMessageLabel = new System.Windows.Forms.Label();
            this.emailAddressTextBox = new System.Windows.Forms.TextBox();
            this.emailAddressLabel = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.streetAddressTextBox = new System.Windows.Forms.TextBox();
            this.streetAddressLabel = new System.Windows.Forms.Label();
            this.suburbLabel = new System.Windows.Forms.Label();
            this.suburbTextBox = new System.Windows.Forms.TextBox();
            this.townLabel = new System.Windows.Forms.Label();
            this.townTextBox = new System.Windows.Forms.TextBox();
            this.zipCodeLabel = new System.Windows.Forms.Label();
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.streetErrorMessageLabel = new System.Windows.Forms.Label();
            this.suburbErrorMessageLabel = new System.Windows.Forms.Label();
            this.townErrorMessageLabel = new System.Windows.Forms.Label();
            this.zipCodeErrorMessageLabel = new System.Windows.Forms.Label();
            this.addressGroupBox = new System.Windows.Forms.GroupBox();
            this.cityErrorMessageLabel = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.customersGroupBox = new System.Windows.Forms.GroupBox();
            this.customerClickInfoLabel = new System.Windows.Forms.Label();
            this.customerListView = new System.Windows.Forms.ListView();
            this.creditGroupBox = new System.Windows.Forms.GroupBox();
            this.creditErrorLabel = new System.Windows.Forms.Label();
            this.creditLimitErrorLabel = new System.Windows.Forms.Label();
            this.creditLimitTextBox = new System.Windows.Forms.TextBox();
            this.creditLimitLabel = new System.Windows.Forms.Label();
            this.currentCreditTextBox = new System.Windows.Forms.TextBox();
            this.currentCreditLabel = new System.Windows.Forms.Label();
            this.editErrorLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cancelButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cancelOrderButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.placeOrderButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.customerInputGroupBox.SuspendLayout();
            this.personalDetailsGroupBox.SuspendLayout();
            this.addressGroupBox.SuspendLayout();
            this.customersGroupBox.SuspendLayout();
            this.creditGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(6, 71);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(82, 13);
            this.inputLabel.TabIndex = 15;
            this.inputLabel.Text = "Customer Code:";
            // 
            // customerInputGroupBox
            // 
            this.customerInputGroupBox.Controls.Add(this.formatLabel);
            this.customerInputGroupBox.Controls.Add(this.inputTextBox);
            this.customerInputGroupBox.Controls.Add(this.searchButton);
            this.customerInputGroupBox.Controls.Add(this.userNotFoundErrorLabel);
            this.customerInputGroupBox.Controls.Add(this.telephoneRadioButton);
            this.customerInputGroupBox.Controls.Add(this.customerNumberRadioButton);
            this.customerInputGroupBox.Controls.Add(this.inputLabel);
            this.customerInputGroupBox.Location = new System.Drawing.Point(13, 73);
            this.customerInputGroupBox.Name = "customerInputGroupBox";
            this.customerInputGroupBox.Size = new System.Drawing.Size(674, 143);
            this.customerInputGroupBox.TabIndex = 0;
            this.customerInputGroupBox.TabStop = false;
            this.customerInputGroupBox.Text = "Customer Input";
            // 
            // formatLabel
            // 
            this.formatLabel.AutoSize = true;
            this.formatLabel.BackColor = System.Drawing.Color.Transparent;
            this.formatLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.formatLabel.Location = new System.Drawing.Point(326, 71);
            this.formatLabel.Name = "formatLabel";
            this.formatLabel.Size = new System.Drawing.Size(173, 13);
            this.formatLabel.TabIndex = 22;
            this.formatLabel.Text = "Example Customer Code: mldtal001";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(93, 68);
            this.inputTextBox.Mask = "LLLLLL000";
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(227, 20);
            this.inputTextBox.TabIndex = 2;
            this.inputTextBox.Leave += new System.EventHandler(this.inputTextBox_Leave);
            // 
            // searchButton
            // 
            this.searchButton.ActiveBorderThickness = 1;
            this.searchButton.ActiveCornerRadius = 20;
            this.searchButton.ActiveFillColor = System.Drawing.Color.Blue;
            this.searchButton.ActiveForecolor = System.Drawing.Color.White;
            this.searchButton.ActiveLineColor = System.Drawing.Color.Blue;
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.searchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchButton.BackgroundImage")));
            this.searchButton.ButtonText = "Search";
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.searchButton.IdleBorderThickness = 1;
            this.searchButton.IdleCornerRadius = 20;
            this.searchButton.IdleFillColor = System.Drawing.Color.White;
            this.searchButton.IdleForecolor = System.Drawing.Color.Blue;
            this.searchButton.IdleLineColor = System.Drawing.Color.Blue;
            this.searchButton.Location = new System.Drawing.Point(222, 91);
            this.searchButton.Margin = new System.Windows.Forms.Padding(5);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(98, 36);
            this.searchButton.TabIndex = 44;
            this.searchButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // userNotFoundErrorLabel
            // 
            this.userNotFoundErrorLabel.AutoSize = true;
            this.userNotFoundErrorLabel.BackColor = System.Drawing.Color.Transparent;
            this.userNotFoundErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.userNotFoundErrorLabel.Location = new System.Drawing.Point(6, 105);
            this.userNotFoundErrorLabel.Name = "userNotFoundErrorLabel";
            this.userNotFoundErrorLabel.Size = new System.Drawing.Size(70, 13);
            this.userNotFoundErrorLabel.TabIndex = 20;
            this.userNotFoundErrorLabel.Text = "<Error Label>";
            this.userNotFoundErrorLabel.Visible = false;
            // 
            // telephoneRadioButton
            // 
            this.telephoneRadioButton.AutoSize = true;
            this.telephoneRadioButton.Location = new System.Drawing.Point(9, 42);
            this.telephoneRadioButton.Name = "telephoneRadioButton";
            this.telephoneRadioButton.Size = new System.Drawing.Size(116, 17);
            this.telephoneRadioButton.TabIndex = 1;
            this.telephoneRadioButton.Text = "Telephone Number";
            this.telephoneRadioButton.UseVisualStyleBackColor = true;
            this.telephoneRadioButton.CheckedChanged += new System.EventHandler(this.telephoneRadioButton_CheckedChanged);
            // 
            // customerNumberRadioButton
            // 
            this.customerNumberRadioButton.AutoSize = true;
            this.customerNumberRadioButton.Checked = true;
            this.customerNumberRadioButton.Location = new System.Drawing.Point(9, 19);
            this.customerNumberRadioButton.Name = "customerNumberRadioButton";
            this.customerNumberRadioButton.Size = new System.Drawing.Size(97, 17);
            this.customerNumberRadioButton.TabIndex = 0;
            this.customerNumberRadioButton.TabStop = true;
            this.customerNumberRadioButton.Text = "Customer Code";
            this.customerNumberRadioButton.UseVisualStyleBackColor = true;
            this.customerNumberRadioButton.CheckedChanged += new System.EventHandler(this.customerNumberRadioButton_CheckedChanged);
            // 
            // personalDetailsGroupBox
            // 
            this.personalDetailsGroupBox.Controls.Add(this.phoneErrorLabel);
            this.personalDetailsGroupBox.Controls.Add(this.phoneNumberMaskBox);
            this.personalDetailsGroupBox.Controls.Add(this.emailErrorMessageLabel);
            this.personalDetailsGroupBox.Controls.Add(this.lastNameErrorMessageLabel);
            this.personalDetailsGroupBox.Controls.Add(this.firstNameErrorMessageLabel);
            this.personalDetailsGroupBox.Controls.Add(this.emailAddressTextBox);
            this.personalDetailsGroupBox.Controls.Add(this.emailAddressLabel);
            this.personalDetailsGroupBox.Controls.Add(this.phoneNumberLabel);
            this.personalDetailsGroupBox.Controls.Add(this.lastNameTextBox);
            this.personalDetailsGroupBox.Controls.Add(this.lastNameLabel);
            this.personalDetailsGroupBox.Controls.Add(this.firstNameTextBox);
            this.personalDetailsGroupBox.Controls.Add(this.firstNameLabel);
            this.personalDetailsGroupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.personalDetailsGroupBox.Location = new System.Drawing.Point(12, 222);
            this.personalDetailsGroupBox.Name = "personalDetailsGroupBox";
            this.personalDetailsGroupBox.Size = new System.Drawing.Size(674, 133);
            this.personalDetailsGroupBox.TabIndex = 5;
            this.personalDetailsGroupBox.TabStop = false;
            this.personalDetailsGroupBox.Text = "Personal Details";
            this.personalDetailsGroupBox.Visible = false;
            // 
            // phoneErrorLabel
            // 
            this.phoneErrorLabel.AutoSize = true;
            this.phoneErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.phoneErrorLabel.Location = new System.Drawing.Point(466, 80);
            this.phoneErrorLabel.Name = "phoneErrorLabel";
            this.phoneErrorLabel.Size = new System.Drawing.Size(70, 13);
            this.phoneErrorLabel.TabIndex = 28;
            this.phoneErrorLabel.Text = "<Error Label>";
            this.phoneErrorLabel.Visible = false;
            // 
            // phoneNumberMaskBox
            // 
            this.phoneNumberMaskBox.Location = new System.Drawing.Point(119, 77);
            this.phoneNumberMaskBox.Mask = "(000) 000-0000";
            this.phoneNumberMaskBox.Name = "phoneNumberMaskBox";
            this.phoneNumberMaskBox.ReadOnly = true;
            this.phoneNumberMaskBox.Size = new System.Drawing.Size(341, 20);
            this.phoneNumberMaskBox.TabIndex = 23;
            this.phoneNumberMaskBox.Leave += new System.EventHandler(this.phoneNumberMaskBox_Leave);
            // 
            // emailErrorMessageLabel
            // 
            this.emailErrorMessageLabel.AutoSize = true;
            this.emailErrorMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.emailErrorMessageLabel.Location = new System.Drawing.Point(466, 103);
            this.emailErrorMessageLabel.Name = "emailErrorMessageLabel";
            this.emailErrorMessageLabel.Size = new System.Drawing.Size(70, 13);
            this.emailErrorMessageLabel.TabIndex = 27;
            this.emailErrorMessageLabel.Text = "<Error Label>";
            this.emailErrorMessageLabel.Visible = false;
            // 
            // lastNameErrorMessageLabel
            // 
            this.lastNameErrorMessageLabel.AutoSize = true;
            this.lastNameErrorMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.lastNameErrorMessageLabel.Location = new System.Drawing.Point(466, 54);
            this.lastNameErrorMessageLabel.Name = "lastNameErrorMessageLabel";
            this.lastNameErrorMessageLabel.Size = new System.Drawing.Size(70, 13);
            this.lastNameErrorMessageLabel.TabIndex = 25;
            this.lastNameErrorMessageLabel.Text = "<Error Label>";
            this.lastNameErrorMessageLabel.Visible = false;
            // 
            // firstNameErrorMessageLabel
            // 
            this.firstNameErrorMessageLabel.AutoSize = true;
            this.firstNameErrorMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.firstNameErrorMessageLabel.Location = new System.Drawing.Point(466, 25);
            this.firstNameErrorMessageLabel.Name = "firstNameErrorMessageLabel";
            this.firstNameErrorMessageLabel.Size = new System.Drawing.Size(70, 13);
            this.firstNameErrorMessageLabel.TabIndex = 24;
            this.firstNameErrorMessageLabel.Text = "<Error Label>";
            this.firstNameErrorMessageLabel.Visible = false;
            // 
            // emailAddressTextBox
            // 
            this.emailAddressTextBox.Location = new System.Drawing.Point(119, 103);
            this.emailAddressTextBox.Name = "emailAddressTextBox";
            this.emailAddressTextBox.ReadOnly = true;
            this.emailAddressTextBox.Size = new System.Drawing.Size(341, 20);
            this.emailAddressTextBox.TabIndex = 23;
            this.emailAddressTextBox.Leave += new System.EventHandler(this.emailAddressTextBox_Leave);
            // 
            // emailAddressLabel
            // 
            this.emailAddressLabel.AutoSize = true;
            this.emailAddressLabel.Location = new System.Drawing.Point(37, 106);
            this.emailAddressLabel.Name = "emailAddressLabel";
            this.emailAddressLabel.Size = new System.Drawing.Size(76, 13);
            this.emailAddressLabel.TabIndex = 21;
            this.emailAddressLabel.Text = "Email Address:";
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(32, 77);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(81, 13);
            this.phoneNumberLabel.TabIndex = 20;
            this.phoneNumberLabel.Text = "Phone Number:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(119, 51);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.ReadOnly = true;
            this.lastNameTextBox.Size = new System.Drawing.Size(341, 20);
            this.lastNameTextBox.TabIndex = 19;
            this.lastNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lastNameTextBox_KeyPress);
            this.lastNameTextBox.Leave += new System.EventHandler(this.lastNameTextBox_Leave);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(52, 54);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.lastNameLabel.TabIndex = 18;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(119, 25);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.ReadOnly = true;
            this.firstNameTextBox.Size = new System.Drawing.Size(341, 20);
            this.firstNameTextBox.TabIndex = 11;
            this.firstNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstNameTestBox_KeyPress);
            this.firstNameTextBox.Leave += new System.EventHandler(this.firstNameTestBox_Leave);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(53, 28);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.firstNameLabel.TabIndex = 16;
            this.firstNameLabel.Text = "First Name:";
            // 
            // streetAddressTextBox
            // 
            this.streetAddressTextBox.Location = new System.Drawing.Point(119, 24);
            this.streetAddressTextBox.Name = "streetAddressTextBox";
            this.streetAddressTextBox.ReadOnly = true;
            this.streetAddressTextBox.Size = new System.Drawing.Size(341, 20);
            this.streetAddressTextBox.TabIndex = 25;
            this.streetAddressTextBox.Leave += new System.EventHandler(this.streetAddressTextBox_Leave);
            // 
            // streetAddressLabel
            // 
            this.streetAddressLabel.AutoSize = true;
            this.streetAddressLabel.Location = new System.Drawing.Point(34, 27);
            this.streetAddressLabel.Name = "streetAddressLabel";
            this.streetAddressLabel.Size = new System.Drawing.Size(79, 13);
            this.streetAddressLabel.TabIndex = 26;
            this.streetAddressLabel.Text = "Street Address:";
            // 
            // suburbLabel
            // 
            this.suburbLabel.AutoSize = true;
            this.suburbLabel.Location = new System.Drawing.Point(63, 53);
            this.suburbLabel.Name = "suburbLabel";
            this.suburbLabel.Size = new System.Drawing.Size(44, 13);
            this.suburbLabel.TabIndex = 27;
            this.suburbLabel.Text = "Suburb:";
            // 
            // suburbTextBox
            // 
            this.suburbTextBox.Location = new System.Drawing.Point(119, 50);
            this.suburbTextBox.Name = "suburbTextBox";
            this.suburbTextBox.ReadOnly = true;
            this.suburbTextBox.Size = new System.Drawing.Size(341, 20);
            this.suburbTextBox.TabIndex = 28;
            this.suburbTextBox.Leave += new System.EventHandler(this.suburbTextBox_Leave);
            // 
            // townLabel
            // 
            this.townLabel.AutoSize = true;
            this.townLabel.Location = new System.Drawing.Point(70, 79);
            this.townLabel.Name = "townLabel";
            this.townLabel.Size = new System.Drawing.Size(37, 13);
            this.townLabel.TabIndex = 29;
            this.townLabel.Text = "Town:";
            // 
            // townTextBox
            // 
            this.townTextBox.Location = new System.Drawing.Point(119, 76);
            this.townTextBox.Name = "townTextBox";
            this.townTextBox.ReadOnly = true;
            this.townTextBox.Size = new System.Drawing.Size(341, 20);
            this.townTextBox.TabIndex = 30;
            this.townTextBox.Leave += new System.EventHandler(this.townTextBox_Leave);
            // 
            // zipCodeLabel
            // 
            this.zipCodeLabel.AutoSize = true;
            this.zipCodeLabel.Location = new System.Drawing.Point(54, 130);
            this.zipCodeLabel.Name = "zipCodeLabel";
            this.zipCodeLabel.Size = new System.Drawing.Size(53, 13);
            this.zipCodeLabel.TabIndex = 31;
            this.zipCodeLabel.Text = "Zip Code:";
            this.zipCodeLabel.UseWaitCursor = true;
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.Location = new System.Drawing.Point(119, 127);
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.ReadOnly = true;
            this.zipCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.zipCodeTextBox.TabIndex = 32;
            this.zipCodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.zipCodeTextBox_KeyPress);
            this.zipCodeTextBox.Leave += new System.EventHandler(this.zipCodeTextBox_Leave);
            // 
            // streetErrorMessageLabel
            // 
            this.streetErrorMessageLabel.AutoSize = true;
            this.streetErrorMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.streetErrorMessageLabel.Location = new System.Drawing.Point(466, 24);
            this.streetErrorMessageLabel.Name = "streetErrorMessageLabel";
            this.streetErrorMessageLabel.Size = new System.Drawing.Size(70, 13);
            this.streetErrorMessageLabel.TabIndex = 28;
            this.streetErrorMessageLabel.Text = "<Error Label>";
            this.streetErrorMessageLabel.Visible = false;
            // 
            // suburbErrorMessageLabel
            // 
            this.suburbErrorMessageLabel.AutoSize = true;
            this.suburbErrorMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.suburbErrorMessageLabel.Location = new System.Drawing.Point(466, 50);
            this.suburbErrorMessageLabel.Name = "suburbErrorMessageLabel";
            this.suburbErrorMessageLabel.Size = new System.Drawing.Size(70, 13);
            this.suburbErrorMessageLabel.TabIndex = 33;
            this.suburbErrorMessageLabel.Text = "<Error Label>";
            this.suburbErrorMessageLabel.Visible = false;
            // 
            // townErrorMessageLabel
            // 
            this.townErrorMessageLabel.AutoSize = true;
            this.townErrorMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.townErrorMessageLabel.Location = new System.Drawing.Point(466, 79);
            this.townErrorMessageLabel.Name = "townErrorMessageLabel";
            this.townErrorMessageLabel.Size = new System.Drawing.Size(70, 13);
            this.townErrorMessageLabel.TabIndex = 34;
            this.townErrorMessageLabel.Text = "<Error Label>";
            this.townErrorMessageLabel.Visible = false;
            // 
            // zipCodeErrorMessageLabel
            // 
            this.zipCodeErrorMessageLabel.AutoSize = true;
            this.zipCodeErrorMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.zipCodeErrorMessageLabel.Location = new System.Drawing.Point(225, 130);
            this.zipCodeErrorMessageLabel.Name = "zipCodeErrorMessageLabel";
            this.zipCodeErrorMessageLabel.Size = new System.Drawing.Size(70, 13);
            this.zipCodeErrorMessageLabel.TabIndex = 35;
            this.zipCodeErrorMessageLabel.Text = "<Error Label>";
            this.zipCodeErrorMessageLabel.Visible = false;
            // 
            // addressGroupBox
            // 
            this.addressGroupBox.Controls.Add(this.cityErrorMessageLabel);
            this.addressGroupBox.Controls.Add(this.cityTextBox);
            this.addressGroupBox.Controls.Add(this.cityLabel);
            this.addressGroupBox.Controls.Add(this.zipCodeErrorMessageLabel);
            this.addressGroupBox.Controls.Add(this.townErrorMessageLabel);
            this.addressGroupBox.Controls.Add(this.suburbErrorMessageLabel);
            this.addressGroupBox.Controls.Add(this.streetErrorMessageLabel);
            this.addressGroupBox.Controls.Add(this.zipCodeTextBox);
            this.addressGroupBox.Controls.Add(this.zipCodeLabel);
            this.addressGroupBox.Controls.Add(this.townTextBox);
            this.addressGroupBox.Controls.Add(this.townLabel);
            this.addressGroupBox.Controls.Add(this.suburbTextBox);
            this.addressGroupBox.Controls.Add(this.suburbLabel);
            this.addressGroupBox.Controls.Add(this.streetAddressLabel);
            this.addressGroupBox.Controls.Add(this.streetAddressTextBox);
            this.addressGroupBox.Location = new System.Drawing.Point(12, 436);
            this.addressGroupBox.Name = "addressGroupBox";
            this.addressGroupBox.Size = new System.Drawing.Size(674, 164);
            this.addressGroupBox.TabIndex = 7;
            this.addressGroupBox.TabStop = false;
            this.addressGroupBox.Text = "Address";
            this.addressGroupBox.Visible = false;
            // 
            // cityErrorMessageLabel
            // 
            this.cityErrorMessageLabel.AutoSize = true;
            this.cityErrorMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.cityErrorMessageLabel.Location = new System.Drawing.Point(466, 104);
            this.cityErrorMessageLabel.Name = "cityErrorMessageLabel";
            this.cityErrorMessageLabel.Size = new System.Drawing.Size(70, 13);
            this.cityErrorMessageLabel.TabIndex = 38;
            this.cityErrorMessageLabel.Text = "<Error Label>";
            this.cityErrorMessageLabel.Visible = false;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(119, 101);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.ReadOnly = true;
            this.cityTextBox.Size = new System.Drawing.Size(341, 20);
            this.cityTextBox.TabIndex = 37;
            this.cityTextBox.Leave += new System.EventHandler(this.cityTextBox_Leave);
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(80, 104);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(27, 13);
            this.cityLabel.TabIndex = 36;
            this.cityLabel.Text = "City:";
            // 
            // customersGroupBox
            // 
            this.customersGroupBox.Controls.Add(this.customerClickInfoLabel);
            this.customersGroupBox.Controls.Add(this.customerListView);
            this.customersGroupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.customersGroupBox.Location = new System.Drawing.Point(12, 222);
            this.customersGroupBox.Name = "customersGroupBox";
            this.customersGroupBox.Size = new System.Drawing.Size(674, 372);
            this.customersGroupBox.TabIndex = 3;
            this.customersGroupBox.TabStop = false;
            this.customersGroupBox.Text = "Customers";
            this.customersGroupBox.Visible = false;
            // 
            // customerClickInfoLabel
            // 
            this.customerClickInfoLabel.AutoSize = true;
            this.customerClickInfoLabel.Location = new System.Drawing.Point(7, 16);
            this.customerClickInfoLabel.Name = "customerClickInfoLabel";
            this.customerClickInfoLabel.Size = new System.Drawing.Size(360, 13);
            this.customerClickInfoLabel.TabIndex = 1;
            this.customerClickInfoLabel.Text = "Double click on customer code to get detailed information on the customer.";
            // 
            // customerListView
            // 
            this.customerListView.HideSelection = false;
            this.customerListView.Location = new System.Drawing.Point(6, 32);
            this.customerListView.Name = "customerListView";
            this.customerListView.Size = new System.Drawing.Size(661, 334);
            this.customerListView.TabIndex = 0;
            this.customerListView.UseCompatibleStateImageBehavior = false;
            this.customerListView.SelectedIndexChanged += new System.EventHandler(this.customerListView_SelectedIndexChanged);
            this.customerListView.DoubleClick += new System.EventHandler(this.customerListView_DoubleClick);
            // 
            // creditGroupBox
            // 
            this.creditGroupBox.Controls.Add(this.creditErrorLabel);
            this.creditGroupBox.Controls.Add(this.creditLimitErrorLabel);
            this.creditGroupBox.Controls.Add(this.creditLimitTextBox);
            this.creditGroupBox.Controls.Add(this.creditLimitLabel);
            this.creditGroupBox.Controls.Add(this.currentCreditTextBox);
            this.creditGroupBox.Controls.Add(this.currentCreditLabel);
            this.creditGroupBox.Location = new System.Drawing.Point(12, 360);
            this.creditGroupBox.Name = "creditGroupBox";
            this.creditGroupBox.Size = new System.Drawing.Size(675, 70);
            this.creditGroupBox.TabIndex = 6;
            this.creditGroupBox.TabStop = false;
            this.creditGroupBox.Text = "Credit";
            this.creditGroupBox.Visible = false;
            // 
            // creditErrorLabel
            // 
            this.creditErrorLabel.AutoSize = true;
            this.creditErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.creditErrorLabel.Location = new System.Drawing.Point(466, 16);
            this.creditErrorLabel.Name = "creditErrorLabel";
            this.creditErrorLabel.Size = new System.Drawing.Size(70, 13);
            this.creditErrorLabel.TabIndex = 37;
            this.creditErrorLabel.Text = "<Error Label>";
            this.creditErrorLabel.Visible = false;
            // 
            // creditLimitErrorLabel
            // 
            this.creditLimitErrorLabel.AutoSize = true;
            this.creditLimitErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.creditLimitErrorLabel.Location = new System.Drawing.Point(466, 39);
            this.creditLimitErrorLabel.Name = "creditLimitErrorLabel";
            this.creditLimitErrorLabel.Size = new System.Drawing.Size(70, 13);
            this.creditLimitErrorLabel.TabIndex = 36;
            this.creditLimitErrorLabel.Text = "<Error Label>";
            this.creditLimitErrorLabel.Visible = false;
            // 
            // creditLimitTextBox
            // 
            this.creditLimitTextBox.Location = new System.Drawing.Point(119, 39);
            this.creditLimitTextBox.Name = "creditLimitTextBox";
            this.creditLimitTextBox.ReadOnly = true;
            this.creditLimitTextBox.Size = new System.Drawing.Size(341, 20);
            this.creditLimitTextBox.TabIndex = 35;
            this.creditLimitTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.creditLimitTextBox_KeyPress);
            this.creditLimitTextBox.Leave += new System.EventHandler(this.creditLimitTextBox_Leave);
            // 
            // creditLimitLabel
            // 
            this.creditLimitLabel.AutoSize = true;
            this.creditLimitLabel.Location = new System.Drawing.Point(15, 42);
            this.creditLimitLabel.Name = "creditLimitLabel";
            this.creditLimitLabel.Size = new System.Drawing.Size(101, 13);
            this.creditLimitLabel.TabIndex = 34;
            this.creditLimitLabel.Text = "Credit Limit (Rands):";
            // 
            // currentCreditTextBox
            // 
            this.currentCreditTextBox.Location = new System.Drawing.Point(119, 13);
            this.currentCreditTextBox.Name = "currentCreditTextBox";
            this.currentCreditTextBox.ReadOnly = true;
            this.currentCreditTextBox.Size = new System.Drawing.Size(341, 20);
            this.currentCreditTextBox.TabIndex = 33;
            // 
            // currentCreditLabel
            // 
            this.currentCreditLabel.AutoSize = true;
            this.currentCreditLabel.Location = new System.Drawing.Point(20, 20);
            this.currentCreditLabel.Name = "currentCreditLabel";
            this.currentCreditLabel.Size = new System.Drawing.Size(93, 13);
            this.currentCreditLabel.TabIndex = 0;
            this.currentCreditLabel.Text = " Credit Remaining:";
            // 
            // editErrorLabel
            // 
            this.editErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.editErrorLabel.Location = new System.Drawing.Point(10, 603);
            this.editErrorLabel.Name = "editErrorLabel";
            this.editErrorLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.editErrorLabel.Size = new System.Drawing.Size(273, 32);
            this.editErrorLabel.TabIndex = 36;
            this.editErrorLabel.Text = "<Error Label>";
            this.editErrorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.editErrorLabel.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PoppelOrderingSystem.Properties.Resources._1601548216418;
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // cancelButton
            // 
            this.cancelButton.ActiveBorderThickness = 1;
            this.cancelButton.ActiveCornerRadius = 20;
            this.cancelButton.ActiveFillColor = System.Drawing.Color.Red;
            this.cancelButton.ActiveForecolor = System.Drawing.Color.White;
            this.cancelButton.ActiveLineColor = System.Drawing.Color.Red;
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cancelButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelButton.BackgroundImage")));
            this.cancelButton.ButtonText = "Cancel";
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.cancelButton.IdleBorderThickness = 1;
            this.cancelButton.IdleCornerRadius = 20;
            this.cancelButton.IdleFillColor = System.Drawing.Color.White;
            this.cancelButton.IdleForecolor = System.Drawing.Color.DarkGray;
            this.cancelButton.IdleLineColor = System.Drawing.Color.DarkGray;
            this.cancelButton.Location = new System.Drawing.Point(13, 640);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(5);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(113, 49);
            this.cancelButton.TabIndex = 43;
            this.cancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // cancelOrderButton
            // 
            this.cancelOrderButton.ActiveBorderThickness = 1;
            this.cancelOrderButton.ActiveCornerRadius = 20;
            this.cancelOrderButton.ActiveFillColor = System.Drawing.Color.DarkRed;
            this.cancelOrderButton.ActiveForecolor = System.Drawing.Color.White;
            this.cancelOrderButton.ActiveLineColor = System.Drawing.Color.DarkRed;
            this.cancelOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cancelOrderButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelOrderButton.BackgroundImage")));
            this.cancelOrderButton.ButtonText = "Concel Order";
            this.cancelOrderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelOrderButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelOrderButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.cancelOrderButton.IdleBorderThickness = 1;
            this.cancelOrderButton.IdleCornerRadius = 20;
            this.cancelOrderButton.IdleFillColor = System.Drawing.Color.White;
            this.cancelOrderButton.IdleForecolor = System.Drawing.Color.DarkGray;
            this.cancelOrderButton.IdleLineColor = System.Drawing.Color.DarkGray;
            this.cancelOrderButton.Location = new System.Drawing.Point(418, 640);
            this.cancelOrderButton.Margin = new System.Windows.Forms.Padding(5);
            this.cancelOrderButton.Name = "cancelOrderButton";
            this.cancelOrderButton.Size = new System.Drawing.Size(129, 49);
            this.cancelOrderButton.TabIndex = 44;
            this.cancelOrderButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancelOrderButton.Click += new System.EventHandler(this.cancelOrderButton_Click);
            // 
            // placeOrderButton
            // 
            this.placeOrderButton.ActiveBorderThickness = 1;
            this.placeOrderButton.ActiveCornerRadius = 20;
            this.placeOrderButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.placeOrderButton.ActiveForecolor = System.Drawing.Color.White;
            this.placeOrderButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.placeOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.placeOrderButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("placeOrderButton.BackgroundImage")));
            this.placeOrderButton.ButtonText = "Place Order";
            this.placeOrderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.placeOrderButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeOrderButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.placeOrderButton.IdleBorderThickness = 1;
            this.placeOrderButton.IdleCornerRadius = 20;
            this.placeOrderButton.IdleFillColor = System.Drawing.Color.White;
            this.placeOrderButton.IdleForecolor = System.Drawing.Color.DarkGray;
            this.placeOrderButton.IdleLineColor = System.Drawing.Color.DarkGray;
            this.placeOrderButton.Location = new System.Drawing.Point(557, 640);
            this.placeOrderButton.Margin = new System.Windows.Forms.Padding(5);
            this.placeOrderButton.Name = "placeOrderButton";
            this.placeOrderButton.Size = new System.Drawing.Size(129, 49);
            this.placeOrderButton.TabIndex = 44;
            this.placeOrderButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.placeOrderButton.Click += new System.EventHandler(this.placeOrderButton_Click);
            // 
            // CustomerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 699);
            this.Controls.Add(this.placeOrderButton);
            this.Controls.Add(this.cancelOrderButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.editErrorLabel);
            this.Controls.Add(this.customerInputGroupBox);
            this.Controls.Add(this.personalDetailsGroupBox);
            this.Controls.Add(this.creditGroupBox);
            this.Controls.Add(this.addressGroupBox);
            this.Controls.Add(this.customersGroupBox);
            this.Name = "CustomerManagement";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "              Customer Management";
            this.customerInputGroupBox.ResumeLayout(false);
            this.customerInputGroupBox.PerformLayout();
            this.personalDetailsGroupBox.ResumeLayout(false);
            this.personalDetailsGroupBox.PerformLayout();
            this.addressGroupBox.ResumeLayout(false);
            this.addressGroupBox.PerformLayout();
            this.customersGroupBox.ResumeLayout(false);
            this.customersGroupBox.PerformLayout();
            this.creditGroupBox.ResumeLayout(false);
            this.creditGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.GroupBox customerInputGroupBox;
        private System.Windows.Forms.RadioButton telephoneRadioButton;
        private System.Windows.Forms.RadioButton customerNumberRadioButton;
        private System.Windows.Forms.GroupBox personalDetailsGroupBox;
        private System.Windows.Forms.Label emailErrorMessageLabel;
        private System.Windows.Forms.Label lastNameErrorMessageLabel;
        private System.Windows.Forms.Label firstNameErrorMessageLabel;
        private System.Windows.Forms.TextBox emailAddressTextBox;
        private System.Windows.Forms.Label emailAddressLabel;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label userNotFoundErrorLabel;
        private System.Windows.Forms.TextBox streetAddressTextBox;
        private System.Windows.Forms.Label streetAddressLabel;
        private System.Windows.Forms.Label suburbLabel;
        private System.Windows.Forms.TextBox suburbTextBox;
        private System.Windows.Forms.Label townLabel;
        private System.Windows.Forms.TextBox townTextBox;
        private System.Windows.Forms.Label zipCodeLabel;
        private System.Windows.Forms.TextBox zipCodeTextBox;
        private System.Windows.Forms.Label streetErrorMessageLabel;
        private System.Windows.Forms.Label suburbErrorMessageLabel;
        private System.Windows.Forms.Label townErrorMessageLabel;
        private System.Windows.Forms.Label zipCodeErrorMessageLabel;
        private System.Windows.Forms.GroupBox addressGroupBox;
        private System.Windows.Forms.GroupBox customersGroupBox;
        private System.Windows.Forms.ListView customerListView;
        private System.Windows.Forms.MaskedTextBox inputTextBox;
        private System.Windows.Forms.Label formatLabel;
        private System.Windows.Forms.GroupBox creditGroupBox;
        private System.Windows.Forms.Label creditLimitLabel;
        private System.Windows.Forms.Label currentCreditLabel;
        private System.Windows.Forms.TextBox currentCreditTextBox;
        private System.Windows.Forms.MaskedTextBox phoneNumberMaskBox;
        private System.Windows.Forms.TextBox creditLimitTextBox;
        private System.Windows.Forms.Label phoneErrorLabel;
        private System.Windows.Forms.Label creditLimitErrorLabel;
        private System.Windows.Forms.Label editErrorLabel;
        private System.Windows.Forms.Label cityErrorMessageLabel;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label customerClickInfoLabel;
        private System.Windows.Forms.Label creditErrorLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 cancelButton;
        private Bunifu.Framework.UI.BunifuThinButton2 searchButton;
        private Bunifu.Framework.UI.BunifuThinButton2 cancelOrderButton;
        private Bunifu.Framework.UI.BunifuThinButton2 placeOrderButton;
    }
}