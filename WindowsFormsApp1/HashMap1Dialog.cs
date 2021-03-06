﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace WindowsFormsApp1
{
    public partial class HashMap1Dialog : Form
    {
        public HashMap1Dialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((waterMarkTextBox1.Text == "") || (waterMarkTextBox2.Text == "") || (waterMarkTextBox3.Text == ""))
            {
                ErrorForm ErrorWindow = new ErrorForm();
                ErrorWindow.label1.Text = "Поля формы не могут быть пустыми";
                ErrorWindow.ShowDialog();
            }
            else
            {
                Result rez = Checks.CheckMachine(waterMarkTextBox1.Text, waterMarkTextBox2.Text, waterMarkTextBox3.Text);
                if (rez.Success)
                {
                    Close();
                }
                else
                {
                    ErrorForm ErrorWindow = new ErrorForm();
                    ErrorWindow.label1.Text = rez.Message;
                    ErrorWindow.ShowDialog();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GUI.stopflag = true;
            Close();
        }
    }
}
