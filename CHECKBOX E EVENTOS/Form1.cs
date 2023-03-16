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
        List<CheckBox> frutas = new List<CheckBox>();//criar uma lista de variavel 
        public Form1()
        {
            InitializeComponent();
            frutas.Add(checkBoxMaca);
            frutas.Add(checkBoxPera);
            frutas.Add(checkBoxAbacaxi);
            frutas.Add(checkBoxLaranja);
            frutas.Add(checkBoxMorango);
            frutas.Add(checkBoxBanana);
            frutas.Add(checkBoxMamao);
        }

        private void btnEscolha_Click(object sender, EventArgs e)
        {
            String txt = "";

            foreach (CheckBox t in frutas)
            {
                if (t.Checked)
                {
                    txt += t.Text + " ,";
                }
                MessageBox.Show("A fruta escolhida foi:" + txt, "A fruta escolhida foi ...");


                //if (checkBoxMaca.Checked)
                //{
                //    txt += checkBoxMaca.Text + " ,";
                //}
                //if (checkBoxPera.Checked)
                //{
                //    txt += checkBoxPera.Text + " ,";
                //}
                //if (checkBoxAbacaxi.Checked)
                //{
                //    txt += checkBoxAbacaxi.Text + " ,";
                //}
                //if (checkBoxLaranja.Checked)
                //{
                //    txt += checkBoxLaranja.Text + " ,";
                //}
                //if (checkBoxMorango.Checked)
                //{
                //    txt += checkBoxMorango.Text + " ,";
                //}
                //if (checkBoxBanana.Checked)
                //{
                //    txt += checkBoxBanana.Text + " ,";
                //}
                //if (checkBoxMamao.Checked)
                //{
                //    txt += checkBoxMamao.Text + " ,";
                //}
                
            }
            }



            private void checkBoxMaca_CheckedChanged(object sender, EventArgs e)
            {
                //if (checkBoxMaca.Checked)
                //{
                //    MessageBox.Show("O Item Maça Marcado");
                //}
            }

            private void checkBoxBanana_CheckedChanged(object sender, EventArgs e)
            {
                //if (checkBoxBanana.Checked)
                //{
                //    MessageBox.Show("O Item Banana Marcado");
                //}
            }

            private void checkBoxPera_CheckedChanged(object sender, EventArgs e)
            {
                //if (checkBoxPera.Checked)
                //{
                //    MessageBox.Show("O iTEM Pera Marcado");
                //}
            }

            private void checkBoxAbacaxi_CheckedChanged(object sender, EventArgs e)
            {
                //if (checkBoxAbacaxi.Checked)
                //{
                //    MessageBox.Show("O Item Abacaxi Marcado");
                //}
            }

            private void checkBoxLaranja_CheckedChanged(object sender, EventArgs e)
            {
                //if (checkBoxLaranja.Checked)
                //{
                //    MessageBox.Show("O Item Laranja Marcada");
                //}
            }

            private void checkBoxMorango_CheckedChanged(object sender, EventArgs e)
            {
                //    if (checkBoxMorango.Checked)
                //    {
                //        MessageBox.Show("O Item Morango Marcado");
                //    }
            }

            private void checkBoxMamao_CheckedChanged(object sender, EventArgs e)
            {
                //if (checkBoxMamao.Checked)
                //{
                //    MessageBox.Show("O item Mamao Marcado");
                //}
            }
        }
    }

