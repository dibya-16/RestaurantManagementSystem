
namespace RestaurantManagementSystem
{
    partial class ManagerDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerDetails));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvManagerDetails = new System.Windows.Forms.DataGridView();
            this.ManagerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManagerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManagerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManagerNID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JoiningDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.dtpJoiningDate = new System.Windows.Forms.DateTimePicker();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSearchByID = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.txtManagerNID = new System.Windows.Forms.TextBox();
            this.txtManagerAddress = new System.Windows.Forms.TextBox();
            this.txtManagerName = new System.Windows.Forms.TextBox();
            this.txtManagerId = new System.Windows.Forms.TextBox();
            this.lblSearchByID = new System.Windows.Forms.Label();
            this.lblJoiningDate = new System.Windows.Forms.Label();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.lblManagerNID = new System.Windows.Forms.Label();
            this.lblManagerAddress = new System.Windows.Forms.Label();
            this.lblManagerName = new System.Windows.Forms.Label();
            this.lblManagerID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManagerDetails)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvManagerDetails);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 504);
            this.panel1.TabIndex = 0;
            // 
            // dgvManagerDetails
            // 
            this.dgvManagerDetails.AllowUserToAddRows = false;
            this.dgvManagerDetails.AllowUserToDeleteRows = false;
            this.dgvManagerDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManagerDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ManagerId,
            this.ManagerName,
            this.ManagerAddress,
            this.ManagerNID,
            this.ContactNumber,
            this.JoiningDate,
            this.Salary});
            this.dgvManagerDetails.Location = new System.Drawing.Point(1, 254);
            this.dgvManagerDetails.Name = "dgvManagerDetails";
            this.dgvManagerDetails.ReadOnly = true;
            this.dgvManagerDetails.Size = new System.Drawing.Size(818, 250);
            this.dgvManagerDetails.TabIndex = 0;
            this.dgvManagerDetails.DoubleClick += new System.EventHandler(this.dgvManagerDetails_DoubleClick);
            // 
            // ManagerId
            // 
            this.ManagerId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ManagerId.DataPropertyName = "ManagerId";
            this.ManagerId.HeaderText = "Manager Id";
            this.ManagerId.Name = "ManagerId";
            this.ManagerId.ReadOnly = true;
            // 
            // ManagerName
            // 
            this.ManagerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ManagerName.DataPropertyName = "ManagerName";
            this.ManagerName.HeaderText = "Manager Name";
            this.ManagerName.Name = "ManagerName";
            this.ManagerName.ReadOnly = true;
            // 
            // ManagerAddress
            // 
            this.ManagerAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ManagerAddress.DataPropertyName = "ManagerAddress";
            this.ManagerAddress.HeaderText = "Manager Address";
            this.ManagerAddress.Name = "ManagerAddress";
            this.ManagerAddress.ReadOnly = true;
            // 
            // ManagerNID
            // 
            this.ManagerNID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ManagerNID.DataPropertyName = "ManagerNID";
            this.ManagerNID.HeaderText = "Manager NID";
            this.ManagerNID.Name = "ManagerNID";
            this.ManagerNID.ReadOnly = true;
            // 
            // ContactNumber
            // 
            this.ContactNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ContactNumber.DataPropertyName = "ContactNumber";
            this.ContactNumber.HeaderText = "Contact Number";
            this.ContactNumber.Name = "ContactNumber";
            this.ContactNumber.ReadOnly = true;
            // 
            // JoiningDate
            // 
            this.JoiningDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.JoiningDate.DataPropertyName = "JoiningDate";
            this.JoiningDate.HeaderText = "Joining Date";
            this.JoiningDate.Name = "JoiningDate";
            this.JoiningDate.ReadOnly = true;
            // 
            // Salary
            // 
            this.Salary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Salary.DataPropertyName = "Salary";
            this.Salary.HeaderText = "Salary";
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.txtSalary);
            this.panel2.Controls.Add(this.lblSalary);
            this.panel2.Controls.Add(this.dtpJoiningDate);
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnRemove);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.txtSearchByID);
            this.panel2.Controls.Add(this.txtContactNumber);
            this.panel2.Controls.Add(this.txtManagerNID);
            this.panel2.Controls.Add(this.txtManagerAddress);
            this.panel2.Controls.Add(this.txtManagerName);
            this.panel2.Controls.Add(this.txtManagerId);
            this.panel2.Controls.Add(this.lblSearchByID);
            this.panel2.Controls.Add(this.lblJoiningDate);
            this.panel2.Controls.Add(this.lblContactNumber);
            this.panel2.Controls.Add(this.lblManagerNID);
            this.panel2.Controls.Add(this.lblManagerAddress);
            this.panel2.Controls.Add(this.lblManagerName);
            this.panel2.Controls.Add(this.lblManagerID);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(819, 262);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(366, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(373, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "year-month-day";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(741, 14);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 28;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(116, 228);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(121, 20);
            this.txtSalary.TabIndex = 27;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(25, 235);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(36, 13);
            this.lblSalary.TabIndex = 26;
            this.lblSalary.Text = "Salary";
            // 
            // dtpJoiningDate
            // 
            this.dtpJoiningDate.CustomFormat = "yyyy-MM-dd";
            this.dtpJoiningDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpJoiningDate.Location = new System.Drawing.Point(116, 192);
            this.dtpJoiningDate.Name = "dtpJoiningDate";
            this.dtpJoiningDate.Size = new System.Drawing.Size(121, 20);
            this.dtpJoiningDate.TabIndex = 25;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(732, 236);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 24;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(651, 236);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(570, 235);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 22;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(489, 236);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSearchByID
            // 
            this.txtSearchByID.Location = new System.Drawing.Point(346, 235);
            this.txtSearchByID.Name = "txtSearchByID";
            this.txtSearchByID.Size = new System.Drawing.Size(110, 20);
            this.txtSearchByID.TabIndex = 19;
            this.txtSearchByID.TextChanged += new System.EventHandler(this.txtSearchByID_TextChanged);
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(116, 154);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(121, 20);
            this.txtContactNumber.TabIndex = 18;
            // 
            // txtManagerNID
            // 
            this.txtManagerNID.Location = new System.Drawing.Point(116, 115);
            this.txtManagerNID.Name = "txtManagerNID";
            this.txtManagerNID.Size = new System.Drawing.Size(121, 20);
            this.txtManagerNID.TabIndex = 17;
            // 
            // txtManagerAddress
            // 
            this.txtManagerAddress.Location = new System.Drawing.Point(116, 82);
            this.txtManagerAddress.Name = "txtManagerAddress";
            this.txtManagerAddress.Size = new System.Drawing.Size(121, 20);
            this.txtManagerAddress.TabIndex = 16;
            // 
            // txtManagerName
            // 
            this.txtManagerName.Location = new System.Drawing.Point(116, 49);
            this.txtManagerName.Name = "txtManagerName";
            this.txtManagerName.Size = new System.Drawing.Size(121, 20);
            this.txtManagerName.TabIndex = 15;
            // 
            // txtManagerId
            // 
            this.txtManagerId.Location = new System.Drawing.Point(116, 12);
            this.txtManagerId.Name = "txtManagerId";
            this.txtManagerId.Size = new System.Drawing.Size(121, 20);
            this.txtManagerId.TabIndex = 14;
            // 
            // lblSearchByID
            // 
            this.lblSearchByID.AutoSize = true;
            this.lblSearchByID.Location = new System.Drawing.Point(258, 238);
            this.lblSearchByID.Name = "lblSearchByID";
            this.lblSearchByID.Size = new System.Drawing.Size(70, 13);
            this.lblSearchByID.TabIndex = 13;
            this.lblSearchByID.Text = "Search By ID";
            // 
            // lblJoiningDate
            // 
            this.lblJoiningDate.AutoSize = true;
            this.lblJoiningDate.Location = new System.Drawing.Point(20, 199);
            this.lblJoiningDate.Name = "lblJoiningDate";
            this.lblJoiningDate.Size = new System.Drawing.Size(66, 13);
            this.lblJoiningDate.TabIndex = 12;
            this.lblJoiningDate.Text = "Joining Date";
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Location = new System.Drawing.Point(20, 161);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(84, 13);
            this.lblContactNumber.TabIndex = 11;
            this.lblContactNumber.Text = "Contact Number";
            // 
            // lblManagerNID
            // 
            this.lblManagerNID.AutoSize = true;
            this.lblManagerNID.Location = new System.Drawing.Point(20, 118);
            this.lblManagerNID.Name = "lblManagerNID";
            this.lblManagerNID.Size = new System.Drawing.Size(71, 13);
            this.lblManagerNID.TabIndex = 10;
            this.lblManagerNID.Text = "Manager NID";
            // 
            // lblManagerAddress
            // 
            this.lblManagerAddress.AutoSize = true;
            this.lblManagerAddress.Location = new System.Drawing.Point(20, 85);
            this.lblManagerAddress.Name = "lblManagerAddress";
            this.lblManagerAddress.Size = new System.Drawing.Size(90, 13);
            this.lblManagerAddress.TabIndex = 9;
            this.lblManagerAddress.Text = "Manager Address";
            // 
            // lblManagerName
            // 
            this.lblManagerName.AutoSize = true;
            this.lblManagerName.Location = new System.Drawing.Point(20, 52);
            this.lblManagerName.Name = "lblManagerName";
            this.lblManagerName.Size = new System.Drawing.Size(80, 13);
            this.lblManagerName.TabIndex = 8;
            this.lblManagerName.Text = "Manager Name";
            // 
            // lblManagerID
            // 
            this.lblManagerID.AutoSize = true;
            this.lblManagerID.Location = new System.Drawing.Point(20, 19);
            this.lblManagerID.Name = "lblManagerID";
            this.lblManagerID.Size = new System.Drawing.Size(61, 13);
            this.lblManagerID.TabIndex = 7;
            this.lblManagerID.Text = "Manager Id";
            // 
            // ManagerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 504);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "ManagerDetails";
            this.Text = "ManagerDetails";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManagerDetails_FormClosed);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManagerDetails)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvManagerDetails;
        private System.Windows.Forms.DateTimePicker dtpJoiningDate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtSearchByID;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.TextBox txtManagerNID;
        private System.Windows.Forms.TextBox txtManagerAddress;
        private System.Windows.Forms.TextBox txtManagerName;
        private System.Windows.Forms.TextBox txtManagerId;
        private System.Windows.Forms.Label lblSearchByID;
        private System.Windows.Forms.Label lblJoiningDate;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.Label lblManagerNID;
        private System.Windows.Forms.Label lblManagerAddress;
        private System.Windows.Forms.Label lblManagerName;
        private System.Windows.Forms.Label lblManagerID;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManagerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManagerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManagerAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManagerNID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn JoiningDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}