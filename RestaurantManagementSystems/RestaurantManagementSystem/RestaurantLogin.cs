using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MetroFramework.Forms;

namespace RestaurantManagementSystem
{
    public partial class RestaurantLogin : Form //MetroForm
    {
        private DataAccess Da { get; set; }
        public RestaurantLogin()
        {
            InitializeComponent();
            this.Da = new DataAccess();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            try
            {
                string sql = "select * from LoginRestaurant where  Id ='" + this.txtUserId.Text.ToLower() + "' and Password = " + this.txtPassword.Text + "; ";

                DataSet ds = this.Da.ExecuteQuery(sql);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    this.ClearContent();
                    //this.Hide();
                    MessageBox.Show("Login Valid");
                    string name = ds.Tables[0].Rows[0][1].ToString();

                    if (ds.Tables[0].Rows[0][3].ToString() == "Owner")
                    {
                        Owner ow = new Owner();
                        ow.Visible = true;
                        this.Visible = false;
                    }
                    else if (ds.Tables[0].Rows[0][3].ToString() == "Manager")
                    {
                        Manager m = new Manager();
                        m.Visible = true;
                        this.Visible = false;
                    }

                }
                else
                {
                    MessageBox.Show("Login Invalid");
                    this.ClearContent();
                }
                //sqlCon.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error:" + exc.Message);
            }




        }

        private void btnCLear_Click(object sender, EventArgs e)
        {
            this.ClearContent();
        }
        private void ClearContent()
        {
            this.txtUserId.Clear();
            this.txtPassword.Clear();
        }

        private void RestaurantLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

       
    }
}
