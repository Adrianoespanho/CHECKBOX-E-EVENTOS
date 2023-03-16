using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHECKBOX_E_EVENTOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEscolha_Click(object sender, EventArgs e)
        {
            String txt = "";
            if (checkBoxMaca.Checked)
            {
                txt += checkBoxMaca.Text + " ,";
            }
            if (checkBoxPera.Checked)
            {
                txt += checkBoxPera.Text + " ,";
            }
            if (checkBoxAbacaxi.Checked)
            {
                txt += checkBoxAbacaxi.Text + " ,";
            }
            if (checkBoxLaranja.Checked)
            {
                txt += checkBoxLaranja.Text + " ,";
            }
            if (checkBoxMorango.Checked)
            {
                txt += checkBoxMorango.Text + " ,";
            }
            if (checkBoxBanana.Checked)
            {
                txt += checkBoxBanana.Text + " ,";
            }
            if (checkBoxMamao.Checked)
            {
                txt += checkBoxMamao.Text + " ,";
            }
            MessageBox.Show("A fruta escolhida foi:" + txt, "A fruta escolhida foi ...");
        }
            


        private void checkBoxMaca_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxBanana_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
        
        
       
    }
