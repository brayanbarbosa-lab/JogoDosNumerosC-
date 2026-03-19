using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brayan_numeros
{
    public partial class facil : Form
    {
        public facil()
        {
            InitializeComponent();
        }

        int contador;

        public void misturar()
        {
            int[] bnum = new int[16];
            int i, j, verificalinha;
            Boolean flag = false;

            i = 1;

            do
            {
                Random RND = new Random();

                verificalinha = Convert.ToInt32((RND.Next(0, 15)) + 1);

                for (j = 1; j <= i; j++)
                {
                    if (bnum[j] == verificalinha)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == true)
                {
                    flag = false;
                }
                else
                {
                    bnum[i] = verificalinha;
                    i = i + 1;
                }
            } while (i <= 15);

            button1.Text = Convert.ToString(bnum[1]);
            button2.Text = Convert.ToString(bnum[2]);
            button3.Text = Convert.ToString(bnum[3]);
            button4.Text = Convert.ToString(bnum[4]);
            button5.Text = Convert.ToString(bnum[5]);
            button6.Text = Convert.ToString(bnum[6]);
            button7.Text = Convert.ToString(bnum[7]);
            button8.Text = Convert.ToString(bnum[8]);
            button9.Text = Convert.ToString(bnum[9]);
            button10.Text = Convert.ToString(bnum[10]);
            button11.Text = Convert.ToString(bnum[11]);
            button12.Text = Convert.ToString(bnum[12]);
            button13.Text = Convert.ToString(bnum[13]);
            button14.Text = Convert.ToString(bnum[14]);
            button15.Text = Convert.ToString(bnum[15]);
            button16.Text = "";

        }

        public void verificar()
        {
            if (button1.Text == "1" && button2.Text == "2" && button3.Text == "3"
                && button4.Text == "4" && button5.Text == "5" && button6.Text == "6"
                && button7.Text == "7" && button8.Text == "8" && button9.Text == "9" && button10.Text == "10"
                && button11.Text == "11" && button12.Text == "12" && button13.Text == "13" && button14.Text == "14" 
                && button15.Text == "15" && button16.Text == "")
            {
                MessageBox.Show("Parabéns, você ganhou!", "Jogo Dos Números", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            contador = contador + 1;
            textBox1.Text = "Número De Cliques: " + contador;
        }

        public void VerificarVazio(Button butt1, Button butt2)
        {
            if (butt2.Text == "")
            {
                butt2.Text = butt1.Text;
                butt1.Text = "";
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            VerificarVazio(button9, button5);
            VerificarVazio(button9, button10);
            VerificarVazio(button9, button13);
            verificar();
        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form1();
            form1.ShowDialog();
        }

        private void facil_Load(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            misturar();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            misturar();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            button1.Text = "1";
            button2.Text = "2";
            button3.Text = "3";
            button4.Text = "4";
            button5.Text = "5";
            button6.Text = "6";
            button7.Text = "7";
            button8.Text = "8";
            button9.Text = "9";
            button10.Text = "10";
            button11.Text = "11";
            button12.Text = "12";
            button13.Text = "13";
            button14.Text = "14";
            button15.Text = "15";
            button16.Text = "";
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            misturar();
            textBox1.Clear();

            contador = 0;

            this.Refresh();
            this.Hide();
            facil NovoJogo = new facil();
            NovoJogo.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VerificarVazio(button1, button2);
            VerificarVazio(button1, button5);
            verificar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VerificarVazio(button2, button3);
            VerificarVazio(button2, button6);
            VerificarVazio(button2, button1);
            verificar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VerificarVazio(button3, button2);
            VerificarVazio(button3, button7);
            VerificarVazio(button3, button4);
            verificar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VerificarVazio(button4, button3);
            VerificarVazio(button4, button8);
            verificar();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            VerificarVazio(button5, button9);
            VerificarVazio(button5, button6);
            VerificarVazio(button5, button1);
            verificar();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            VerificarVazio(button6, button2);
            VerificarVazio(button6, button5);
            VerificarVazio(button6, button7);
            VerificarVazio(button6, button10);
            verificar();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            VerificarVazio(button7, button3);
            VerificarVazio(button7, button6);
            VerificarVazio(button7, button8);
            VerificarVazio(button7, button11);
            verificar();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            VerificarVazio(button8, button4);
            VerificarVazio(button8, button7);
            VerificarVazio(button8, button12);
            verificar();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            VerificarVazio(button10, button6);
            VerificarVazio(button10, button9);
            VerificarVazio(button10, button11);
            VerificarVazio(button10, button14);
            verificar();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            VerificarVazio(button11, button7);
            VerificarVazio(button11, button10);
            VerificarVazio(button11, button12);
            VerificarVazio(button11, button15);
            verificar();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            VerificarVazio(button12, button8);
            VerificarVazio(button12, button11);
            VerificarVazio(button12, button16);
            verificar();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            VerificarVazio(button13, button14);
            VerificarVazio(button13, button9);
            verificar();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            VerificarVazio(button14, button10);
            VerificarVazio(button14, button13);
            VerificarVazio(button14, button15);
            verificar();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            VerificarVazio(button15, button11);
            VerificarVazio(button15, button14);
            VerificarVazio(button15, button16);
            verificar();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            VerificarVazio(button16, button12);
            VerificarVazio(button16, button15);
            verificar();
        }
    }
}
