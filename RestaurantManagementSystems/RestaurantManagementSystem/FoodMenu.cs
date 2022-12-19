using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RestaurantManagementSystem
{
    public partial class FoodMenu : Form
    {
        private DataAccess Da { get; set; }
        public FoodMenu()
        {
            
            InitializeComponent();
            this.Da = new DataAccess();
            this.FoodMenuGridView();
        }

        private void FoodMenuGridView(string sql = "select * from foodDetailsAll ;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvFoodMenu.AutoGenerateColumns = false;
            this.dgvFoodMenu.DataSource = ds.Tables[0];
        }

        private void btnFoodDetails_Click(object sender, EventArgs e)
        {
            this.FoodMenuGridView();
        }

      

       
        private void FoodMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Manager r = new Manager();
            r.Visible = true;
            this.Visible = false;
        }

      

        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from foodDetailsAll where category = '" + this.txtSearch.Text + "'or foodItem='" + this.txtSearch.Text + "';";
                this.FoodMenuGridView(sql);
                this.ClearContent();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void ClearContent()
        {
            this.txtSearch.Clear();
           
        }
    }
}
