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
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
            LoadItemsFromDatabase();
        }

        private void LoadItemsFromDatabase()
        {
            dataGridView.Controls.Clear();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataTable dt = DatabaseHelper.GetDataTable("SELECT * FROM itemcards");
            dataGridView.DataSource = dt;
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            inventoryManagement inventory = new inventoryManagement();

            // When itemManagement closes, reload the data
            inventory.FormClosed += (s, args) =>
            {
                LoadItemsFromDatabase(); // 🔁 refresh your data/cards
            };

            inventory.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }
    }
}
