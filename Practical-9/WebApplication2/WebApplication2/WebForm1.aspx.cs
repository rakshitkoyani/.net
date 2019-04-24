using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPlus_Click(object sender, EventArgs e)
        {
            WebService1 cal = new WebService1();
            lblResult.Text = cal.Add(Convert.ToInt16(txtA.Text),Convert.ToInt16(txtB.Text)).ToString();
        }

        protected void btnSub_Click(object sender, EventArgs e)
        {
            WebService1 cal = new WebService1();
            lblResult.Text = cal.Sub(Convert.ToInt32(txtA.Text), Convert.ToInt32(txtB.Text)).ToString();
        }

        protected void btnMul_Click(object sender, EventArgs e)
        {
            WebService1 cal = new WebService1();
            lblResult.Text = cal.Mul(Convert.ToInt16(txtA.Text) , Convert.ToInt16(txtB.Text)).ToString();
        }

        protected void btnDiv_Click(object sender, EventArgs e)
        {
            WebService1 cal = new WebService1();
            lblResult.Text = cal.Div(Convert.ToInt32(txtA.Text) , Convert.ToInt32(txtB.Text)).ToString();
        }
    }
}