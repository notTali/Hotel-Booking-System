namespace PoppelOrderingSystem.PresentationLayer
{
    partial class CancelOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CancelOrder));
            this.ordersListView = new System.Windows.Forms.ListView();
            this.errorLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.removeButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.backButton = new FontAwesome.Sharp.IconButton();
            this.cancelButton = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ordersListView
            // 
            this.ordersListView.HideSelection = false;
            this.ordersListView.Location = new System.Drawing.Point(35, 141);
            this.ordersListView.Name = "ordersListView";
            this.ordersListView.Size = new System.Drawing.Size(846, 399);
            this.ordersListView.TabIndex = 21;
            this.ordersListView.UseCompatibleStateImageBehavior = false;
            this.ordersListView.SelectedIndexChanged += new System.EventHandler(this.ordersListView_SelectedIndexChanged);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(32, 125);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(40, 13);
            this.errorLabel.TabIndex = 31;
            this.errorLabel.Text = "<error>";
            this.errorLabel.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PoppelOrderingSystem.Properties.Resources._1601548216418;
            this.pictureBox1.Location = new System.Drawing.Point(40, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // removeButton
            // 
            this.removeButton.ActiveBorderThickness = 1;
            this.removeButton.ActiveCornerRadius = 20;
            this.removeButton.ActiveFillColor = System.Drawing.Color.Gray;
            this.removeButton.ActiveForecolor = System.Drawing.Color.White;
            this.removeButton.ActiveLineColor = System.Drawing.Color.Gray;
            this.removeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.removeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("removeButton.BackgroundImage")));
            this.removeButton.ButtonText = "Delete Order";
            this.removeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.ForeColor = System.Drawing.Color.Red;
            this.removeButton.IdleBorderThickness = 1;
            this.removeButton.IdleCornerRadius = 20;
            this.removeButton.IdleFillColor = System.Drawing.Color.White;
            this.removeButton.IdleForecolor = System.Drawing.Color.Gray;
            this.removeButton.IdleLineColor = System.Drawing.Color.Gray;
            this.removeButton.Location = new System.Drawing.Point(740, 561);
            this.removeButton.Margin = new System.Windows.Forms.Padding(5);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(141, 46);
            this.removeButton.TabIndex = 43;
            this.removeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
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
            this.backButton.Location = new System.Drawing.Point(2, 18);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(35, 34);
            this.backButton.TabIndex = 46;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
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
            this.cancelButton.Location = new System.Drawing.Point(35, 561);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(5);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(125, 46);
            this.cancelButton.TabIndex = 45;
            this.cancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // CancelOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 614);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.ordersListView);
            this.Name = "CancelOrder";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "                 Order Cancelation";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView ordersListView;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 removeButton;
        private FontAwesome.Sharp.IconButton backButton;
        private Bunifu.Framework.UI.BunifuThinButton2 cancelButton;
    }
}