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
    public partial class Reservation : Form
    {
        private DataAccess Da { get; set; }
        public Reservation()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            this.ReservationGridView();
            this.AutoCustomerIdGenerate();
        }

        private void ReservationGridView(string sql = "select * from reservationTable;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvReservation.AutoGenerateColumns = false;
            this.dgvReservation.DataSource = ds.Tables[0];
        }

       


        private void btnSave_Click(object sender, EventArgs e)
        {


            try
            {
                if (!this.IsValidToSaveData() ||!this.IsValidInput())
                {
                    MessageBox.Show("Operation is not valid. Please fill up all the information properly");
                    return;
                }

                var query = "select * from reservationTable where customerId = '" + this.txtCustomerId.Text + "';";
                var ds = this.Da.ExecuteQuery(query);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    
                    var sql = @"update reservationTable
                                set customerName = '" + this.txtCustomerName.Text + @"',
                               
                                
                                customerContactNumber = '" + this.txtCustomerContactNumber.Text + @"',
                                tableId =' " + this.cmbTableId.Text + @"',
                               
                                reservationDate = '" + dtpResevationTime.Text + @"',
                                bookingState = '" + this.cmbBookingState.Text + @"'
                                
                                where customerId = '" + this.txtCustomerId.Text + "';";

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
                   
                    var sql = @"insert into reservationTable values('" + this.txtCustomerId.Text + "','" + this.txtCustomerName.Text + "','" + this.txtCustomerContactNumber.Text + "','" + this.cmbTableId.Text + "','" + this.dtpResevationTime.Text + "','" + this.cmbBookingState.Text + "');";
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

                this.ReservationGridView();
                this.RefreshContent();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }

        }

        private bool IsValidToSaveData() //validation
        {
            if (String.IsNullOrEmpty(this.txtCustomerId.Text) || String.IsNullOrEmpty(this.txtCustomerName.Text) || String.IsNullOrEmpty(this.txtCustomerContactNumber.Text) ||
                String.IsNullOrEmpty(this.cmbTableId.Text) || String.IsNullOrWhiteSpace(this.cmbBookingState.Text) || String.IsNullOrWhiteSpace(this.dtpResevationTime.Text))
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

            if (int.TryParse(this.txtCustomerContactNumber.Text, out int n))
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
                var id = this.dgvReservation.CurrentRow.Cells[0].Value.ToString();
                var name = this.dgvReservation.CurrentRow.Cells[1].Value.ToString();

                var sql = "delete from reservationTable where customerId = '" + id + "';";
                int count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                {
                    MessageBox.Show(name + " has been deleted successfully");
                }

                else
                {
                    MessageBox.Show("Data deletion failed");
                }



                this.ReservationGridView();
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
            this.txtCustomerId.Clear();
            this.txtCustomerName.Clear();
           
            this.txtCustomerContactNumber.Clear();
            this.cmbTableId.Text = "";
            this.cmbBookingState.Text = "";

            this.dtpResevationTime.Text = "";
            this.txtSearchByTableNumber.Clear();
            this.AutoCustomerIdGenerate();

        }

        private void AutoCustomerIdGenerate()
        {
            var sql = "select customerId from reservationTable order by customerId desc;";
            DataSet ds = this.Da.ExecuteQuery(sql);
            string previousId = ds.Tables[0].Rows[0]["customerId"].ToString();
            string[] temp = previousId.Split('-');
            int number = Convert.ToInt32(temp[1]);
            string newcustomerId = "c-" + (++number).ToString("d2");
            this.txtCustomerId.Text = newcustomerId;


        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.ReservationGridView();
        }

        private void Reservation_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Manager r = new Manager();
            r.Visible = true;
            this.Visible = false;
        }

        private void dgvReservation_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.txtCustomerId.Text = this.dgvReservation.CurrentRow.Cells["customerId"].Value.ToString();
                this.txtCustomerName.Text = this.dgvReservation.CurrentRow.Cells["customerName"].Value.ToString();
             
                this.txtCustomerContactNumber.Text = this.dgvReservation.CurrentRow.Cells["customerContactNumber"].Value.ToString();
                this.cmbTableId.Text = dgvReservation.CurrentRow.Cells["tableId"].Value.ToString();
                this.cmbBookingState.Text = this.dgvReservation.CurrentRow.Cells["bookingState"].Value.ToString();
                this.dtpResevationTime.Text = this.dgvReservation.CurrentRow.Cells["reservationDate"].Value.ToString();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void txtSearchByTableNumber_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var sql = "select * from reservationTable where tableId like '" + this.txtSearchByTableNumber.Text + "%';";
                this.ReservationGridView(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

       

        private void btnNextToChooseFood_Click(object sender, EventArgs e)
        {
            try
            {
                string customerId = dgvReservation.CurrentRow.Cells["customerId"].Value.ToString();
                string tableId = dgvReservation.CurrentRow.Cells["tableId"].Value.ToString();
                SelectFood sf = new SelectFood(customerId, tableId);
                sf.Visible = true;
                this.Visible = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
