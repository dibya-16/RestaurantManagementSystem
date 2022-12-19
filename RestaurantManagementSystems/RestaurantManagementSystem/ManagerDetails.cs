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

namespace RestaurantManagementSystem
{
   
    public partial class ManagerDetails : Form
    { 
         private DataAccess Da { get; set; }
        
    
        public ManagerDetails()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            this.ManagerGridView();
            this.AutoManagerIdGenerate();
        }

        private void ManagerGridView(string sql = "select * from ManagerDetail;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvManagerDetails.AutoGenerateColumns = false;
            this.dgvManagerDetails.DataSource = ds.Tables[0];
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.ManagerGridView();

        }

        private void txtSearchByID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from ManagerDetail where ManagerId = '" + this.txtSearchByID.Text + "';";
                this.ManagerGridView(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSaveData() || !this.IsValidInput())
                {
                    MessageBox.Show("Operation is not valid. Please fill up all the information properly");
                    return;

                



                }
                
                

                var query = "select * from ManagerDetail where ManagerId = '" + this.txtManagerId.Text + "';";
                var ds = this.Da.ExecuteQuery(query);

                if (ds.Tables[0].Rows.Count == 1)
                {
                   
                    var sql = @"update ManagerDetail
                                set ManagerName = '" + this.txtManagerName.Text + @"',
                                ManagerAddress = '" + this.txtManagerAddress.Text + @"', 
                                ManagerNID =' " + this.txtManagerNID.Text + @"',
                                ContactNumber = '" + this.txtContactNumber.Text + @"',
                                JoiningDate = '" + dtpJoiningDate.Text + @"',
                                Salary = '" + this.txtSalary.Text + @"'
                                where ManagerId = '" + this.txtManagerId.Text + "';";

                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                    {
                        MessageBox.Show("Data updated successfully");
                    }

                    else
                    {
                        MessageBox.Show("Data upgradation failed");
                    }
                        
                }
                else
                {
                   
                    var sql = @"insert into ManagerDetail values('" + this.txtManagerId.Text + "','" + this.txtManagerName.Text + "','" + this.txtManagerAddress.Text + "','" + this.txtManagerNID.Text + "','" + this.txtContactNumber.Text + "','" + this.dtpJoiningDate.Text + "','" + this.txtSalary.Text + "');";
                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                    {
                        MessageBox.Show("Data insertion successfull");
                    }
                    else
                    {
                        MessageBox.Show("Data insertion failed");
                    }

                }

                this.ManagerGridView();
                this.RefreshContent();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }


        }

        private bool IsValidToSaveData() //validation
        {
            if (String.IsNullOrEmpty(this.txtManagerId.Text) || String.IsNullOrEmpty(this.txtManagerName.Text) ||
                String.IsNullOrEmpty(this.txtManagerAddress.Text) || String.IsNullOrEmpty(this.txtManagerNID.Text) ||
                String.IsNullOrEmpty(this.txtContactNumber.Text) || String.IsNullOrEmpty(this.txtSalary.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
               
        }

        private bool IsValidInput()
        {

            if((int.TryParse(this.txtContactNumber.Text, out int n)) && (double.TryParse(this.txtSalary.Text, out double m)))
            {

                return true;

            }
            else
            {
                return false;
            }


        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                var id = this.dgvManagerDetails.CurrentRow.Cells[0].Value.ToString();
                var name = this.dgvManagerDetails.CurrentRow.Cells[1].Value.ToString();

                var sql = "delete from ManagerDetail where ManagerId = '" + id + "';";
                int count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                {
                    MessageBox.Show(name + " has been deleted successfully");
                }

                else
                {
                    MessageBox.Show("Data deletion failed");
                }

                
               
                this.ManagerGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            this.RefreshContent();

        }
        

        

        private void RefreshContent()
        {
            this.txtManagerId.Clear();
            this.txtManagerName.Clear();
            this.txtManagerAddress.Clear();
            this.txtManagerNID.Clear();
            this.txtContactNumber.Clear();
            this.dtpJoiningDate.Text = "";

            this.txtSalary.Clear();
            this.txtSearchByID.Clear();
            this.AutoManagerIdGenerate();

        }

        

        private void dgvManagerDetails_DoubleClick(object sender, EventArgs e)
        {

            this.txtManagerId.Text = this.dgvManagerDetails.CurrentRow.Cells["ManagerId"].Value.ToString();
            this.txtManagerName.Text = this.dgvManagerDetails.CurrentRow.Cells["ManagerName"].Value.ToString();
            this.txtManagerAddress.Text = this.dgvManagerDetails.CurrentRow.Cells["ManagerAddress"].Value.ToString();
            this.txtManagerNID.Text = this.dgvManagerDetails.CurrentRow.Cells["ManagerNID"].Value.ToString();
            this.txtContactNumber.Text = this.dgvManagerDetails.CurrentRow.Cells["ContactNumber"].Value.ToString();
            this.dtpJoiningDate.Text = this.dgvManagerDetails.CurrentRow.Cells["JoiningDate"].Value.ToString();
            this.txtSalary.Text = this.dgvManagerDetails.CurrentRow.Cells["Salary"].Value.ToString();

        }

        private void AutoManagerIdGenerate()
        {
            var sql = "select ManagerId from ManagerDetail order by ManagerId desc;";
            DataSet ds = this.Da.ExecuteQuery(sql);
            string previousId = ds.Tables[0].Rows[0]["ManagerId"].ToString();
            string[] temp = previousId.Split('-');
            int number = Convert.ToInt32(temp[1]);
            string newManagerId = "m-" + (++number).ToString("d2");
            this.txtManagerId.Text = newManagerId;


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Owner ow = new Owner();
            ow.Visible = true;
            this.Visible = false;
        }


        private void ManagerDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
