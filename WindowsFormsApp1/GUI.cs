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
            string errormessage = "";
            bool flagstring = false;
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

                for (int i = 0; i < DialogWindow1.textBox1.Text.Length; i++)
                {
                    if (!(DialogWindow1.textBox1.Text[i] >= '0' && DialogWindow1.textBox1.Text[i] <= '9'))
                    {
                        errormessage = errormessage + "Неверный формат данных в поле <Номер>\n\n";
                        flagstring = true;
                        break;
                    }
                }
                if ((flagstring == false) && ((Convert.ToInt32(DialogWindow1.textBox1.Text) < 1) || (Convert.ToInt32(DialogWindow1.textBox1.Text) > 500)))
                {
                    errormessage = errormessage + "Значение не попадает в допустимый диапазон поля <Номер>\n\n";
                }
                for (int i = 0; i < DialogWindow1.textBox2.Text.Length; i++)
                {
                    if (!(DialogWindow1.textBox2.Text[i] >= 'А' && DialogWindow1.textBox2.Text[i] <= 'Я') && !(DialogWindow1.textBox2.Text[i] >= 'а' && DialogWindow1.textBox2.Text[i] <= 'я'))
                    {
                        errormessage = errormessage + "Неверный формат данных в поле <Адрес>\n\n";
                        break;
                    }
                }
                for (int i = 0; i < DialogWindow1.textBox3.Text.Length; i++)
                {
                    if (!(DialogWindow1.textBox3.Text[i] >= 'А' && DialogWindow1.textBox3.Text[i] <= 'Я') && !(DialogWindow1.textBox3.Text[i] >= 'а' && DialogWindow1.textBox3.Text[i] <= 'я'))
                    {
                        errormessage = errormessage + "Неверный формат данных в поле <Название>\n\n";
                        break;
                    }
                }
                if (errormessage == "")
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
                else 
                {
                    ErrorForm ErrorWindow = new ErrorForm();
                    ErrorWindow.label1.Text = errormessage;
                    ErrorWindow.ShowDialog();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string errormessage = "";
            bool flagstring = false;
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
                for (int i = 0; i < DialogWindow2.textBox1.Text.Length; i++)
                {
                    if (!(DialogWindow2.textBox1.Text[i] >= '0' && DialogWindow2.textBox1.Text[i] <= '9'))
                    {
                        errormessage = errormessage + "Неверный формат данных в поле <Номер карточки>\n\n";
                        flagstring = true;
                        break;
                    }
                }
                if ((flagstring == false) && ((Convert.ToInt32(DialogWindow2.textBox1.Text) < 111) || (Convert.ToInt32(DialogWindow2.textBox1.Text) > 999999999)))
                {
                    errormessage = errormessage + "Значение не попадает в допустимый диапазон поля <Номер карточки>\n\n";
                }
                for (int i = 0; i < DialogWindow2.textBox2.Text.Length; i++)
                {
                    if (!(DialogWindow2.textBox2.Text[i] >= 'А' && DialogWindow2.textBox2.Text[i] <= 'Я') && !(DialogWindow2.textBox2.Text[i] >= 'а' && DialogWindow2.textBox2.Text[i] <= 'я'))
                    {
                        errormessage = errormessage + "Неверный формат данных в поле <Обслуживающий банк>\n\n";
                        break;
                    }
                }
                for (int i = 0; i < DialogWindow2.textBox3.Text.Length; i++)
                {
                    if (!(DialogWindow2.textBox3.Text[i] >= 'А' && DialogWindow2.textBox3.Text[i] <= 'Я') && !(DialogWindow2.textBox3.Text[i] >= 'а' && DialogWindow2.textBox3.Text[i] <= 'я'))
                    {
                        errormessage = errormessage + "Неверный формат данных в поле <ФИО>\n\n";
                        break;
                    }
                }
                if (errormessage == "")
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
                else
                {
                    ErrorForm ErrorWindow = new ErrorForm();
                    ErrorWindow.label1.Text = errormessage;
                    ErrorWindow.ShowDialog();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string errormessage = "";
            bool flagstring = false;
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
                for (int i = 0; i < DialogWindow3.textBox4.Text.Length; i++)
                {
                    if (!(DialogWindow3.textBox4.Text[i] >= '0' && DialogWindow3.textBox4.Text[i] <= '9'))
                    {
                        errormessage = errormessage + "Неверный формат данных в поле <Процент>\n\n";
                        flagstring = true;
                        break;
                    }
                }
                if ((flagstring == false) && ((Convert.ToInt32(DialogWindow3.textBox4.Text) < 0) || (Convert.ToInt32(DialogWindow3.textBox4.Text) > 100)))
                {
                    errormessage = errormessage + "Значение не попадает в допустимый диапазон поля <Процент>\n\n";
                }
                for (int i = 0; i < DialogWindow3.textBox1.Text.Length; i++)
                {
                    if (!(DialogWindow3.textBox1.Text[i] >= 'А' && DialogWindow3.textBox1.Text[i] <= 'Я') && !(DialogWindow3.textBox1.Text[i] >= 'а' && DialogWindow3.textBox1.Text[i] <= 'я'))
                    {
                        errormessage = errormessage + "Неверный формат данных в поле <Тип операции>\n\n";
                        break;
                    }
                }
                for (int i = 0; i < DialogWindow3.textBox2.Text.Length; i++)
                {
                    if (!(DialogWindow3.textBox2.Text[i] >= 'А' && DialogWindow3.textBox2.Text[i] <= 'Я') && !(DialogWindow3.textBox2.Text[i] >= 'а' && DialogWindow3.textBox2.Text[i] <= 'я'))
                    {
                        errormessage = errormessage + "Неверный формат данных в поле <Банк-отправитель>\n\n";
                        break;
                    }
                }
                for (int i = 0; i < DialogWindow3.textBox3.Text.Length; i++)
                {
                    if (!(DialogWindow3.textBox3.Text[i] >= 'А' && DialogWindow3.textBox3.Text[i] <= 'Я') && !(DialogWindow3.textBox3.Text[i] >= 'а' && DialogWindow3.textBox3.Text[i] <= 'я'))
                    {
                        errormessage = errormessage + "Неверный формат данных в поле <Банк-получатель>\n\n";
                        break;
                    }
                }
                if (errormessage == "")
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
                else
                {
                    ErrorForm ErrorWindow = new ErrorForm();
                    ErrorWindow.label1.Text = errormessage;
                    ErrorWindow.ShowDialog();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string errormessage = "";
            bool flagstring1 = false;
            bool flagstring2 = false;
            bool flagstring3 = false;
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
                for (int i = 0; i < DialogWindow4.textBox1.Text.Length; i++)
                {
                    if (!(DialogWindow4.textBox1.Text[i] >= 'А' && DialogWindow4.textBox1.Text[i] <= 'Я') && !(DialogWindow4.textBox1.Text[i] >= 'а' && DialogWindow4.textBox1.Text[i] <= 'я'))
                    {
                        errormessage = errormessage + "Неверный формат данных в поле <Тип операции>\n\n";
                        break;
                    }
                }
                for (int i = 0; i < DialogWindow4.textBox2.Text.Length; i++)
                {
                    if (!(DialogWindow4.textBox2.Text[i] >= '0' && DialogWindow4.textBox2.Text[i] <= '9') && !(DialogWindow4.textBox2.Text[i] >= 'а' && DialogWindow4.textBox2.Text[i] <= 'я'))
                    {
                        errormessage = errormessage + "Неверный формат данных в поле <Номер карточки>\n\n";
                        flagstring1 = true;
                    }
                    break;
                }
                if ((flagstring1 == false) && ((Convert.ToInt32(DialogWindow4.textBox2.Text) < 111) || (Convert.ToInt32(DialogWindow4.textBox2.Text) > 999999999)))
                {
                    errormessage = errormessage + "Значение не попадает в допустимый диапазон поля <Номер карточки>\n\n";
                }
                for (int i = 0; i < DialogWindow4.textBox3.Text.Length; i++)
                {
                    if (!(DialogWindow4.textBox3.Text[i] >= '0' && DialogWindow4.textBox3.Text[i] <= '9'))
                    {
                        errormessage = errormessage + "Неверный формат данных в поле <Номер банкомата>\n\n";
                        flagstring2 = true;
                    }
                    break;
                }
                if ((flagstring2 == false) && ((Convert.ToInt32(DialogWindow4.textBox2.Text) < 1) || (Convert.ToInt32(DialogWindow4.textBox2.Text) > 500)))
                {
                    errormessage = errormessage + "Значение не попадает в допустимый диапазон поля <Номер банкомата>\n\n";
                }
                for (int i = 0; i < DialogWindow4.textBox4.Text.Length; i++)
                {
                    if (!(DialogWindow4.textBox4.Text[i] >= '0' && DialogWindow4.textBox4.Text[i] <= '9'))
                    {
                        errormessage = errormessage + "Неверный формат данных в поле <Сумма операции>\n\n";
                        flagstring3 = true;
                    }
                    break;
                }
                if ((flagstring3 == false) && ((Convert.ToInt32(DialogWindow4.textBox4.Text) < 0) || (Convert.ToInt32(DialogWindow4.textBox4.Text) > 10000000)))
                {
                    errormessage = errormessage + "Значение не попадает в допустимый диапазон поля <Сумма операции>\n\n";
                }
                if (errormessage == "")
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
                else
                {
                    ErrorForm ErrorWindow = new ErrorForm();
                    ErrorWindow.label1.Text = errormessage;
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
                Machine removableMachine = new Machine (Convert.ToInt32(dataGridView1.Rows[index1].Cells[1].Value), Convert.ToString(dataGridView1.Rows[index1].Cells[2].Value), Convert.ToString(dataGridView1.Rows[index1].Cells[3].Value));
                myDatabase.RemoveMachine(removableMachine);
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
                Client removableClient = new Client(Convert.ToInt32(dataGridView3.Rows[index2].Cells[1].Value), Convert.ToString(dataGridView3.Rows[index2].Cells[2].Value), Convert.ToString(dataGridView3.Rows[index2].Cells[3].Value));
                myDatabase.RemoveClient(removableClient);
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
                Percent removablePercent = new Percent(Convert.ToString(dataGridView2.Rows[index3].Cells[0].Value), Convert.ToString(dataGridView2.Rows[index3].Cells[1].Value), Convert.ToString(dataGridView2.Rows[index3].Cells[2].Value), Convert.ToInt32(dataGridView2.Rows[index3].Cells[3].Value));
                myDatabase.RemovePercent(removablePercent);
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
                Operation removableOperation = new Operation(Convert.ToString(dataGridView4.Rows[index4].Cells[0].Value), Convert.ToInt32(dataGridView4.Rows[index4].Cells[1].Value), Convert.ToInt32(dataGridView4.Rows[index4].Cells[2].Value), Convert.ToInt32(dataGridView4.Rows[index4].Cells[3].Value));
                myDatabase.RemoveOperation(removableOperation);
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
