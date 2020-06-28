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
            if ((waterMarkTextBox1.Text == "") || (waterMarkTextBox2.Text == "") || (waterMarkTextBox3.Text == "") || (waterMarkTextBox3.Text == "_"))
            {
                ErrorForm ErrorWindow = new ErrorForm();
                ErrorWindow.label1.Text = "Поля формы не могут быть пустыми";
                ErrorWindow.ShowDialog();
            }
            else
            {
                for (int i = 0; i < waterMarkTextBox1.Text.Length; i++)
                {
                    if (!(waterMarkTextBox1.Text[i] >= '0' && waterMarkTextBox1.Text[i] <= '9'))
                    {
                        errormessage = errormessage + "Неверный формат данных в поле <Номер карточки>\n\n";
                        flagstring = true;
                        break;
                    }
                }
                if ((flagstring == false) && ((Convert.ToInt32(waterMarkTextBox1.Text) < 1) || (Convert.ToInt32(waterMarkTextBox1.Text) > 99999999)))
                {
                    errormessage = errormessage + "Значение " + waterMarkTextBox1.Text + " не попадает в допустимый диапазон поля <Номер карточки> 1..99999999\n\n";
                }
                for (int i = 0; i < waterMarkTextBox2.Text.Length; i++)
                {
                    if (!(waterMarkTextBox2.Text[i] >= 'А' && waterMarkTextBox2.Text[i] <= 'Я') && !(waterMarkTextBox2.Text[i] >= 'а' && waterMarkTextBox2.Text[i] <= 'я'))
                    {
                        errormessage = errormessage + "Неверный формат данных в поле <Обслуживающий банк>\n\n";
                        break;
                    }
                }
                if (waterMarkTextBox2.Text.Length > 20)
                {
                    errormessage = errormessage + "Слишком длинное поле <Обслуживающий банк> (более 20 символов)\n\n";
                }
                if (!(waterMarkTextBox2.Text[0] >= 'А' && waterMarkTextBox2.Text[0] <= 'Я')
                    && !(waterMarkTextBox2.Text[0] >= 'A' && waterMarkTextBox2.Text[0] <= 'Z'))
                {
                    errormessage = errormessage + "Поле <Обслуживающий банк> должно начинаться с заглавной буквы\n\n";
                }
                for (int i = 0; i < waterMarkTextBox3.Text.Length; i++)
                {
                    if (!(waterMarkTextBox3.Text[i] >= 'А' && waterMarkTextBox3.Text[i] <= 'Я') && !(waterMarkTextBox3.Text[i] >= 'а' && waterMarkTextBox3.Text[i] <= 'я') && !(waterMarkTextBox3.Text[i] == '_'))
                    {
                        errormessage = errormessage + "Неверный формат данных в поле <ФИО>\n\n";
                        break;
                    }
                }
                if (waterMarkTextBox3.Text.Length > 40)
                {
                    errormessage = errormessage + "Слишком длинное поле <ФИО> (более 40 символов)\n\n";
                }
                if (!(waterMarkTextBox3.Text[0] >= 'А' && waterMarkTextBox3.Text[0] <= 'Я')
                    && !(waterMarkTextBox3.Text[0] >= 'A' && waterMarkTextBox3.Text[0] <= 'Z'))
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

        private void button2_Click(object sender, EventArgs e)
        {
            GUI.stopflag = true;
            Close();
        }
    }
}
