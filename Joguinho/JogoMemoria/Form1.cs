using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JogoMemoria 
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int cont = 0;
        int vezes = 0;

        int boxe = 0;
        int judo = 0;
        int bolavolei = 0 ;
        int imagens = 0;
        int bolosoccer = 0 ;
        int jogadorbask = 0;
        int footbol = 0;
        int bolabask = 0 ;
        int nado = 0 ;
        int rugby = 0 ;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (boxe != 3)
            {
                button4.BackgroundImage = Properties.Resources.plano;
                button23.BackgroundImage = Properties.Resources.plano;
            }
            if (judo != 3)
            {
                button6.BackgroundImage = Properties.Resources.plano;
                button21.BackgroundImage = Properties.Resources.plano;
            }
            if (nado != 3)
            {
                button5.BackgroundImage = Properties.Resources.plano;
                button19.BackgroundImage = Properties.Resources.plano;
            }
            if (bolavolei != 3)
            {
                button12.BackgroundImage = Properties.Resources.plano;
                button18.BackgroundImage = Properties.Resources.plano;
            }
            if (bolabask != 3)
            {
                button14.BackgroundImage = Properties.Resources.plano;
                button11.BackgroundImage = Properties.Resources.plano;
            }
            if (bolosoccer != 3)
            {
                button13.BackgroundImage = Properties.Resources.plano;
                button15.BackgroundImage = Properties.Resources.plano;
            }
            if (imagens != 3)
            {
                button16.BackgroundImage = Properties.Resources.plano;
                button10.BackgroundImage = Properties.Resources.plano;
            }
            if (footbol != 3)
            {
                button17.BackgroundImage = Properties.Resources.plano;
                button8.BackgroundImage = Properties.Resources.plano;
            }
            if (rugby != 3)
            {
                button9.BackgroundImage = Properties.Resources.plano;
                button20.BackgroundImage = Properties.Resources.plano;
            }
            if (jogadorbask != 3)
            {
                button22.BackgroundImage = Properties.Resources.plano;
                button7.BackgroundImage = Properties.Resources.plano;
            }
            timer1.Enabled = false;
        }

        public void verificar()
        {
            vezes = 0;
            if (boxe != 3)
            {
                boxe = 0;
            }
            if (judo != 3)
            {
                judo = 0;
            }
            if (bolavolei != 3)
            {
                bolavolei = 0;
            }
            if (bolosoccer != 3)
            {
                bolosoccer = 0;
            }
            if (bolabask != 3)
            {
                bolabask = 0;
            }
            if (footbol != 3)
            {
                footbol = 0;
            }
            if (imagens != 3)
            {
                imagens = 0;
            }
            if (jogadorbask != 3)
            {
                jogadorbask = 0;
            }
            if (nado != 3)
            {
                nado = 0;
            }
            if (rugby != 3)
            {
                rugby = 0;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            vezes = vezes + 1;
            if (vezes <= 2)
            {
                button4.BackgroundImage = Properties.Resources.boxe;
                boxe = boxe + 1;
            }
            if (vezes == 2)
            {
                if (boxe == 2)
                {
                    //MessageBox.Show("Figuras Iguais");
                    vezes = 0;
                    boxe = 3;
                    cont++;
                    button4.Enabled = false;
                    button23.Enabled = false;
                    if (cont == 10)
                    {
                        MessageBox.Show("Parabens você ganhou");
                    }
                }
                else
                {
                    //MessageBox.Show("figuras erradas");
                    timer1.Enabled = true;
                    verificar();
                }
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            vezes = vezes + 1;

            if (vezes <= 2)
            {
                button23.BackgroundImage = Properties.Resources.boxe;
                boxe = boxe + 1;
            }
            if (vezes == 2)
            {
                if (boxe == 2)
                {
                    //MessageBox.Show("Figuras Iguais");
                    vezes = 0;
                    boxe = 3;
                    cont++;
                    button4.Enabled = false;
                    button23.Enabled = false;
                    if (cont == 10)
                    {
                        MessageBox.Show("Parabens você ganhou");
                    }
                }
                else
                {
                    //MessageBox.Show("figuras erradas");

                    timer1.Enabled = true;
                    verificar();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            vezes = vezes + 1;

            if (vezes <= 2)
            {
                button6.BackgroundImage = Properties.Resources.judo;
                judo = judo + 1;
            }
            if (vezes == 2)
            {
                if (judo == 2)
                {
                    //MessageBox.Show("Figuras Iguais");
                    vezes = 0;
                    judo = 3;
                    cont++;
                    button6.Enabled = false;
                    button21.Enabled = false;
                    if(cont == 10)
                    {
                        MessageBox.Show("Parabens você ganhou");
                    }
                }
                else
                {
                    //MessageBox.Show("figuras erradas");
                    timer1.Enabled = true;
                    verificar();
                }
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            vezes = vezes + 1;

            if (vezes <= 2)
            {
                button21.BackgroundImage = Properties.Resources.judo;
                judo = judo + 1;
            }
            if (vezes == 2)
            {
                if (judo == 2)
                {
                    //MessageBox.Show("Figuras Iguais");
                    vezes = 0;           
                    judo = 3;
                    cont++;
                    button21.Enabled = false;
                    button6.Enabled = false;
                    if(cont == 10)
                    {
                        MessageBox.Show("Parabens você ganhou");
                    }
                }
                else
                {
                    //MessageBox.Show("figuras erradas");
                    timer1.Enabled = true;
                    verificar();
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            vezes = vezes + 1;

            if (vezes <= 2)
            {
                button18.BackgroundImage = Properties.Resources.bolavolei;
                bolavolei = bolavolei + 1;
            }
            if (vezes == 2)
            {
                if (bolavolei == 2)
                {
                    //MessageBox.Show("Figuras Iguais");
                    vezes = 0;
                    bolavolei = 3;
                    cont++;
                    button18.Enabled = false;
                    button12.Enabled = false;
                    if(cont == 10)
                    {
                        MessageBox.Show("Parabens você ganhou");
                    }
                }
                else
                {
                    //MessageBox.Show("figuras erradas");
                    timer1.Enabled = true;
                    verificar();
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            vezes = vezes + 1;

            if (vezes <= 2)
            {
                button12.BackgroundImage = Properties.Resources.bolavolei;
                bolavolei = bolavolei + 1;
            }
            if (vezes == 2)
            {
                if (bolavolei == 2)
                {
                    //MessageBox.Show("Figuras Iguais");
                    vezes = 0;
                    bolavolei = 3;
                    cont++;
                    button12.Enabled = false;
                    button18.Enabled = false;
                    if(cont == 10)
                    {
                        MessageBox.Show("Parabens você ganhou");
                    }
                }
                else
                {
                    //MessageBox.Show("figuras erradas");
                    timer1.Enabled = true;
                    verificar();
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            vezes = vezes + 1;

            if (vezes <= 2)
            {
                button10.BackgroundImage = Properties.Resources.images;
                imagens = imagens + 1;
            }
            if (vezes == 2)
            {
                if (imagens == 2)
                {
                    //MessageBox.Show("Figuras Iguais");
                    vezes = 0;
                    imagens = 3;
                    cont++;
                    button10.Enabled = false;
                    button16.Enabled = false;
                    if(cont == 10)
                    {
                        MessageBox.Show("Parabens você ganhou");
                    }
                }
                else
                {
                    //MessageBox.Show("figuras erradas");
                    timer1.Enabled = true;
                    verificar();
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            vezes = vezes + 1;

            if (vezes <= 2)
            {
                button16.BackgroundImage = Properties.Resources.images;
                imagens = imagens + 1;
            }
            if (vezes == 2)
            {
                if (imagens == 2)
                {
                    //MessageBox.Show("Figuras Iguais");
                    vezes = 0;
                    imagens = 3;
                    cont++;
                    button16.Enabled = false;
                    button10.Enabled = false;
                    if(cont == 10)
                    {
                        MessageBox.Show("Parabens você ganhou");
                    }
                }
                else
                {
                    //MessageBox.Show("figuras erradas");
                    timer1.Enabled = true;
                    verificar();
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            vezes = vezes + 1;

            if (vezes <= 2)
            {
                button15.BackgroundImage = Properties.Resources.bolosoccer;
                bolosoccer = bolosoccer + 1;
            }
            if (vezes == 2)
            {
                if (bolosoccer == 2)
                {
                    //MessageBox.Show("Figuras Iguais");
                    vezes = 0;
                    bolosoccer = 3;
                    cont++;
                    button15.Enabled = false;
                    button13.Enabled = false;
                    if(cont == 10)
                    {
                        MessageBox.Show("Parabens você ganhou");
                    }
                }
                else
                {
                    //MessageBox.Show("figuras erradas");
                    timer1.Enabled = true;
                    verificar();
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            vezes = vezes + 1;

            if (vezes <= 2)
            {
                button13.BackgroundImage = Properties.Resources.bolosoccer;
                bolosoccer = bolosoccer + 1;
            }
            if (vezes == 2)
            {
                if (bolosoccer == 2)
                {
                    //MessageBox.Show("Figuras Iguais");
                    vezes = 0;
                    bolosoccer=3;
                    cont++;
                    button13.Enabled = false;
                    button15.Enabled = false;
                    if(cont == 10)
                    {
                        MessageBox.Show("Parabens você ganhou");
                    }
                }
                else
                {
                    //MessageBox.Show("figuras erradas");
                    timer1.Enabled = true;
                    verificar();
                }
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            vezes = vezes + 1;

            if (vezes <= 2)
            {
                button8.BackgroundImage = Properties.Resources.footbol;
                footbol = footbol + 1;
            }
            if (vezes == 2)
            {
                if (footbol == 2)
                {
                    //MessageBox.Show("Figuras Iguais");
                    vezes = 0;
                    footbol = 3;
                    cont++;
                    button8.Enabled = false;
                    button17.Enabled = false;
                    if(cont == 10)
                    {
                        MessageBox.Show("Parabens você ganhou");
                    }
                }
                else
                {
                    //MessageBox.Show("figuras erradas");
                    timer1.Enabled = true;
                    verificar();
                }
            }
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            vezes = vezes + 1;

            if (vezes <= 2)
            {
                button17.BackgroundImage = Properties.Resources.footbol;
                footbol = footbol + 1;
            }
            if (vezes == 2)
            {
                if (footbol == 2)
                {
                    //MessageBox.Show("Figuras Iguais");
                    vezes = 0;
                    footbol = 3;
                    cont++;
                    button17.Enabled = false;
                    button8.Enabled = false;
                    if(cont == 10)
                    {
                        MessageBox.Show("Parabens você ganhou");
                    }
                }
                else
                {
                    //MessageBox.Show("figuras erradas");
                    timer1.Enabled = true;
                    verificar();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            vezes = vezes + 1;

            if (vezes <= 2)
            {
                button7.BackgroundImage = Properties.Resources.jogadorbas;
                jogadorbask = jogadorbask + 1;
            }
            if (vezes == 2)
            {
                if (jogadorbask == 2)
                {
                    //MessageBox.Show("Figuras Iguais");
                    vezes = 0;
                    jogadorbask = 3;
                    cont++;
                    button7.Enabled = false;
                    button22.Enabled = false;
                    if(cont == 10)
                    {
                        MessageBox.Show("Parabens você ganhou");
                    }
                }
                else
                {
                    //MessageBox.Show("figuras erradas");
                    timer1.Enabled = true;
                    verificar();
                }
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            vezes = vezes + 1;

            if (vezes <= 2)
            {
                button22.BackgroundImage = Properties.Resources.jogadorbas;
                jogadorbask = jogadorbask + 1;
            }
            if (vezes == 2)
            {
                if (jogadorbask == 2)
                {
                    //MessageBox.Show("Figuras Iguais");
                    vezes = 0;
                    jogadorbask = 3;
                    cont++;
                    button22.Enabled = false;
                    button7.Enabled = false;
                    if(cont == 10)
                    {
                        MessageBox.Show("Parabens você ganhou");
                    }
                }
                else
                {
                    //MessageBox.Show("figuras erradas");
                    timer1.Enabled = true;
                    verificar();
                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            vezes = vezes + 1;

            if (vezes <= 2)
            {
                button19.BackgroundImage = Properties.Resources.nado;
                nado = nado + 1;
            }
            if (vezes == 2)
            {
                if (nado == 2)
                {
                    //MessageBox.Show("Figuras Iguais");
                    vezes = 0;
                    nado = 3;
                    cont++;
                    button19.Enabled = false;
                    button5.Enabled = false;
                    if(cont == 10)
                    {
                        MessageBox.Show("Parabens você ganhou");
                    }
                }
                else
                {
                    //MessageBox.Show("figuras erradas");
                    timer1.Enabled = true;
                    verificar();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            vezes = vezes + 1;

            if (vezes <= 2)
            {
                button5.BackgroundImage = Properties.Resources.nado;
                nado = nado + 1;
            }
            if (vezes == 2)
            {
                if (nado == 2)
                {
                    //MessageBox.Show("Figuras Iguais");
                    vezes = 0;
                    nado = 3;
                    cont++;
                    button5.Enabled = false;
                    button19.Enabled = false;
                    if(cont == 10)
                    {
                        MessageBox.Show("Parabens você ganhou");
                    }
                }
                else
                {
                    //MessageBox.Show("figuras erradas");
                    timer1.Enabled = true;
                    verificar();
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            vezes = vezes + 1;

            if (vezes <= 2)
            {
                button14.BackgroundImage = Properties.Resources.bolabask;
                bolabask = bolabask + 1;
            }
            if (vezes == 2)
            {
                if (bolabask == 2)
                {
                    //MessageBox.Show("Figuras Iguais");
                    vezes = 0;
                    bolabask = 3;
                    cont++;
                    button14.Enabled = false;
                    button11.Enabled = false;
                    if(cont == 10)
                    {
                        MessageBox.Show("Parabens você ganhou");
                    }
                }
                else
                {
                    //MessageBox.Show("figuras erradas");
                    timer1.Enabled = true;
                    verificar();
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            vezes = vezes + 1;

            if (vezes <= 2)
            {
                button11.BackgroundImage = Properties.Resources.bolabask;
                bolabask = bolabask + 1;
            }
            if (vezes == 2)
            {
                if (bolabask == 2)
                {
                    //MessageBox.Show("Figuras Iguais");
                    vezes = 0;
                    bolabask = 3;
                    cont++;
                    button11.Enabled = false;
                    button14.Enabled = false;
                    if(cont == 10)
                    {
                        MessageBox.Show("Parabens você ganhou");
                    }
                }
                else
                {
                    //MessageBox.Show("figuras erradas");
                    timer1.Enabled = true;
                    verificar();
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            vezes = vezes + 1;

            if (vezes <= 2)
            {
                button9.BackgroundImage = Properties.Resources.rugby;
                rugby = rugby + 1;
            }
            if (vezes == 2)
            {
                if (rugby == 2)
                {
                    //MessageBox.Show("Figuras Iguais");
                    vezes = 0;
                    rugby = 3;
                    cont++;
                    button9.Enabled = false;
                    button20.Enabled = false;
                    if(cont == 10)
                    {
                        MessageBox.Show("Parabens você ganhou");
                    }
                }
                else
                {
                    //MessageBox.Show("figuras erradas");
                    timer1.Enabled = true;
                    verificar();
                }
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            vezes = vezes + 1;

            if (vezes <= 2)
            {
                button20.BackgroundImage = Properties.Resources.rugby;
                rugby = rugby + 1;
            }
            if (vezes == 2)
            {
                if (rugby == 2)
                {
                    //MessageBox.Show("Figuras Iguais");
                    vezes = 0;
                    rugby = 3;
                    cont++;
                    button20.Enabled = false;
                    button9.Enabled = false;
                    if(cont == 10)
                    {
                        MessageBox.Show("Parabens você ganhou");
                    }
                }
                else
                {
                    //MessageBox.Show("figuras erradas");
                    timer1.Enabled = true;
                    verificar();
                }
            }
        }

        public void vira()
        {
            button7.BackgroundImage = Properties.Resources.jogadorbas;
            button22.BackgroundImage = Properties.Resources.jogadorbas;

            button9.BackgroundImage = Properties.Resources.rugby;
            button20.BackgroundImage = Properties.Resources.rugby;

            button4.BackgroundImage = Properties.Resources.boxe;
            button23.BackgroundImage = Properties.Resources.boxe;

            button17.BackgroundImage = Properties.Resources.footbol;
            button8.BackgroundImage = Properties.Resources.footbol;

            button16.BackgroundImage = Properties.Resources.images;
            button10.BackgroundImage = Properties.Resources.images;

            button13.BackgroundImage = Properties.Resources.bolosoccer;
            button15.BackgroundImage = Properties.Resources.bolosoccer;

            button14.BackgroundImage = Properties.Resources.bolabask;
            button11.BackgroundImage = Properties.Resources.bolabask;

            button12.BackgroundImage = Properties.Resources.bolavolei;
            button18.BackgroundImage = Properties.Resources.bolavolei;

            button19.BackgroundImage = Properties.Resources.nado;
            button5.BackgroundImage = Properties.Resources.nado;

            button6.BackgroundImage = Properties.Resources.judo;
            button21.BackgroundImage = Properties.Resources.judo;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 50)
            {
                progressBar1.Value = progressBar1.Value + 1;
                vira();
            }
            else
            {
                timer2.Enabled = false;
                this.progressBar1.Visible = false;
                timer1.Enabled = true;
            }
        }

        public void posicao()
        {
            Point a = new Point(18, 108);
            Point b = new Point(18, 211);
            Point c = new Point(18, 321);
            Point d = new Point(18, 425);

            Point f = new Point(185, 108);
            Point g = new Point(185, 211);
            Point h = new Point(185, 321);
            Point i = new Point(185, 425);

            Point j = new Point(348, 108);
            Point k = new Point(348, 211);
            Point l = new Point(348, 321);
            Point m = new Point(348, 425);

            Point n = new Point(507, 108);
            Point o = new Point(507, 211);
            Point p = new Point(507, 321);
            Point q = new Point(507, 425);

            Point r = new Point(666, 108);
            Point s = new Point(666, 211);
            Point t = new Point(666, 321);
            Point u = new Point(666, 425);

            Random valor = new Random();
            int sorteado = valor.Next(1, 5);

            //MessageBox.Show(sorteado.ToString());

            if (sorteado == 1)
            {
                button4.Location = a;
                button23.Location = k;

                button18.Location = p;
                button12.Location = l;

                button13.Location = b;
                button15.Location = m;

                button8.Location = u;
                button17.Location = n;

                button9.Location = t;
                button20.Location = o;

                button14.Location = c;
                button11.Location = i;

                button19.Location = s;
                button5.Location = d;

                button7.Location = j;
                button22.Location = r;

                button10.Location = f;
                button16.Location = q;

                button6.Location = h;
                button21.Location = g;
            }
            if (sorteado == 2)
            {
                button4.Location = g;
                button23.Location = n;

                button18.Location = t;
                button12.Location = u;

                button13.Location = a;
                button15.Location = o;

                button8.Location = h;
                button17.Location = p;

                button9.Location = b;
                button20.Location = q;

                button14.Location = i;
                button11.Location = r;

                button19.Location = c;
                button5.Location = j;

                button7.Location = s;
                button22.Location = d;

                button10.Location = k;
                button16.Location = l;

                button6.Location = f;
                button21.Location = m;
            }
            if (sorteado == 3)
            {
                button4.Location = k;
                button23.Location = j;

                button18.Location = s;
                button12.Location = i;

                button13.Location = h;
                button15.Location = r;

                button8.Location = q;
                button17.Location = g;

                button9.Location = p;
                button20.Location = f;

                button14.Location = o;
                button11.Location = d;

                button19.Location = n;
                button5.Location = c;

                button7.Location = u;
                button22.Location = m;

                button10.Location = b;
                button16.Location = t;

                button6.Location = l;
                button21.Location = a;
            }
            if (sorteado == 4)
            {
                button4.Location = j;
                button23.Location = p;

                button18.Location = i;
                button12.Location = q;

                button13.Location = k;
                button15.Location = u;

                button8.Location = h;
                button17.Location = l;

                button9.Location = s;
                button20.Location = m;

                button14.Location = t;
                button11.Location = a;

                button19.Location = g;
                button5.Location = o;

                button7.Location = n;
                button22.Location = b;

                button10.Location = r;
                button16.Location = d;

                button6.Location = f;
                button21.Location = c;
            }
        }

        public void button3_Click(object sender, EventArgs e)
        {
            vira();
            posicao();
            novo_jogo();
            //timer1.Enabled = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            posicao();
        }
        public void novo_jogo()
        {
            button4.BackgroundImage = Properties.Resources.plano;
            button23.BackgroundImage = Properties.Resources.plano;
            button4.Enabled = true;
            button23.Enabled = true;

            button6.BackgroundImage = Properties.Resources.plano;
            button21.BackgroundImage = Properties.Resources.plano;
            button6.Enabled = true;
            button21.Enabled = true;

            button5.BackgroundImage = Properties.Resources.plano;
            button19.BackgroundImage = Properties.Resources.plano;
            button5.Enabled = true;
            button19.Enabled = true;

            button12.BackgroundImage = Properties.Resources.plano;
            button18.BackgroundImage = Properties.Resources.plano;
            button12.Enabled = true;
            button18.Enabled = true;

            button14.BackgroundImage = Properties.Resources.plano;
            button11.BackgroundImage = Properties.Resources.plano;
            button14.Enabled = true;
            button11.Enabled = true;

            button13.BackgroundImage = Properties.Resources.plano;
            button15.BackgroundImage = Properties.Resources.plano;
            button13.Enabled = true;
            button15.Enabled = true;

            button16.BackgroundImage = Properties.Resources.plano;
            button10.BackgroundImage = Properties.Resources.plano;
            button16.Enabled = true;
            button10.Enabled = true;

            button17.BackgroundImage = Properties.Resources.plano;
            button8.BackgroundImage = Properties.Resources.plano;
            button17.Enabled = true;
            button18.Enabled = true;

            button9.BackgroundImage = Properties.Resources.plano;
            button20.BackgroundImage = Properties.Resources.plano;
            button9.Enabled = true;
            button20.Enabled = true;

            button22.BackgroundImage = Properties.Resources.plano;
            button7.BackgroundImage = Properties.Resources.plano;
            button22.Enabled = true;
            button7.Enabled = true;
        }
    }
}
