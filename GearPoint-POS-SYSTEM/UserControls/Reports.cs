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
    public partial class Reports : UserControl
    {
        public Reports()
        {
            InitializeComponent();
            LoadItemsFromDatabase();
        }

        private void LoadItemsFromDatabase()
        {
            dgvReportData.Controls.Clear();
            dgvReportData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataTable dt = DatabaseHelper.GetDataTable("SELECT * FROM orders");
            dgvReportData.DataSource = dt;
        }

        private void btnEditReports_Click(object sender, EventArgs e)
        {
            reportManagement reportManagement = new reportManagement();

            // When itemManagement closes, reload the data
            reportManagement.FormClosed += (s, args) =>
            {
                LoadItemsFromDatabase(); // 🔁 refresh your data/cards
            };

            reportManagement.ShowDialog();
        }
        private void gdvReportData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
