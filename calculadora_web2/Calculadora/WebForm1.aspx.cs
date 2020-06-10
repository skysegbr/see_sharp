using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculadora
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        int resultado = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TxtNum.Text = TxtNum.Text + Btn7.Text;

        }

        protected void Btn8_Click(object sender, EventArgs e)
        {
            TxtNum.Text = TxtNum.Text + Btn8.Text;
        }

        protected void Btn9_Click(object sender, EventArgs e)
        {
            TxtNum.Text = TxtNum.Text + Btn9.Text;
        }

        protected void Btn4_Click(object sender, EventArgs e)
        {
            TxtNum.Text = TxtNum.Text + Btn4.Text;
        }

        protected void Btn5_Click(object sender, EventArgs e)
        {
            TxtNum.Text = TxtNum.Text + Btn5.Text;
        }

        protected void Btn6_Click(object sender, EventArgs e)
        {
            TxtNum.Text = TxtNum.Text + Btn6.Text;
        }

        protected void Btn1_Click(object sender, EventArgs e)
        {
            TxtNum.Text = TxtNum.Text + Btn1.Text;
        }

        protected void Btn2_Click(object sender, EventArgs e)
        {
            TxtNum.Text = TxtNum.Text + Btn2.Text;
        }

        protected void Btn3_Click(object sender, EventArgs e)
        {
            TxtNum.Text = TxtNum.Text + Btn3.Text;
        }

        protected void Btn0_Click(object sender, EventArgs e)
        {
            TxtNum.Text = TxtNum.Text + Btn0.Text;
        }

        protected void BtnDiv_Click(object sender, EventArgs e)
        {

            if (!LblAnt.Text.Equals(string.Empty))
            {
                resultado = int.Parse(LblAnt.Text) / int.Parse(TxtNum.Text);
                TxtNum.Text = resultado.ToString();
                LblAnt.Text = String.Empty;
            }
            else
            {

                resultado = int.Parse(TxtNum.Text);

                LblAnt.Text = TxtNum.Text;

                TxtNum.Text = String.Empty;
            }
        }

        protected void BtnMult_Click(object sender, EventArgs e)
        {

        }
    }
}