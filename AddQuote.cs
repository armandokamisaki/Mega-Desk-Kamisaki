﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mega_Desk_Kamisaki
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            mainMenu viewMainMenu = (mainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainMenu main = this.Tag as mainMenu;
            main.Show();
        }
    }
}
