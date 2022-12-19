
namespace RestaurantManagementSystem
{
    partial class Owner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Owner));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExpenses = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnStaffDetails = new System.Windows.Forms.Button();
            this.btnManagerDetails = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnExpenses);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnStaffDetails);
            this.panel1.Controls.Add(this.btnManagerDetails);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 397);
            this.panel1.TabIndex = 0;
            // 
            // btnExpenses
            // 
            this.btnExpenses.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpenses.Location = new System.Drawing.Point(130, 151);
            this.btnExpenses.Name = "btnExpenses";
            this.btnExpenses.Size = new System.Drawing.Size(134, 33);
            this.btnExpenses.TabIndex = 4;
            this.btnExpenses.Text = "Expenses";
            this.btnExpenses.UseVisualStyleBackColor = false;
            this.btnExpenses.Click += new System.EventHandler(this.btnExpenses_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SlateBlue;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(234, 362);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(95, 26);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnStaffDetails
            // 
            this.btnStaffDetails.BackColor = System.Drawing.Color.Azure;
            this.btnStaffDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffDetails.Location = new System.Drawing.Point(130, 224);
            this.btnStaffDetails.Name = "btnStaffDetails";
            this.btnStaffDetails.Size = new System.Drawing.Size(134, 30);
            this.btnStaffDetails.TabIndex = 1;
            this.btnStaffDetails.Text = "Staff Details";
            this.btnStaffDetails.UseVisualStyleBackColor = false;
            this.btnStaffDetails.Click += new System.EventHandler(this.btnStaffDetails_Click);
            // 
            // btnManagerDetails
            // 
            this.btnManagerDetails.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnManagerDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagerDetails.Location = new System.Drawing.Point(130, 77);
            this.btnManagerDetails.Name = "btnManagerDetails";
            this.btnManagerDetails.Size = new System.Drawing.Size(134, 36);
            this.btnManagerDetails.TabIndex = 0;
            this.btnManagerDetails.Text = "Manager Details";
            this.btnManagerDetails.UseVisualStyleBackColor = false;
            this.btnManagerDetails.Click += new System.EventHandler(this.btnManagerDetails_Click);
            // 
            // Owner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 402);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Owner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Owner";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Owner_FormClosed);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnStaffDetails;
        private System.Windows.Forms.Button btnManagerDetails;
        private System.Windows.Forms.Button btnExpenses;
    }
}