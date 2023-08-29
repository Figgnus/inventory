using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory
{
	public partial class Invetory : Form
	{
		DataTable inventory = new DataTable();
		public Invetory()
		{
			InitializeComponent();
		}

		private void newB_Click(object sender, EventArgs e)
		{
			SKUTB.Text = "";
			nameTB.Text = "";
			priceTB.Text = "";
			descriptionTB.Text = "";
			quantityTB.Text = "";
			categoryCB.SelectedIndex = -1;
		}

		private void saveB_Click(object sender, EventArgs e)
		{
			String sku = SKUTB.Text;
			String name = nameTB.Text;
			String price = priceTB.Text;
			String quantity = quantityTB.Text;
			String description = descriptionTB.Text;

			String category = (string)categoryCB.SelectedItem;
			//add values to database
			inventory.Rows.Add(sku, name, category, price, description, quantity );	
			//clear fields
			newB_Click(sender, e);
		}

		private void deleteB_Click(object sender, EventArgs e)
		{
			try
			{
				inventory.Rows[inventoryGridView.CurrentCell.RowIndex].Delete();
			}
			catch(Exception ex)
			{
				
				Console.WriteLine("Error: " + ex);
			}
		}

		private void inventoryGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				SKUTB.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[0].ToString();	
				nameTB.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[1].ToString();	
				priceTB.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[3].ToString();	
				descriptionTB.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[4].ToString();	
				quantityTB.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[5].ToString();	

				String itemToLookFor = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[2].ToString();
				categoryCB.SelectedIndex = categoryCB.Items.IndexOf(itemToLookFor);
			}
			catch( Exception ex) { Console.WriteLine(ex); }
		}

		private void Invetory_Load(object sender, EventArgs e)
		{
			inventory.Columns.Add("SKU");
			inventory.Columns.Add("Name");
			inventory.Columns.Add("Category");
			inventory.Columns.Add("Price");
			inventory.Columns.Add("Description");
			inventory.Columns.Add("Quantity");

			inventoryGridView.DataSource = inventory;
		}

		private void categoryCB_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
