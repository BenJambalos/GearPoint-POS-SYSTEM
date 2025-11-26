using GearPoint_POS_SYSTEM.SubForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GearPoint_POS_SYSTEM.UserControls
{
    public partial class Cash : UserControl
    {
        public Cash()
        {
            InitializeComponent();
            LoadItemsFromDatabase();
        }

        private void LoadItemsFromDatabase()
        {
            dgvCash.Controls.Clear();
            dgvCash.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataTable dt = DatabaseHelper.GetDataTable("SELECT * FROM orders");
            dgvCash.DataSource = dt;
        }
        private void btnOpenDrawer_Click(object sender, EventArgs e)
        {
            cashManagement cashManagement = new cashManagement();

            // When itemManagement closes, reload the data
            cashManagement.FormClosed += (s, args) =>
            {
                LoadItemsFromDatabase(); // 🔁 refresh your data/cards
            };

            cashManagement.ShowDialog();
        }
    }
}
