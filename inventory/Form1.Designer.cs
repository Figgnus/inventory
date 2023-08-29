namespace inventory
{
	partial class Invetory
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
			this.inventoryLabel = new System.Windows.Forms.Label();
			this.priceTB = new System.Windows.Forms.TextBox();
			this.inventoryGridView = new System.Windows.Forms.DataGridView();
			this.newB = new System.Windows.Forms.Button();
			this.saveB = new System.Windows.Forms.Button();
			this.deleteB = new System.Windows.Forms.Button();
			this.descriptionTB = new System.Windows.Forms.TextBox();
			this.quantityTB = new System.Windows.Forms.TextBox();
			this.SKUTB = new System.Windows.Forms.TextBox();
			this.nameTB = new System.Windows.Forms.TextBox();
			this.categoryCB = new System.Windows.Forms.ComboBox();
			this.skuL = new System.Windows.Forms.Label();
			this.nameL = new System.Windows.Forms.Label();
			this.categoryL = new System.Windows.Forms.Label();
			this.priceL = new System.Windows.Forms.Label();
			this.descriptionL = new System.Windows.Forms.Label();
			this.quantityL = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.inventoryGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// inventoryLabel
			// 
			this.inventoryLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.inventoryLabel.Font = new System.Drawing.Font("Sitka Text", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inventoryLabel.Location = new System.Drawing.Point(12, 9);
			this.inventoryLabel.Name = "inventoryLabel";
			this.inventoryLabel.Size = new System.Drawing.Size(1019, 214);
			this.inventoryLabel.TabIndex = 0;
			this.inventoryLabel.Text = "Inventory Managment";
			this.inventoryLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// priceTB
			// 
			this.priceTB.Location = new System.Drawing.Point(20, 136);
			this.priceTB.Name = "priceTB";
			this.priceTB.Size = new System.Drawing.Size(322, 20);
			this.priceTB.TabIndex = 1;
			// 
			// inventoryGridView
			// 
			this.inventoryGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.inventoryGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.inventoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.inventoryGridView.Location = new System.Drawing.Point(12, 235);
			this.inventoryGridView.Name = "inventoryGridView";
			this.inventoryGridView.Size = new System.Drawing.Size(1019, 486);
			this.inventoryGridView.TabIndex = 2;
			this.inventoryGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inventoryGridView_CellDoubleClick);
			// 
			// newB
			// 
			this.newB.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.newB.Location = new System.Drawing.Point(20, 173);
			this.newB.Name = "newB";
			this.newB.Size = new System.Drawing.Size(322, 37);
			this.newB.TabIndex = 3;
			this.newB.Text = "New";
			this.newB.UseVisualStyleBackColor = true;
			this.newB.Click += new System.EventHandler(this.newB_Click);
			// 
			// saveB
			// 
			this.saveB.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.saveB.Location = new System.Drawing.Point(360, 173);
			this.saveB.Name = "saveB";
			this.saveB.Size = new System.Drawing.Size(322, 37);
			this.saveB.TabIndex = 4;
			this.saveB.Text = "Save";
			this.saveB.UseVisualStyleBackColor = true;
			this.saveB.Click += new System.EventHandler(this.saveB_Click);
			// 
			// deleteB
			// 
			this.deleteB.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.deleteB.Location = new System.Drawing.Point(699, 173);
			this.deleteB.Name = "deleteB";
			this.deleteB.Size = new System.Drawing.Size(322, 37);
			this.deleteB.TabIndex = 5;
			this.deleteB.Text = "Delete";
			this.deleteB.UseVisualStyleBackColor = true;
			this.deleteB.Click += new System.EventHandler(this.deleteB_Click);
			// 
			// descriptionTB
			// 
			this.descriptionTB.Location = new System.Drawing.Point(360, 136);
			this.descriptionTB.Name = "descriptionTB";
			this.descriptionTB.Size = new System.Drawing.Size(322, 20);
			this.descriptionTB.TabIndex = 6;
			// 
			// quantityTB
			// 
			this.quantityTB.Location = new System.Drawing.Point(699, 136);
			this.quantityTB.Name = "quantityTB";
			this.quantityTB.Size = new System.Drawing.Size(322, 20);
			this.quantityTB.TabIndex = 7;
			// 
			// SKUTB
			// 
			this.SKUTB.Location = new System.Drawing.Point(20, 89);
			this.SKUTB.Name = "SKUTB";
			this.SKUTB.Size = new System.Drawing.Size(322, 20);
			this.SKUTB.TabIndex = 8;
			// 
			// nameTB
			// 
			this.nameTB.Location = new System.Drawing.Point(360, 89);
			this.nameTB.Name = "nameTB";
			this.nameTB.Size = new System.Drawing.Size(322, 20);
			this.nameTB.TabIndex = 9;
			// 
			// categoryCB
			// 
			this.categoryCB.FormattingEnabled = true;
			this.categoryCB.Items.AddRange(new object[] {
            "Aoutomitive",
            "Hardwere",
            "Tools"});
			this.categoryCB.Location = new System.Drawing.Point(699, 88);
			this.categoryCB.Name = "categoryCB";
			this.categoryCB.Size = new System.Drawing.Size(322, 21);
			this.categoryCB.TabIndex = 10;
			this.categoryCB.SelectedIndexChanged += new System.EventHandler(this.categoryCB_SelectedIndexChanged);
			// 
			// skuL
			// 
			this.skuL.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.skuL.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.skuL.Location = new System.Drawing.Point(17, 63);
			this.skuL.Name = "skuL";
			this.skuL.Size = new System.Drawing.Size(100, 23);
			this.skuL.TabIndex = 11;
			this.skuL.Text = "SKU:";
			// 
			// nameL
			// 
			this.nameL.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.nameL.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nameL.Location = new System.Drawing.Point(355, 63);
			this.nameL.Name = "nameL";
			this.nameL.Size = new System.Drawing.Size(100, 23);
			this.nameL.TabIndex = 12;
			this.nameL.Text = "Name:";
			// 
			// categoryL
			// 
			this.categoryL.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.categoryL.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.categoryL.Location = new System.Drawing.Point(694, 63);
			this.categoryL.Name = "categoryL";
			this.categoryL.Size = new System.Drawing.Size(100, 23);
			this.categoryL.TabIndex = 13;
			this.categoryL.Text = "Category:";
			// 
			// priceL
			// 
			this.priceL.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.priceL.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.priceL.Location = new System.Drawing.Point(17, 110);
			this.priceL.Name = "priceL";
			this.priceL.Size = new System.Drawing.Size(100, 23);
			this.priceL.TabIndex = 14;
			this.priceL.Text = "Price:";
			// 
			// descriptionL
			// 
			this.descriptionL.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.descriptionL.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.descriptionL.Location = new System.Drawing.Point(355, 110);
			this.descriptionL.Name = "descriptionL";
			this.descriptionL.Size = new System.Drawing.Size(100, 23);
			this.descriptionL.TabIndex = 15;
			this.descriptionL.Text = "Description:";
			// 
			// quantityL
			// 
			this.quantityL.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.quantityL.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.quantityL.Location = new System.Drawing.Point(694, 110);
			this.quantityL.Name = "quantityL";
			this.quantityL.Size = new System.Drawing.Size(100, 23);
			this.quantityL.TabIndex = 16;
			this.quantityL.Text = "Quantity:";
			// 
			// Invetory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ClientSize = new System.Drawing.Size(1043, 724);
			this.Controls.Add(this.quantityL);
			this.Controls.Add(this.descriptionL);
			this.Controls.Add(this.priceL);
			this.Controls.Add(this.categoryL);
			this.Controls.Add(this.nameL);
			this.Controls.Add(this.skuL);
			this.Controls.Add(this.categoryCB);
			this.Controls.Add(this.nameTB);
			this.Controls.Add(this.SKUTB);
			this.Controls.Add(this.quantityTB);
			this.Controls.Add(this.descriptionTB);
			this.Controls.Add(this.deleteB);
			this.Controls.Add(this.saveB);
			this.Controls.Add(this.newB);
			this.Controls.Add(this.inventoryGridView);
			this.Controls.Add(this.priceTB);
			this.Controls.Add(this.inventoryLabel);
			this.Name = "Invetory";
			this.Text = "Inventory";
			this.Load += new System.EventHandler(this.Invetory_Load);
			((System.ComponentModel.ISupportInitialize)(this.inventoryGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label inventoryLabel;
		private System.Windows.Forms.TextBox priceTB;
		private System.Windows.Forms.DataGridView inventoryGridView;
		private System.Windows.Forms.Button newB;
		private System.Windows.Forms.Button saveB;
		private System.Windows.Forms.Button deleteB;
		private System.Windows.Forms.TextBox descriptionTB;
		private System.Windows.Forms.TextBox quantityTB;
		private System.Windows.Forms.TextBox SKUTB;
		private System.Windows.Forms.TextBox nameTB;
		private System.Windows.Forms.ComboBox categoryCB;
		private System.Windows.Forms.Label skuL;
		private System.Windows.Forms.Label nameL;
		private System.Windows.Forms.Label categoryL;
		private System.Windows.Forms.Label priceL;
		private System.Windows.Forms.Label descriptionL;
		private System.Windows.Forms.Label quantityL;
	}
}

