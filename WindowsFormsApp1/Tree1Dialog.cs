using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Tree1Dialog : Form
    {
        public Tree1Dialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool bigflag = false;
            string errormessage = "";
            bool flagstring = false;
            if ((waterMarkTextBox1.Text == "") || (waterMarkTextBox2.Text == "") || (waterMarkTextBox3.Text == "") || (waterMarkTextBox4.Text == ""))
            {
                ErrorForm ErrorWindow = new ErrorForm();
                ErrorWindow.label1.Text = "Поля формы не могут быть пустыми";
                ErrorWindow.ShowDialog();
            }
            else
            {
                for (int i = 0; i < waterMarkTextBox4.Text.Length; i++)
                {
                    if (!(waterMarkTextBox4.Text[i] >= '0' && waterMarkTextBox4.Text[i] <= '9'))
                    {
                        errormessage = errormessage + "Неверный формат данных в поле <Процент>\n\n";
                        flagstring = true;
                        break;
                    }
                }
                if ((flagstring == false) && ((Convert.ToInt32(waterMarkTextBox4.Text) < 0) || (Convert.ToInt32(waterMarkTextBox4.Text) > 100)))
                {
                    errormessage = errormessage + "Значение не попадает в допустимый диапазон поля <Процент> 0..100\n\n";
                }
                for (int i = 0; i < waterMarkTextBox1.Text.Length; i++)
                {
                    if (!(waterMarkTextBox1.Text[i] >= 'А' && waterMarkTextBox1.Text[i] <= 'Я') && !(waterMarkTextBox1.Text[i] >= 'а' && waterMarkTextBox1.Text[i] <= 'я'))
                    {
                        errormessage = errormessage + "Неверный формат данных в поле <Название операции>\n\n";
                        break;
                    }
                }
                if (waterMarkTextBox1.Text.Length > 20)
                {
                    errormessage = errormessage + "Слишком длинное поле <Название операции> (более 20 символов)\n\n";
                }
                if ((waterMarkTextBox1.Text[0] >= 'А' && waterMarkTextBox1.Text[0] <= 'Я') || (waterMarkTextBox1.Text[0] >= 'A' && waterMarkTextBox1.Text[0] <= 'Z'))
                {
                    bigflag = true;
                }
                else
                {
                    errormessage = errormessage + "Поле <Название операции> должно начинаться с заглавной буквы\n\n";
                }
                for (int i = 1; i < waterMarkTextBox1.Text.Length; i++)
                {
                    if (((waterMarkTextBox1.Text[i] >= 'А' && waterMarkTextBox1.Text[i] <= 'Я') || (waterMarkTextBox1.Text[0] >= 'A' && waterMarkTextBox1.Text[0] <= 'Z')) && bigflag)
                    {
                        errormessage = errormessage + "В поле <Название операции> не может быть более одной заглавной буквы\n\n";
                        break;
                    }
                }
                for (int i = 0; i < waterMarkTextBox2.Text.Length; i++)
                {
                    if (!(waterMarkTextBox2.Text[i] >= 'А' && waterMarkTextBox2.Text[i] <= 'Я') && !(waterMarkTextBox2.Text[i] >= 'а' && waterMarkTextBox2.Text[i] <= 'я'))
                    {
                        errormessage = errormessage + "Неверный формат данных в поле <Банк-отправитель>\n\n";
                        break;
                    }
                }
                if (waterMarkTextBox2.Text.Length > 20)
                {
                    errormessage = errormessage + "Слишком длинное поле <Банк-отправитель> (более 20 символов)\n\n";
                }
                if (!(waterMarkTextBox2.Text[0] >= 'А' && waterMarkTextBox2.Text[0] <= 'Я') && !(waterMarkTextBox2.Text[0] >= 'A' && waterMarkTextBox2.Text[0] <= 'Z'))
                {
                    errormessage = errormessage + "Поле <Банк-отправитель> должно начинаться с заглавной буквы\n\n";
                }
                for (int i = 0; i < waterMarkTextBox3.Text.Length; i++)
                {
                    if (!(waterMarkTextBox3.Text[i] >= 'А' && waterMarkTextBox3.Text[i] <= 'Я') && !(waterMarkTextBox3.Text[i] >= 'а' && waterMarkTextBox3.Text[i] <= 'я'))
                    {
                        errormessage = errormessage + "Неверный формат данных в поле <Банк-получатель>\n\n";
                        break;
                    }
                }
                if (waterMarkTextBox3.Text.Length > 20)
                {
                    errormessage = errormessage + "Слишком длинное поле <Банк-получатель> (более 20 символов)\n\n";
                }
                if (!(waterMarkTextBox3.Text[0] >= 'А' && waterMarkTextBox3.Text[0] <= 'Я') && !(waterMarkTextBox3.Text[0] >= 'A' && waterMarkTextBox3.Text[0] <= 'Z'))
                {
                    errormessage = errormessage + "Поле <Банк-получатель> должно начинаться с заглавной буквы\n\n";
                }
                if (errormessage == "")
                {
                    Close();
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
            GUI.stopflag = true;
            Close();
        }
    }
}
