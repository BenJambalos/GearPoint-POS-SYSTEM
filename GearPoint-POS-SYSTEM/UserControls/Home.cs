using GearPoint_POS_SYSTEM.Cards;
using GearPoint_POS_SYSTEM.SubForms;//to read sql syntax
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GearPoint_POS_SYSTEM.UserControls
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
            //LoadItems();
            LoadItemsFromDatabase();

        }

        private void PanelCards_Paint(object sender, PaintEventArgs e)
        {

        }

        public void AddItemCard(Image itemImage, string itemName, string itemCode, decimal price, int itemStock)
        {
            // Create a new instance of your custom item card
            ItemCards card = new ItemCards();

            // Set properties of the card
            card.ItemImage = itemImage;
            card.ItemName = itemName;
            card.ItemCode = itemCode;
            card.ItemPrice = price;
            card.ItemStock = itemStock;
            // Add the card to the flow panel inside this UserControl
            PanelCards.Controls.Add(card);

            // Optional: Add click event for interaction
            card.Click += (s, e) =>
            {
                MessageBox.Show($"You clicked on {itemName}");
            };


        }

        //public void LoadItems()
        //{
        //    PanelCards.Controls.Clear(); // Clear old items

        //    AddItemCard(Properties.Resources.chicarizz, "Motor Oil", "ASFHG", 350.00m, 45);
        //    AddItemCard(Properties.Resources.chicarizz, "Helmet", "HSADHI", 1200.00m, 76);
        //    AddItemCard(Properties.Resources.chicarizz, "Wrench Set", "ADSAC", 899.50m, 69);
        //    AddItemCard(Properties.Resources.chicarizz, "Spare Parts", "ASDFG", 450.75m, 34);
        //    AddItemCard(Properties.Resources.chicarizz, "Battery", "ASDFG", 450.75m, 34);
        //    AddItemCard(Properties.Resources.chicarizz, "Motor Oil", "ASFHG", 350.00m, 45);
        //    AddItemCard(Properties.Resources.chicarizz, "Helmet", "HSADHI", 1200.00m, 76);
        //    AddItemCard(Properties.Resources.chicarizz, "Wrench Set", "ADSAC", 899.50m, 69);
        //    AddItemCard(Properties.Resources.chicarizz, "Spare Parts", "ASDFG", 450.75m, 34);
        //    AddItemCard(Properties.Resources.chicarizz, "Battery", "ASDFG", 450.75m, 34);
        //    AddItemCard(Properties.Resources.chicarizz, "Motor Oil", "ASFHG", 350.00m, 45);
        //    AddItemCard(Properties.Resources.chicarizz, "Helmet", "HSADHI", 1200.00m, 76);
        //    AddItemCard(Properties.Resources.chicarizz, "Wrench Set", "ADSAC", 899.50m, 69);
        //    AddItemCard(Properties.Resources.chicarizz, "Spare Parts", "ASDFG", 450.75m, 34);
        //    AddItemCard(Properties.Resources.chicarizz, "Battery", "ASDFG", 450.75m, 34);
        //    AddItemCard(Properties.Resources.chicarizz, "Motor Oil", "ASFHG", 350.00m, 45);
        //    AddItemCard(Properties.Resources.chicarizz, "Helmet", "HSADHI", 1200.00m, 76);
        //    AddItemCard(Properties.Resources.chicarizz, "Wrench Set", "ADSAC", 899.50m, 69);
        //    AddItemCard(Properties.Resources.chicarizz, "Spare Parts", "ASDFG", 450.75m, 34);
        //    AddItemCard(Properties.Resources.chicarizz, "Battery", "ASDFG", 450.75m, 34);
        //    AddItemCard(Properties.Resources.chicarizz, "Motor Oil", "ASFHG", 350.00m, 45);
        //    AddItemCard(Properties.Resources.chicarizz, "Helmet", "HSADHI", 1200.00m, 76);
        //    AddItemCard(Properties.Resources.chicarizz, "Wrench Set", "ADSAC", 899.50m, 69);
        //    AddItemCard(Properties.Resources.chicarizz, "Spare Parts", "ASDFG", 450.75m, 34);
        //    AddItemCard(Properties.Resources.chicarizz, "Battery", "ASDFG", 450.75m, 34);


        //}

        public void LoadItemsFromDatabase()
        {
            DataTable dt = DatabaseHelper.GetDataTable("SELECT * FROM itemcards");
            PanelCards.Controls.Clear();

            foreach (DataRow row in dt.Rows)
            {
                byte[] imgBytes = (byte[])row["ItemImage"];
                string name = row["ItemName"].ToString();
                string code = row["ItemCode"].ToString();
                decimal price = Convert.ToDecimal(row["ItemPrice"]);
                int stock = Convert.ToInt32(row["ItemStock"]);

                Image itemImage;
                using (MemoryStream ms = new MemoryStream(imgBytes))
                {
                    itemImage = Image.FromStream(ms);
                }

                AddItemCard(itemImage, name, code, price, stock);
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection("server=localhost;database=gearpointdb;uid=root;pwd=;"))
                {
                    conn.Open();
                    MessageBox.Show("✅ Connection successful!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Connection failed: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            itemManagement manageForm = new itemManagement();

            // When itemManagement closes, reload the data
            manageForm.FormClosed += (s, args) =>
            {
                LoadItemsFromDatabase(); // 🔁 refresh your data/cards
            };

            manageForm.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            addCustomer addCustomer = new addCustomer();

            // When itemManagement closes, reload the data
            addCustomer.FormClosed += (s, args) =>
            {
                LoadItemsFromDatabase(); // 🔁 refresh your data/cards
            };

            addCustomer.ShowDialog();
        }
    }
}
