using GearPoint_POS_SYSTEM.SubForms;
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
    public partial class Customers : UserControl
    {
        public Customers()
        {
            InitializeComponent();
            LoadItemsFromDatabase();

        }
        private void LoadItemsFromDatabase()
        {
            dgvCustomerData.Controls.Clear();
            dgvCustomerData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataTable dt = DatabaseHelper.GetDataTable("SELECT * FROM customers");
            dgvCustomerData.DataSource = dt;
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            customerManagement customerManagement = new customerManagement();

            // When itemManagement closes, reload the data
            customerManagement.FormClosed += (s, args) =>
            {
                LoadItemsFromDatabase(); // 🔁 refresh your data/cards
            };

            customerManagement.ShowDialog();
        }

        private void dgvCustomerData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
