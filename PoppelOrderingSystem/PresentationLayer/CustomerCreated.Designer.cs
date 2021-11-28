namespace PoppelOrderingSystem.PresentationLayer
{
    partial class CustomerCreated
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerCreated));
            this.messageLabel = new System.Windows.Forms.Label();
            this.CustomerNumberLabel = new System.Windows.Forms.Label();
            this.customerNumberTextBox = new System.Windows.Forms.TextBox();
            this.customersListView = new System.Windows.Forms.ListView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closeButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(386, 465);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 13);
            this.messageLabel.TabIndex = 16;
            // 
            // CustomerNumberLabel
            // 
            this.CustomerNumberLabel.AutoSize = true;
            this.CustomerNumberLabel.Location = new System.Drawing.Point(14, 431);
            this.CustomerNumberLabel.Name = "CustomerNumberLabel";
            this.CustomerNumberLabel.Size = new System.Drawing.Size(94, 13);
            this.CustomerNumberLabel.TabIndex = 17;
            this.CustomerNumberLabel.Text = "Customer Number:";
            // 
            // customerNumberTextBox
            // 
            this.customerNumberTextBox.Location = new System.Drawing.Point(114, 431);
            this.customerNumberTextBox.Name = "customerNumberTextBox";
            this.customerNumberTextBox.ReadOnly = true;
            this.customerNumberTextBox.Size = new System.Drawing.Size(168, 20);
            this.customerNumberTextBox.TabIndex = 19;
            // 
            // customersListView
            // 
            this.customersListView.HideSelection = false;
            this.customersListView.Location = new System.Drawing.Point(15, 120);
            this.customersListView.Name = "customersListView";
            this.customersListView.Size = new System.Drawing.Size(693, 293);
            this.customersListView.TabIndex = 21;
            this.customersListView.UseCompatibleStateImageBehavior = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PoppelOrderingSystem.Properties.Resources._1601548216418;
            this.pictureBox1.Location = new System.Drawing.Point(15, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // closeButton
            // 
            this.closeButton.ActiveBorderThickness = 1;
            this.closeButton.ActiveCornerRadius = 20;
            this.closeButton.ActiveFillColor = System.Drawing.Color.Red;
            this.closeButton.ActiveForecolor = System.Drawing.Color.White;
            this.closeButton.ActiveLineColor = System.Drawing.Color.Red;
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
            this.closeButton.ButtonText = "Close";
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.Red;
            this.closeButton.IdleBorderThickness = 1;
            this.closeButton.IdleCornerRadius = 20;
            this.closeButton.IdleFillColor = System.Drawing.Color.White;
            this.closeButton.IdleForecolor = System.Drawing.Color.Red;
            this.closeButton.IdleLineColor = System.Drawing.Color.Red;
            this.closeButton.Location = new System.Drawing.Point(583, 483);
            this.closeButton.Margin = new System.Windows.Forms.Padding(5);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(125, 46);
            this.closeButton.TabIndex = 42;
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 461);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Keep track of this customer number for ordering perposes!";
            // 
            // CustomerCreated
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 554);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.customersListView);
            this.Controls.Add(this.customerNumberTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomerNumberLabel);
            this.Controls.Add(this.messageLabel);
            this.Name = "CustomerCreated";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "                 All Customers Customer";
            this.Activated += new System.EventHandler(this.CustomerCreatedForm_Activated);
            this.Load += new System.EventHandler(this.CustomerCreatedForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label CustomerNumberLabel;
        private System.Windows.Forms.TextBox customerNumberTextBox;
        private System.Windows.Forms.ListView customersListView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 closeButton;
        private System.Windows.Forms.Label label1;
    }
}