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
    public partial class medio : Form
    {
        public medio()
        {
            InitializeComponent();
        }

        int contador;

        public void VerificarVazio(Button butt1, Button butt2)
        {
            if (butt2.Text == "")
            {
                butt2.Text = butt1.Text;
                butt1.Text = "";
            }
        }

        public void verificar()
        {
            if (button1.Text == "1" && button2.Text == "2" && button3.Text == "3"
                && button4.Text == "4" && button5.Text == "5" && button6.Text == "6"
                && button7.Text == "7" && button8.Text == "8" && button9.Text == "9" && button10.Text == "10"
                && button11.Text == "11" && button12.Text == "12" && button13.Text == "13" && button14.Text == "14"
                && button15.Text == "15" && button16.Text == "16" && button17.Text == "17" && button18.Text == "18" && button19.Text == "19"
                && button20.Text == "20" && button21.Text == "21" && button22.Text == "22" && button23.Text == "23" && button24.Text == "24"
                && button25.Text == "")
            {
                MessageBox.Show("Parabéns, você ganhou!", "Jogo Dos Números", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            contador = contador + 1;
            textBox1.Text = "Número De Cliques: " + contador;
        }

        public void misturar()
        {
            int[] bnum = new int[25];
            int i, j, verificalinha;
            Boolean flag = false;

            i = 1;

            do
            {
                Random RND = new Random();

                verificalinha = Convert.ToInt32((RND.Next(0, 24)) + 1);

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
            } while (i <= 24);

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
            button16.Text = Convert.ToString(bnum[16]);
            button17.Text = Convert.ToString(bnum[17]);
            button18.Text = Convert.ToString(bnum[18]);
            button19.Text = Convert.ToString(bnum[19]);
            button20.Text = Convert.ToString(bnum[20]);
            button21.Text = Convert.ToString(bnum[21]);
            button22.Text = Convert.ToString(bnum[22]);
            button23.Text = Convert.ToString(bnum[23]);
            button24.Text = Convert.ToString(bnum[24]);
            button25.Text = "";

        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form1();
            form1.ShowDialog();
        }

        private void medio_Load(object sender, EventArgs e)
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
            button16.Text = "16";
            button17.Text = "17";
            button18.Text = "18";
            button19.Text = "19";
            button20.Text = "20";
            button21.Text = "21";
            button22.Text = "22";
            button23.Text = "23";
            button24.Text = "24";
            button25.Text = "";
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            misturar();
            textBox1.Clear();

            contador = 0;

            this.Refresh();
            this.Hide();
            medio NovoJogo = new medio();
            NovoJogo.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VerificarVazio(button1, button2);
            VerificarVazio(button1, button6);
            verificar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VerificarVazio(button2, button1);
            VerificarVazio(button2, button3);
            VerificarVazio(button2, button7);
            verificar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VerificarVazio(button3, button2);
            VerificarVazio(button3, button8);
            VerificarVazio(button3, button4);
            verificar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VerificarVazio(button4, button3);
            VerificarVazio(button4, button9);
            VerificarVazio(button4, button5);
            verificar();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            VerificarVazio(button5, button4);
            VerificarVazio(button5, button10);
            verificar();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            VerificarVazio(button6, button1);
            VerificarVazio(button6, button7);
            VerificarVazio(button6, button11);
            verificar();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            VerificarVazio(button7, button2);
            VerificarVazio(button7, button6);
            VerificarVazio(button7, button8);
            VerificarVazio(button7, button12);
            verificar();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            VerificarVazio(button8, button3);
            VerificarVazio(button8, button7);
            VerificarVazio(button8, button9);
            VerificarVazio(button8, button13);
            verificar();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            VerificarVazio(button9, button4);
            VerificarVazio(button9, button8);
            VerificarVazio(button9, button14);
            VerificarVazio(button9, button10);
            verificar();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            VerificarVazio(button10, button5);
            VerificarVazio(button10, button9);
            VerificarVazio(button10, button15);
            verificar();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            VerificarVazio(button11, button6);
            VerificarVazio(button11, button12);
            VerificarVazio(button11, button16);
            verificar();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            VerificarVazio(button12, button7);
            VerificarVazio(button12, button11);
            VerificarVazio(button12, button13);
            VerificarVazio(button12, button17);
            verificar();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            VerificarVazio(button13, button8);
            VerificarVazio(button13, button12);
            VerificarVazio(button13, button14);
            VerificarVazio(button13, button18);
            verificar();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            VerificarVazio(button14, button9);
            VerificarVazio(button14, button13);
            VerificarVazio(button14, button15);
            VerificarVazio(button14, button19);
            verificar();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            VerificarVazio(button15, button10);
            VerificarVazio(button15, button14);
            VerificarVazio(button15, button20);
            verificar();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            VerificarVazio(button16, button11);
            VerificarVazio(button16, button17);
            VerificarVazio(button16, button21);
            verificar();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            VerificarVazio(button17, button12);
            VerificarVazio(button17, button16);
            VerificarVazio(button17, button18);
            VerificarVazio(button17, button22);
            verificar();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            VerificarVazio(button18, button13);
            VerificarVazio(button18, button17);
            VerificarVazio(button18, button19);
            VerificarVazio(button18, button23);
            verificar();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            VerificarVazio(button19, button14);
            VerificarVazio(button19, button20);
            VerificarVazio(button19, button18);
            VerificarVazio(button19, button24);
            verificar();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            VerificarVazio(button20, button15);
            VerificarVazio(button20, button19);
            VerificarVazio(button20, button25);
            verificar();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            VerificarVazio(button21, button16);
            VerificarVazio(button21, button22);
            verificar();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            VerificarVazio(button22, button23);
            VerificarVazio(button22, button17);
            VerificarVazio(button22, button21);
            verificar();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            VerificarVazio(button23, button18);
            VerificarVazio(button23, button24);
            VerificarVazio(button23, button22);
            verificar();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            VerificarVazio(button24, button19);
            VerificarVazio(button24, button23);
            VerificarVazio(button24, button25);
            verificar();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            VerificarVazio(button25, button20);
            VerificarVazio(button25, button24);
            verificar();
        }
    }
}
