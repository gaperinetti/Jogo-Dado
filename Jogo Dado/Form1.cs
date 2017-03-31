using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_Dado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btJogador1_Click_1(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int valor1 = rnd1.Next(1, 7);
            txtJogador1.Text = Convert.ToString(valor1);
        }

        private void btPlayer2_Click_1(object sender, EventArgs e)
        {
            int rod = Convert.ToInt16(txtRodada.Text);
            if (rod > 3)
            {
                MessageBox.Show("Fim de jogo!");

                if (Convert.ToInt16(txtPlacarJ1.Text) == Convert.ToInt16(txtPlacarJ2.Text))
                {

                    MessageBox.Show("Jogo empatado!");
                    Application.Exit();
                }
            }

            else
            {
                Random rnd2 = new Random();
                int valor2 = rnd2.Next(1, 7);
                txtJogador2.Text = Convert.ToString(valor2);


                rod += 1;
                txtRodada.Text = Convert.ToString(rod);
                if (Convert.ToInt16(txtJogador1.Text) > Convert.ToInt16(txtJogador2.Text))
                {
                    MessageBox.Show("Player 1 ganhou");
                    int p1 = Convert.ToInt16(txtPlacarJ1.Text);
                    p1 += 1;
                    txtPlacarJ1.Text = Convert.ToString(p1);
                }
                else if (Convert.ToInt16(txtJogador1.Text) < Convert.ToInt16(txtJogador2.Text))
                {
                    MessageBox.Show("Player 2 ganhou");
                    int p2 = Convert.ToInt16(txtPlacarJ2.Text);
                    p2 += 1;
                    txtPlacarJ2.Text = Convert.ToString(p2);
                }
                else { MessageBox.Show("Jogo Empatado!"); }
              //  int pp1 = Convert.ToInt16(txtPlacarP1.Text);
             //   int pp2 = Convert.ToInt16(txtPlacarP2.Text);
                if (Convert.ToInt16(txtPlacarJ1.Text) == 2)
                {
                    MessageBox.Show("Player 1 Vencedor");
                    Application.Exit();
                }
                else if (Convert.ToInt16(txtPlacarJ2.Text) == 2)
                {
                    MessageBox.Show("Player 2 vencedor");
                    Application.Exit();
                }

                
            }

        }
             
    }
}

