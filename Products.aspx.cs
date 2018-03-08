using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace Rachel_eCommerce
{
    public partial class Products : System.Web.UI.Page
    {
        public static string webSitePics = HttpContext.Current.Server.MapPath(".") + @"\pictures";  

        public static string webSiteData = HttpContext.Current.Server.MapPath(".") + @"\data\products\";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string[] fileList = Directory.GetFiles(webSitePics, "*.*");
                // *.* means select all in the folder
                // anything.anyfileextension 
                listPictures.Items.Clear();

                for (int i = 0; i < fileList.Length; i++)
                {
                    string fileName = Path.GetFileName(fileList[i]);
                    listPictures.Items.Add(fileName);
                }
            }
        }

      

        protected void btnNew_Click(object sender, EventArgs e)
        {
            flushData();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            StreamWriter output = new StreamWriter(webSiteData + txtProductID.Text + ".txt");
            output.WriteLine(txtManCode.Text);
            output.WriteLine(txtDescription.Text);
            output.WriteLine(txtPicture.Text);
            output.WriteLine(txtQty.Text);
            output.WriteLine(txtPrice.Text);
            output.Close();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtProductID.Text != "")
            {
                StreamWriter output = new StreamWriter(webSiteData + txtProductID.Text + ".txt");
                output.WriteLine(txtManCode.Text);
                output.WriteLine(txtDescription.Text);
                output.WriteLine(txtPicture.Text);
                output.WriteLine(txtQty.Text);
                output.WriteLine(txtPrice.Text);
                output.Close();
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (File.Exists(webSiteData + txtProductID.Text + ".txt"))
            {
                File.Delete(webSiteData + txtProductID.Text + ".txt");
                flushData();
            }
        }

        protected void btnFind_Click(object sender, EventArgs e)
        {
            if (File.Exists(webSiteData + txtProductID.Text + ".txt"))
            {
                StreamReader input = new StreamReader(webSiteData + txtProductID.Text + ".txt");
                txtManCode.Text = input.ReadLine();
                txtDescription.Text = input.ReadLine();
                txtPicture.Text = input.ReadLine();
                txtQty.Text = input.ReadLine();
                txtPrice.Text = input.ReadLine();
                input.Close();
            }
        }
        private void flushData()
        {
            txtProductID.Text = "";
            txtManCode.Text = "";
            txtDescription.Text = "";
            txtPicture.Text = "";
            txtQty.Text = "";
            txtPrice.Text = "";
        }

        protected void listPictures_SelectedIndexChanged(object sender, EventArgs e)
        {
            imgPictures.ImageUrl = "pictures/" + listPictures.SelectedItem;
            string picName = listPictures.SelectedItem.Text;
            txtPicture.Text = picName;
        }
    }
}