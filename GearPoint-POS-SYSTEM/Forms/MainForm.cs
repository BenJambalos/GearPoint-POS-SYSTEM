using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GearPoint_POS_SYSTEM.UserControls;

namespace GearPoint_POS_SYSTEM
{
    public partial class MainForm : Form
    {
        UserControl home = new Home();
        public MainForm()
        {
            InitializeComponent();
            
            loadUserControl(home);
        }


        private void loadUserControl(UserControl userControl)
        {
            UserControlPanel.Controls.Clear();
            userControl.Dock = DockStyle.Fill;  // Add this line!
            UserControlPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void UserControlPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "GEARPOINT POS";
            loadUserControl(home);
        }   

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Customer Management";
            Customers customers = new Customers(); 
            loadUserControl(customers);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Reports & Analytics";
            Reports reports = new Reports();
            loadUserControl(reports);
        }

        private void btnCashManagement_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Cash Management";
            Cash cash = new Cash();
            loadUserControl(cash);
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Inventory Management";
            Inventory inventory = new Inventory();
            loadUserControl(inventory);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "System Settings";
            Settings settings = new Settings();
            loadUserControl(settings);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Dashboard";
            Dashboard dashboard = new Dashboard();
            loadUserControl(dashboard);
        }
    }
}
