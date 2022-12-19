
namespace RestaurantManagementSystem
{
    partial class StaffDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffDetails));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvStaffDetails = new System.Windows.Forms.DataGridView();
            this.StaffId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffNID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JoiningDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblStaffId = new System.Windows.Forms.Label();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.lblStaffAddress = new System.Windows.Forms.Label();
            this.lblStaffNID = new System.Windows.Forms.Label();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.lblJoiningDate = new System.Windows.Forms.Label();
            this.lblStaffPosition = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtStaffId = new System.Windows.Forms.TextBox();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.txtStaffAddress = new System.Windows.Forms.TextBox();
            this.txtStaffNID = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.txtStaffPosition = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.dtpJoiningDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblSearchById = new System.Windows.Forms.Label();
            this.txtSearchByTableNumber = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvStaffDetails);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 263);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 218);
            this.panel1.TabIndex = 0;
            // 
            // dgvStaffDetails
            // 
            this.dgvStaffDetails.AllowUserToAddRows = false;
            this.dgvStaffDetails.AllowUserToDeleteRows = false;
            this.dgvStaffDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaffDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StaffId,
            this.StaffName,
            this.StaffAddress,
            this.StaffNID,
            this.ContactNumber,
            this.JoiningDate,
            this.StaffPosition,
            this.Salary});
            this.dgvStaffDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStaffDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvStaffDetails.Name = "dgvStaffDetails";
            this.dgvStaffDetails.ReadOnly = true;
            this.dgvStaffDetails.Size = new System.Drawing.Size(869, 218);
            this.dgvStaffDetails.TabIndex = 0;
            this.dgvStaffDetails.DoubleClick += new System.EventHandler(this.dgvStaffDetails_DoubleClick);
            // 
            // StaffId
            // 
            this.StaffId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StaffId.DataPropertyName = "StaffId";
            this.StaffId.HeaderText = "Staff Id";
            this.StaffId.Name = "StaffId";
            this.StaffId.ReadOnly = true;
            // 
            // StaffName
            // 
            this.StaffName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StaffName.DataPropertyName = "StaffName";
            this.StaffName.HeaderText = "Staff Name";
            this.StaffName.Name = "StaffName";
            this.StaffName.ReadOnly = true;
            // 
            // StaffAddress
            // 
            this.StaffAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StaffAddress.DataPropertyName = "StaffAddress";
            this.StaffAddress.HeaderText = "Staff Address";
            this.StaffAddress.Name = "StaffAddress";
            this.StaffAddress.ReadOnly = true;
            // 
            // StaffNID
            // 
            this.StaffNID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StaffNID.DataPropertyName = "StaffNID";
            this.StaffNID.HeaderText = "Staff NID";
            this.StaffNID.Name = "StaffNID";
            this.StaffNID.ReadOnly = true;
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
            // StaffPosition
            // 
            this.StaffPosition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StaffPosition.DataPropertyName = "StaffPosition";
            this.StaffPosition.HeaderText = "Staff Position";
            this.StaffPosition.Name = "StaffPosition";
            this.StaffPosition.ReadOnly = true;
            // 
            // Salary
            // 
            this.Salary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Salary.DataPropertyName = "Salary";
            this.Salary.HeaderText = "Salary";
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            // 
            // lblStaffId
            // 
            this.lblStaffId.AutoSize = true;
            this.lblStaffId.Location = new System.Drawing.Point(12, 19);
            this.lblStaffId.Name = "lblStaffId";
            this.lblStaffId.Size = new System.Drawing.Size(41, 13);
            this.lblStaffId.TabIndex = 1;
            this.lblStaffId.Text = "Staff Id";
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Location = new System.Drawing.Point(12, 54);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(60, 13);
            this.lblStaffName.TabIndex = 2;
            this.lblStaffName.Text = "Staff Name";
            // 
            // lblStaffAddress
            // 
            this.lblStaffAddress.AutoSize = true;
            this.lblStaffAddress.Location = new System.Drawing.Point(12, 82);
            this.lblStaffAddress.Name = "lblStaffAddress";
            this.lblStaffAddress.Size = new System.Drawing.Size(70, 13);
            this.lblStaffAddress.TabIndex = 3;
            this.lblStaffAddress.Text = "Staff Address";
            // 
            // lblStaffNID
            // 
            this.lblStaffNID.AutoSize = true;
            this.lblStaffNID.Location = new System.Drawing.Point(12, 114);
            this.lblStaffNID.Name = "lblStaffNID";
            this.lblStaffNID.Size = new System.Drawing.Size(51, 13);
            this.lblStaffNID.TabIndex = 4;
            this.lblStaffNID.Text = "Staff NID";
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Location = new System.Drawing.Point(12, 142);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(84, 13);
            this.lblContactNumber.TabIndex = 5;
            this.lblContactNumber.Text = "Contact Number";
            // 
            // lblJoiningDate
            // 
            this.lblJoiningDate.AutoSize = true;
            this.lblJoiningDate.Location = new System.Drawing.Point(12, 176);
            this.lblJoiningDate.Name = "lblJoiningDate";
            this.lblJoiningDate.Size = new System.Drawing.Size(66, 13);
            this.lblJoiningDate.TabIndex = 6;
            this.lblJoiningDate.Text = "Joining Date";
            // 
            // lblStaffPosition
            // 
            this.lblStaffPosition.AutoSize = true;
            this.lblStaffPosition.Location = new System.Drawing.Point(12, 204);
            this.lblStaffPosition.Name = "lblStaffPosition";
            this.lblStaffPosition.Size = new System.Drawing.Size(69, 13);
            this.lblStaffPosition.TabIndex = 7;
            this.lblStaffPosition.Text = "Staff Position";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(12, 240);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(36, 13);
            this.lblSalary.TabIndex = 8;
            this.lblSalary.Text = "Salary";
            // 
            // txtStaffId
            // 
            this.txtStaffId.Location = new System.Drawing.Point(102, 16);
            this.txtStaffId.Name = "txtStaffId";
            this.txtStaffId.Size = new System.Drawing.Size(115, 20);
            this.txtStaffId.TabIndex = 9;
            // 
            // txtStaffName
            // 
            this.txtStaffName.Location = new System.Drawing.Point(102, 51);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(115, 20);
            this.txtStaffName.TabIndex = 10;
            // 
            // txtStaffAddress
            // 
            this.txtStaffAddress.Location = new System.Drawing.Point(102, 79);
            this.txtStaffAddress.Name = "txtStaffAddress";
            this.txtStaffAddress.Size = new System.Drawing.Size(115, 20);
            this.txtStaffAddress.TabIndex = 11;
            // 
            // txtStaffNID
            // 
            this.txtStaffNID.Location = new System.Drawing.Point(102, 108);
            this.txtStaffNID.Name = "txtStaffNID";
            this.txtStaffNID.Size = new System.Drawing.Size(115, 20);
            this.txtStaffNID.TabIndex = 12;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(102, 139);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(115, 20);
            this.txtContactNumber.TabIndex = 13;
            // 
            // txtStaffPosition
            // 
            this.txtStaffPosition.Location = new System.Drawing.Point(102, 204);
            this.txtStaffPosition.Name = "txtStaffPosition";
            this.txtStaffPosition.Size = new System.Drawing.Size(115, 20);
            this.txtStaffPosition.TabIndex = 15;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(102, 237);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(115, 20);
            this.txtSalary.TabIndex = 16;
            // 
            // dtpJoiningDate
            // 
            this.dtpJoiningDate.CustomFormat = "yyyy-MM-dd";
            this.dtpJoiningDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpJoiningDate.Location = new System.Drawing.Point(102, 176);
            this.dtpJoiningDate.Name = "dtpJoiningDate";
            this.dtpJoiningDate.Size = new System.Drawing.Size(115, 20);
            this.dtpJoiningDate.TabIndex = 17;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(530, 235);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(611, 235);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 19;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(692, 235);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "CLear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(782, 235);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 21;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(782, 9);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // lblSearchById
            // 
            this.lblSearchById.AutoSize = true;
            this.lblSearchById.Location = new System.Drawing.Point(272, 240);
            this.lblSearchById.Name = "lblSearchById";
            this.lblSearchById.Size = new System.Drawing.Size(68, 13);
            this.lblSearchById.TabIndex = 23;
            this.lblSearchById.Text = "Search By Id";
            // 
            // txtSearchByTableNumber
            // 
            this.txtSearchByTableNumber.Location = new System.Drawing.Point(356, 237);
            this.txtSearchByTableNumber.Name = "txtSearchByTableNumber";
            this.txtSearchByTableNumber.Size = new System.Drawing.Size(119, 20);
            this.txtSearchByTableNumber.TabIndex = 24;
            this.txtSearchByTableNumber.TextChanged += new System.EventHandler(this.txtSearchById_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(236, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(540, 215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // StaffDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(869, 481);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSearchByTableNumber);
            this.Controls.Add(this.lblSearchById);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpJoiningDate);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtStaffPosition);
            this.Controls.Add(this.txtContactNumber);
            this.Controls.Add(this.txtStaffNID);
            this.Controls.Add(this.txtStaffAddress);
            this.Controls.Add(this.txtStaffName);
            this.Controls.Add(this.txtStaffId);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblStaffPosition);
            this.Controls.Add(this.lblJoiningDate);
            this.Controls.Add(this.lblContactNumber);
            this.Controls.Add(this.lblStaffNID);
            this.Controls.Add(this.lblStaffAddress);
            this.Controls.Add(this.lblStaffName);
            this.Controls.Add(this.lblStaffId);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "StaffDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffDetails";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StaffDetails_FormClosed);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStaffId;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.Label lblStaffAddress;
        private System.Windows.Forms.Label lblStaffNID;
        private System.Windows.Forms.DataGridView dgvStaffDetails;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.Label lblJoiningDate;
        private System.Windows.Forms.Label lblStaffPosition;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtStaffId;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.TextBox txtStaffAddress;
        private System.Windows.Forms.TextBox txtStaffNID;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.TextBox txtStaffPosition;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.DateTimePicker dtpJoiningDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffNID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn JoiningDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblSearchById;
        private System.Windows.Forms.TextBox txtSearchByTableNumber;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}