using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GearPoint_POS_SYSTEM.Cards
{
    public partial class ItemCards : UserControl
    {
        public ItemCards()
        {
            InitializeComponent();
        }
        public Image ItemImage
        {
            get => ItemPicture.Image;
            set => ItemPicture.Image = value;
        }
        public string ItemName
        {
            get => LabelNameItem.Text;
            set => LabelNameItem.Text = value;
        }

        public string ItemCode
        {
            get => LabelItemCode.Text;
            set => LabelItemCode.Text = value;
        }

        public decimal ItemPrice
        {
            get => decimal.Parse(LabelItemPrice.Text.Replace("₱", ""));
            set => LabelItemPrice.Text = $"₱{value:N2}";

        }
        public int ItemStock
        {
            get
            {
                // Safely convert Label text to int
                int stock;
                if (int.TryParse(LabelItemStocks.Text, out stock))
                    return stock;
                return 0; // default if parsing fails
            }
            set
            {
                // Convert int to string for the Label
                LabelItemStocks.Text = value.ToString();
            }
        }
        private void ItemCards_Load(object sender, EventArgs e)
        {

        }
    }
}
