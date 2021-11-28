namespace PoppelOrderingSystem.PresentationLayer
{
    partial class CreateCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateCustomer));
            this.addressGroupBox = new System.Windows.Forms.GroupBox();
            this.townErrorMessageLabel = new System.Windows.Forms.Label();
            this.townTextBox = new System.Windows.Forms.TextBox();
            this.townLabel = new System.Windows.Forms.Label();
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.zipCodeErrorMessageLabel = new System.Windows.Forms.Label();
            this.cityErrorMessageLabel = new System.Windows.Forms.Label();
            this.suburbErrorMessageLabel = new System.Windows.Forms.Label();
            this.streetErrorMessageLabel = new System.Windows.Forms.Label();
            this.zipCodeLabel = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.suburbTextBox = new System.Windows.Forms.TextBox();
            this.suburbLabel = new System.Windows.Forms.Label();
            this.streetAddressLabel = new System.Windows.Forms.Label();
            this.streetAddressTextBox = new System.Windows.Forms.TextBox();
            this.personalDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.emailAddressTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberMaskBox = new System.Windows.Forms.MaskedTextBox();
            this.emailErrorMessageLabel = new System.Windows.Forms.Label();
            this.phoneErrorLabel = new System.Windows.Forms.Label();
            this.lastNameErrorMessageLabel = new System.Windows.Forms.Label();
            this.firstNameErrorMessageLabel = new System.Windows.Forms.Label();
            this.emailAddressLabel = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.createCustomerErrorLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.creditLimitErrorLabel = new System.Windows.Forms.Label();
            this.modifyCreditLimitCheckBox = new System.Windows.Forms.CheckBox();
            this.creditLimitTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.createCustomerButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cancelButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.addressGroupBox.SuspendLayout();
            this.personalDetailsGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addressGroupBox
            // 
            this.addressGroupBox.Controls.Add(this.townErrorMessageLabel);
            this.addressGroupBox.Controls.Add(this.townTextBox);
            this.addressGroupBox.Controls.Add(this.townLabel);
            this.addressGroupBox.Controls.Add(this.zipCodeTextBox);
            this.addressGroupBox.Controls.Add(this.zipCodeErrorMessageLabel);
            this.addressGroupBox.Controls.Add(this.cityErrorMessageLabel);
            this.addressGroupBox.Controls.Add(this.suburbErrorMessageLabel);
            this.addressGroupBox.Controls.Add(this.streetErrorMessageLabel);
            this.addressGroupBox.Controls.Add(this.zipCodeLabel);
            this.addressGroupBox.Controls.Add(this.cityTextBox);
            this.addressGroupBox.Controls.Add(this.cityLabel);
            this.addressGroupBox.Controls.Add(this.suburbTextBox);
            this.addressGroupBox.Controls.Add(this.suburbLabel);
            this.addressGroupBox.Controls.Add(this.streetAddressLabel);
            this.addressGroupBox.Controls.Add(this.streetAddressTextBox);
            this.addressGroupBox.Location = new System.Drawing.Point(12, 202);
            this.addressGroupBox.Name = "addressGroupBox";
            this.addressGroupBox.Size = new System.Drawing.Size(674, 163);
            this.addressGroupBox.TabIndex = 25;
            this.addressGroupBox.TabStop = false;
            this.addressGroupBox.Text = "Address";
            // 
            // townErrorMessageLabel
            // 
            this.townErrorMessageLabel.AutoSize = true;
            this.townErrorMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.townErrorMessageLabel.Location = new System.Drawing.Point(466, 76);
            this.townErrorMessageLabel.Name = "townErrorMessageLabel";
            this.townErrorMessageLabel.Size = new System.Drawing.Size(70, 13);
            this.townErrorMessageLabel.TabIndex = 41;
            this.townErrorMessageLabel.Text = "<Error Label>";
            this.townErrorMessageLabel.Visible = false;
            // 
            // townTextBox
            // 
            this.townTextBox.Location = new System.Drawing.Point(93, 76);
            this.townTextBox.Name = "townTextBox";
            this.townTextBox.Size = new System.Drawing.Size(367, 20);
            this.townTextBox.TabIndex = 40;
            this.townTextBox.Leave += new System.EventHandler(this.townTextBox_Leave);
            // 
            // townLabel
            // 
            this.townLabel.AutoSize = true;
            this.townLabel.Location = new System.Drawing.Point(50, 79);
            this.townLabel.Name = "townLabel";
            this.townLabel.Size = new System.Drawing.Size(37, 13);
            this.townLabel.TabIndex = 39;
            this.townLabel.Text = "Town:";
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.Location = new System.Drawing.Point(92, 128);
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.Size = new System.Drawing.Size(111, 20);
            this.zipCodeTextBox.TabIndex = 38;
            this.zipCodeTextBox.TextChanged += new System.EventHandler(this.zipCodeTextBox_TextChanged);
            this.zipCodeTextBox.Leave += new System.EventHandler(this.zipCodeTextBox_Leave);
            // 
            // zipCodeErrorMessageLabel
            // 
            this.zipCodeErrorMessageLabel.AutoSize = true;
            this.zipCodeErrorMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.zipCodeErrorMessageLabel.Location = new System.Drawing.Point(209, 128);
            this.zipCodeErrorMessageLabel.Name = "zipCodeErrorMessageLabel";
            this.zipCodeErrorMessageLabel.Size = new System.Drawing.Size(70, 13);
            this.zipCodeErrorMessageLabel.TabIndex = 35;
            this.zipCodeErrorMessageLabel.Text = "<Error Label>";
            this.zipCodeErrorMessageLabel.Visible = false;
            // 
            // cityErrorMessageLabel
            // 
            this.cityErrorMessageLabel.AutoSize = true;
            this.cityErrorMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.cityErrorMessageLabel.Location = new System.Drawing.Point(466, 105);
            this.cityErrorMessageLabel.Name = "cityErrorMessageLabel";
            this.cityErrorMessageLabel.Size = new System.Drawing.Size(70, 13);
            this.cityErrorMessageLabel.TabIndex = 34;
            this.cityErrorMessageLabel.Text = "<Error Label>";
            this.cityErrorMessageLabel.Visible = false;
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
            // zipCodeLabel
            // 
            this.zipCodeLabel.AutoSize = true;
            this.zipCodeLabel.Location = new System.Drawing.Point(33, 131);
            this.zipCodeLabel.Name = "zipCodeLabel";
            this.zipCodeLabel.Size = new System.Drawing.Size(53, 13);
            this.zipCodeLabel.TabIndex = 31;
            this.zipCodeLabel.Text = "Zip Code:";
            this.zipCodeLabel.UseWaitCursor = true;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(93, 102);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(367, 20);
            this.cityTextBox.TabIndex = 30;
            this.cityTextBox.Leave += new System.EventHandler(this.cityTextBox_Leave);
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(60, 105);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(27, 13);
            this.cityLabel.TabIndex = 29;
            this.cityLabel.Text = "City:";
            // 
            // suburbTextBox
            // 
            this.suburbTextBox.Location = new System.Drawing.Point(93, 50);
            this.suburbTextBox.Name = "suburbTextBox";
            this.suburbTextBox.Size = new System.Drawing.Size(367, 20);
            this.suburbTextBox.TabIndex = 28;
            this.suburbTextBox.Leave += new System.EventHandler(this.suburbTextBox_Leave);
            // 
            // suburbLabel
            // 
            this.suburbLabel.AutoSize = true;
            this.suburbLabel.Location = new System.Drawing.Point(43, 53);
            this.suburbLabel.Name = "suburbLabel";
            this.suburbLabel.Size = new System.Drawing.Size(44, 13);
            this.suburbLabel.TabIndex = 27;
            this.suburbLabel.Text = "Suburb:";
            // 
            // streetAddressLabel
            // 
            this.streetAddressLabel.AutoSize = true;
            this.streetAddressLabel.Location = new System.Drawing.Point(9, 27);
            this.streetAddressLabel.Name = "streetAddressLabel";
            this.streetAddressLabel.Size = new System.Drawing.Size(79, 13);
            this.streetAddressLabel.TabIndex = 26;
            this.streetAddressLabel.Text = "Street Address:";
            // 
            // streetAddressTextBox
            // 
            this.streetAddressTextBox.Location = new System.Drawing.Point(93, 24);
            this.streetAddressTextBox.Name = "streetAddressTextBox";
            this.streetAddressTextBox.Size = new System.Drawing.Size(367, 20);
            this.streetAddressTextBox.TabIndex = 25;
            this.streetAddressTextBox.Leave += new System.EventHandler(this.streetAddressTextBox_Leave);
            // 
            // personalDetailsGroupBox
            // 
            this.personalDetailsGroupBox.Controls.Add(this.emailAddressTextBox);
            this.personalDetailsGroupBox.Controls.Add(this.phoneNumberMaskBox);
            this.personalDetailsGroupBox.Controls.Add(this.emailErrorMessageLabel);
            this.personalDetailsGroupBox.Controls.Add(this.phoneErrorLabel);
            this.personalDetailsGroupBox.Controls.Add(this.lastNameErrorMessageLabel);
            this.personalDetailsGroupBox.Controls.Add(this.firstNameErrorMessageLabel);
            this.personalDetailsGroupBox.Controls.Add(this.emailAddressLabel);
            this.personalDetailsGroupBox.Controls.Add(this.phoneNumberLabel);
            this.personalDetailsGroupBox.Controls.Add(this.lastNameTextBox);
            this.personalDetailsGroupBox.Controls.Add(this.lastNameLabel);
            this.personalDetailsGroupBox.Controls.Add(this.firstNameTextBox);
            this.personalDetailsGroupBox.Controls.Add(this.firstNameLabel);
            this.personalDetailsGroupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.personalDetailsGroupBox.Location = new System.Drawing.Point(12, 67);
            this.personalDetailsGroupBox.Name = "personalDetailsGroupBox";
            this.personalDetailsGroupBox.Size = new System.Drawing.Size(674, 129);
            this.personalDetailsGroupBox.TabIndex = 24;
            this.personalDetailsGroupBox.TabStop = false;
            this.personalDetailsGroupBox.Text = "Personal Details";
            // 
            // emailAddressTextBox
            // 
            this.emailAddressTextBox.Location = new System.Drawing.Point(93, 103);
            this.emailAddressTextBox.Name = "emailAddressTextBox";
            this.emailAddressTextBox.Size = new System.Drawing.Size(367, 20);
            this.emailAddressTextBox.TabIndex = 37;
            this.emailAddressTextBox.Leave += new System.EventHandler(this.emailAddressTextBox_Leave);
            // 
            // phoneNumberMaskBox
            // 
            this.phoneNumberMaskBox.Location = new System.Drawing.Point(93, 77);
            this.phoneNumberMaskBox.Mask = "(000) 000-0000";
            this.phoneNumberMaskBox.Name = "phoneNumberMaskBox";
            this.phoneNumberMaskBox.Size = new System.Drawing.Size(367, 20);
            this.phoneNumberMaskBox.TabIndex = 36;
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
            // phoneErrorLabel
            // 
            this.phoneErrorLabel.AutoSize = true;
            this.phoneErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.phoneErrorLabel.Location = new System.Drawing.Point(466, 77);
            this.phoneErrorLabel.Name = "phoneErrorLabel";
            this.phoneErrorLabel.Size = new System.Drawing.Size(70, 13);
            this.phoneErrorLabel.TabIndex = 26;
            this.phoneErrorLabel.Text = "<Error Label>";
            this.phoneErrorLabel.Visible = false;
            // 
            // lastNameErrorMessageLabel
            // 
            this.lastNameErrorMessageLabel.AutoSize = true;
            this.lastNameErrorMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.lastNameErrorMessageLabel.Location = new System.Drawing.Point(466, 51);
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
            // emailAddressLabel
            // 
            this.emailAddressLabel.AutoSize = true;
            this.emailAddressLabel.Location = new System.Drawing.Point(11, 106);
            this.emailAddressLabel.Name = "emailAddressLabel";
            this.emailAddressLabel.Size = new System.Drawing.Size(76, 13);
            this.emailAddressLabel.TabIndex = 21;
            this.emailAddressLabel.Text = "Email Address:";
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(6, 80);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(81, 13);
            this.phoneNumberLabel.TabIndex = 20;
            this.phoneNumberLabel.Text = "Phone Number:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(93, 51);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(367, 20);
            this.lastNameTextBox.TabIndex = 19;
            this.lastNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lastNameTextBox_KeyPress);
            this.lastNameTextBox.Leave += new System.EventHandler(this.lastNameTextBox_Leave);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(27, 54);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.lastNameLabel.TabIndex = 18;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(93, 25);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(367, 20);
            this.firstNameTextBox.TabIndex = 1;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.firstNameTextBox_TextChanged);
            this.firstNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstNameTestBox_KeyPress);
            this.firstNameTextBox.Leave += new System.EventHandler(this.firstNameTestBox_Leave);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(27, 28);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.firstNameLabel.TabIndex = 16;
            this.firstNameLabel.Text = "First Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Credit Limit:";
            // 
            // createCustomerErrorLabel
            // 
            this.createCustomerErrorLabel.BackColor = System.Drawing.Color.Transparent;
            this.createCustomerErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.createCustomerErrorLabel.Location = new System.Drawing.Point(166, 462);
            this.createCustomerErrorLabel.Name = "createCustomerErrorLabel";
            this.createCustomerErrorLabel.Size = new System.Drawing.Size(346, 67);
            this.createCustomerErrorLabel.TabIndex = 28;
            this.createCustomerErrorLabel.Text = "<Error Label>";
            this.createCustomerErrorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.createCustomerErrorLabel.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.creditLimitErrorLabel);
            this.groupBox1.Controls.Add(this.modifyCreditLimitCheckBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.creditLimitTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 371);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 74);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Credit";
            // 
            // creditLimitErrorLabel
            // 
            this.creditLimitErrorLabel.AutoSize = true;
            this.creditLimitErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.creditLimitErrorLabel.Location = new System.Drawing.Point(209, 42);
            this.creditLimitErrorLabel.Name = "creditLimitErrorLabel";
            this.creditLimitErrorLabel.Size = new System.Drawing.Size(70, 13);
            this.creditLimitErrorLabel.TabIndex = 30;
            this.creditLimitErrorLabel.Text = "<Error Label>";
            this.creditLimitErrorLabel.Visible = false;
            // 
            // modifyCreditLimitCheckBox
            // 
            this.modifyCreditLimitCheckBox.AutoSize = true;
            this.modifyCreditLimitCheckBox.Location = new System.Drawing.Point(93, 19);
            this.modifyCreditLimitCheckBox.Name = "modifyCreditLimitCheckBox";
            this.modifyCreditLimitCheckBox.Size = new System.Drawing.Size(111, 17);
            this.modifyCreditLimitCheckBox.TabIndex = 29;
            this.modifyCreditLimitCheckBox.Text = "Modify Credit Limit";
            this.modifyCreditLimitCheckBox.UseVisualStyleBackColor = true;
            this.modifyCreditLimitCheckBox.CheckedChanged += new System.EventHandler(this.modifyCreditLimitCheckBox_CheckedChanged);
            // 
            // creditLimitTextBox
            // 
            this.creditLimitTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditLimitTextBox.Location = new System.Drawing.Point(93, 42);
            this.creditLimitTextBox.Name = "creditLimitTextBox";
            this.creditLimitTextBox.ReadOnly = true;
            this.creditLimitTextBox.Size = new System.Drawing.Size(110, 20);
            this.creditLimitTextBox.TabIndex = 25;
            this.creditLimitTextBox.Text = "700";
            this.creditLimitTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.creditLimitTextBox_KeyPress);
            this.creditLimitTextBox.Leave += new System.EventHandler(this.creditLimitTextBox_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PoppelOrderingSystem.Properties.Resources._1601548216418;
            this.pictureBox1.Location = new System.Drawing.Point(6, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // createCustomerButton
            // 
            this.createCustomerButton.ActiveBorderThickness = 1;
            this.createCustomerButton.ActiveCornerRadius = 20;
            this.createCustomerButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.createCustomerButton.ActiveForecolor = System.Drawing.Color.White;
            this.createCustomerButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.createCustomerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.createCustomerButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("createCustomerButton.BackgroundImage")));
            this.createCustomerButton.ButtonText = "Create Customer";
            this.createCustomerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createCustomerButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createCustomerButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.createCustomerButton.IdleBorderThickness = 1;
            this.createCustomerButton.IdleCornerRadius = 20;
            this.createCustomerButton.IdleFillColor = System.Drawing.Color.White;
            this.createCustomerButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.createCustomerButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.createCustomerButton.Location = new System.Drawing.Point(520, 471);
            this.createCustomerButton.Margin = new System.Windows.Forms.Padding(5);
            this.createCustomerButton.Name = "createCustomerButton";
            this.createCustomerButton.Size = new System.Drawing.Size(166, 49);
            this.createCustomerButton.TabIndex = 42;
            this.createCustomerButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.createCustomerButton.Click += new System.EventHandler(this.createCustomerButton_Click);
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
            this.cancelButton.IdleForecolor = System.Drawing.Color.Red;
            this.cancelButton.IdleLineColor = System.Drawing.Color.Red;
            this.cancelButton.Location = new System.Drawing.Point(12, 471);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(5);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(146, 49);
            this.cancelButton.TabIndex = 42;
            this.cancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // CreateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 546);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createCustomerButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.createCustomerErrorLabel);
            this.Controls.Add(this.personalDetailsGroupBox);
            this.Controls.Add(this.addressGroupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CreateCustomer";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "            Create Customer";
            this.addressGroupBox.ResumeLayout(false);
            this.addressGroupBox.PerformLayout();
            this.personalDetailsGroupBox.ResumeLayout(false);
            this.personalDetailsGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox addressGroupBox;
        private System.Windows.Forms.Label zipCodeLabel;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox suburbTextBox;
        private System.Windows.Forms.Label suburbLabel;
        private System.Windows.Forms.Label streetAddressLabel;
        private System.Windows.Forms.TextBox streetAddressTextBox;
        private System.Windows.Forms.GroupBox personalDetailsGroupBox;
        private System.Windows.Forms.Label emailAddressLabel;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameErrorMessageLabel;
        private System.Windows.Forms.Label firstNameErrorMessageLabel;
        private System.Windows.Forms.Label zipCodeErrorMessageLabel;
        private System.Windows.Forms.Label cityErrorMessageLabel;
        private System.Windows.Forms.Label suburbErrorMessageLabel;
        private System.Windows.Forms.Label streetErrorMessageLabel;
        private System.Windows.Forms.Label emailErrorMessageLabel;
        private System.Windows.Forms.Label phoneErrorLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label createCustomerErrorLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox creditLimitTextBox;
        private System.Windows.Forms.CheckBox modifyCreditLimitCheckBox;
        private System.Windows.Forms.MaskedTextBox phoneNumberMaskBox;
        private System.Windows.Forms.TextBox emailAddressTextBox;
        private System.Windows.Forms.TextBox zipCodeTextBox;
        private System.Windows.Forms.Label creditLimitErrorLabel;
        private System.Windows.Forms.Label townErrorMessageLabel;
        private System.Windows.Forms.TextBox townTextBox;
        private System.Windows.Forms.Label townLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 createCustomerButton;
        private Bunifu.Framework.UI.BunifuThinButton2 cancelButton;
    }
}