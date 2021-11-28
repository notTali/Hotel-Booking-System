namespace PoppelOrderingSystem.PresentationLayer
{
    partial class OrderSummary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderSummary));
            this.orderInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.employee = new System.Windows.Forms.Label();
            this.employeeLabel = new System.Windows.Forms.Label();
            this.orderTotalTextBox = new System.Windows.Forms.TextBox();
            this.orderTotalLabel = new System.Windows.Forms.Label();
            this.customer = new System.Windows.Forms.Label();
            this.orderDate = new System.Windows.Forms.Label();
            this.orderDateLabel = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            this.shoppingCartGroupBox = new System.Windows.Forms.GroupBox();
            this.OrderListView = new System.Windows.Forms.ListView();
            this.deliveryGroupBox = new System.Windows.Forms.GroupBox();
            this.DateDeliveryTextBox = new System.Windows.Forms.TextBox();
            this.deliveryDaysTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.deliveryTimeEnd = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.deliveryTimeStart = new System.Windows.Forms.Label();
            this.allowedDeliveryDaysLabel = new System.Windows.Forms.Label();
            this.deliveryTimeLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cancelButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.confirm = new Bunifu.Framework.UI.BunifuThinButton2();
            this.backButton = new FontAwesome.Sharp.IconButton();
            this.orderInfoGroupBox.SuspendLayout();
            this.shoppingCartGroupBox.SuspendLayout();
            this.deliveryGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // orderInfoGroupBox
            // 
            this.orderInfoGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.orderInfoGroupBox.Controls.Add(this.employee);
            this.orderInfoGroupBox.Controls.Add(this.employeeLabel);
            this.orderInfoGroupBox.Controls.Add(this.orderTotalTextBox);
            this.orderInfoGroupBox.Controls.Add(this.orderTotalLabel);
            this.orderInfoGroupBox.Controls.Add(this.customer);
            this.orderInfoGroupBox.Controls.Add(this.orderDate);
            this.orderInfoGroupBox.Controls.Add(this.orderDateLabel);
            this.orderInfoGroupBox.Controls.Add(this.customerLabel);
            this.orderInfoGroupBox.Location = new System.Drawing.Point(12, 121);
            this.orderInfoGroupBox.Name = "orderInfoGroupBox";
            this.orderInfoGroupBox.Size = new System.Drawing.Size(385, 199);
            this.orderInfoGroupBox.TabIndex = 0;
            this.orderInfoGroupBox.TabStop = false;
            this.orderInfoGroupBox.Text = "Order Details";
            // 
            // employee
            // 
            this.employee.AutoSize = true;
            this.employee.Location = new System.Drawing.Point(116, 34);
            this.employee.Name = "employee";
            this.employee.Size = new System.Drawing.Size(98, 13);
            this.employee.TabIndex = 11;
            this.employee.Text = "<Sales Consultant>";
            this.employee.Visible = false;
            this.employee.Click += new System.EventHandler(this.employee_Click);
            // 
            // employeeLabel
            // 
            this.employeeLabel.AutoSize = true;
            this.employeeLabel.Location = new System.Drawing.Point(72, 34);
            this.employeeLabel.Name = "employeeLabel";
            this.employeeLabel.Size = new System.Drawing.Size(34, 13);
            this.employeeLabel.TabIndex = 10;
            this.employeeLabel.Text = "Clerk:";
            this.employeeLabel.Visible = false;
            // 
            // orderTotalTextBox
            // 
            this.orderTotalTextBox.Location = new System.Drawing.Point(141, 118);
            this.orderTotalTextBox.Name = "orderTotalTextBox";
            this.orderTotalTextBox.Size = new System.Drawing.Size(111, 20);
            this.orderTotalTextBox.TabIndex = 90;
            this.orderTotalTextBox.TabStop = false;
            // 
            // orderTotalLabel
            // 
            this.orderTotalLabel.AutoSize = true;
            this.orderTotalLabel.Location = new System.Drawing.Point(65, 121);
            this.orderTotalLabel.Name = "orderTotalLabel";
            this.orderTotalLabel.Size = new System.Drawing.Size(63, 13);
            this.orderTotalLabel.TabIndex = 8;
            this.orderTotalLabel.Text = "Order Total:";
            // 
            // customer
            // 
            this.customer.AutoSize = true;
            this.customer.Location = new System.Drawing.Point(137, 64);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(63, 13);
            this.customer.TabIndex = 6;
            this.customer.Text = "<Customer>";
            // 
            // orderDate
            // 
            this.orderDate.AutoSize = true;
            this.orderDate.Location = new System.Drawing.Point(138, 92);
            this.orderDate.Name = "orderDate";
            this.orderDate.Size = new System.Drawing.Size(71, 13);
            this.orderDate.TabIndex = 5;
            this.orderDate.Text = "<Order Date>";
            // 
            // orderDateLabel
            // 
            this.orderDateLabel.AutoSize = true;
            this.orderDateLabel.Location = new System.Drawing.Point(66, 92);
            this.orderDateLabel.Name = "orderDateLabel";
            this.orderDateLabel.Size = new System.Drawing.Size(62, 13);
            this.orderDateLabel.TabIndex = 2;
            this.orderDateLabel.Text = "Order Date:";
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Location = new System.Drawing.Point(74, 64);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(54, 13);
            this.customerLabel.TabIndex = 1;
            this.customerLabel.Text = "Customer:";
            // 
            // shoppingCartGroupBox
            // 
            this.shoppingCartGroupBox.Controls.Add(this.OrderListView);
            this.shoppingCartGroupBox.Location = new System.Drawing.Point(12, 326);
            this.shoppingCartGroupBox.Name = "shoppingCartGroupBox";
            this.shoppingCartGroupBox.Size = new System.Drawing.Size(774, 233);
            this.shoppingCartGroupBox.TabIndex = 36;
            this.shoppingCartGroupBox.TabStop = false;
            this.shoppingCartGroupBox.Text = "Shopping Cart";
            // 
            // OrderListView
            // 
            this.OrderListView.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.OrderListView.HideSelection = false;
            this.OrderListView.Location = new System.Drawing.Point(6, 19);
            this.OrderListView.MultiSelect = false;
            this.OrderListView.Name = "OrderListView";
            this.OrderListView.Size = new System.Drawing.Size(762, 208);
            this.OrderListView.TabIndex = 22;
            this.OrderListView.UseCompatibleStateImageBehavior = false;
            // 
            // deliveryGroupBox
            // 
            this.deliveryGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.deliveryGroupBox.Controls.Add(this.DateDeliveryTextBox);
            this.deliveryGroupBox.Controls.Add(this.deliveryDaysTextBox);
            this.deliveryGroupBox.Controls.Add(this.addressTextBox);
            this.deliveryGroupBox.Controls.Add(this.addressLabel);
            this.deliveryGroupBox.Controls.Add(this.deliveryTimeEnd);
            this.deliveryGroupBox.Controls.Add(this.label17);
            this.deliveryGroupBox.Controls.Add(this.deliveryTimeStart);
            this.deliveryGroupBox.Controls.Add(this.allowedDeliveryDaysLabel);
            this.deliveryGroupBox.Controls.Add(this.deliveryTimeLabel);
            this.deliveryGroupBox.Location = new System.Drawing.Point(403, 121);
            this.deliveryGroupBox.Name = "deliveryGroupBox";
            this.deliveryGroupBox.Size = new System.Drawing.Size(383, 199);
            this.deliveryGroupBox.TabIndex = 8;
            this.deliveryGroupBox.TabStop = false;
            this.deliveryGroupBox.Text = "Delivery Details";
            // 
            // DateDeliveryTextBox
            // 
            this.DateDeliveryTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.DateDeliveryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DateDeliveryTextBox.Location = new System.Drawing.Point(186, 45);
            this.DateDeliveryTextBox.Multiline = true;
            this.DateDeliveryTextBox.Name = "DateDeliveryTextBox";
            this.DateDeliveryTextBox.Size = new System.Drawing.Size(98, 66);
            this.DateDeliveryTextBox.TabIndex = 14;
            this.DateDeliveryTextBox.TabStop = false;
            // 
            // deliveryDaysTextBox
            // 
            this.deliveryDaysTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.deliveryDaysTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.deliveryDaysTextBox.Location = new System.Drawing.Point(128, 46);
            this.deliveryDaysTextBox.Multiline = true;
            this.deliveryDaysTextBox.Name = "deliveryDaysTextBox";
            this.deliveryDaysTextBox.Size = new System.Drawing.Size(75, 66);
            this.deliveryDaysTextBox.TabIndex = 13;
            this.deliveryDaysTextBox.TabStop = false;
            // 
            // addressTextBox
            // 
            this.addressTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.addressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addressTextBox.Location = new System.Drawing.Point(128, 118);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(239, 76);
            this.addressTextBox.TabIndex = 12;
            this.addressTextBox.TabStop = false;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(74, 118);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(48, 13);
            this.addressLabel.TabIndex = 10;
            this.addressLabel.Text = "Address:";
            // 
            // deliveryTimeEnd
            // 
            this.deliveryTimeEnd.AutoSize = true;
            this.deliveryTimeEnd.Location = new System.Drawing.Point(226, 20);
            this.deliveryTimeEnd.Name = "deliveryTimeEnd";
            this.deliveryTimeEnd.Size = new System.Drawing.Size(34, 13);
            this.deliveryTimeEnd.TabIndex = 9;
            this.deliveryTimeEnd.Text = "00:00";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(187, 20);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(16, 13);
            this.label17.TabIndex = 8;
            this.label17.Text = "to";
            // 
            // deliveryTimeStart
            // 
            this.deliveryTimeStart.AutoSize = true;
            this.deliveryTimeStart.Location = new System.Drawing.Point(128, 21);
            this.deliveryTimeStart.Name = "deliveryTimeStart";
            this.deliveryTimeStart.Size = new System.Drawing.Size(34, 13);
            this.deliveryTimeStart.TabIndex = 7;
            this.deliveryTimeStart.Text = "14:00";
            // 
            // allowedDeliveryDaysLabel
            // 
            this.allowedDeliveryDaysLabel.AutoSize = true;
            this.allowedDeliveryDaysLabel.Location = new System.Drawing.Point(47, 56);
            this.allowedDeliveryDaysLabel.Name = "allowedDeliveryDaysLabel";
            this.allowedDeliveryDaysLabel.Size = new System.Drawing.Size(75, 13);
            this.allowedDeliveryDaysLabel.TabIndex = 1;
            this.allowedDeliveryDaysLabel.Text = "Delivery Days:";
            // 
            // deliveryTimeLabel
            // 
            this.deliveryTimeLabel.AutoSize = true;
            this.deliveryTimeLabel.Location = new System.Drawing.Point(48, 21);
            this.deliveryTimeLabel.Name = "deliveryTimeLabel";
            this.deliveryTimeLabel.Size = new System.Drawing.Size(74, 13);
            this.deliveryTimeLabel.TabIndex = 0;
            this.deliveryTimeLabel.Text = "Delivery Time:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PoppelOrderingSystem.Properties.Resources._1601548216418;
            this.pictureBox1.Location = new System.Drawing.Point(43, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
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
            this.cancelButton.ForeColor = System.Drawing.Color.Red;
            this.cancelButton.IdleBorderThickness = 1;
            this.cancelButton.IdleCornerRadius = 20;
            this.cancelButton.IdleFillColor = System.Drawing.Color.White;
            this.cancelButton.IdleForecolor = System.Drawing.Color.Red;
            this.cancelButton.IdleLineColor = System.Drawing.Color.Red;
            this.cancelButton.Location = new System.Drawing.Point(12, 558);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(5);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(125, 46);
            this.cancelButton.TabIndex = 41;
            this.cancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // confirm
            // 
            this.confirm.ActiveBorderThickness = 1;
            this.confirm.ActiveCornerRadius = 20;
            this.confirm.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.confirm.ActiveForecolor = System.Drawing.Color.White;
            this.confirm.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.confirm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("confirm.BackgroundImage")));
            this.confirm.ButtonText = "Confirm";
            this.confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm.ForeColor = System.Drawing.Color.SeaGreen;
            this.confirm.IdleBorderThickness = 1;
            this.confirm.IdleCornerRadius = 20;
            this.confirm.IdleFillColor = System.Drawing.Color.White;
            this.confirm.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.confirm.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.confirm.Location = new System.Drawing.Point(661, 558);
            this.confirm.Margin = new System.Windows.Forms.Padding(5);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(125, 46);
            this.confirm.TabIndex = 41;
            this.confirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
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
            this.backButton.Location = new System.Drawing.Point(2, 11);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(35, 34);
            this.backButton.TabIndex = 42;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // OrderSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 607);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.deliveryGroupBox);
            this.Controls.Add(this.shoppingCartGroupBox);
            this.Controls.Add(this.orderInfoGroupBox);
            this.Name = "OrderSummary";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "                   Order Summary";
            this.orderInfoGroupBox.ResumeLayout(false);
            this.orderInfoGroupBox.PerformLayout();
            this.shoppingCartGroupBox.ResumeLayout(false);
            this.deliveryGroupBox.ResumeLayout(false);
            this.deliveryGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox orderInfoGroupBox;
        private System.Windows.Forms.Label customer;
        private System.Windows.Forms.Label orderDate;
        private System.Windows.Forms.Label orderDateLabel;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.GroupBox shoppingCartGroupBox;
        private System.Windows.Forms.GroupBox deliveryGroupBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label deliveryTimeEnd;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label deliveryTimeStart;
        private System.Windows.Forms.Label allowedDeliveryDaysLabel;
        private System.Windows.Forms.Label deliveryTimeLabel;
        private System.Windows.Forms.TextBox orderTotalTextBox;
        private System.Windows.Forms.Label orderTotalLabel;
        private System.Windows.Forms.ListView OrderListView;
        private System.Windows.Forms.Label employee;
        private System.Windows.Forms.Label employeeLabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox deliveryDaysTextBox;
        private System.Windows.Forms.TextBox DateDeliveryTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 cancelButton;
        private Bunifu.Framework.UI.BunifuThinButton2 confirm;
        private FontAwesome.Sharp.IconButton backButton;
    }
}