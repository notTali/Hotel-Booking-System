namespace PoppelOrderingSystem.PresentationLayer
{
    partial class CreateOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateOrder));
            this.stockItemsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.basketLabel = new System.Windows.Forms.Label();
            this.basketListView = new System.Windows.Forms.ListView();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.removeFromOrderButton = new System.Windows.Forms.Button();
            this.removeFiltersButton = new System.Windows.Forms.Button();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.creditRemainingLabel = new System.Windows.Forms.Label();
            this.poppelDatabaseDataSet1 = new PoppelOrderingSystem.PoppelDatabaseDataSet();
            this.backButton = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cancelOrderButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.checkOutButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.totalCostTextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.creditRemainingTextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.poppelDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // stockItemsFlowLayoutPanel
            // 
            this.stockItemsFlowLayoutPanel.AutoScroll = true;
            this.stockItemsFlowLayoutPanel.Location = new System.Drawing.Point(12, 151);
            this.stockItemsFlowLayoutPanel.Name = "stockItemsFlowLayoutPanel";
            this.stockItemsFlowLayoutPanel.Size = new System.Drawing.Size(653, 512);
            this.stockItemsFlowLayoutPanel.TabIndex = 0;
            this.stockItemsFlowLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.stockItemsFlowLayoutPanel_Paint);
            this.stockItemsFlowLayoutPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel_MouseClick);
            this.stockItemsFlowLayoutPanel.MouseEnter += new System.EventHandler(this.flowLayoutPanel_MouseEnter);
            // 
            // basketLabel
            // 
            this.basketLabel.AutoSize = true;
            this.basketLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basketLabel.Location = new System.Drawing.Point(838, 251);
            this.basketLabel.Name = "basketLabel";
            this.basketLabel.Size = new System.Drawing.Size(61, 20);
            this.basketLabel.TabIndex = 19;
            this.basketLabel.Text = "Basket";
            // 
            // basketListView
            // 
            this.basketListView.HideSelection = false;
            this.basketListView.Location = new System.Drawing.Point(674, 274);
            this.basketListView.MultiSelect = false;
            this.basketListView.Name = "basketListView";
            this.basketListView.Size = new System.Drawing.Size(228, 389);
            this.basketListView.TabIndex = 21;
            this.basketListView.UseCompatibleStateImageBehavior = false;
            this.basketListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.basketListView_ItemSelectionChanged);
            this.basketListView.Click += new System.EventHandler(this.basketListView_Click);
            this.basketListView.Leave += new System.EventHandler(this.basketListView_Leave);
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(674, 156);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(52, 13);
            this.categoryLabel.TabIndex = 22;
            this.categoryLabel.Text = "Category:";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(732, 153);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(170, 21);
            this.categoryComboBox.TabIndex = 24;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // removeFromOrderButton
            // 
            this.removeFromOrderButton.Enabled = false;
            this.removeFromOrderButton.Location = new System.Drawing.Point(677, 245);
            this.removeFromOrderButton.Name = "removeFromOrderButton";
            this.removeFromOrderButton.Size = new System.Drawing.Size(123, 23);
            this.removeFromOrderButton.TabIndex = 25;
            this.removeFromOrderButton.Text = "Delete from order";
            this.removeFromOrderButton.UseVisualStyleBackColor = true;
            this.removeFromOrderButton.Click += new System.EventHandler(this.removeFromOrderButton_Click);
            // 
            // removeFiltersButton
            // 
            this.removeFiltersButton.Location = new System.Drawing.Point(809, 180);
            this.removeFiltersButton.Name = "removeFiltersButton";
            this.removeFiltersButton.Size = new System.Drawing.Size(95, 23);
            this.removeFiltersButton.TabIndex = 26;
            this.removeFiltersButton.Text = "Delete Filters";
            this.removeFiltersButton.UseVisualStyleBackColor = true;
            this.removeFiltersButton.Click += new System.EventHandler(this.removeFiltersButton_Click);
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostLabel.Location = new System.Drawing.Point(9, 119);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(83, 16);
            this.totalCostLabel.TabIndex = 27;
            this.totalCostLabel.Text = "Total Cost:";
            // 
            // creditRemainingLabel
            // 
            this.creditRemainingLabel.AutoSize = true;
            this.creditRemainingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditRemainingLabel.Location = new System.Drawing.Point(335, 119);
            this.creditRemainingLabel.Name = "creditRemainingLabel";
            this.creditRemainingLabel.Size = new System.Drawing.Size(131, 16);
            this.creditRemainingLabel.TabIndex = 28;
            this.creditRemainingLabel.Text = "Credit Remaining:";
            // 
            // poppelDatabaseDataSet1
            // 
            this.poppelDatabaseDataSet1.DataSetName = "PoppelDatabaseDataSet";
            this.poppelDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.backButton.Location = new System.Drawing.Point(4, 8);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(35, 34);
            this.backButton.TabIndex = 44;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PoppelOrderingSystem.Properties.Resources._1601548216418;
            this.pictureBox1.Location = new System.Drawing.Point(45, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // cancelOrderButton
            // 
            this.cancelOrderButton.ActiveBorderThickness = 1;
            this.cancelOrderButton.ActiveCornerRadius = 20;
            this.cancelOrderButton.ActiveFillColor = System.Drawing.Color.Red;
            this.cancelOrderButton.ActiveForecolor = System.Drawing.Color.White;
            this.cancelOrderButton.ActiveLineColor = System.Drawing.Color.Red;
            this.cancelOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cancelOrderButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelOrderButton.BackgroundImage")));
            this.cancelOrderButton.ButtonText = "Cancel";
            this.cancelOrderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelOrderButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelOrderButton.ForeColor = System.Drawing.Color.Red;
            this.cancelOrderButton.IdleBorderThickness = 1;
            this.cancelOrderButton.IdleCornerRadius = 20;
            this.cancelOrderButton.IdleFillColor = System.Drawing.Color.White;
            this.cancelOrderButton.IdleForecolor = System.Drawing.Color.Red;
            this.cancelOrderButton.IdleLineColor = System.Drawing.Color.Red;
            this.cancelOrderButton.Location = new System.Drawing.Point(12, 681);
            this.cancelOrderButton.Margin = new System.Windows.Forms.Padding(5);
            this.cancelOrderButton.Name = "cancelOrderButton";
            this.cancelOrderButton.Size = new System.Drawing.Size(125, 46);
            this.cancelOrderButton.TabIndex = 45;
            this.cancelOrderButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancelOrderButton.Click += new System.EventHandler(this.cancelOrderButton_Click);
            // 
            // checkOutButton
            // 
            this.checkOutButton.ActiveBorderThickness = 1;
            this.checkOutButton.ActiveCornerRadius = 20;
            this.checkOutButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.checkOutButton.ActiveForecolor = System.Drawing.Color.White;
            this.checkOutButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.checkOutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.checkOutButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkOutButton.BackgroundImage")));
            this.checkOutButton.ButtonText = "Proceed to Checkout";
            this.checkOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkOutButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOutButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.checkOutButton.IdleBorderThickness = 1;
            this.checkOutButton.IdleCornerRadius = 20;
            this.checkOutButton.IdleFillColor = System.Drawing.Color.White;
            this.checkOutButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.checkOutButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.checkOutButton.Location = new System.Drawing.Point(694, 681);
            this.checkOutButton.Margin = new System.Windows.Forms.Padding(5);
            this.checkOutButton.Name = "checkOutButton";
            this.checkOutButton.Size = new System.Drawing.Size(205, 46);
            this.checkOutButton.TabIndex = 46;
            this.checkOutButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkOutButton.Click += new System.EventHandler(this.checkOutButton_Click);
            // 
            // totalCostTextBox
            // 
            this.totalCostTextBox.BorderColorFocused = System.Drawing.Color.Blue;
            this.totalCostTextBox.BorderColorIdle = System.Drawing.Color.Green;
            this.totalCostTextBox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.totalCostTextBox.BorderThickness = 2;
            this.totalCostTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.totalCostTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.totalCostTextBox.isPassword = false;
            this.totalCostTextBox.Location = new System.Drawing.Point(97, 109);
            this.totalCostTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.totalCostTextBox.Name = "totalCostTextBox";
            this.totalCostTextBox.Size = new System.Drawing.Size(151, 35);
            this.totalCostTextBox.TabIndex = 48;
            this.totalCostTextBox.Text = "R 0.00";
            this.totalCostTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // creditRemainingTextBox
            // 
            this.creditRemainingTextBox.BorderColorFocused = System.Drawing.Color.Blue;
            this.creditRemainingTextBox.BorderColorIdle = System.Drawing.Color.Green;
            this.creditRemainingTextBox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.creditRemainingTextBox.BorderThickness = 2;
            this.creditRemainingTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.creditRemainingTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditRemainingTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.creditRemainingTextBox.isPassword = false;
            this.creditRemainingTextBox.Location = new System.Drawing.Point(473, 109);
            this.creditRemainingTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.creditRemainingTextBox.Name = "creditRemainingTextBox";
            this.creditRemainingTextBox.Size = new System.Drawing.Size(152, 35);
            this.creditRemainingTextBox.TabIndex = 48;
            this.creditRemainingTextBox.Text = "R 0.00";
            this.creditRemainingTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(732, 49);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(167, 20);
            this.searchTextBox.TabIndex = 49;
            this.searchTextBox.Text = "Search Product";
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // CreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 733);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.creditRemainingTextBox);
            this.Controls.Add(this.totalCostTextBox);
            this.Controls.Add(this.checkOutButton);
            this.Controls.Add(this.cancelOrderButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.creditRemainingLabel);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.removeFiltersButton);
            this.Controls.Add(this.removeFromOrderButton);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.basketListView);
            this.Controls.Add(this.basketLabel);
            this.Controls.Add(this.stockItemsFlowLayoutPanel);
            this.Name = "CreateOrder";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "                  Create Customer Order";
            ((System.ComponentModel.ISupportInitialize)(this.poppelDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel stockItemsFlowLayoutPanel;
        private System.Windows.Forms.Label basketLabel;
        private System.Windows.Forms.ListView basketListView;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Button removeFromOrderButton;
        private System.Windows.Forms.Button removeFiltersButton;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Label creditRemainingLabel;
        private PoppelDatabaseDataSet poppelDatabaseDataSet1;
        private FontAwesome.Sharp.IconButton backButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 cancelOrderButton;
        private Bunifu.Framework.UI.BunifuThinButton2 checkOutButton;
        private Bunifu.Framework.UI.BunifuMetroTextbox totalCostTextBox;
        private Bunifu.Framework.UI.BunifuMetroTextbox creditRemainingTextBox;
        private System.Windows.Forms.TextBox searchTextBox;
    }
}