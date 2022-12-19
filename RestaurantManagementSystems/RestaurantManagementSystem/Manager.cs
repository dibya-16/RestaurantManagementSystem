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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void Manager_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

       

       

        private void btnFoodDetails_Click(object sender, EventArgs e)
        {
            try
            {

                FoodMenu fm = new FoodMenu();
                fm.Visible = true;
                this.Visible = false;
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message);
            }
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            Reservation r = new Reservation();
            r.Visible = true;
            this.Visible = false;

        }

        private void btnBillHistory_Click(object sender, EventArgs e)
        {
            try
            {
                BillHistory bl = new BillHistory();
                bl.Visible = true;
                this.Visible = false;
            }

            catch (Exception exc)
            {

                MessageBox.Show(exc.Message);
            }

        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            Expenses ex = new Expenses();
            ex.Visible = true;
            this.Visible = false;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            RestaurantLogin rl = new RestaurantLogin();
            rl.Visible = true;
            this.Visible = false;
        }
    }
}
