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
    public partial class SelectFood : Form
    {
        private DataAccess Da { get; set; }
        public SelectFood()
        {
            InitializeComponent();
            this.Da = new DataAccess();
           // this.AutoBillIdGenerate();
        }

        public SelectFood(string customerId, string tableId) : this()
        {
            this.txtCustomerId.Text = customerId;
            this.txtTableNumber.Text = tableId;
           


        }

        public double CalculateTotalBill()
        {
            double totalBillAll = 0.00;
            if ((this.clbFastFood.Text).Equals("Burger"))
            {
                //var sql = "select foodCost from foodDetailsAll where foodItem = 'Burger	';";
                // var ds = this.Da.ExecuteDMLQuery(sql);
                //  double bill = Convert.ToDouble(ds);
                double bill = 299*Convert.ToDouble(this.nudQuantityForBurger.Text);

                totalBillAll += bill;


            }

            if ((this.clbFastFood.Text).Equals("French Fries"))
            {
               
                double bill = 129 * Convert.ToDouble(this.nudQuantityForFrenchFries.Text);
                totalBillAll += bill;


            }

            if ((this.clbFastFood.Text).Equals("Pizza"))
            {
                double bill = 999 * Convert.ToDouble(this.nudQuantityForPizza.Text);

                totalBillAll += bill;


            }

            if ((this.clbFastFood.Text).Equals("Chicken Lolly-Pop"))
            {
                
                double bill = 999 * Convert.ToDouble(this.nudQuantityForChickenLollyPop.Text);

                totalBillAll += bill;


            }

            if ((this.clbFastFood.Text).Equals("Fried Chicken"))
            {

                double bill = 399 * Convert.ToDouble(this.nudQuantityForFriedChicken.Text);

                totalBillAll += bill;


            }

            if ((this.clbFastFood.Text).Equals("Chicken Nuggets"))
            {

                double bill = 249 * Convert.ToDouble(this.nudQuantityForChickenNuggets.Text);

                totalBillAll += bill;


            }

            if ((this.clbDessert.Text).Equals("Pancakes"))
            {

                double bill = 139 * Convert.ToDouble(this.nudQuantityForPanCakes.Text);

                totalBillAll += bill;


            }
            if ((this.clbDessert.Text).Equals("Ice Cream"))
            {

                double bill = 100 * Convert.ToDouble(this.nudQuantityForIceCream.Text);

                totalBillAll += bill;


            }

            if ((this.clbDessert.Text).Equals("Milk Shake"))
            {

                double bill = 179 * Convert.ToDouble(this.nudQuantityForBurger.Text);

                totalBillAll += bill;


            }

            if ((this.clbDessert.Text).Equals("Oreo Shake"))
            {

                double bill = 155 * Convert.ToDouble(this.nudQuantityForOreoShake.Text);
                totalBillAll += bill;


            }

            if ((this.clbDrinks.Text).Equals("Coca-Cola"))
            {

                double bill = 50 * Convert.ToDouble(this.nudQuantityForCocaCola.Text);

                totalBillAll += bill;


            }

            if ((this.clbDrinks.Text).Equals("Pepsi"))
            {

                double bill = 50 * Convert.ToDouble(this.nudQuantityForPepsi.Text);

                totalBillAll += bill;


            }

            if ((this.clbDrinks.Text).Equals("Mountain Due"))
            {
                // var sql = "select foodCost from foodDetailsAll where foodItem = 'Mountain Due';";
                // var ds = this.Da.ExecuteDMLQuery(sql);
                // double bill = Convert.ToDouble(ds);
                double bill = 50 * Convert.ToDouble(this.nudQuantityForMountainDue.Text);

                totalBillAll += bill;


            }
            if ((this.clbSetMenu.Text).Equals("Fried Rice with Chicken Lolly-Pop"))
            {

                double bill = 399 * Convert.ToDouble(this.nudQuantityForFriedRiceWithChickenLollyPop.Text);

                totalBillAll += bill;


            }
            if ((this.clbSetMenu.Text).Equals("Fried Rice with Vegetable and Chicken Curry"))
            {

                double bill = 455 * Convert.ToDouble(this.nudQuantityForFriedRiceWithVegetableAndChickenCurry.Text);

                totalBillAll += bill;


            }



            return totalBillAll;
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {



            /* try
             {


                 var query = "select * from billHistoryAll where billId = '" + this.txtBillId.Text + "';";
                 var ds = this.Da.ExecuteQuery(query);

                 if (ds.Tables[0].Rows.Count == 1)
                 {
                     string items = this.clbFastFood.Text + " " + this.clbSetMenu.Text + " " + this.clbDessert.Text + " " + this.clbDrinks.Text;
                     string totalBillAll = this.CalculateTotalBill().ToString();
                     var sql = @"update billHistoryAll
                                      set customerId = '" + this.txtCustomerId.Text + @"',
                                      items='" + items + @"', 
                                      tableNumber='" + this.txtTableNumber.Text + @"',
                                      totalBill = '" + totalBillAll+ @"'

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

                     //BillHistory bl = new BillHistory();
                     //bl.BillHistoryGridView1(sql);
                    *//* string billIdNew = this.txtBillId.Text;
                     BillHistory bl = new BillHistory(billIdNew);*//*
                 }



             catch (Exception exc)
             {
                 MessageBox.Show(exc.Message);
             }*/


            try
            {
                //string billId = this.txtBillId.Text;
                string customerIdTOBillHistory = this.txtCustomerId.Text;
                string tableIdTOBillHistory = this.txtTableNumber.Text;
                string items = this.clbFastFood.Text + " " + this.clbSetMenu.Text + " " + this.clbDessert.Text + " " + this.clbDrinks.Text;
                string totalBill = Convert.ToString(this.CalculateTotalBill());
                BillHistory bl = new BillHistory(customerIdTOBillHistory, items, tableIdTOBillHistory, totalBill);

                bl.Visible = true;

                this.Visible = false;
                MessageBox.Show("Added to Cart Successfully And"+" "+"Total Bill =" +totalBill);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

       /* public void AutoBillIdGenerate()
        {

            var sql = "select billId from billHistoryAll order by billId desc;";
            DataSet ds = this.Da.ExecuteQuery(sql);
            string previousId = ds.Tables[0].Rows[0]["billId"].ToString();
            string[] temp = previousId.Split('-');
            int number = Convert.ToInt32(temp[1]);
            string newBillId = "b-" + (++number).ToString("d2");
            this.txtBillId.Text = newBillId;


        }*/




        private void SelectFood_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Reservation r = new Reservation();
            r.Visible = true;
            this.Visible = false;
        }

        private void btnBillHistory_Click(object sender, EventArgs e)
        {
            BillHistory bl = new BillHistory();
            bl.Visible = true;
            this.Visible = false;
        }

       
    }
}
