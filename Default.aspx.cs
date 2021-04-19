using Shoppingmaschinen.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Unipluss.Sign.ExternalContract.Entities;

namespace Shoppingmaschinen
{
    public partial class _Default : Page
    {
        public static int deposit;
        public static string message;
       
        protected void Page_Load(object sender, EventArgs e)
        { 
          

            if (!IsPostBack)
           {
                message = "Внесите оплату, выберите товар, нажмите Купить";
                Repeater1.DataSource = ProductBD.Products;
                Repeater1.DataBind();
                Page.DataBind();
            }

            
        }


        protected void Page_Prerender(object sender, EventArgs e)
        {
            Repeater1.DataSource = ProductBD.Products;
            Repeater1.DataBind();
        }


        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if(ProductBD.Products.Find(x => x.id == e.Item.ItemIndex).price <= deposit)
            {
                ProductBD.Products.Find(x => x.id == e.Item.ItemIndex).Buy();
                deposit = deposit - ProductBD.Products.Find(x => x.id == e.Item.ItemIndex).price;
                message = "СПАСИБО!";
            }
            else
            {
                message = "Не достаточно средств";
            }

            
       
          //  Debug.WriteLine(e.Item.ItemIndex);
           
        
          //  Repeater1.DataSource = ProductBD.Products;
          //  Repeater1.DataBind();
            Page.DataBind();
        }

        protected void rest_button_Click(object sender, EventArgs e)
        {
            int n_ten = deposit / 10;
            int n_five = (deposit - n_ten * 10) / 5;
            int n_two = (deposit - n_ten * 10 - n_five * 5) / 2;
            int n_one = (deposit - n_ten * 10 - n_five * 5 - n_two * 2);
            //
            //
            CMoneyBag.ten = CMoneyBag.ten + n_ten;
            CMoneyBag.five = CMoneyBag.five + n_five;
            CMoneyBag.two = CMoneyBag.two + n_two;
            CMoneyBag.one = CMoneyBag.one + n_one;

            deposit = 0;
            message = "Внесите оплату, выберите товар, нажмите Купить";

            Page.DataBind();


        }

        protected void Button_10_Click(object sender, EventArgs e)
        {
            if (CMoneyBag.ten != 0)
            {
                deposit = deposit + 10;
                CMoneyBag.ten = CMoneyBag.ten - 1;
                MMoneyBag.ten += 1;
            }
            Page.DataBind();
        }

        protected void Button_5_Click(object sender, EventArgs e)
        {
            if (CMoneyBag.five != 0)
            {
                deposit = deposit + 5;
                CMoneyBag.five = CMoneyBag.five - 1;
                MMoneyBag.five += 1;
            }
            Page.DataBind();
        }

        protected void Button_2_Click(object sender, EventArgs e)
        {
            if (CMoneyBag.two != 0)
            {
                deposit = deposit + 2;
                CMoneyBag.two = CMoneyBag.two - 1;
                MMoneyBag.two += 1;
            }
            Page.DataBind();
        }

        protected void Button_1_Click(object sender, EventArgs e)
        {
            if (CMoneyBag.one != 0) { 
                deposit = deposit + 1;
                CMoneyBag.one = CMoneyBag.one - 1;
                MMoneyBag.one += 1;
            }
            Page.DataBind();
        }
    }
}