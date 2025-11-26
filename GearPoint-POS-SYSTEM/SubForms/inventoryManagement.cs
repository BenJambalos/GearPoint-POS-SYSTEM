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

namespace GearPoint_POS_SYSTEM.SubForms
{
    public partial class inventoryManagement : Form
    {
        public inventoryManagement()
        {
            InitializeComponent();
        }

        private void loadData()
        {

            string query = "SELECT * FROM itemcards";
            DataTable dt = DatabaseHelper.GetDataTable(query);
            dataGridView.DataSource = dt;

        }
        private void inventoryManagement_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] imageBytes;
                using (MemoryStream ms = new MemoryStream())
                {
                    itemImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    imageBytes = ms.ToArray();
                }

                string query = "INSERT INTO itemcards (ItemImage, ItemName, ItemCode, ItemPrice, ItemStock, ItemCategory) VALUES (@ItemImage, @ItemName, @ItemCode, @ItemPrice, @ItemStock, @ItemCategory)";
                var parameters = new Dictionary<string, object>
                {
                    { "@ItemImage", imageBytes },
                    { "@ItemName", txtName.Text },
                    { "@ItemCode", txtCode.Text },
                    { "@ItemPrice", decimal.Parse(txtPrice.Text) },
                    { "@ItemStock", int.Parse(txtStock.Text) },
                    { "@ItemCategory", txtCategory.Text }
                };

                DatabaseHelper.ExecuteQuery(query, parameters);

                MessageBox.Show("✅ Item added successfully!");

                loadData(); // Refresh data grid
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error adding item: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] imageBytes = null;

                // Only save image if one exists
                if (itemImage.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        itemImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        imageBytes = ms.ToArray();
                    }
                }

                string query = @"UPDATE itemcards 
                         SET ItemImage = @ItemImage, 
                             ItemName = @ItemName, 
                             ItemCode = @ItemCode, 
                             ItemPrice = @ItemPrice, 
                             ItemStock = @ItemStock,
                             ItemCategory = @ItemCategory
                         WHERE ItemID = @ItemID";

                var parameters = new Dictionary<string, object>
                {
                    { "@ItemImage", (object)imageBytes ?? DBNull.Value },
                    { "@ItemName", txtName.Text },
                    { "@ItemCode", txtCode.Text },
                    { "@ItemPrice", decimal.Parse(txtPrice.Text) },
                    { "@ItemStock", int.Parse(txtStock.Text) },
                    { "@ItemCategory", txtCategory.Text },
                    { "@ItemID", int.Parse(txtID.Text) } // assumes you have a textbox for ID
                };

                DatabaseHelper.ExecuteQuery(query, parameters);

                MessageBox.Show("✅ Item updated successfully!");

                loadData(); // Refresh data grid
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error updating item: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "DELETE FROM itemcards WHERE ItemID = @ItemID";

                var parameters = new Dictionary<string, object>
                {
                    { "@ItemID", int.Parse(txtID.Text) } // assumes textbox for ID
                };

                DatabaseHelper.ExecuteQuery(query, parameters);

                MessageBox.Show("🗑️ Item deleted successfully!");
                loadData(); // Refresh data grid
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error deleting item: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            itemImage.Image = null;
            txtID.Clear();
            txtName.Clear();
            txtCode.Clear();
            txtPrice.Clear();
            txtStock.Clear();
            txtCategory.Clear();
            txtName.Focus();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                txtID.Text = row.Cells["ItemID"].Value.ToString();
                txtName.Text = row.Cells["ItemName"].Value.ToString();
                txtCode.Text = row.Cells["ItemCode"].Value.ToString();
                txtPrice.Text = row.Cells["ItemPrice"].Value.ToString();
                txtStock.Text = row.Cells["ItemStock"].Value.ToString();
                txtCategory.Text = row.Cells["ItemCategory"].Value.ToString();

                if (row.Cells["ItemImage"].Value != DBNull.Value)
                {
                    byte[] imgBytes = (byte[])row.Cells["ItemImage"].Value;
                    using (MemoryStream ms = new MemoryStream(imgBytes))
                        itemImage.Image = Image.FromStream(ms);
                }
                else
                {
                    itemImage.Image = null;
                }
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {
                open.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    itemImage.Image = Image.FromFile(open.FileName);
                }
            }
        }
    }
}
