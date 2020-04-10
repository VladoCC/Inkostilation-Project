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
        int NumRows = -1;
        HashMap<int, Machine> map = new HashMap<int, Machine>(new ModFunction(),
           new ListStorage<int, Machine>());
        public GUI()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HashMap1Dialog DialogWindow1 = new HashMap1Dialog();
            DialogWindow1.ShowDialog();
            NumRows += 1;
            dataGridView1.Rows.Add();
            dataGridView1.Rows[NumRows].Cells[1].Value = DialogWindow1.textBox1.Text;
            dataGridView1.Rows[NumRows].Cells[2].Value = DialogWindow1.textBox2.Text;
            dataGridView1.Rows[NumRows].Cells[3].Value = DialogWindow1.textBox3.Text;
            Machine machine1 = new Machine(Convert.ToInt32(dataGridView1.Rows[NumRows].Cells[1].Value),
                Convert.ToString(dataGridView1.Rows[NumRows].Cells[2].Value), Convert.ToString(dataGridView1.Rows[NumRows].Cells[3].Value));
            map.Add(machine1);
        }
    }
}
