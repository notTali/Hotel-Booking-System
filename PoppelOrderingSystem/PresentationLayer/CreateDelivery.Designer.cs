namespace PoppelOrderingSystem.PresentationLayer
{
    partial class CreateDelivery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateDelivery));
            this.deliveryTimeLabel = new System.Windows.Forms.Label();
            this.startTimeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.endTimeComboBox = new System.Windows.Forms.ComboBox();
            this.day1CheckBox = new System.Windows.Forms.CheckBox();
            this.day2CheckBox = new System.Windows.Forms.CheckBox();
            this.day3CheckBox = new System.Windows.Forms.CheckBox();
            this.day4CheckBox = new System.Windows.Forms.CheckBox();
            this.day5CheckBox = new System.Windows.Forms.CheckBox();
            this.deliveryErrorMessageLabel = new System.Windows.Forms.Label();
            this.deliveryWeekLabel = new System.Windows.Forms.Label();
            this.dateOfWeekOfDelivery = new System.Windows.Forms.Label();
            this.allowedDaysLabel = new System.Windows.Forms.Label();
            this.timeErrorLabel = new System.Windows.Forms.Label();
            this.backButton = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nextButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cancelButton = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // deliveryTimeLabel
            // 
            this.deliveryTimeLabel.AutoSize = true;
            this.deliveryTimeLabel.Location = new System.Drawing.Point(166, 144);
            this.deliveryTimeLabel.Name = "deliveryTimeLabel";
            this.deliveryTimeLabel.Size = new System.Drawing.Size(74, 13);
            this.deliveryTimeLabel.TabIndex = 34;
            this.deliveryTimeLabel.Text = "Delivery Time:";
            // 
            // startTimeComboBox
            // 
            this.startTimeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startTimeComboBox.FormattingEnabled = true;
            this.startTimeComboBox.Items.AddRange(new object[] {
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00"});
            this.startTimeComboBox.Location = new System.Drawing.Point(246, 141);
            this.startTimeComboBox.Name = "startTimeComboBox";
            this.startTimeComboBox.Size = new System.Drawing.Size(121, 21);
            this.startTimeComboBox.TabIndex = 35;
            this.startTimeComboBox.SelectedIndexChanged += new System.EventHandler(this.startTimeComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(374, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "to";
            // 
            // endTimeComboBox
            // 
            this.endTimeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.endTimeComboBox.FormattingEnabled = true;
            this.endTimeComboBox.Location = new System.Drawing.Point(395, 141);
            this.endTimeComboBox.Name = "endTimeComboBox";
            this.endTimeComboBox.Size = new System.Drawing.Size(121, 21);
            this.endTimeComboBox.TabIndex = 37;
            // 
            // day1CheckBox
            // 
            this.day1CheckBox.AutoSize = true;
            this.day1CheckBox.Location = new System.Drawing.Point(243, 211);
            this.day1CheckBox.Name = "day1CheckBox";
            this.day1CheckBox.Size = new System.Drawing.Size(64, 17);
            this.day1CheckBox.TabIndex = 40;
            this.day1CheckBox.Text = "Monday";
            this.day1CheckBox.UseVisualStyleBackColor = true;
            // 
            // day2CheckBox
            // 
            this.day2CheckBox.AutoSize = true;
            this.day2CheckBox.Location = new System.Drawing.Point(243, 234);
            this.day2CheckBox.Name = "day2CheckBox";
            this.day2CheckBox.Size = new System.Drawing.Size(67, 17);
            this.day2CheckBox.TabIndex = 42;
            this.day2CheckBox.Text = "Tuesday";
            this.day2CheckBox.UseVisualStyleBackColor = true;
            // 
            // day3CheckBox
            // 
            this.day3CheckBox.AutoSize = true;
            this.day3CheckBox.Location = new System.Drawing.Point(243, 257);
            this.day3CheckBox.Name = "day3CheckBox";
            this.day3CheckBox.Size = new System.Drawing.Size(83, 17);
            this.day3CheckBox.TabIndex = 43;
            this.day3CheckBox.Text = "Wednesday";
            this.day3CheckBox.UseVisualStyleBackColor = true;
            // 
            // day4CheckBox
            // 
            this.day4CheckBox.AutoSize = true;
            this.day4CheckBox.Location = new System.Drawing.Point(243, 280);
            this.day4CheckBox.Name = "day4CheckBox";
            this.day4CheckBox.Size = new System.Drawing.Size(70, 17);
            this.day4CheckBox.TabIndex = 44;
            this.day4CheckBox.Text = "Thursday";
            this.day4CheckBox.UseVisualStyleBackColor = true;
            // 
            // day5CheckBox
            // 
            this.day5CheckBox.AutoSize = true;
            this.day5CheckBox.Location = new System.Drawing.Point(243, 303);
            this.day5CheckBox.Name = "day5CheckBox";
            this.day5CheckBox.Size = new System.Drawing.Size(54, 17);
            this.day5CheckBox.TabIndex = 45;
            this.day5CheckBox.Text = "Friday";
            this.day5CheckBox.UseVisualStyleBackColor = true;
            // 
            // deliveryErrorMessageLabel
            // 
            this.deliveryErrorMessageLabel.AutoSize = true;
            this.deliveryErrorMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.deliveryErrorMessageLabel.Location = new System.Drawing.Point(240, 323);
            this.deliveryErrorMessageLabel.Name = "deliveryErrorMessageLabel";
            this.deliveryErrorMessageLabel.Size = new System.Drawing.Size(70, 13);
            this.deliveryErrorMessageLabel.TabIndex = 46;
            this.deliveryErrorMessageLabel.Text = "<Error Label>";
            this.deliveryErrorMessageLabel.Visible = false;
            // 
            // deliveryWeekLabel
            // 
            this.deliveryWeekLabel.AutoSize = true;
            this.deliveryWeekLabel.Location = new System.Drawing.Point(163, 181);
            this.deliveryWeekLabel.Name = "deliveryWeekLabel";
            this.deliveryWeekLabel.Size = new System.Drawing.Size(74, 13);
            this.deliveryWeekLabel.TabIndex = 47;
            this.deliveryWeekLabel.Text = "Delivery Date:";
            // 
            // dateOfWeekOfDelivery
            // 
            this.dateOfWeekOfDelivery.AutoSize = true;
            this.dateOfWeekOfDelivery.Location = new System.Drawing.Point(243, 181);
            this.dateOfWeekOfDelivery.Name = "dateOfWeekOfDelivery";
            this.dateOfWeekOfDelivery.Size = new System.Drawing.Size(89, 13);
            this.dateOfWeekOfDelivery.TabIndex = 48;
            this.dateOfWeekOfDelivery.Text = "<Delivery Week>";
            this.dateOfWeekOfDelivery.Visible = false;
            // 
            // allowedDaysLabel
            // 
            this.allowedDaysLabel.AutoSize = true;
            this.allowedDaysLabel.Location = new System.Drawing.Point(163, 212);
            this.allowedDaysLabel.Name = "allowedDaysLabel";
            this.allowedDaysLabel.Size = new System.Drawing.Size(75, 13);
            this.allowedDaysLabel.TabIndex = 49;
            this.allowedDaysLabel.Text = "Delivery Days:";
            // 
            // timeErrorLabel
            // 
            this.timeErrorLabel.AutoSize = true;
            this.timeErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.timeErrorLabel.Location = new System.Drawing.Point(243, 165);
            this.timeErrorLabel.Name = "timeErrorLabel";
            this.timeErrorLabel.Size = new System.Drawing.Size(70, 13);
            this.timeErrorLabel.TabIndex = 50;
            this.timeErrorLabel.Text = "<Error Label>";
            this.timeErrorLabel.Visible = false;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.White;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.backButton.IconColor = System.Drawing.Color.Black;
            this.backButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.backButton.IconSize = 30;
            this.backButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backButton.Location = new System.Drawing.Point(1, 7);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(35, 34);
            this.backButton.TabIndex = 52;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PoppelOrderingSystem.Properties.Resources._1601548216418;
            this.pictureBox1.Location = new System.Drawing.Point(42, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // nextButton
            // 
            this.nextButton.ActiveBorderThickness = 1;
            this.nextButton.ActiveCornerRadius = 20;
            this.nextButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.nextButton.ActiveForecolor = System.Drawing.Color.White;
            this.nextButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.nextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nextButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nextButton.BackgroundImage")));
            this.nextButton.ButtonText = "Next";
            this.nextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.nextButton.IdleBorderThickness = 1;
            this.nextButton.IdleCornerRadius = 20;
            this.nextButton.IdleFillColor = System.Drawing.Color.White;
            this.nextButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.nextButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.nextButton.Location = new System.Drawing.Point(480, 364);
            this.nextButton.Margin = new System.Windows.Forms.Padding(5);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(125, 46);
            this.nextButton.TabIndex = 53;
            this.nextButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
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
            this.cancelButton.ForeColor = System.Drawing.Color.Red;
            this.cancelButton.IdleBorderThickness = 1;
            this.cancelButton.IdleCornerRadius = 20;
            this.cancelButton.IdleFillColor = System.Drawing.Color.White;
            this.cancelButton.IdleForecolor = System.Drawing.Color.Red;
            this.cancelButton.IdleLineColor = System.Drawing.Color.Red;
            this.cancelButton.Location = new System.Drawing.Point(42, 364);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(5);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(125, 46);
            this.cancelButton.TabIndex = 54;
            this.cancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // CreateDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 417);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.timeErrorLabel);
            this.Controls.Add(this.allowedDaysLabel);
            this.Controls.Add(this.dateOfWeekOfDelivery);
            this.Controls.Add(this.deliveryWeekLabel);
            this.Controls.Add(this.deliveryErrorMessageLabel);
            this.Controls.Add(this.day5CheckBox);
            this.Controls.Add(this.day4CheckBox);
            this.Controls.Add(this.day3CheckBox);
            this.Controls.Add(this.day2CheckBox);
            this.Controls.Add(this.day1CheckBox);
            this.Controls.Add(this.endTimeComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startTimeComboBox);
            this.Controls.Add(this.deliveryTimeLabel);
            this.Name = "CreateDelivery";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "                 Delivery";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label deliveryTimeLabel;
        private System.Windows.Forms.ComboBox startTimeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox endTimeComboBox;
        private System.Windows.Forms.CheckBox day1CheckBox;
        private System.Windows.Forms.CheckBox day2CheckBox;
        private System.Windows.Forms.CheckBox day3CheckBox;
        private System.Windows.Forms.CheckBox day4CheckBox;
        private System.Windows.Forms.CheckBox day5CheckBox;
        private System.Windows.Forms.Label deliveryErrorMessageLabel;
        private System.Windows.Forms.Label deliveryWeekLabel;
        private System.Windows.Forms.Label dateOfWeekOfDelivery;
        private System.Windows.Forms.Label allowedDaysLabel;
        private System.Windows.Forms.Label timeErrorLabel;
        private FontAwesome.Sharp.IconButton backButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 nextButton;
        private Bunifu.Framework.UI.BunifuThinButton2 cancelButton;
    }
}