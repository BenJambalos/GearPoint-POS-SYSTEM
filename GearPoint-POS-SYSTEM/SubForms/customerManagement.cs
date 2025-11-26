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
using System.Xml.Linq;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace GearPoint_POS_SYSTEM.SubForms
{
    public partial class customerManagement : Form
    {
        public customerManagement()
        {
            InitializeComponent();
            loadData();
        }
        private void loadData()
        {
            string query = "SELECT * FROM customers";
            DataTable dt = DatabaseHelper.GetDataTable(query);
            dataGridView.DataSource = dt;

        }
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string selectedStatus = cmbboxStatus.GetItemText(cmbboxStatus.SelectedItem);
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                txtCustomerID.Text = row.Cells["CustomerID"].Value.ToString();
                txtCustomerName.Text = row.Cells["CustomerName"].Value.ToString();
                txtCustomerPhone.Text = row.Cells["CustomerPhone"].Value.ToString();
                txtCustomerEmail.Text = row.Cells["CustomerEmail"].Value.ToString();
                txtTotalPurchase.Text = row.Cells["CusTotalPurchase"].Value.ToString();
                selectedStatus = row.Cells["CustomerStatus"].Value.ToString();
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedStatus = cmbboxStatus.GetItemText(cmbboxStatus.SelectedItem);
                string query = "INSERT INTO customers (CustomerName, CustomerPhone, CustomerEmail, CusTotalPurchase, CustomerStatus) " +
                    "VALUES (@CustomerName, @CustomerPhone, @CustomerEmail, @CusTotalPurchase, @CustomerStatus)";
                var parameters = new Dictionary<string, object>
                {
                    { "@CustomerName", txtCustomerName.Text },
                    { "@CustomerPhone", txtCustomerPhone.Text },
                    { "@CustomerEmail", txtCustomerEmail.Text },
                    { "@CusTotalPurchase", decimal.Parse(txtTotalPurchase.Text) },
                    { "@CustomerStatus", selectedStatus }
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
                string query = @"UPDATE customers 
                         SET CustomerName = @CustomerName, 
                             CustomerPhone = @CustomerPhone, 
                             CustomerEmail = @CustomerEmail, 
                             CusTotalPurchase = @CusTotalPurchase, 
                             CustomerStatus = @CustomerStatus 
                         WHERE CustomerID = @CustomerID";

                var parameters = new Dictionary<string, object>
                {
                    { "@CustomerName", txtCustomerName.Text },
                    { "@CustomerPhone", txtCustomerPhone.Text },
                    { "@CustomerEmail", txtCustomerEmail.Text },
                    { "@CusTotalPurchase", decimal.Parse(txtTotalPurchase.Text) },
                    { "@CustomerStatus", cmbboxStatus.Text },
                    { "@CustomerID", int.Parse(txtCustomerID.Text) } // assumes you have a textbox for ID
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
                string query = "DELETE FROM customers WHERE CustomerID = @CustomerID";

                var parameters = new Dictionary<string, object>
                {
                    { "@CustomerID", int.Parse(txtCustomerID.Text) } // assumes textbox for ID
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
            txtCustomerID.Clear();
            txtCustomerName.Clear();
            txtCustomerPhone.Clear();
            txtCustomerEmail.Clear();
            txtTotalPurchase.Clear();
            cmbboxStatus.SelectedIndex = -1;
        }

        private void customerManagement_Load(object sender, EventArgs e)
        {

        }
    }
}
