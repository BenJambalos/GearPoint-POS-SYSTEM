using GearPoint_POS_SYSTEM.UserControls;
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
    public partial class addCustomer : Form
    {
        public addCustomer()
        {
            InitializeComponent();
            LoadItemsFromDatabase();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {

        }
        private void LoadItemsFromDatabase()
        {
            dataGridView.Controls.Clear();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataTable dt = DatabaseHelper.GetDataTable("SELECT CustomerName, CustomerPhone, CustomerEmail FROM customers");
            dataGridView.DataSource = dt;
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
