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
    public partial class GUI : Form
    {
        int NumRows1 = -1;
        int NumRows2 = -1;
        int NumRows3 = -1;
        int NumRows4 = -1;

        Database myDatabase = Database.GetNewInstance();
        public GUI()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HashMap1Dialog DialogWindow1 = new HashMap1Dialog();
            DialogWindow1.ShowDialog();
            NumRows1 += 1;
            dataGridView1.Rows.Add();
            dataGridView1.Rows[NumRows1].Cells[1].Value = DialogWindow1.textBox1.Text;
            dataGridView1.Rows[NumRows1].Cells[2].Value = DialogWindow1.textBox2.Text;
            dataGridView1.Rows[NumRows1].Cells[3].Value = DialogWindow1.textBox3.Text;
            Machine NewMachine = new Machine(Convert.ToInt32(dataGridView1.Rows[NumRows1].Cells[1].Value),
                Convert.ToString(dataGridView1.Rows[NumRows1].Cells[2].Value), Convert.ToString(dataGridView1.Rows[NumRows1].Cells[3].Value));
            string tempstring = myDatabase.AddMachine(NewMachine);
            HashFunction<int> myHashFunction1 = myDatabase.MachinesFunction();
            dataGridView1.Rows[NumRows1].Cells[0].Value = myHashFunction1.Hash(NewMachine.GetKey());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HashMap2Dialog DialogWindow2 = new HashMap2Dialog();
            DialogWindow2.ShowDialog();
            NumRows2 += 1;
            dataGridView3.Rows.Add();
            dataGridView3.Rows[NumRows2].Cells[1].Value = DialogWindow2.textBox1.Text;
            dataGridView3.Rows[NumRows2].Cells[2].Value = DialogWindow2.textBox2.Text;
            dataGridView3.Rows[NumRows2].Cells[3].Value = DialogWindow2.textBox3.Text;
            Client NewClient = new Client(Convert.ToInt32(dataGridView3.Rows[NumRows2].Cells[1].Value),
                Convert.ToString(dataGridView3.Rows[NumRows2].Cells[2].Value), Convert.ToString(dataGridView3.Rows[NumRows2].Cells[3].Value));
            string tempstring = myDatabase.AddClient(NewClient);
            HashFunction<int> myHashFunction2 = myDatabase.ClientsFunction();
            dataGridView3.Rows[NumRows2].Cells[0].Value = myHashFunction2.Hash(NewClient.GetKey());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tree1Dialog DialogWindow3 = new Tree1Dialog();
            DialogWindow3.ShowDialog();
            NumRows3 += 1;
            dataGridView2.Rows.Add();
            dataGridView2.Rows[NumRows3].Cells[0].Value = DialogWindow3.textBox1.Text;
            dataGridView2.Rows[NumRows3].Cells[1].Value = DialogWindow3.textBox2.Text;
            dataGridView2.Rows[NumRows3].Cells[2].Value = DialogWindow3.textBox3.Text;
            dataGridView2.Rows[NumRows3].Cells[3].Value = DialogWindow3.textBox4.Text;
            Percent NewPercent = new Percent(Convert.ToInt32(dataGridView3.Rows[NumRows3].Cells[1].Value),
                Convert.ToString(dataGridView3.Rows[NumRows3].Cells[2].Value), 
                Convert.ToString(dataGridView3.Rows[NumRows3].Cells[3].Value),
                Convert.ToInt32(dataGridView3.Rows[NumRows3].Cells[3].Value));
            //myDatabase.AddPercent(NewPercent);
        }
    }
}
