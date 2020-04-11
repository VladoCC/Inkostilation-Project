using System;
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
            if (tempstring == "")
            {
                HashFunction<int> myHashFunction1 = myDatabase.MachinesFunction();
                dataGridView1.Rows[NumRows1].Cells[0].Value = myHashFunction1.Hash(NewMachine.GetKey());
            }
            else
            {
                dataGridView1.Rows.RemoveAt(NumRows1);
                NumRows1 -= 1;
                ErrorForm ErrorWindow = new ErrorForm();
                ErrorWindow.ShowDialog();
                ErrorWindow.label1.Text = tempstring;
            }
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
            if (tempstring == "")
            {
                HashFunction<int> myHashFunction2 = myDatabase.ClientsFunction();
                dataGridView3.Rows[NumRows2].Cells[0].Value = myHashFunction2.Hash(NewClient.GetKey());
            }
            else
            {
                dataGridView3.Rows.RemoveAt(NumRows2);
                NumRows2 -= 1;
                ErrorForm ErrorWindow = new ErrorForm();
                ErrorWindow.ShowDialog();
                ErrorWindow.label1.Text = tempstring;
            }
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
            Percent NewPercent = new Percent(Convert.ToString(dataGridView2.Rows[NumRows3].Cells[0].Value),
                Convert.ToString(dataGridView2.Rows[NumRows3].Cells[1].Value),
                Convert.ToString(dataGridView2.Rows[NumRows3].Cells[2].Value),
                Convert.ToInt32(dataGridView2.Rows[NumRows3].Cells[3].Value));
            string tempstring = myDatabase.AddPercent(NewPercent);
            if (tempstring == "")
            {

            }
            else
            {
                dataGridView2.Rows.RemoveAt(NumRows3);
                NumRows3 -= 1;
                ErrorForm ErrorWindow = new ErrorForm();
                ErrorWindow.ShowDialog();
                ErrorWindow.label1.Text = tempstring;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tree2Dialog DialogWindow4 = new Tree2Dialog();
            DialogWindow4.ShowDialog();
            NumRows4 += 1;
            dataGridView4.Rows.Add();
            dataGridView4.Rows[NumRows4].Cells[0].Value = DialogWindow4.textBox1.Text;
            dataGridView4.Rows[NumRows4].Cells[1].Value = DialogWindow4.textBox2.Text;
            dataGridView4.Rows[NumRows4].Cells[2].Value = DialogWindow4.textBox3.Text;
            dataGridView4.Rows[NumRows4].Cells[3].Value = DialogWindow4.textBox4.Text;
            Operation NewOperation = new Operation(Convert.ToString(dataGridView4.Rows[NumRows4].Cells[0].Value),
                Convert.ToInt32(dataGridView4.Rows[NumRows4].Cells[1].Value),
                Convert.ToInt32(dataGridView4.Rows[NumRows4].Cells[2].Value),
                Convert.ToInt32(dataGridView4.Rows[NumRows4].Cells[3].Value));
            string tempstring = myDatabase.AddOperation(NewOperation);
            if (tempstring == "")
            {

            }
            else
            {
                dataGridView4.Rows.RemoveAt(NumRows4);
                NumRows4 -= 1;
                ErrorForm ErrorWindow = new ErrorForm();
                ErrorWindow.ShowDialog();
                ErrorWindow.label1.Text = tempstring;
            }
        }
    }
}
