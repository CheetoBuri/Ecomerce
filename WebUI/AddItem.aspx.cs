using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DAL.Models;

namespace WebUI
{
    public partial class AddItem : System.Web.UI.Page
    {
        private ItemService itemService = new ItemService();

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            var item = new Item
            {
                ItemName = txtItemName.Text,
                Size = txtSize.Text
            };

            itemService.AddItem(item);
            lblMessage.Text = "Item added successfully!";
            txtItemName.Text = "";
            txtSize.Text = "";
        }
    }
}