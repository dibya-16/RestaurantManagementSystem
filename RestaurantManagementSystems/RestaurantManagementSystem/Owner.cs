using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    public partial class Owner : Form
    {
       

        public Owner()
        {
            InitializeComponent();
        }

        

        private void btnManagerDetails_Click(object sender, EventArgs e)
        {
            ManagerDetails md = new ManagerDetails();
            md.Visible = true;
            this.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            RestaurantLogin rl = new RestaurantLogin();
            rl.Show();
            this.Hide();
           
        }


        private void btnStaffDetails_Click(object sender, EventArgs e)
        {
            try
            {
                StaffDetails sd = new StaffDetails();
                sd.Show();
                this.Hide();
            }
            catch(Exception exc)
            {
                MessageBox.Show("Error:" + exc);

            }
        }

        private void Owner_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            Expenses ex = new Expenses();
            ex.Visible = true;
            this.Visible = false;
        }
    }
}
