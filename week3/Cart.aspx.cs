using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using week3.Models;


namespace week3
{
    public partial class Cart : System.Web.UI.Page
    {
         
        private CartitemList itemList = new CartitemList();
        protected void Page_Load(object sender, EventArgs e)
        {      
            if ((CartitemList)Session["CartitemList"] != null)
            {
                itemList = (CartitemList)Session["CartitemList"]; 
            }
            if (!IsPostBack)
            { 
                DisplayCart();
            }

            //     = (Cartitem)Session["Cartitem"];
            //    if (myCartItem != null)
            //   {
            //     lstCart.Items.Add(myCartItem.Display());
            //  }
        }
        public void DisplayCart()
        {
           lstCart.Items.Clear();
           
             for(int i = 0; i<itemList.Count(); i++)
            {
                Cartitem itemToDisplay = itemList.itemAt(i);
                 lstCart.Items.Add(itemToDisplay.Display());
               }
           

        }

        protected void btnEmpty_Click(object sender, EventArgs e)
        {
            itemList.Clear();
            lstCart.Items.Clear();
        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {
            int num = lstCart.SelectedIndex;
            if (lstCart.SelectedIndex > -1 && lstCart.SelectedIndex < itemList.Count())
            {
                itemList.RemoveAt(num);
            }
            this.DisplayCart();

        }
    }
}