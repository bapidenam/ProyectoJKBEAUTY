﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bienvenido
{
    public partial class Bienvenido : Form
    {
        public Bienvenido()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bunifuCircleProgressbar1.Value += 1;
            if(this.Opacity < 1)
            {
                this.Opacity += 0.05;
            }
            if(bunifuCircleProgressbar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void Bienvenido_Load(object sender, EventArgs e)
        {
            bunifuCircleProgressbar1.Value = 0;
            this.Opacity = 0;
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if(this.Opacity == 0)
            {
                timer2.Stop();
                this.Close();
            }
        }
    }
}
