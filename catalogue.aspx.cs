using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Security.Permissions;

namespace Rachel_eCommerce
{
    public partial class catalogue : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string filePath = Default.websiteData;

            Default.ResetArrays();

            string[] fileList;
            fileList = Directory.GetFiles(filePath, "*.*");

            for (int i = 0; i < fileList.Length; i++)
            {
                StreamReader input = new StreamReader(fileList[i]);
                Default.code[i] = input.ReadLine();
                Default.descrip[i] = input.ReadLine();
                Default.pics[i] = input.ReadLine();
                Default.qtyOnHand[i] = input.ReadLine();
                Default.price[i] = input.ReadLine();
                input.Close();
            }

            CreateCartGrid();
        }

        private void CreateCartGrid()
        {
            Table1.Rows.Clear();

            for (int i = 0; i < Default.pics.Length; i++)
            {
                TableRow row = new TableRow();
                for (int j = 0; j < 4; j++)
                {
                    TableCell cell = new TableCell();

                    if (j == 0)
                    {
                        Image image = new Image();
                        image.ImageUrl = "pictures/" + Default.pics[i];
                        image.Height = 200;
                        cell.Controls.Add(image);
                    }
                    else if (j == 1)
                    {
                        Label description = new Label();
                        description.Text = Default.descrip[i];
                        description.CssClass = "description";
                        cell.Controls.Add(description);
                    }
                    else if (j == 2)
                    {
                        Label label = new Label();
                        label.Text = "$" + Default.price[i];
                        label.CssClass = "lblPrice";
                        cell.Controls.Add(label);

                    }
                    else
                    {
                        Panel panel = new Panel();

                        Button btnAddToCart = new Button();
                        btnAddToCart.ID = "btnSelect_" + i + "_" + j;
                        btnAddToCart.CssClass = "btnAdd";
                        btnAddToCart.Click += new EventHandler(AddToCart_Click);
                        btnAddToCart.Text = "Add to Cart";
                        panel.Controls.Add(btnAddToCart);

                        Label label = new Label();
                        label.CssClass = Default.show[i];
                        label.ID = "added_" + i;
                        label.Text = "Added to Cart";
                        panel.Controls.Add(label);

                        cell.Controls.Add(panel);
                    }
                    row.Cells.Add(cell);
                }
                Table1.Rows.Add(row);
            }
        }

        protected void AddToCart_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string id = b.ID;

            string[] idParts = id.Split('_');
            int row = int.Parse(idParts[1]);

            lblRowSelected.Text = "You Selected " + Default.descrip[row];

            Default.show[row] = "show";

            if (Default.numItems > 0)
            {
                bool matchRow = false;
                for (int i = 0; i < Default.numItems; i++)
                {
                    if (row == Default.cartInfo[i])
                        matchRow = true;
                }
                if (!matchRow)
                {
                    Default.cartInfo[Default.numItems] = row;
                    Default.numItems++;                  
                }
            }
            else
            {
                Default.cartInfo[Default.numItems] = row;
                Default.numItems++;
            }

            CreateCartGrid();
        }
    }
}