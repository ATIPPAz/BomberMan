﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BomberMan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenGameForm(object sender, EventArgs e)
        {
            Game GameForm = new Game();
            GameForm.Show();
            this.Hide();
        }

        private void CloseForm(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
