namespace PoppelOrderingSystem.PresentationLayer
{
    partial class PickingList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PickingList));
            this.dateLabel = new System.Windows.Forms.Label();
            this.pickDateCalendar = new System.Windows.Forms.MonthCalendar();
            this.productListView = new System.Windows.Forms.ListView();
            this.pickDateLabel = new System.Windows.Forms.Label();
            this.pickSignLabel = new System.Windows.Forms.Label();
            this.pickNameLabel = new System.Windows.Forms.Label();
            this.selectDateLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.resetButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cancelButton = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.ForeColor = System.Drawing.Color.Black;
            this.dateLabel.Location = new System.Drawing.Point(80, 102);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(42, 13);
            this.dateLabel.TabIndex = 19;
            this.dateLabel.Text = "<Date>";
            this.dateLabel.Visible = false;
            // 
            // pickDateCalendar
            // 
            this.pickDateCalendar.Location = new System.Drawing.Point(264, 154);
            this.pickDateCalendar.Margin = new System.Windows.Forms.Padding(7);
            this.pickDateCalendar.Name = "pickDateCalendar";
            this.pickDateCalendar.TabIndex = 20;
            this.pickDateCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.pickDateCalendar_DateSelected);
            // 
            // productListView
            // 
            this.productListView.HideSelection = false;
            this.productListView.Location = new System.Drawing.Point(22, 134);
            this.productListView.Margin = new System.Windows.Forms.Padding(2);
            this.productListView.Name = "productListView";
            this.productListView.Size = new System.Drawing.Size(719, 312);
            this.productListView.TabIndex = 21;
            this.productListView.UseCompatibleStateImageBehavior = false;
            this.productListView.Visible = false;
            // 
            // pickDateLabel
            // 
            this.pickDateLabel.AutoSize = true;
            this.pickDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickDateLabel.Location = new System.Drawing.Point(297, 533);
            this.pickDateLabel.Name = "pickDateLabel";
            this.pickDateLabel.Size = new System.Drawing.Size(262, 13);
            this.pickDateLabel.TabIndex = 31;
            this.pickDateLabel.Text = "Collection Date        ..................................";
            this.pickDateLabel.Visible = false;
            // 
            // pickSignLabel
            // 
            this.pickSignLabel.AutoSize = true;
            this.pickSignLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickSignLabel.Location = new System.Drawing.Point(280, 500);
            this.pickSignLabel.Name = "pickSignLabel";
            this.pickSignLabel.Size = new System.Drawing.Size(283, 13);
            this.pickSignLabel.TabIndex = 32;
            this.pickSignLabel.Text = "Collector Signature        ..................................";
            this.pickSignLabel.Visible = false;
            // 
            // pickNameLabel
            // 
            this.pickNameLabel.AutoSize = true;
            this.pickNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickNameLabel.Location = new System.Drawing.Point(297, 472);
            this.pickNameLabel.Name = "pickNameLabel";
            this.pickNameLabel.Size = new System.Drawing.Size(261, 13);
            this.pickNameLabel.TabIndex = 34;
            this.pickNameLabel.Text = "Collector Name        ..................................";
            this.pickNameLabel.Visible = false;
            // 
            // selectDateLabel
            // 
            this.selectDateLabel.AutoSize = true;
            this.selectDateLabel.Location = new System.Drawing.Point(236, 134);
            this.selectDateLabel.Name = "selectDateLabel";
            this.selectDateLabel.Size = new System.Drawing.Size(66, 13);
            this.selectDateLabel.TabIndex = 35;
            this.selectDateLabel.Text = "Select Date:";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(313, 102);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(40, 13);
            this.errorLabel.TabIndex = 36;
            this.errorLabel.Text = "<error>";
            this.errorLabel.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PoppelOrderingSystem.Properties.Resources._1601548216418;
            this.pictureBox1.Location = new System.Drawing.Point(22, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // resetButton
            // 
            this.resetButton.ActiveBorderThickness = 1;
            this.resetButton.ActiveCornerRadius = 20;
            this.resetButton.ActiveFillColor = System.Drawing.Color.Gray;
            this.resetButton.ActiveForecolor = System.Drawing.Color.White;
            this.resetButton.ActiveLineColor = System.Drawing.Color.Gray;
            this.resetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.resetButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resetButton.BackgroundImage")));
            this.resetButton.ButtonText = "Clear";
            this.resetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.Color.Black;
            this.resetButton.IdleBorderThickness = 1;
            this.resetButton.IdleCornerRadius = 20;
            this.resetButton.IdleFillColor = System.Drawing.Color.White;
            this.resetButton.IdleForecolor = System.Drawing.Color.Gray;
            this.resetButton.IdleLineColor = System.Drawing.Color.Gray;
            this.resetButton.Location = new System.Drawing.Point(616, 564);
            this.resetButton.Margin = new System.Windows.Forms.Padding(5);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(125, 46);
            this.resetButton.TabIndex = 42;
            this.resetButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
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
            this.cancelButton.Location = new System.Drawing.Point(400, 564);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(5);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(125, 46);
            this.cancelButton.TabIndex = 43;
            this.cancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // PickingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 635);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.selectDateLabel);
            this.Controls.Add(this.pickDateCalendar);
            this.Controls.Add(this.pickNameLabel);
            this.Controls.Add(this.pickSignLabel);
            this.Controls.Add(this.pickDateLabel);
            this.Controls.Add(this.productListView);
            this.Controls.Add(this.dateLabel);
            this.Name = "PickingList";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "                Picking List";
            this.Load += new System.EventHandler(this.PickingList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.MonthCalendar pickDateCalendar;
        private System.Windows.Forms.ListView productListView;
        private System.Windows.Forms.Label pickDateLabel;
        private System.Windows.Forms.Label pickSignLabel;
        private System.Windows.Forms.Label pickNameLabel;
        private System.Windows.Forms.Label selectDateLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 resetButton;
        private Bunifu.Framework.UI.BunifuThinButton2 cancelButton;
    }
}