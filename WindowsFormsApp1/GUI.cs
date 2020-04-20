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
        int index1 = -1;
        int index2 = -1;
        int index3 = -1;
        int index4 = -1;

        Database myDatabase = Database.GetNewInstance();
        public GUI()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HashMap1Dialog DialogWindow1 = new HashMap1Dialog();
            DialogWindow1.ShowDialog();
            if ((DialogWindow1.textBox1.Text == "") || (DialogWindow1.textBox2.Text == "") || (DialogWindow1.textBox3.Text == ""))
            {
                ErrorForm ErrorWindow = new ErrorForm();
                ErrorWindow.label1.Text = "Поля формы не могут быть пустыми";
                ErrorWindow.ShowDialog();
            }
            else
            {
                if (!((DialogWindow1.textBox1.Text == "") || (DialogWindow1.textBox2.Text == "") || (DialogWindow1.textBox3.Text == "")))
                {
                    for (int i = 0; i < DialogWindow1.textBox1.Text.Length; i++)
                    {
                        if (!(DialogWindow1.textBox1.Text[i] >= '0' && DialogWindow1.textBox1.Text[i] <= '9'))
                        {
                            ErrorForm ErrorWindow = new ErrorForm();
                            ErrorWindow.label1.Text = "Неверный формат числовых данных";
                            ErrorWindow.ShowDialog();
                            break;
                        }
                        else
                        {
                            dataGridView1.Rows.Add();
                            NumRows1 += 1;
                            dataGridView1.Rows[NumRows1].Cells[1].Value = DialogWindow1.textBox1.Text;
                            dataGridView1.Rows[NumRows1].Cells[2].Value = DialogWindow1.textBox2.Text;
                            dataGridView1.Rows[NumRows1].Cells[3].Value = DialogWindow1.textBox3.Text;
                            Machine NewMachine = new Machine(Convert.ToInt32(dataGridView1.Rows[NumRows1].Cells[1].Value),
                                Convert.ToString(dataGridView1.Rows[NumRows1].Cells[2].Value), Convert.ToString(dataGridView1.Rows[NumRows1].Cells[3].Value));
                            string tempstring = myDatabase.AddMachine(NewMachine);
                            if (tempstring == "База данных совместима")
                            {
                                HashFunction<int> myHashFunction1 = myDatabase.MachinesFunction();
                                dataGridView1.Rows[NumRows1].Cells[0].Value = myHashFunction1.Hash(NewMachine.GetKey());
                            }
                            else
                            {
                                dataGridView1.Rows.RemoveAt(NumRows1);
                                NumRows1 -= 1;
                                ErrorForm ErrorWindow = new ErrorForm();
                                ErrorWindow.label1.Text = tempstring;
                                ErrorWindow.ShowDialog();
                            }
                        }
                    }
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HashMap2Dialog DialogWindow2 = new HashMap2Dialog();
            DialogWindow2.ShowDialog();
            if ((DialogWindow2.textBox1.Text == "") || (DialogWindow2.textBox2.Text == "") || (DialogWindow2.textBox3.Text == ""))
            {
                ErrorForm ErrorWindow = new ErrorForm();
                ErrorWindow.label1.Text = "Поля формы не могут быть пустыми";
                ErrorWindow.ShowDialog();
            }
            else
            {
                dataGridView3.Rows.Add();
                NumRows2 += 1;
                dataGridView3.Rows[NumRows2].Cells[1].Value = DialogWindow2.textBox1.Text;
                dataGridView3.Rows[NumRows2].Cells[2].Value = DialogWindow2.textBox2.Text;
                dataGridView3.Rows[NumRows2].Cells[3].Value = DialogWindow2.textBox3.Text;
                Client NewClient = new Client(Convert.ToInt32(dataGridView3.Rows[NumRows2].Cells[1].Value),
                    Convert.ToString(dataGridView3.Rows[NumRows2].Cells[2].Value), Convert.ToString(dataGridView3.Rows[NumRows2].Cells[3].Value));
                string tempstring = myDatabase.AddClient(NewClient);
                if (tempstring == "База данных совместима")
                {
                    HashFunction<int> myHashFunction2 = myDatabase.ClientsFunction();
                    dataGridView3.Rows[NumRows2].Cells[0].Value = myHashFunction2.Hash(NewClient.GetKey());
                }
                else
                {
                    dataGridView3.Rows.RemoveAt(NumRows2);
                    NumRows2 -= 1;
                    ErrorForm ErrorWindow = new ErrorForm();
                    ErrorWindow.label1.Text = tempstring;
                    ErrorWindow.ShowDialog();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tree1Dialog DialogWindow3 = new Tree1Dialog();
            DialogWindow3.ShowDialog();
            if ((DialogWindow3.textBox1.Text == "") || (DialogWindow3.textBox2.Text == "") || (DialogWindow3.textBox3.Text == "") || (DialogWindow3.textBox4.Text == ""))
            {
                ErrorForm ErrorWindow = new ErrorForm();
                ErrorWindow.label1.Text = "Поля формы не могут быть пустыми";
                ErrorWindow.ShowDialog();
            }
            else
            {
                dataGridView2.Rows.Add();
                NumRows3 += 1;
                dataGridView2.Rows[NumRows3].Cells[0].Value = DialogWindow3.textBox1.Text;
                dataGridView2.Rows[NumRows3].Cells[1].Value = DialogWindow3.textBox2.Text;
                dataGridView2.Rows[NumRows3].Cells[2].Value = DialogWindow3.textBox3.Text;
                dataGridView2.Rows[NumRows3].Cells[3].Value = DialogWindow3.textBox4.Text;
                Percent NewPercent = new Percent(Convert.ToString(dataGridView2.Rows[NumRows3].Cells[0].Value),
                    Convert.ToString(dataGridView2.Rows[NumRows3].Cells[1].Value),
                    Convert.ToString(dataGridView2.Rows[NumRows3].Cells[2].Value),
                    Convert.ToInt32(dataGridView2.Rows[NumRows3].Cells[3].Value));
                string tempstring = myDatabase.AddPercent(NewPercent);
                if (tempstring == "База данных совместима")
                {

                }
                else
                {
                    dataGridView2.Rows.RemoveAt(NumRows3);
                    NumRows3 -= 1;
                    ErrorForm ErrorWindow = new ErrorForm();
                    ErrorWindow.label1.Text = tempstring;
                    ErrorWindow.ShowDialog();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tree2Dialog DialogWindow4 = new Tree2Dialog();
            DialogWindow4.ShowDialog();
            if ((DialogWindow4.textBox1.Text == "") || (DialogWindow4.textBox2.Text == "") || (DialogWindow4.textBox3.Text == "") || (DialogWindow4.textBox4.Text == ""))
            {
                ErrorForm ErrorWindow = new ErrorForm();
                ErrorWindow.label1.Text = "Поля формы не могут быть пустыми";
                ErrorWindow.ShowDialog();
            }
            else
            {
                dataGridView4.Rows.Add();
                NumRows4 += 1;
                dataGridView4.Rows[NumRows4].Cells[0].Value = DialogWindow4.textBox1.Text;
                dataGridView4.Rows[NumRows4].Cells[1].Value = DialogWindow4.textBox2.Text;
                dataGridView4.Rows[NumRows4].Cells[2].Value = DialogWindow4.textBox3.Text;
                dataGridView4.Rows[NumRows4].Cells[3].Value = DialogWindow4.textBox4.Text;
                Operation NewOperation = new Operation(Convert.ToString(dataGridView4.Rows[NumRows4].Cells[0].Value),
                    Convert.ToInt32(dataGridView4.Rows[NumRows4].Cells[1].Value),
                    Convert.ToInt32(dataGridView4.Rows[NumRows4].Cells[2].Value),
                    Convert.ToInt32(dataGridView4.Rows[NumRows4].Cells[3].Value));
                string tempstring = myDatabase.AddOperation(NewOperation);
                if (tempstring == "База данных совместима")
                {

                }
                else
                {
                    dataGridView4.Rows.RemoveAt(NumRows4);
                    NumRows4 -= 1;
                    ErrorForm ErrorWindow = new ErrorForm();
                    ErrorWindow.label1.Text = tempstring;
                    ErrorWindow.ShowDialog();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index1 = e.RowIndex;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (index1 != -1)
            {
                myDatabase.RemoveMachine(myDatabase.MachineArray()[index1]);
                dataGridView1.Rows.RemoveAt(index1);
                NumRows1 -= 1;
                index1 = -1;
            }
            else 
            {
                ErrorForm ErrorWindow = new ErrorForm();
                ErrorWindow.label1.Text = "Выберите запись, которую хотите удалить, клинкув на неё мышью";
                ErrorWindow.ShowDialog();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (index2 != -1)
            {
                myDatabase.RemoveClient(myDatabase.ClientArray()[index2]);
                dataGridView3.Rows.RemoveAt(index2);
                NumRows2 -= 1;
                index2 = -1;
            }
            else
            {
                ErrorForm ErrorWindow = new ErrorForm();
                ErrorWindow.label1.Text = "Выберите запись, которую хотите удалить, клинкув на неё мышью";
                ErrorWindow.ShowDialog();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (index3 != -1)
            {
                myDatabase.RemovePercent(myDatabase.PercentArray()[index3]);
                dataGridView2.Rows.RemoveAt(index3);
                NumRows3 -= 1;
                index3 = -1;
            }
            else
            {
                ErrorForm ErrorWindow = new ErrorForm();
                ErrorWindow.label1.Text = "Выберите запись, которую хотите удалить, клинкув на неё мышью";
                ErrorWindow.ShowDialog();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (index4 != -1)
            {
                myDatabase.RemoveOperation(myDatabase.OperationArray()[index4]);
                dataGridView4.Rows.RemoveAt(index4);
                NumRows4 -= 1;
                index4 = -1;
            }
            else
            {
                ErrorForm ErrorWindow = new ErrorForm();
                ErrorWindow.label1.Text = "Выберите запись, которую хотите удалить, клинкув на неё мышью";
                ErrorWindow.ShowDialog();
            }
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index2 = e.RowIndex;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index3 = e.RowIndex;
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index4 = e.RowIndex;
        }
    }
}
