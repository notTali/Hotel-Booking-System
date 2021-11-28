using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PoppelOrderingSystem.Order;
using PoppelOrderingSystem.Domain;
using System.IO;
namespace PoppelOrderingSystem.Order
{
   public class OrderItemForm
    {

        private int id;
        private OrderItem refOrderItem;

        public OrderItem RefOrderItem
        {
            get { return refOrderItem; }
            set { refOrderItem = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private FlowLayoutPanel productPanel;

        public FlowLayoutPanel ProductPanel
        {
            get { return productPanel; }
            set { productPanel = value; }
        }
        private Label pictureLabel = new Label();

        public Label PictureLabel
        {
            get { return pictureLabel; }
            set { pictureLabel = value; }
        }
        private Label productDescriptionLabel;

        public Label ProductDescriptionLabel
        {
            get { return productDescriptionLabel; }
            set { productDescriptionLabel = value; }
        }

        private Label numberInStockLabel = new Label();

        public Label NumberInStockLabel
        {
            get { return numberInStockLabel; }
            set { numberInStockLabel = value; }
        }
        private CheckBox similarFilterCheckBox;

        public CheckBox SimilarFilterCheckBox
        {
            get { return similarFilterCheckBox; }
            set { similarFilterCheckBox = value; }
        }
        private Label costLabel;

        public Label CostLabel
        {
            get { return costLabel; }
            set { costLabel = value; }
        }

        private Label quantityLabel;

        public Label QuantityLabel
        {
            get { return quantityLabel; }
            set { quantityLabel = value; }
        }
        private NumericUpDown orderQuantityNumericUpDown;

        public NumericUpDown OrderQuantityNumericUpDown
        {
            get { return orderQuantityNumericUpDown; }
            set { orderQuantityNumericUpDown = value; }
        }
        private Button placeOrderButton;

        public Button PlaceOrderButton
        {
            get { return placeOrderButton; }
            set { placeOrderButton = value; }
        }
        private Label spacerLabel;

        public Label SpacerLabel
        {
            get { return spacerLabel; }
            set { spacerLabel = value; }
        }

        public OrderItemForm(OrderItem orderItem)
        {
            productPanel = new FlowLayoutPanel();
            pictureLabel = new Label();
            productDescriptionLabel = new Label();
            numberInStockLabel = new Label();
            similarFilterCheckBox = new CheckBox();
            costLabel = new Label();
            quantityLabel = new Label();
            orderQuantityNumericUpDown = new NumericUpDown();
            placeOrderButton = new Button();
            spacerLabel = new Label();

            RefOrderItem = orderItem;
            Id = orderItem.Product.Id;

            ProductPanel.Width = 200;
            ProductPanel.Height = 270;
            ProductPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;


            PictureLabel.Width = 200;
            PictureLabel.Height = 150;
            string path = "Assets/" + orderItem.Product.ProductCode + ".png";
            FileInfo file = new FileInfo(path);
            if(file.Exists)
            {
                Bitmap pictureBitmap = new Bitmap(path);
                PictureLabel.Image = pictureBitmap;

            }

            ProductPanel.Controls.Add(PictureLabel);

            ProductDescriptionLabel = new Label();
            ProductDescriptionLabel.Width = ProductPanel.Width;
            ProductDescriptionLabel.Text = orderItem.Product.Description;
            ProductDescriptionLabel.TextAlign = ContentAlignment.TopCenter;
            ProductPanel.Controls.Add(ProductDescriptionLabel);


            NumberInStockLabel.Text = "Quantity In Stock: " + orderItem.Product.NumberInStock;
            NumberInStockLabel.AutoSize = true;
            NumberInStockLabel.Width = ProductPanel.Width;


            SimilarFilterCheckBox.Width = ProductPanel.Width;
            SimilarFilterCheckBox.Text = "Filter to alternatives";
            SimilarFilterCheckBox.Tag = orderItem.Product.Id;
            


            ProductPanel.Controls.Add(NumberInStockLabel);
            ProductPanel.Controls.Add(SimilarFilterCheckBox);


            CostLabel = new Label();
            CostLabel.Text = "R " + string.Format("{0:0.00}", orderItem.Product.Price);
            CostLabel.Width = ProductPanel.Width;
            CostLabel.BackColor = Color.NavajoWhite;
            CostLabel.TextAlign = ContentAlignment.MiddleCenter;
            CostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CostLabel.Width = ProductPanel.Width;
            ProductPanel.Controls.Add(CostLabel);


            QuantityLabel.Text = "Quantity:";
            QuantityLabel.TextAlign = ContentAlignment.MiddleCenter;
            QuantityLabel.Size = new System.Drawing.Size(49, 20);
            ProductPanel.Controls.Add(QuantityLabel);


            OrderQuantityNumericUpDown.Minimum = 1;
            OrderQuantityNumericUpDown.Width = 35;
            OrderQuantityNumericUpDown.Tag = orderItem.Product.Id;
            OrderQuantityNumericUpDown.Maximum = orderItem.Product.NumberInStock;
            ProductPanel.Controls.Add(OrderQuantityNumericUpDown);
           

            PlaceOrderButton.Tag = orderItem.Product.Id;
            PlaceOrderButton.Text = "Add";
            

            SpacerLabel.Width = 15;
            ProductPanel.Controls.Add(SpacerLabel);
            ProductPanel.Controls.Add(PlaceOrderButton);

            if(orderItem.Product.NumberInStock<=0)
            {
                placeOrderButton.Enabled = false;
                orderQuantityNumericUpDown.Enabled = false;
            }
           
        }

        #region Properties


        #endregion

        public OrderController OrderController
        {
            get => default;
            set
            {
            }
        }
    }
}
