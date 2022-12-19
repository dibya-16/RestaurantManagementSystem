
namespace RestaurantManagementSystem
{
    partial class Expenses
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Expenses));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvExpenses = new System.Windows.Forms.DataGridView();
            this.mainananceCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restaurantRent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OthersBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMonthLyCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtTotalMonthlyCost = new System.Windows.Forms.TextBox();
            this.lblTotalMonthlyCost = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.btnCalculateTotalCost = new System.Windows.Forms.Button();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.txtFoodCost = new System.Windows.Forms.TextBox();
            this.lblFoodCost = new System.Windows.Forms.Label();
            this.btnExpensesDetails = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtRestaurantRent = new System.Windows.Forms.TextBox();
            this.txtEmployeeSalary = new System.Windows.Forms.TextBox();
            this.txtOthersBill = new System.Windows.Forms.TextBox();
            this.txtMaintananceCost = new System.Windows.Forms.TextBox();
            this.lblEmployeeSalary = new System.Windows.Forms.Label();
            this.lblRestaurantRent = new System.Windows.Forms.Label();
            this.lblOthersBill = new System.Windows.Forms.Label();
            this.lblMaintananceCost = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvExpenses);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 241);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 230);
            this.panel1.TabIndex = 0;
            // 
            // dgvExpenses
            // 
            this.dgvExpenses.AllowUserToAddRows = false;
            this.dgvExpenses.AllowUserToDeleteRows = false;
            this.dgvExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mainananceCost,
            this.restaurantRent,
            this.employeeSalary,
            this.foodCost,
            this.OthersBill,
            this.Month,
            this.year,
            this.totalMonthLyCost});
            this.dgvExpenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExpenses.Location = new System.Drawing.Point(0, 0);
            this.dgvExpenses.Name = "dgvExpenses";
            this.dgvExpenses.ReadOnly = true;
            this.dgvExpenses.Size = new System.Drawing.Size(789, 230);
            this.dgvExpenses.TabIndex = 0;
            // 
            // mainananceCost
            // 
            this.mainananceCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mainananceCost.DataPropertyName = "maintananceCost";
            this.mainananceCost.HeaderText = "Mainanance Cost";
            this.mainananceCost.Name = "mainananceCost";
            this.mainananceCost.ReadOnly = true;
            // 
            // restaurantRent
            // 
            this.restaurantRent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.restaurantRent.DataPropertyName = "restaurantRent";
            this.restaurantRent.HeaderText = "Restaurant Rent";
            this.restaurantRent.Name = "restaurantRent";
            this.restaurantRent.ReadOnly = true;
            // 
            // employeeSalary
            // 
            this.employeeSalary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.employeeSalary.DataPropertyName = "employeeSalary";
            this.employeeSalary.HeaderText = "Employee Salary";
            this.employeeSalary.Name = "employeeSalary";
            this.employeeSalary.ReadOnly = true;
            // 
            // foodCost
            // 
            this.foodCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.foodCost.DataPropertyName = "foodCost";
            this.foodCost.HeaderText = "Food Cost";
            this.foodCost.Name = "foodCost";
            this.foodCost.ReadOnly = true;
            // 
            // OthersBill
            // 
            this.OthersBill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OthersBill.DataPropertyName = "othersBill";
            this.OthersBill.HeaderText = "Others Bill";
            this.OthersBill.Name = "OthersBill";
            this.OthersBill.ReadOnly = true;
            // 
            // Month
            // 
            this.Month.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Month.DataPropertyName = "month";
            this.Month.HeaderText = "month";
            this.Month.Name = "Month";
            this.Month.ReadOnly = true;
            // 
            // year
            // 
            this.year.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.year.DataPropertyName = "year";
            this.year.HeaderText = "Year";
            this.year.Name = "year";
            this.year.ReadOnly = true;
            // 
            // totalMonthLyCost
            // 
            this.totalMonthLyCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalMonthLyCost.DataPropertyName = "totalMonthlyCost";
            this.totalMonthLyCost.HeaderText = "Total Monthly Cost";
            this.totalMonthLyCost.Name = "totalMonthLyCost";
            this.totalMonthLyCost.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.txtYear);
            this.panel2.Controls.Add(this.txtTotalMonthlyCost);
            this.panel2.Controls.Add(this.lblTotalMonthlyCost);
            this.panel2.Controls.Add(this.lblYear);
            this.panel2.Controls.Add(this.btnCalculateTotalCost);
            this.panel2.Controls.Add(this.cmbMonth);
            this.panel2.Controls.Add(this.lblMonth);
            this.panel2.Controls.Add(this.txtFoodCost);
            this.panel2.Controls.Add(this.lblFoodCost);
            this.panel2.Controls.Add(this.btnExpensesDetails);
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.btnRemove);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.txtRestaurantRent);
            this.panel2.Controls.Add(this.txtEmployeeSalary);
            this.panel2.Controls.Add(this.txtOthersBill);
            this.panel2.Controls.Add(this.txtMaintananceCost);
            this.panel2.Controls.Add(this.lblEmployeeSalary);
            this.panel2.Controls.Add(this.lblRestaurantRent);
            this.panel2.Controls.Add(this.lblOthersBill);
            this.panel2.Controls.Add(this.lblMaintananceCost);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(789, 245);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(286, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(124, 192);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(114, 20);
            this.txtYear.TabIndex = 24;
            // 
            // txtTotalMonthlyCost
            // 
            this.txtTotalMonthlyCost.Location = new System.Drawing.Point(124, 218);
            this.txtTotalMonthlyCost.Name = "txtTotalMonthlyCost";
            this.txtTotalMonthlyCost.Size = new System.Drawing.Size(114, 20);
            this.txtTotalMonthlyCost.TabIndex = 23;
            // 
            // lblTotalMonthlyCost
            // 
            this.lblTotalMonthlyCost.AutoSize = true;
            this.lblTotalMonthlyCost.Location = new System.Drawing.Point(15, 222);
            this.lblTotalMonthlyCost.Name = "lblTotalMonthlyCost";
            this.lblTotalMonthlyCost.Size = new System.Drawing.Size(95, 13);
            this.lblTotalMonthlyCost.TabIndex = 22;
            this.lblTotalMonthlyCost.Text = "Total Monthly Cost";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(18, 195);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 21;
            this.lblYear.Text = "Year";
            // 
            // btnCalculateTotalCost
            // 
            this.btnCalculateTotalCost.Location = new System.Drawing.Point(267, 198);
            this.btnCalculateTotalCost.Name = "btnCalculateTotalCost";
            this.btnCalculateTotalCost.Size = new System.Drawing.Size(75, 40);
            this.btnCalculateTotalCost.TabIndex = 20;
            this.btnCalculateTotalCost.Text = "Calculate Total Cost";
            this.btnCalculateTotalCost.UseVisualStyleBackColor = true;
            this.btnCalculateTotalCost.Click += new System.EventHandler(this.btnCalculateTotalCost_Click);
            // 
            // cmbMonth
            // 
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbMonth.Location = new System.Drawing.Point(124, 162);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(114, 21);
            this.cmbMonth.TabIndex = 19;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(15, 162);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(37, 13);
            this.lblMonth.TabIndex = 18;
            this.lblMonth.Text = "Month";
            // 
            // txtFoodCost
            // 
            this.txtFoodCost.Location = new System.Drawing.Point(124, 95);
            this.txtFoodCost.Name = "txtFoodCost";
            this.txtFoodCost.Size = new System.Drawing.Size(114, 20);
            this.txtFoodCost.TabIndex = 17;
            // 
            // lblFoodCost
            // 
            this.lblFoodCost.AutoSize = true;
            this.lblFoodCost.Location = new System.Drawing.Point(14, 98);
            this.lblFoodCost.Name = "lblFoodCost";
            this.lblFoodCost.Size = new System.Drawing.Size(55, 13);
            this.lblFoodCost.TabIndex = 16;
            this.lblFoodCost.Text = "Food Cost";
            // 
            // btnExpensesDetails
            // 
            this.btnExpensesDetails.Location = new System.Drawing.Point(668, 212);
            this.btnExpensesDetails.Name = "btnExpensesDetails";
            this.btnExpensesDetails.Size = new System.Drawing.Size(109, 23);
            this.btnExpensesDetails.TabIndex = 15;
            this.btnExpensesDetails.Text = "Expenses Details";
            this.btnExpensesDetails.UseVisualStyleBackColor = true;
            this.btnExpensesDetails.Click += new System.EventHandler(this.btnExpensesDetails_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(702, 9);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(456, 212);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 13;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(559, 212);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(366, 212);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtRestaurantRent
            // 
            this.txtRestaurantRent.Location = new System.Drawing.Point(124, 35);
            this.txtRestaurantRent.Name = "txtRestaurantRent";
            this.txtRestaurantRent.Size = new System.Drawing.Size(114, 20);
            this.txtRestaurantRent.TabIndex = 10;
            // 
            // txtEmployeeSalary
            // 
            this.txtEmployeeSalary.Location = new System.Drawing.Point(124, 66);
            this.txtEmployeeSalary.Name = "txtEmployeeSalary";
            this.txtEmployeeSalary.Size = new System.Drawing.Size(114, 20);
            this.txtEmployeeSalary.TabIndex = 8;
            // 
            // txtOthersBill
            // 
            this.txtOthersBill.Location = new System.Drawing.Point(124, 128);
            this.txtOthersBill.Name = "txtOthersBill";
            this.txtOthersBill.Size = new System.Drawing.Size(114, 20);
            this.txtOthersBill.TabIndex = 6;
            // 
            // txtMaintananceCost
            // 
            this.txtMaintananceCost.Location = new System.Drawing.Point(124, 6);
            this.txtMaintananceCost.Name = "txtMaintananceCost";
            this.txtMaintananceCost.Size = new System.Drawing.Size(114, 20);
            this.txtMaintananceCost.TabIndex = 5;
            // 
            // lblEmployeeSalary
            // 
            this.lblEmployeeSalary.AutoSize = true;
            this.lblEmployeeSalary.Location = new System.Drawing.Point(14, 66);
            this.lblEmployeeSalary.Name = "lblEmployeeSalary";
            this.lblEmployeeSalary.Size = new System.Drawing.Size(85, 13);
            this.lblEmployeeSalary.TabIndex = 3;
            this.lblEmployeeSalary.Text = "Employee Salary";
            // 
            // lblRestaurantRent
            // 
            this.lblRestaurantRent.AutoSize = true;
            this.lblRestaurantRent.Location = new System.Drawing.Point(14, 35);
            this.lblRestaurantRent.Name = "lblRestaurantRent";
            this.lblRestaurantRent.Size = new System.Drawing.Size(85, 13);
            this.lblRestaurantRent.TabIndex = 2;
            this.lblRestaurantRent.Text = "Restaurant Rent";
            // 
            // lblOthersBill
            // 
            this.lblOthersBill.AutoSize = true;
            this.lblOthersBill.Location = new System.Drawing.Point(15, 128);
            this.lblOthersBill.Name = "lblOthersBill";
            this.lblOthersBill.Size = new System.Drawing.Size(54, 13);
            this.lblOthersBill.TabIndex = 1;
            this.lblOthersBill.Text = "Others Bill";
            // 
            // lblMaintananceCost
            // 
            this.lblMaintananceCost.AutoSize = true;
            this.lblMaintananceCost.Location = new System.Drawing.Point(14, 9);
            this.lblMaintananceCost.Name = "lblMaintananceCost";
            this.lblMaintananceCost.Size = new System.Drawing.Size(93, 13);
            this.lblMaintananceCost.TabIndex = 0;
            this.lblMaintananceCost.Text = "Maintanance Cost";
            // 
            // Expenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 471);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Expenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "expenses";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Expenses_FormClosed);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvExpenses;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtRestaurantRent;
        private System.Windows.Forms.TextBox txtEmployeeSalary;
        private System.Windows.Forms.TextBox txtOthersBill;
        private System.Windows.Forms.TextBox txtMaintananceCost;
        private System.Windows.Forms.Label lblEmployeeSalary;
        private System.Windows.Forms.Label lblRestaurantRent;
        private System.Windows.Forms.Label lblOthersBill;
        private System.Windows.Forms.Label lblMaintananceCost;
        private System.Windows.Forms.TextBox txtFoodCost;
        private System.Windows.Forms.Label lblFoodCost;
        private System.Windows.Forms.Button btnExpensesDetails;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtTotalMonthlyCost;
        private System.Windows.Forms.Label lblTotalMonthlyCost;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Button btnCalculateTotalCost;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainananceCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn restaurantRent;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn OthersBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalMonthLyCost;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}