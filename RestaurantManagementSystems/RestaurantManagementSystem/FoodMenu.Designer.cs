
namespace RestaurantManagementSystem
{
    partial class FoodMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvFoodMenu = new System.Windows.Forms.DataGridView();
            this.foodItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnFoodDetails = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodMenu)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvFoodMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 209);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 267);
            this.panel1.TabIndex = 0;
            // 
            // dgvFoodMenu
            // 
            this.dgvFoodMenu.AllowUserToAddRows = false;
            this.dgvFoodMenu.AllowUserToDeleteRows = false;
            this.dgvFoodMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.foodItem,
            this.foodCost,
            this.category});
            this.dgvFoodMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFoodMenu.Location = new System.Drawing.Point(0, 0);
            this.dgvFoodMenu.Name = "dgvFoodMenu";
            this.dgvFoodMenu.ReadOnly = true;
            this.dgvFoodMenu.Size = new System.Drawing.Size(794, 267);
            this.dgvFoodMenu.TabIndex = 0;
            // 
            // foodItem
            // 
            this.foodItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.foodItem.DataPropertyName = "foodItem";
            this.foodItem.HeaderText = "Food Item";
            this.foodItem.Name = "foodItem";
            this.foodItem.ReadOnly = true;
            // 
            // foodCost
            // 
            this.foodCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.foodCost.DataPropertyName = "foodCost";
            this.foodCost.HeaderText = "Food Cost";
            this.foodCost.Name = "foodCost";
            this.foodCost.ReadOnly = true;
            // 
            // category
            // 
            this.category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.category.DataPropertyName = "category";
            this.category.HeaderText = "Category";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            // 
            // panel
            // 
            this.panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel.BackgroundImage")));
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.btnBack);
            this.panel.Controls.Add(this.btnSearch);
            this.panel.Controls.Add(this.txtSearch);
            this.panel.Controls.Add(this.btnFoodDetails);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(794, 211);
            this.panel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Search By Food Item or Category ";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(722, 8);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(60, 23);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(183, 182);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 184);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(165, 20);
            this.txtSearch.TabIndex = 6;
            // 
            // btnFoodDetails
            // 
            this.btnFoodDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoodDetails.Location = new System.Drawing.Point(661, 178);
            this.btnFoodDetails.Name = "btnFoodDetails";
            this.btnFoodDetails.Size = new System.Drawing.Size(121, 23);
            this.btnFoodDetails.TabIndex = 4;
            this.btnFoodDetails.Text = "Food Details >>";
            this.btnFoodDetails.UseVisualStyleBackColor = true;
            this.btnFoodDetails.Click += new System.EventHandler(this.btnFoodDetails_Click);
            // 
            // FoodMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 476);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FoodMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "foodMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FoodMenu_FormClosed);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodMenu)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnFoodDetails;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvFoodMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.Label label1;
    }
}