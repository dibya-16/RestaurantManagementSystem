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
    public partial class BillHistory : Form
    {
        private DataAccess Da { get; set; }
        public BillHistory()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.BillHistoryGridView();
            this.AutoBillIdGenerate();



        }


        public BillHistory(string customerIdTOBillHistory, string items, string tableIdTOBillHistory, string totalBill) : this()
        {
            //this.txtBillId.Text = billId;
            this.txtCustomerId.Text = customerIdTOBillHistory;
            this.txtItems.Text = items;
            this.txtTableNumber.Text = tableIdTOBillHistory;
            this.txtTotalBill.Text = totalBill;


        }

        private void BillHistoryGridView(string sql = "select * from billHistoryAll;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvBillHistory.AutoGenerateColumns = false;
            this.dgvBillHistory.DataSource = ds.Tables[0];
        }



        private void AutoBillIdGenerate()
        {
            var sql = "select billId from billHistoryAll order by billId desc;";
            DataSet ds = this.Da.ExecuteQuery(sql);
            string previousId = ds.Tables[0].Rows[0]["billId"].ToString();
            string[] temp = previousId.Split('-');
            int number = Convert.ToInt32(temp[1]);
            string newBillId = "b-" + (++number).ToString("d2");
            this.txtBillId.Text = newBillId;


        }


      





        private void billHistory_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBillHistoryDetails_Click(object sender, EventArgs e)
        {
            this.BillHistoryGridView();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double totalPay = Convert.ToDouble(this.txtTotalPay.Text);
            double totalBill = Convert.ToDouble(this.txtTotalBill.Text);


            if (totalPay > totalBill) {
                double returned = totalPay - totalBill;
                string returnMoney = Convert.ToString(returned);

                this.txtReturned.Text = returnMoney;

            }
            else
            {
                this.txtReturned.Text = "0";
            }

        }

        private void btnBackToManager_Click(object sender, EventArgs e)
        {
            Manager m = new Manager();
            m.Visible = true;
            this.Visible = false;
        }

        private void btnBackToFoodItems_Click(object sender, EventArgs e)
        {
            SelectFood sf = new SelectFood();
            sf.Visible = true;
            this.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (!this.IsValidToSaveData()||!this.IsValidInput())
                {
                    MessageBox.Show("Operation is not valid. Please fill up all the information properly");
                    return;
                }

                var query = "select * from billHistoryAll where billId = '" + this.txtBillId.Text + "';";
                var ds = this.Da.ExecuteQuery(query);

                if (ds.Tables[0].Rows.Count == 1)
                {
                   
                    var sql = @"update billHistoryAll
                                set customerId = '" + this.txtCustomerId.Text + @"',
                                items = '" + this.txtItems.Text + @"', 
                                tableNumber =' " + this.txtTableNumber.Text + @"',
                                totalBill = '" + this.txtTotalBill.Text + @"',
                                totalPay = '" + this.txtTotalPay.Text + @"',
                                returned = '" + this.txtReturned.Text + @"',
                                date = '" + this.dtpBillPayTime.Text + @"'
                                where billId = '" + this.txtBillId.Text + "';";

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
                    var sql = @"insert into billHistoryAll values('" + this.txtBillId.Text + "','" + this.txtItems.Text + "','" + this.txtTableNumber.Text + "','" + this.txtTotalBill.Text + "','" + this.txtTotalPay.Text + "','" + this.txtReturned.Text + "','" + this.dtpBillPayTime.Text + "','" + this.txtCustomerId.Text + "');";
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

                this.BillHistoryGridView();
                this.RefreshContent();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }

        private bool IsValidToSaveData() //validation
        {
            if (String.IsNullOrEmpty(this.txtBillId.Text) || String.IsNullOrEmpty(this.txtItems.Text) ||
                String.IsNullOrEmpty(this.txtTableNumber.Text) || String.IsNullOrEmpty(this.txtTotalBill.Text) ||
                String.IsNullOrEmpty(this.txtTotalPay.Text) || String.IsNullOrWhiteSpace(this.txtReturned.Text) || String.IsNullOrWhiteSpace(this.dtpBillPayTime.Text) || String.IsNullOrWhiteSpace(this.txtCustomerId.Text))
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

            if (double.TryParse(this.txtTotalBill.Text, out double m) && double.TryParse(this.txtTotalPay.Text, out double n) && double.TryParse(this.txtReturned.Text, out double o))
            {

                return true;

            }
            else
            {
                return false;
            }


        }




        private void RefreshContent()
        {
            this.txtBillId.Clear();
            this.txtCustomerId.Clear();
            this.txtItems.Clear();
            this.txtTableNumber.Clear();
            this.txtTotalBill.Clear();
            this.txtTotalPay.Clear();

            this.txtReturned.Clear();
            this.dtpBillPayTime.Text = "";
            this.txtSearchByCustomerId.Clear();
            this.AutoBillIdGenerate();

        }




        private void dgvBillHistory_DoubleClick(object sender, EventArgs e)
        {
            this.txtBillId.Text = this.dgvBillHistory.CurrentRow.Cells["billId"].Value.ToString();
            this.txtCustomerId.Text = this.dgvBillHistory.CurrentRow.Cells["customerId"].Value.ToString();
            this.txtItems.Text = this.dgvBillHistory.CurrentRow.Cells["items"].Value.ToString();
            this.txtTableNumber.Text = this.dgvBillHistory.CurrentRow.Cells["tableNumber"].Value.ToString();
            this.txtTotalBill.Text = this.dgvBillHistory.CurrentRow.Cells["totalBill"].Value.ToString();
            this.txtTotalPay.Text = this.dgvBillHistory.CurrentRow.Cells["totalPay"].Value.ToString();
            this.txtReturned.Text = this.dgvBillHistory.CurrentRow.Cells["returned"].Value.ToString();
            this.dtpBillPayTime.Text = this.dgvBillHistory.CurrentRow.Cells["date"].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.RefreshContent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                var id = this.dgvBillHistory.CurrentRow.Cells[0].Value.ToString();
                

                var sql = "delete from billHistoryAll where billId = '" + id + "';";
                int count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                {
                    MessageBox.Show(id + " has been deleted successfully");
                }

                else
                {
                    MessageBox.Show("Data deletion failed");
                }



                this.BillHistoryGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void txtSearchByCustomerId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var sql = "select * from billHistoryAll where customerId like '" + this.txtSearchByCustomerId.Text + "%';";
                this.BillHistoryGridView(sql);
             
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
