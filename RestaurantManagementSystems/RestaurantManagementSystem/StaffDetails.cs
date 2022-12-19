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
    public partial class StaffDetails : Form
    {
        private DataAccess Da { get; set; }
        public StaffDetails()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.StaffGridView();
           this.AutoStaffIdGenerate();
        }

        private void StaffGridView(string sql = "select * from StaffDetail;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvStaffDetails.AutoGenerateColumns = false;
            this.dgvStaffDetails.DataSource = ds.Tables[0];
        }

        private void txtSearchById_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from StaffDetail where StaffId = '" + this.txtSearchByTableNumber.Text + "';";
                this.StaffGridView(sql);
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

                var query = "select * from StaffDetail where StaffId = '" + this.txtStaffId.Text + "';";
                var ds = this.Da.ExecuteQuery(query);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    //update
                    var sql = @"update StaffDetail
                                set StaffName = '" + this.txtStaffName.Text + @"',
                                StaffAddress = '" + this.txtStaffAddress.Text + @"', 
                                StaffNID =' " + this.txtStaffNID.Text + @"',
                                ContactNumber = '" + this.txtContactNumber.Text + @"',
                                JoiningDate = '" + dtpJoiningDate.Text + @"',
                                StaffPosition = '" + txtStaffPosition.Text + @"',
                                Salary = '" + this.txtSalary.Text + @"'
                                where StaffId = '" + this.txtStaffId.Text + "';";

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
                    //insert
                    var sql = @"insert into StaffDetail values('" + this.txtStaffId.Text + "','" + this.txtStaffName.Text + "','" + this.txtStaffAddress.Text + "','" + this.txtStaffNID.Text + "','" + this.txtContactNumber.Text + "','" + this.dtpJoiningDate.Text + "','" + this.txtStaffPosition.Text + "','" + this.txtSalary.Text + "');";
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

                this.StaffGridView();
                this.RefreshContent();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }

        private bool IsValidToSaveData() //validation
        {
            if (String.IsNullOrEmpty(this.txtStaffId.Text) || String.IsNullOrEmpty(this.txtStaffName.Text) ||
                String.IsNullOrEmpty(this.txtStaffAddress.Text) || String.IsNullOrEmpty(this.txtStaffNID.Text) ||
                String.IsNullOrEmpty(this.txtContactNumber.Text) || String.IsNullOrEmpty(this.txtStaffPosition.Text) || String.IsNullOrWhiteSpace(this.txtSalary.Text))
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

            if (int.TryParse(this.txtContactNumber.Text, out int n) && double.TryParse(this.txtSalary.Text, out double m))
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
                var id = this.dgvStaffDetails.CurrentRow.Cells[0].Value.ToString();
                var name = this.dgvStaffDetails.CurrentRow.Cells[1].Value.ToString();

                var sql = "delete from StaffDetail where STaffId = '" + id + "';";
                int count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                {
                    MessageBox.Show(name + " has been deleted successfully");
                }

                else
                {
                    MessageBox.Show("Data deletion failed");
                }



                this.StaffGridView();
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.StaffGridView();
        }


        private void RefreshContent()
        {
            this.txtStaffId.Clear();
            this.txtStaffName.Clear();
            this.txtStaffAddress.Clear();
            this.txtStaffNID.Clear();
            this.txtContactNumber.Clear();
            this.dtpJoiningDate.Text = "";
            this.txtStaffPosition.Clear();
            this.txtSalary.Clear();
            this.txtSearchByTableNumber.Clear();
            this.AutoStaffIdGenerate();

        }

        private void dgvStaffDetails_DoubleClick(object sender, EventArgs e)
        {
            this.txtStaffId.Text = this.dgvStaffDetails.CurrentRow.Cells["StaffId"].Value.ToString();
            this.txtStaffName.Text = this.dgvStaffDetails.CurrentRow.Cells["StaffName"].Value.ToString();
            this.txtStaffAddress.Text = this.dgvStaffDetails.CurrentRow.Cells["StaffAddress"].Value.ToString();
            this.txtStaffNID.Text = this.dgvStaffDetails.CurrentRow.Cells["StaffNID"].Value.ToString();
            this.txtContactNumber.Text = this.dgvStaffDetails.CurrentRow.Cells["ContactNumber"].Value.ToString();
            this.dtpJoiningDate.Text = this.dgvStaffDetails.CurrentRow.Cells["JoiningDate"].Value.ToString();
            this.txtStaffPosition.Text = this.dgvStaffDetails.CurrentRow.Cells["STaffPosition"].Value.ToString();
            this.txtSalary.Text = this.dgvStaffDetails.CurrentRow.Cells["Salary"].Value.ToString();
        }

        private void AutoStaffIdGenerate()
        {
            var sql = "select StaffId from StaffDetail order by StaffId desc;";
            DataSet ds = this.Da.ExecuteQuery(sql);
            string previousId = ds.Tables[0].Rows[0]["StaffId"].ToString();
            string[] temp = previousId.Split('-');
            int number = Convert.ToInt32(temp[1]);
            string newStaffId = "s-" + (++number).ToString("d2");
            this.txtStaffId.Text = newStaffId;


        }

       

       

        private void btnBack_Click_1(object sender, EventArgs e)
        {


            Owner ow = new Owner();
            ow.Visible = true;
            this.Visible = false;

        }

        private void StaffDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
