using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GearPoint_POS_SYSTEM.SubForms
{
    public partial class reportManagement : Form
    {
        public reportManagement()
        {
            InitializeComponent();
            loadData();
        }
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                txtOrderID.Text = row.Cells["CustomerID"].Value.ToString();
                txtOrderTime.Text = row.Cells["CustomerName"].Value.ToString();
                txtOrderItem.Text = row.Cells["CustomerPhone"].Value.ToString();
                txtOrderAmount.Text = row.Cells["CustomerEmail"].Value.ToString();
                txtOrderedPayment.Text = row.Cells["CusTotalPurchase"].Value.ToString();
            }
        }
        private void loadData()
        {
            string query = "SELECT * FROM orders";
            DataTable dt = DatabaseHelper.GetDataTable(query);
            dataGridView.DataSource = dt;

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO orders (OrderTime, OrderedItems, OrderedAmount, OrderedPayment) " +
                    "VALUES (@OrderTime, @OrderedItems, @OrderedAmount, @OrderedPayment)";
                var parameters = new Dictionary<string, object>
                {
                    { "@OrderTime", txtOrderTime.Text },
                    { "@OrderedItems", txtOrderItem.Text },
                    { "@OrderedAmount", decimal.Parse(txtOrderAmount.Text) },
                    { "@OrderedPayment", txtOrderPayment.Text},
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
                string query = @"UPDATE orders 
                         SET OrderTime = @OrderTime, 
                             OrderedItems = @OrderedItems, 
                             OrderedAmount = @OrderedAmount, 
                             OrderedPayment = @OrderedPayment,  
                         WHERE OrderID = @OrderID";

                var parameters = new Dictionary<string, object>
                {
                    { "@OrderTime", txtOrderTime.Text },
                    { "@OrderedItems", txtOrderItem.Text },
                    { "@OrderedAmount", decimal.Parse(txtOrderAmount.Text) },
                    { "@OrderedPayment",  txtOrderedPayment.Text},
                    { "@OrderID", int.Parse(txtOrderID.Text) } // assumes you have a textbox for ID
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
                string query = "DELETE FROM orders WHERE OrderID = @OrderID";

                var parameters = new Dictionary<string, object>
                {
                    { "@OrderID", int.Parse(txtOrderID.Text) } // assumes textbox for ID
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
        //has a proble with the foreign key fix it later
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOrderID.Clear();
            txtOrderTime.Clear();
            txtOrderItem.Clear();
            txtOrderAmount.Clear();
            txtOrderPayment.Clear();
            txtOrderID.Focus();
        }

    }
}
