using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace WebUI
{
    public partial class Item : System.Web.UI.Page
    {
        private ItemService _itemService = new ItemService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Bind the data to the GridView when the page loads
                BindItems();
            }
        }

        private void BindItems()
        {
            // Get all items from the ItemService
            var items = _itemService.GetAllItems();

            // Bind the items to the GridView
            gvItems.DataSource = items;
            gvItems.DataBind();
        }
    }
}