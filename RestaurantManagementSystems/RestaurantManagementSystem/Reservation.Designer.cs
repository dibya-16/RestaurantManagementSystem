
namespace RestaurantManagementSystem
{
    partial class Reservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservation));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvReservation = new System.Windows.Forms.DataGridView();
            this.customerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerContactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNextToChooseFood = new System.Windows.Forms.Button();
            this.cmbBookingState = new System.Windows.Forms.ComboBox();
            this.lblBookingState = new System.Windows.Forms.Label();
            this.cmbTableId = new System.Windows.Forms.ComboBox();
            this.txtSearchByTableNumber = new System.Windows.Forms.TextBox();
            this.lblSearchByTableNumber = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpResevationTime = new System.Windows.Forms.DateTimePicker();
            this.txtCustomerContactNumber = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.lblStaffPosition = new System.Windows.Forms.Label();
            this.lblJoiningDate = new System.Windows.Forms.Label();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.lblStaffId = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservation)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvReservation);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 254);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 235);
            this.panel1.TabIndex = 0;
            // 
            // dgvReservation
            // 
            this.dgvReservation.AllowUserToAddRows = false;
            this.dgvReservation.AllowUserToDeleteRows = false;
            this.dgvReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerId,
            this.customerName,
            this.customerContactNumber,
            this.tableId,
            this.reservationDate,
            this.bookingState});
            this.dgvReservation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReservation.Location = new System.Drawing.Point(0, 0);
            this.dgvReservation.Name = "dgvReservation";
            this.dgvReservation.ReadOnly = true;
            this.dgvReservation.Size = new System.Drawing.Size(800, 235);
            this.dgvReservation.TabIndex = 0;
            this.dgvReservation.DoubleClick += new System.EventHandler(this.dgvReservation_DoubleClick);
            // 
            // customerId
            // 
            this.customerId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customerId.DataPropertyName = "customerId";
            this.customerId.HeaderText = "Customer Id";
            this.customerId.Name = "customerId";
            this.customerId.ReadOnly = true;
            // 
            // customerName
            // 
            this.customerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customerName.DataPropertyName = "customerName";
            this.customerName.HeaderText = "Customer Name";
            this.customerName.Name = "customerName";
            this.customerName.ReadOnly = true;
            // 
            // customerContactNumber
            // 
            this.customerContactNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customerContactNumber.DataPropertyName = "customerContactNumber";
            this.customerContactNumber.HeaderText = "Customer Contact Number";
            this.customerContactNumber.Name = "customerContactNumber";
            this.customerContactNumber.ReadOnly = true;
            // 
            // tableId
            // 
            this.tableId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tableId.DataPropertyName = "tableId";
            this.tableId.HeaderText = "Table Number";
            this.tableId.Name = "tableId";
            this.tableId.ReadOnly = true;
            // 
            // reservationDate
            // 
            this.reservationDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.reservationDate.DataPropertyName = "reservationDate";
            this.reservationDate.HeaderText = "Reservation Date";
            this.reservationDate.Name = "reservationDate";
            this.reservationDate.ReadOnly = true;
            // 
            // bookingState
            // 
            this.bookingState.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bookingState.DataPropertyName = "bookingState";
            this.bookingState.HeaderText = "Booking State";
            this.bookingState.Name = "bookingState";
            this.bookingState.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnNextToChooseFood);
            this.panel2.Controls.Add(this.cmbBookingState);
            this.panel2.Controls.Add(this.lblBookingState);
            this.panel2.Controls.Add(this.cmbTableId);
            this.panel2.Controls.Add(this.txtSearchByTableNumber);
            this.panel2.Controls.Add(this.lblSearchByTableNumber);
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnRemove);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.dtpResevationTime);
            this.panel2.Controls.Add(this.txtCustomerContactNumber);
            this.panel2.Controls.Add(this.txtCustomerName);
            this.panel2.Controls.Add(this.txtCustomerId);
            this.panel2.Controls.Add(this.lblStaffPosition);
            this.panel2.Controls.Add(this.lblJoiningDate);
            this.panel2.Controls.Add(this.lblContactNumber);
            this.panel2.Controls.Add(this.lblStaffName);
            this.panel2.Controls.Add(this.lblStaffId);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 255);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(380, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 16);
            this.label1.TabIndex = 52;
            this.label1.Text = "Select A Row And Click Next To Choose Food Button For Order";
            // 
            // btnNextToChooseFood
            // 
            this.btnNextToChooseFood.Location = new System.Drawing.Point(571, 114);
            this.btnNextToChooseFood.Name = "btnNextToChooseFood";
            this.btnNextToChooseFood.Size = new System.Drawing.Size(149, 39);
            this.btnNextToChooseFood.TabIndex = 51;
            this.btnNextToChooseFood.Text = "Next To Choose Food";
            this.btnNextToChooseFood.UseVisualStyleBackColor = true;
            this.btnNextToChooseFood.Click += new System.EventHandler(this.btnNextToChooseFood_Click);
            // 
            // cmbBookingState
            // 
            this.cmbBookingState.FormattingEnabled = true;
            this.cmbBookingState.Items.AddRange(new object[] {
            "Booked",
            "Unbooked"});
            this.cmbBookingState.Location = new System.Drawing.Point(186, 148);
            this.cmbBookingState.Name = "cmbBookingState";
            this.cmbBookingState.Size = new System.Drawing.Size(115, 21);
            this.cmbBookingState.TabIndex = 50;
            // 
            // lblBookingState
            // 
            this.lblBookingState.AutoSize = true;
            this.lblBookingState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingState.Location = new System.Drawing.Point(16, 153);
            this.lblBookingState.Name = "lblBookingState";
            this.lblBookingState.Size = new System.Drawing.Size(92, 16);
            this.lblBookingState.TabIndex = 49;
            this.lblBookingState.Text = "Booking State";
            // 
            // cmbTableId
            // 
            this.cmbTableId.FormattingEnabled = true;
            this.cmbTableId.Items.AddRange(new object[] {
            "t-01",
            "t-02",
            "t-03",
            "t-04",
            "t-05",
            "t-06",
            "t-07",
            "t-08",
            "t-09",
            "t-10"});
            this.cmbTableId.Location = new System.Drawing.Point(186, 113);
            this.cmbTableId.Name = "cmbTableId";
            this.cmbTableId.Size = new System.Drawing.Size(115, 21);
            this.cmbTableId.TabIndex = 48;
            // 
            // txtSearchByTableNumber
            // 
            this.txtSearchByTableNumber.Location = new System.Drawing.Point(346, 188);
            this.txtSearchByTableNumber.Name = "txtSearchByTableNumber";
            this.txtSearchByTableNumber.Size = new System.Drawing.Size(210, 20);
            this.txtSearchByTableNumber.TabIndex = 47;
            this.txtSearchByTableNumber.TextChanged += new System.EventHandler(this.txtSearchByTableNumber_TextChanged);
            // 
            // lblSearchByTableNumber
            // 
            this.lblSearchByTableNumber.AutoSize = true;
            this.lblSearchByTableNumber.Location = new System.Drawing.Point(372, 168);
            this.lblSearchByTableNumber.Name = "lblSearchByTableNumber";
            this.lblSearchByTableNumber.Size = new System.Drawing.Size(126, 13);
            this.lblSearchByTableNumber.TabIndex = 46;
            this.lblSearchByTableNumber.Text = "Search By Table Number";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(713, 10);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 45;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(687, 226);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 44;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(587, 225);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 43;
            this.btnClear.Text = "CLear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(481, 225);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 42;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(361, 225);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 41;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpResevationTime
            // 
            this.dtpResevationTime.CustomFormat = "yyyy-MM-dd";
            this.dtpResevationTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpResevationTime.Location = new System.Drawing.Point(186, 195);
            this.dtpResevationTime.Name = "dtpResevationTime";
            this.dtpResevationTime.Size = new System.Drawing.Size(115, 20);
            this.dtpResevationTime.TabIndex = 40;
            // 
            // txtCustomerContactNumber
            // 
            this.txtCustomerContactNumber.Location = new System.Drawing.Point(186, 79);
            this.txtCustomerContactNumber.Name = "txtCustomerContactNumber";
            this.txtCustomerContactNumber.Size = new System.Drawing.Size(115, 20);
            this.txtCustomerContactNumber.TabIndex = 37;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(186, 46);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(115, 20);
            this.txtCustomerName.TabIndex = 34;
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(186, 3);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(115, 20);
            this.txtCustomerId.TabIndex = 33;
            // 
            // lblStaffPosition
            // 
            this.lblStaffPosition.AutoSize = true;
            this.lblStaffPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffPosition.Location = new System.Drawing.Point(16, 114);
            this.lblStaffPosition.Name = "lblStaffPosition";
            this.lblStaffPosition.Size = new System.Drawing.Size(95, 16);
            this.lblStaffPosition.TabIndex = 31;
            this.lblStaffPosition.Text = "Table Number";
            // 
            // lblJoiningDate
            // 
            this.lblJoiningDate.AutoSize = true;
            this.lblJoiningDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoiningDate.Location = new System.Drawing.Point(16, 195);
            this.lblJoiningDate.Name = "lblJoiningDate";
            this.lblJoiningDate.Size = new System.Drawing.Size(113, 16);
            this.lblJoiningDate.TabIndex = 30;
            this.lblJoiningDate.Text = "Reservation Date";
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNumber.Location = new System.Drawing.Point(16, 83);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(164, 16);
            this.lblContactNumber.TabIndex = 29;
            this.lblContactNumber.Text = "Customer Contact Number";
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffName.Location = new System.Drawing.Point(16, 50);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(105, 16);
            this.lblStaffName.TabIndex = 26;
            this.lblStaffName.Text = "Customer Name";
            // 
            // lblStaffId
            // 
            this.lblStaffId.AutoSize = true;
            this.lblStaffId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffId.Location = new System.Drawing.Point(16, 15);
            this.lblStaffId.Name = "lblStaffId";
            this.lblStaffId.Size = new System.Drawing.Size(79, 16);
            this.lblStaffId.TabIndex = 25;
            this.lblStaffId.Text = "Customer Id";
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Reservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "reservation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Reservation_FormClosed);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservation)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvReservation;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbBookingState;
        private System.Windows.Forms.Label lblBookingState;
        private System.Windows.Forms.ComboBox cmbTableId;
        private System.Windows.Forms.TextBox txtSearchByTableNumber;
        private System.Windows.Forms.Label lblSearchByTableNumber;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtpResevationTime;
        private System.Windows.Forms.TextBox txtCustomerContactNumber;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label lblStaffPosition;
        private System.Windows.Forms.Label lblJoiningDate;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.Label lblStaffId;
        private System.Windows.Forms.Button btnNextToChooseFood;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerContactNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableId;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingState;
        private System.Windows.Forms.Label label1;
    }
}