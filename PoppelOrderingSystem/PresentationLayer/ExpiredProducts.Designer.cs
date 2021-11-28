namespace PoppelOrderingSystem.Report
{
    partial class ExpiredProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpiredProducts));
            this.productListView = new System.Windows.Forms.ListView();
            this.dateLabel = new System.Windows.Forms.Label();
            this.pickDateCalendar = new System.Windows.Forms.MonthCalendar();
            this.cancelButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.resetButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // productListView
            // 
            this.productListView.HideSelection = false;
            this.productListView.HoverSelection = true;
            this.productListView.Location = new System.Drawing.Point(29, 107);
            this.productListView.Margin = new System.Windows.Forms.Padding(2);
            this.productListView.Name = "productListView";
            this.productListView.Size = new System.Drawing.Size(719, 312);
            this.productListView.TabIndex = 45;
            this.productListView.UseCompatibleStateImageBehavior = false;
            this.productListView.Visible = false;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.ForeColor = System.Drawing.Color.Black;
            this.dateLabel.Location = new System.Drawing.Point(26, 82);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(42, 13);
            this.dateLabel.TabIndex = 43;
            this.dateLabel.Text = "<Date>";
            this.dateLabel.Visible = false;
            // 
            // pickDateCalendar
            // 
            this.pickDateCalendar.Location = new System.Drawing.Point(263, 127);
            this.pickDateCalendar.Margin = new System.Windows.Forms.Padding(7);
            this.pickDateCalendar.Name = "pickDateCalendar";
            this.pickDateCalendar.TabIndex = 47;
            this.pickDateCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.pickDateCalendar_DateChanged);
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
            this.cancelButton.Location = new System.Drawing.Point(29, 439);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(5);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(146, 49);
            this.cancelButton.TabIndex = 49;
            this.cancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.ActiveBorderThickness = 1;
            this.resetButton.ActiveCornerRadius = 20;
            this.resetButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.resetButton.ActiveForecolor = System.Drawing.Color.White;
            this.resetButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.resetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.resetButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resetButton.BackgroundImage")));
            this.resetButton.ButtonText = "Reset";
            this.resetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.resetButton.IdleBorderThickness = 1;
            this.resetButton.IdleCornerRadius = 20;
            this.resetButton.IdleFillColor = System.Drawing.Color.White;
            this.resetButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.resetButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.resetButton.Location = new System.Drawing.Point(615, 439);
            this.resetButton.Margin = new System.Windows.Forms.Padding(5);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(133, 49);
            this.resetButton.TabIndex = 50;
            this.resetButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PoppelOrderingSystem.Properties.Resources._1601548216418;
            this.pictureBox1.Location = new System.Drawing.Point(7, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // ExpiredProducts
            // 
            this.ClientSize = new System.Drawing.Size(772, 508);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.pickDateCalendar);
            this.Controls.Add(this.productListView);
            this.Controls.Add(this.dateLabel);
            this.Name = "ExpiredProducts";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "            Expiring products";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView productListView;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.MonthCalendar pickDateCalendar;
        private Bunifu.Framework.UI.BunifuThinButton2 cancelButton;
        private Bunifu.Framework.UI.BunifuThinButton2 resetButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}