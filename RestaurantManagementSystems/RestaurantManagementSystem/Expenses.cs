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
    public partial class Expenses : Form
    {
        private DataAccess Da { get; set; }
        public Expenses()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.ExpensesGridView();
        }

        private void ExpensesGridView(string sql = "select * from expenses;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvExpenses.AutoGenerateColumns = false;
            this.dgvExpenses.DataSource = ds.Tables[0];
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


                
                var sql = @"insert into expenses values('" + this.txtMaintananceCost.Text + "','" + this.txtRestaurantRent.Text + "','" + this.txtEmployeeSalary.Text + "','" + this.txtFoodCost.Text + "','" + this.txtOthersBill.Text + "','" + this.cmbMonth.Text + "','" + this.txtYear.Text + "','" + this.txtTotalMonthlyCost.Text + "');";
                int count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                {
                    MessageBox.Show("Data insertion successfull");
                }
                else
                {
                    MessageBox.Show("Data insertion failed");
                }

                this.ExpensesGridView();
                this.RefreshContent();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

           

        }

        private bool IsValidToSaveData() //validation
        {
            if (String.IsNullOrEmpty(this.txtMaintananceCost.Text) || String.IsNullOrEmpty(this.txtRestaurantRent.Text) ||
                String.IsNullOrEmpty(this.txtEmployeeSalary.Text) || String.IsNullOrEmpty(this.txtFoodCost.Text) ||
                String.IsNullOrEmpty(this.txtOthersBill.Text) || String.IsNullOrWhiteSpace(this.cmbMonth.Text) || String.IsNullOrWhiteSpace(this.txtYear.Text) || String.IsNullOrWhiteSpace(this.txtTotalMonthlyCost.Text))
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

            if (double.TryParse(this.txtMaintananceCost.Text, out double m) && double.TryParse(this.txtRestaurantRent.Text, out double n) &&
                double.TryParse(this.txtEmployeeSalary.Text, out double o) && double.TryParse(this.txtFoodCost.Text, out double p)
                                && double.TryParse(this.txtOthersBill.Text, out double q) && int.TryParse(this.txtYear.Text, out int r) && double.TryParse(this.txtTotalMonthlyCost.Text, out double k))
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
                
                var month = this.dgvExpenses.CurrentRow.Cells[5].Value.ToString();

                var sql = "delete from expenses where month = '" + month+ "';";
                int count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                {
                    MessageBox.Show(month + " has been deleted successfully");
                }

                else
                {
                    MessageBox.Show("Data deletion failed");
                }



                this.ExpensesGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }


        private void RefreshContent()
        {
            this.txtMaintananceCost.Clear();
            this.txtRestaurantRent.Clear();
            this.txtEmployeeSalary.Clear();
            this.txtFoodCost.Clear();
            this.txtOthersBill.Clear();
            this.cmbMonth.Text = "";

            this.txtYear.Clear();
            this.txtTotalMonthlyCost.Clear();
            

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.RefreshContent();
        }

        private void btnExpensesDetails_Click(object sender, EventArgs e)
        {
            this.ExpensesGridView();
        }

        private void btnCalculateTotalCost_Click(object sender, EventArgs e)
        {
            double maintananceCost = Convert.ToDouble(this.txtMaintananceCost.Text);
            double restaurantRent = Convert.ToDouble(this.txtRestaurantRent.Text);
            double employeeSalary= Convert.ToDouble(this.txtEmployeeSalary.Text);
            double foodCost= Convert.ToDouble(this.txtFoodCost.Text);
            double othersBill= Convert.ToDouble(this.txtOthersBill.Text);

            double totalMonthlyCost = maintananceCost + restaurantRent + employeeSalary + foodCost + foodCost;
            string totalMonthlyCostAll = Convert.ToString(totalMonthlyCost); 
            this.txtTotalMonthlyCost.Text = totalMonthlyCostAll;
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Owner ow = new Owner();
            ow.Visible = true;
            this.Visible = false;

        }

        private void Expenses_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
