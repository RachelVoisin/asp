using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Rachel_eCommerce
{
    public partial class cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CreateCartGrid();
            CalculateTotal();
        }

        protected void RemoveFromCart_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string id = b.ID;

            string[] idParts = id.Split('_');

            int row = int.Parse(idParts[1]);
            lblRowSelected.Text = "You removed an item";

            Default.qty[Default.cartInfo[row]] = "1";
            for (int i = row; i < Default.numItems; i++)
                Default.cartInfo[i] = Default.cartInfo[i + 1];

            Default.show[Default.cartInfo[row]] = "added";

            Default.numItems--;
            CreateCartGrid();
            CalculateTotal();
        }

        private void CreateCartGrid()
        {
            Table1.Rows.Clear();
            for (int i = 0; i < Default.numItems; i++)
            {
                TableRow row = new TableRow();
                for (int j = 0; j < 5; j++)
                {
                    TableCell cell = new TableCell();

                    if (j == 0)
                    {
                        Image image = new Image();
                        image.ImageUrl = "pictures/" + Default.pics[Default.cartInfo[i]];
                        image.CssClass = "cartPic";
                        image.Height = 150;
                        cell.Controls.Add(image);
                    }
                    else if (j == 1)
                    {
                        Label label = new Label();
                        label.Text = Default.descrip[Default.cartInfo[i]];
                        label.CssClass = "desText";
                        cell.Controls.Add(label);
                    }
                    else if (j == 2)
                    {
                        Label label = new Label();
                        label.Text = Default.price[Default.cartInfo[i]];
                        label.CssClass = "lblPrice";
                        cell.Controls.Add(label);
                    }
                    else if (j == 3)
                    {
                        Button btnAddToCart = new Button();
                        btnAddToCart.ID = "btnSelect_" + i + "_" + j;
                        btnAddToCart.CssClass = "btnSelect";
                        btnAddToCart.Click += new EventHandler(RemoveFromCart_Click);
                        btnAddToCart.Text = "Remove";
                        cell.Controls.Add(btnAddToCart);
                    }
                    else
                    {
                        TextBox text = new TextBox();
                        text.Text = Default.qty[Default.cartInfo[i]];
                        text.CssClass = "qtyBox";
                        cell.Controls.Add(text);
                    }
                    row.Cells.Add(cell);
                }
                Table1.Rows.Add(row);
            }
        }

        private void CalculateTotal()
        {
            decimal total = 0;
            for (int i = 0; i < Default.numItems; i++)
            {
                TableRow row = Table1.Rows[i];
                decimal rowPrice = 0;

                for (int j = 0; j < 5; j++)
                {
                    TableCell cell = row.Cells[j];

                    if (j == 2)
                    {
                        Control ctrl = cell.Controls[0];
                        Label lbl = (Label)ctrl;
                        string price = lbl.Text;
                        rowPrice = decimal.Parse(price);
                    }
                    else if (j == 4)
                    {
                        Control ctrl = cell.Controls[0];
                        TextBox txt = (TextBox)ctrl;
                        string qty = txt.Text;
                        Default.qty[Default.cartInfo[i]] = qty;

                        decimal rowTotal = rowPrice * int.Parse(qty);
                        total += rowTotal;
                    }
                }
            }

            LblTotal.Text = ("Total: " + total.ToString("$##,##0.##"));
        }

        protected void btnRecalculate_Click(object sender, EventArgs e)
        {
            CalculateTotal();
        }
    }
}