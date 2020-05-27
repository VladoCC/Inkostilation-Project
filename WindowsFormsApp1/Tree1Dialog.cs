using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (textBox4.Text == ""))
            {
                ErrorForm ErrorWindow = new ErrorForm();
                ErrorWindow.label1.Text = "Поля формы не могут быть пустыми";
                ErrorWindow.ShowDialog();
            }
            else
            {
                for (int i = 0; i < textBox4.Text.Length; i++)
                {
                    if (!(textBox4.Text[i] >= '0' && textBox4.Text[i] <= '9'))
                    {
                        errormessage = errormessage + "Неверный формат данных в поле <Процент>\n\n";
                        flagstring = true;
                        break;
                    }
                }
                if ((flagstring == false) && ((Convert.ToInt32(textBox4.Text) < 0) || (Convert.ToInt32(textBox4.Text) > 100)))
                {
                    errormessage = errormessage + "Значение не попадает в допустимый диапазон поля <Процент> 0..100\n\n";
                }
                for (int i = 0; i < textBox1.Text.Length; i++)
                {
                    if (!(textBox1.Text[i] >= 'А' && textBox1.Text[i] <= 'Я') && !(textBox1.Text[i] >= 'а' && textBox1.Text[i] <= 'я'))
                    {
                        errormessage = errormessage + "Неверный формат данных в поле <Название операции>\n\n";
                        break;
                    }
                }
                if (textBox1.Text.Length > 20)
                {
                    errormessage = errormessage + "Слишком длинное поле <Название операции> (более 20 символов)\n\n";
                }
                if ((textBox1.Text[0] >= 'А' && textBox1.Text[0] <= 'Я') || (textBox1.Text[0] >= 'A' && textBox1.Text[0] <= 'Z'))
                {
                    bigflag = true;
                }
                else
                {
                    errormessage = errormessage + "Поле <Название операции> должно начинаться с заглавной буквы\n\n";
                }
                for (int i = 1; i < textBox1.Text.Length; i++)
                {
                    if (((textBox1.Text[i] >= 'А' && textBox1.Text[i] <= 'Я') || (textBox1.Text[0] >= 'A' && textBox1.Text[0] <= 'Z')) && bigflag)
                    {
                        errormessage = errormessage + "В поле <Название операции> не может быть более одной заглавной буквы\n\n";
                        break;
                    }
                }
                for (int i = 0; i < textBox2.Text.Length; i++)
                {
                    if (!(textBox2.Text[i] >= 'А' && textBox2.Text[i] <= 'Я') && !(textBox2.Text[i] >= 'а' && textBox2.Text[i] <= 'я'))
                    {
                        errormessage = errormessage + "Неверный формат данных в поле <Банк-отправитель>\n\n";
                        break;
                    }
                }
                if (textBox2.Text.Length > 20)
                {
                    errormessage = errormessage + "Слишком длинное поле <Банк-отправитель> (более 20 символов)\n\n";
                }
                if (!(textBox2.Text[0] >= 'А' && textBox2.Text[0] <= 'Я') && !(textBox2.Text[0] >= 'A' && textBox2.Text[0] <= 'Z'))
                {
                    errormessage = errormessage + "Поле <Банк-отправитель> должно начинаться с заглавной буквы\n\n";
                }
                for (int i = 0; i < textBox3.Text.Length; i++)
                {
                    if (!(textBox3.Text[i] >= 'А' && textBox3.Text[i] <= 'Я') && !(textBox3.Text[i] >= 'а' && textBox3.Text[i] <= 'я'))
                    {
                        errormessage = errormessage + "Неверный формат данных в поле <Банк-получатель>\n\n";
                        break;
                    }
                }
                if (textBox3.Text.Length > 20)
                {
                    errormessage = errormessage + "Слишком длинное поле <Банк-получатель> (более 20 символов)\n\n";
                }
                if (!(textBox3.Text[0] >= 'А' && textBox3.Text[0] <= 'Я') && !(textBox3.Text[0] >= 'A' && textBox3.Text[0] <= 'Z'))
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
    }
}
