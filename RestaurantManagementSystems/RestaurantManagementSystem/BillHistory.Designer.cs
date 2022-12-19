
namespace RestaurantManagementSystem
{
    partial class BillHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillHistory));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvBillHistory = new System.Windows.Forms.DataGridView();
            this.billId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.items = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBackToManager = new System.Windows.Forms.Button();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.lblSearchByTableNumber = new System.Windows.Forms.Label();
            this.txtSearchByCustomerId = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnBillHistoryDetails = new System.Windows.Forms.Button();
            this.btnBackToFoodItems = new System.Windows.Forms.Button();
            this.dtpBillPayTime = new System.Windows.Forms.DateTimePicker();
            this.txtBillId = new System.Windows.Forms.TextBox();
            this.lblBillId = new System.Windows.Forms.Label();
            this.txtItems = new System.Windows.Forms.TextBox();
            this.lblItems = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblBillPayTime = new System.Windows.Forms.Label();
            this.lblReturned = new System.Windows.Forms.Label();
            this.lblTotalPay = new System.Windows.Forms.Label();
            this.txtTotalBill = new System.Windows.Forms.TextBox();
            this.txtTotalPay = new System.Windows.Forms.TextBox();
            this.txtReturned = new System.Windows.Forms.TextBox();
            this.txtTableNumber = new System.Windows.Forms.TextBox();
            this.lblTotalBill = new System.Windows.Forms.Label();
            this.lblTableNumber = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillHistory)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvBillHistory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 240);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 231);
            this.panel1.TabIndex = 0;
            // 
            // dgvBillHistory
            // 
            this.dgvBillHistory.AllowUserToAddRows = false;
            this.dgvBillHistory.AllowUserToDeleteRows = false;
            this.dgvBillHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.billId,
            this.items,
            this.tableNumber,
            this.totalBill,
            this.totalPay,
            this.returned,
            this.date,
            this.customerId});
            this.dgvBillHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBillHistory.Location = new System.Drawing.Point(0, 0);
            this.dgvBillHistory.Name = "dgvBillHistory";
            this.dgvBillHistory.ReadOnly = true;
            this.dgvBillHistory.Size = new System.Drawing.Size(806, 231);
            this.dgvBillHistory.TabIndex = 0;
            this.dgvBillHistory.DoubleClick += new System.EventHandler(this.dgvBillHistory_DoubleClick);
            // 
            // billId
            // 
            this.billId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.billId.DataPropertyName = "billId";
            this.billId.HeaderText = "Bill Id";
            this.billId.Name = "billId";
            this.billId.ReadOnly = true;
            // 
            // items
            // 
            this.items.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.items.DataPropertyName = "items";
            this.items.HeaderText = "Items";
            this.items.Name = "items";
            this.items.ReadOnly = true;
            // 
            // tableNumber
            // 
            this.tableNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tableNumber.DataPropertyName = "tableNumber";
            this.tableNumber.HeaderText = "Table Number";
            this.tableNumber.Name = "tableNumber";
            this.tableNumber.ReadOnly = true;
            // 
            // totalBill
            // 
            this.totalBill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalBill.DataPropertyName = "totalBill";
            this.totalBill.HeaderText = "Total Bill";
            this.totalBill.Name = "totalBill";
            this.totalBill.ReadOnly = true;
            // 
            // totalPay
            // 
            this.totalPay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalPay.DataPropertyName = "totalPay";
            this.totalPay.HeaderText = "Total Pay";
            this.totalPay.Name = "totalPay";
            this.totalPay.ReadOnly = true;
            // 
            // returned
            // 
            this.returned.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.returned.DataPropertyName = "returned";
            this.returned.HeaderText = "Returned";
            this.returned.Name = "returned";
            this.returned.ReadOnly = true;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // customerId
            // 
            this.customerId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customerId.DataPropertyName = "customerId";
            this.customerId.HeaderText = "Customer Id";
            this.customerId.Name = "customerId";
            this.customerId.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnRemove);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnBackToManager);
            this.panel2.Controls.Add(this.txtCustomerId);
            this.panel2.Controls.Add(this.lblCustomerId);
            this.panel2.Controls.Add(this.lblSearchByTableNumber);
            this.panel2.Controls.Add(this.txtSearchByCustomerId);
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Controls.Add(this.btnBillHistoryDetails);
            this.panel2.Controls.Add(this.btnBackToFoodItems);
            this.panel2.Controls.Add(this.dtpBillPayTime);
            this.panel2.Controls.Add(this.txtBillId);
            this.panel2.Controls.Add(this.lblBillId);
            this.panel2.Controls.Add(this.txtItems);
            this.panel2.Controls.Add(this.lblItems);
            this.panel2.Controls.Add(this.btnCalculate);
            this.panel2.Controls.Add(this.lblBillPayTime);
            this.panel2.Controls.Add(this.lblReturned);
            this.panel2.Controls.Add(this.lblTotalPay);
            this.panel2.Controls.Add(this.txtTotalBill);
            this.panel2.Controls.Add(this.txtTotalPay);
            this.panel2.Controls.Add(this.txtReturned);
            this.panel2.Controls.Add(this.txtTableNumber);
            this.panel2.Controls.Add(this.lblTotalBill);
            this.panel2.Controls.Add(this.lblTableNumber);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(806, 241);
            this.panel2.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(514, 164);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(411, 164);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 28;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(306, 164);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBackToManager
            // 
            this.btnBackToManager.Location = new System.Drawing.Point(646, 74);
            this.btnBackToManager.Name = "btnBackToManager";
            this.btnBackToManager.Size = new System.Drawing.Size(127, 29);
            this.btnBackToManager.TabIndex = 25;
            this.btnBackToManager.Text = "Back To Manager";
            this.btnBackToManager.UseVisualStyleBackColor = true;
            this.btnBackToManager.Click += new System.EventHandler(this.btnBackToManager_Click);
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(127, 210);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerId.TabIndex = 24;
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerId.Location = new System.Drawing.Point(30, 217);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(79, 16);
            this.lblCustomerId.TabIndex = 23;
            this.lblCustomerId.Text = "Customer Id";
            // 
            // lblSearchByTableNumber
            // 
            this.lblSearchByTableNumber.AutoSize = true;
            this.lblSearchByTableNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchByTableNumber.Location = new System.Drawing.Point(272, 217);
            this.lblSearchByTableNumber.Name = "lblSearchByTableNumber";
            this.lblSearchByTableNumber.Size = new System.Drawing.Size(144, 16);
            this.lblSearchByTableNumber.TabIndex = 22;
            this.lblSearchByTableNumber.Text = "Search By Customer Id";
            // 
            // txtSearchByCustomerId
            // 
            this.txtSearchByCustomerId.Location = new System.Drawing.Point(447, 214);
            this.txtSearchByCustomerId.Name = "txtSearchByCustomerId";
            this.txtSearchByCustomerId.Size = new System.Drawing.Size(160, 20);
            this.txtSearchByCustomerId.TabIndex = 21;
            this.txtSearchByCustomerId.TextChanged += new System.EventHandler(this.txtSearchByCustomerId_TextChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(377, 62);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 65);
            this.btnPrint.TabIndex = 20;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnBillHistoryDetails
            // 
            this.btnBillHistoryDetails.Location = new System.Drawing.Point(687, 196);
            this.btnBillHistoryDetails.Name = "btnBillHistoryDetails";
            this.btnBillHistoryDetails.Size = new System.Drawing.Size(107, 36);
            this.btnBillHistoryDetails.TabIndex = 19;
            this.btnBillHistoryDetails.Text = "Bill History Details";
            this.btnBillHistoryDetails.UseVisualStyleBackColor = true;
            this.btnBillHistoryDetails.Click += new System.EventHandler(this.btnBillHistoryDetails_Click);
            // 
            // btnBackToFoodItems
            // 
            this.btnBackToFoodItems.Location = new System.Drawing.Point(646, 15);
            this.btnBackToFoodItems.Name = "btnBackToFoodItems";
            this.btnBackToFoodItems.Size = new System.Drawing.Size(127, 32);
            this.btnBackToFoodItems.TabIndex = 18;
            this.btnBackToFoodItems.Text = "Back To Food Items";
            this.btnBackToFoodItems.UseVisualStyleBackColor = true;
            this.btnBackToFoodItems.Click += new System.EventHandler(this.btnBackToFoodItems_Click);
            // 
            // dtpBillPayTime
            // 
            this.dtpBillPayTime.CustomFormat = "yyyy-MM-dd";
            this.dtpBillPayTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBillPayTime.Location = new System.Drawing.Point(127, 183);
            this.dtpBillPayTime.Name = "dtpBillPayTime";
            this.dtpBillPayTime.Size = new System.Drawing.Size(100, 20);
            this.dtpBillPayTime.TabIndex = 17;
            // 
            // txtBillId
            // 
            this.txtBillId.Location = new System.Drawing.Point(127, 5);
            this.txtBillId.Name = "txtBillId";
            this.txtBillId.Size = new System.Drawing.Size(100, 20);
            this.txtBillId.TabIndex = 16;
            // 
            // lblBillId
            // 
            this.lblBillId.AutoSize = true;
            this.lblBillId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillId.Location = new System.Drawing.Point(28, 9);
            this.lblBillId.Name = "lblBillId";
            this.lblBillId.Size = new System.Drawing.Size(40, 16);
            this.lblBillId.TabIndex = 15;
            this.lblBillId.Text = "Bill Id";
            // 
            // txtItems
            // 
            this.txtItems.Location = new System.Drawing.Point(127, 40);
            this.txtItems.Name = "txtItems";
            this.txtItems.Size = new System.Drawing.Size(100, 20);
            this.txtItems.TabIndex = 14;
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItems.Location = new System.Drawing.Point(28, 44);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(40, 16);
            this.lblItems.TabIndex = 13;
            this.lblItems.Text = "Items";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(264, 60);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 69);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblBillPayTime
            // 
            this.lblBillPayTime.AutoSize = true;
            this.lblBillPayTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillPayTime.Location = new System.Drawing.Point(30, 189);
            this.lblBillPayTime.Name = "lblBillPayTime";
            this.lblBillPayTime.Size = new System.Drawing.Size(37, 16);
            this.lblBillPayTime.TabIndex = 10;
            this.lblBillPayTime.Text = "Date";
            // 
            // lblReturned
            // 
            this.lblReturned.AutoSize = true;
            this.lblReturned.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturned.Location = new System.Drawing.Point(30, 160);
            this.lblReturned.Name = "lblReturned";
            this.lblReturned.Size = new System.Drawing.Size(63, 16);
            this.lblReturned.TabIndex = 9;
            this.lblReturned.Text = "Returned";
            // 
            // lblTotalPay
            // 
            this.lblTotalPay.AutoSize = true;
            this.lblTotalPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPay.Location = new System.Drawing.Point(28, 129);
            this.lblTotalPay.Name = "lblTotalPay";
            this.lblTotalPay.Size = new System.Drawing.Size(66, 16);
            this.lblTotalPay.TabIndex = 8;
            this.lblTotalPay.Text = "Total Pay";
            // 
            // txtTotalBill
            // 
            this.txtTotalBill.Location = new System.Drawing.Point(127, 99);
            this.txtTotalBill.Name = "txtTotalBill";
            this.txtTotalBill.Size = new System.Drawing.Size(100, 20);
            this.txtTotalBill.TabIndex = 7;
            // 
            // txtTotalPay
            // 
            this.txtTotalPay.Location = new System.Drawing.Point(127, 125);
            this.txtTotalPay.Name = "txtTotalPay";
            this.txtTotalPay.Size = new System.Drawing.Size(100, 20);
            this.txtTotalPay.TabIndex = 6;
            // 
            // txtReturned
            // 
            this.txtReturned.Location = new System.Drawing.Point(127, 157);
            this.txtReturned.Name = "txtReturned";
            this.txtReturned.Size = new System.Drawing.Size(100, 20);
            this.txtReturned.TabIndex = 5;
            // 
            // txtTableNumber
            // 
            this.txtTableNumber.Location = new System.Drawing.Point(127, 70);
            this.txtTableNumber.Name = "txtTableNumber";
            this.txtTableNumber.Size = new System.Drawing.Size(100, 20);
            this.txtTableNumber.TabIndex = 3;
            // 
            // lblTotalBill
            // 
            this.lblTotalBill.AutoSize = true;
            this.lblTotalBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBill.Location = new System.Drawing.Point(26, 100);
            this.lblTotalBill.Name = "lblTotalBill";
            this.lblTotalBill.Size = new System.Drawing.Size(60, 16);
            this.lblTotalBill.TabIndex = 2;
            this.lblTotalBill.Text = "Total Bill";
            // 
            // lblTableNumber
            // 
            this.lblTableNumber.AutoSize = true;
            this.lblTableNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableNumber.Location = new System.Drawing.Point(26, 74);
            this.lblTableNumber.Name = "lblTableNumber";
            this.lblTableNumber.Size = new System.Drawing.Size(95, 16);
            this.lblTableNumber.TabIndex = 0;
            this.lblTableNumber.Text = "Table Number";
            // 
            // BillHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 471);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "BillHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BillHistory";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.billHistory_FormClosed);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillHistory)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvBillHistory;
        private System.Windows.Forms.Label lblTableNumber;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblBillPayTime;
        private System.Windows.Forms.Label lblReturned;
        private System.Windows.Forms.Label lblTotalPay;
        private System.Windows.Forms.TextBox txtTotalBill;
        private System.Windows.Forms.TextBox txtTotalPay;
        private System.Windows.Forms.TextBox txtReturned;
        private System.Windows.Forms.TextBox txtTableNumber;
        private System.Windows.Forms.Label lblTotalBill;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.TextBox txtItems;
        private System.Windows.Forms.DateTimePicker dtpBillPayTime;
        private System.Windows.Forms.TextBox txtBillId;
        private System.Windows.Forms.Label lblBillId;
        private System.Windows.Forms.Button btnBackToFoodItems;
        private System.Windows.Forms.Button btnBillHistoryDetails;
        private System.Windows.Forms.Label lblSearchByTableNumber;
        private System.Windows.Forms.TextBox txtSearchByCustomerId;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.Button btnBackToManager;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn billId;
        private System.Windows.Forms.DataGridViewTextBoxColumn items;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn returned;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerId;
    }
}