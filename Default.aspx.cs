using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace Rachel_eCommerce
{
    public partial class Default : System.Web.UI.Page
    {
        public static string websiteData = HttpContext.Current.Server.MapPath(".") + @"/data/products";
        public static int[] cartInfo = new int[10];
        public static int numItems = 0;
        public static string[] fileList;

        public static string[] pics;
        public static string[] descrip;
        public static string[] price;
        public static string[] qty = new string [100];
        public static string[] qtyOnHand;
        public static string[] code;

        public static string[] show;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ResetArrays();

                for (int i = 0; i < fileList.Length; i++)
                    qty[i] = "1";

                    show = new string[fileList.Length];

                    for (int i = 0; i < fileList.Length; i++)
                    {
                        show[i] = "added";
                    }  
            }

        }

        protected void btnCustomers_Click(object sender, EventArgs e)
        {
            myFrame.Attributes.Add("src", "Customers.aspx");
        }

        protected void btnProducts_Click(object sender, EventArgs e)
        {
           myFrame.Attributes.Add("src", "Products.aspx");
        }

        protected void btnPromoPage_Click(object sender, EventArgs e)
        {
            myFrame.Attributes.Add("src", "PromoPage.aspx");
        }

        protected void btnCatalog_Click(object sender, EventArgs e)
        {
            myFrame.Attributes.Add("src", "catalogue.aspx");
        }

        protected void btnCart_Click(object sender, EventArgs e)
        {
            myFrame.Attributes.Add("src", "cart.aspx");
        }

        public static void ResetArrays()
        {
            fileList = Directory.GetFiles(websiteData, "*.*");

            pics = new string[fileList.Length];
            descrip = new string[fileList.Length];
            price = new string[fileList.Length];
            code = new string[fileList.Length];
            qtyOnHand = new string[fileList.Length];     
        }
    }
}