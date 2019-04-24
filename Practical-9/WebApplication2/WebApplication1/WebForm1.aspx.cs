using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPlus_Click(object sender, EventArgs e)
        {
            localhost.WebService1 cal = new localhost.WebService1();
            lblResult.Text = cal.Add(Convert.ToInt16(txtA.Text), Convert.ToInt16(txtB.Text)).ToString();
        }

        protected void btnSub_Click(object sender, EventArgs e)
        {
            localhost.WebService1 cal = new localhost.WebService1();
            lblResult.Text = cal.Sub(Convert.ToInt16(txtA.Text), Convert.ToInt16(txtB.Text)).ToString();
        }

        protected void btnMul_Click(object sender, EventArgs e)
        {
            localhost.WebService1 cal = new localhost.WebService1();
            lblResult.Text = cal.Mul(Convert.ToInt16(txtA.Text), Convert.ToInt16(txtB.Text)).ToString();
        }

        protected void btnDiv_Click(object sender, EventArgs e)
        {
            localhost.WebService1 cal = new localhost.WebService1();
            lblResult.Text = cal.Div(Convert.ToInt16(txtA.Text), Convert.ToInt16(txtB.Text)).ToString();
        }
    }
}