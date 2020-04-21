using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        double tulos = 0.0;
        string operaatio = "";
        bool onkoOperaatioSuoritettu = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e) 
        {
            if ((textTulos.Text == "0") || (onkoOperaatioSuoritettu))
                textTulos.Clear();

            onkoOperaatioSuoritettu = false;
            Button button = (Button)sender;
            if(button.Text == ",")
            {
                if(!textTulos.Text.Contains(","))
                    textTulos.Text = textTulos.Text + button.Text;
            }
            else
            textTulos.Text = textTulos.Text + button.Text;
            
        }
        private void lasku_click(object sender, EventArgs e)
        {
             Button button = (Button)sender;
             operaatio = button.Text;
             tulos = Double.Parse(textTulos.Text);
             lbl_nykyinenOperaatio.Text = tulos + " " + operaatio;
             onkoOperaatioSuoritettu = true;
           
        }

        private void onYhteensa_click(object sender, EventArgs e)
        {
            switch (operaatio)
            {
                case "+":
                    textTulos.Text = (tulos + Double.Parse(textTulos.Text)).ToString();
                    break;
                case "-":
                    textTulos.Text = (tulos - Double.Parse(textTulos.Text)).ToString();
                    break;
                case "*":
                    textTulos.Text = (tulos * Double.Parse(textTulos.Text)).ToString();
                    break;
                case "/":
                    textTulos.Text = (tulos / Double.Parse(textTulos.Text)).ToString();
                    break;
                default:
                    break;
            }
            tulos = Double.Parse(textTulos.Text);
            lbl_nykyinenOperaatio.Text = "";
        }
       
        private void takaisin_click(object sender, EventArgs e)
        {
            textTulos.Text = "0";
           
        }

        private void clear_click(object sender, EventArgs e)
        {
            textTulos.Text = "0";
            tulos = 0;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //
        }
    }
}
