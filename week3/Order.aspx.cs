using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using week3.Models;
using System.Data;
namespace week3
{
    public partial class Order : System.Web.UI.Page
    {
        private Product selectedProduct;
        private CartitemList itemList = new CartitemList();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownList1.DataBind();
            }
            selectedProduct = this.GetSelectedProduct();

            lblName.Text = selectedProduct.Name;
            lblShortDescription.Text = selectedProduct.ShortDescription;
            lblLongDescription.Text = selectedProduct.LongDescription;
            lblUnitPrice.Text = selectedProduct.UnitPrice.ToString("c") + "each";

            imgProduct.ImageUrl = "Images/Products/" + selectedProduct.ImageFile;

            if ((CartitemList)Session["CartitemList"] != null)
            {
                itemList = (CartitemList)Session["CartitemList"];
            }
           
        }


        private Product GetSelectedProduct()
        {
            DataView productsTable = (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);
            productsTable.RowFilter = string.Format("ProductID = '{0}'", DropDownList1.SelectedValue);
            DataRowView row = productsTable[0];



            Product p = new Product();
            p.Name = row["Name"].ToString();
            p.ShortDescription = row["ShortDescription"].ToString(); ;
            p.LongDescription = row["LongDescription"].ToString(); ;
            p.UnitPrice = (decimal)row["UnitPrice"];
          
            p.ImageFile = row["ImageFile"].ToString(); 

            return p;
 
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
          //  Cartitem lol = new Cartitem(selectedProduct, Convert.ToInt32(txtQuantity.Text));
          //  Session["CartItem"]= lol;
            itemList.AddItem(selectedProduct,Convert.ToInt32(txtQuantity.Text));
            Session["CartitemList"] = itemList;
            LblTotal.Text = "purchasing " + txtQuantity.Text+" " + lblName.Text;
        }
    }
}