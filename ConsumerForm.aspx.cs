using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WCFApplication
{
    
    public partial class ConsumerForm : System.Web.UI.Page
    {
        ServiceReference1.CalculatorService1Client obj = new ServiceReference1.CalculatorService1Client();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox3.Text = obj.add(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text)).ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox3.Text = obj.sub(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text)).ToString();

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox3.Text = obj.mul(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text)).ToString();

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            TextBox3.Text = obj.div(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text)).ToString();

        }
    }
}