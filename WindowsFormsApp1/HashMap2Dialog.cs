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
    public partial class HashMap2Dialog : Form
    {
        public HashMap2Dialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string errormessage = "";
            bool flagstring = false;
            if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (textBox3.Text == "_"))
            {
                ErrorForm ErrorWindow = new ErrorForm();
                ErrorWindow.label1.Text = "Поля формы не могут быть пустыми";
                ErrorWindow.ShowDialog();
            }
            else
            {
                for (int i = 0; i < textBox1.Text.Length; i++)
                {
                    if (!(textBox1.Text[i] >= '0' && textBox1.Text[i] <= '9'))
                    {
                        errormessage = errormessage + "Неверный формат данных в поле <Номер карточки>\n\n";
                        flagstring = true;
                        break;
                    }
                }
                if ((flagstring == false) && ((Convert.ToInt32(textBox1.Text) < 1) || (Convert.ToInt32(textBox1.Text) > 99999999)))
                {
                    errormessage = errormessage + "Значение не попадает в допустимый диапазон поля <Номер карточки> 1..99999999\n\n";
                }
                for (int i = 0; i < textBox2.Text.Length; i++)
                {
                    if (!(textBox2.Text[i] >= 'А' && textBox2.Text[i] <= 'Я') && !(textBox2.Text[i] >= 'а' && textBox2.Text[i] <= 'я'))
                    {
                        errormessage = errormessage + "Неверный формат данных в поле <Обслуживающий банк>\n\n";
                        break;
                    }
                }
                if (textBox2.Text.Length > 20)
                {
                    errormessage = errormessage + "Слишком длинное поле <Обслуживающий банк> (более 20 символов)\n\n";
                }
                if (!(textBox2.Text[0] >= 'А' && textBox2.Text[0] <= 'Я')
                    && !(textBox2.Text[0] >= 'A' && textBox2.Text[0] <= 'Z'))
                {
                    errormessage = errormessage + "Поле <Обслуживающий банк> должно начинаться с заглавной буквы\n\n";
                }
                for (int i = 0; i < textBox3.Text.Length; i++)
                {
                    if (!(textBox3.Text[i] >= 'А' && textBox3.Text[i] <= 'Я') && !(textBox3.Text[i] >= 'а' && textBox3.Text[i] == '_'))
                    {
                        errormessage = errormessage + "Неверный формат данных в поле <ФИО>\n\n";
                        break;
                    }
                }
                if (textBox3.Text.Length > 40)
                {
                    errormessage = errormessage + "Слишком длинное поле <ФИО> (более 40 символов)\n\n";
                }
                if (!(textBox3.Text[0] >= 'А' && textBox3.Text[0] <= 'Я')
                    && !(textBox3.Text[0] >= 'A' && textBox3.Text[0] <= 'Z'))
                {
                    errormessage = errormessage + "Поле <ФИО> должно начинаться с заглавной буквы\n\n";
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
