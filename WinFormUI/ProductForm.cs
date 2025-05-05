using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL.Models;

namespace WinFormUI
{
    public partial class ProductForm : Form
    {
        private ItemService itemService;
        public ProductForm()
        {
            InitializeComponent();
            itemService = new ItemService();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var item = new Item
            {
                ItemName = txtItemName.Text,
                Size = txtSize.Text,
                Price = decimal.Parse(txtPrice.Text)
            };

            itemService.AddItem(item);
            MessageBox.Show("Product saved!");
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
