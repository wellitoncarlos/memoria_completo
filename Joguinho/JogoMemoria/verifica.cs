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
    public partial class verifica : Form
    {
        public verifica()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 5)
            {
                progressBar1.Value = progressBar1.Value + 1;
            }
            else
            {
                this.Close();
            }
        }

        private void verifica_Load(object sender, EventArgs e)
        {

        }
    }
}
