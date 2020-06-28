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
    public partial class HashMap1Dialog : Form
    {
        public HashMap1Dialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool bigflag = false;
            string errormessage = "";
            bool flagstring = false;
            if ((waterMarkTextBox1.Text == "") || (waterMarkTextBox2.Text == "") || (waterMarkTextBox3.Text == ""))
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
                        errormessage = errormessage + "Неверный формат данных в поле <Номер>\n\n";
                        flagstring = true;
                        break;
                    }
                }
                if ((flagstring == false) && ((Convert.ToInt32(waterMarkTextBox1.Text) < 1) || (Convert.ToInt32(waterMarkTextBox1.Text) > 500)))
                {
                    errormessage = errormessage + "Значение " + waterMarkTextBox1.Text + " не попадает в допустимый диапазон поля <Номер> 1..500\n\n";
                }
                for (int i = 0; i < waterMarkTextBox2.Text.Length; i++)
                {
                    if (!(waterMarkTextBox2.Text[i] >= 'А' && waterMarkTextBox2.Text[i] <= 'Я') && !(waterMarkTextBox2.Text[i] >= 'а' && waterMarkTextBox2.Text[i] <= 'я'))
                    {
                        errormessage = errormessage + "Неверный формат данных в поле <Адрес>\n\n";
                        break;
                    }
                }
                if (waterMarkTextBox2.Text.Length > 20)
                {
                    errormessage = errormessage + "Слишком длинное поле <Адрес> (более 20 символов)\n\n";
                }
                if ((waterMarkTextBox2.Text[0] >= 'А' && waterMarkTextBox2.Text[0] <= 'Я')
                    || (waterMarkTextBox2.Text[0] >= 'A' && waterMarkTextBox2.Text[0] <= 'Z'))
                {
                    bigflag = true;
                }
                else
                {
                    errormessage = errormessage + "Поле <Адрес> должно начинаться с заглавной буквы\n\n";
                }
                for (int i = 1; i < waterMarkTextBox2.Text.Length; i++)
                {
                    if (((waterMarkTextBox2.Text[i] >= 'А' && waterMarkTextBox2.Text[i] <= 'Я') ||
                        (waterMarkTextBox2.Text[i] >= 'A' && waterMarkTextBox2.Text[i] <= 'Z')) && bigflag)
                    {
                        errormessage = errormessage + "В поле <Адрес> не может быть более одной заглавной буквы\n\n";
                        break;
                    }
                }
                for (int i = 0; i < waterMarkTextBox3.Text.Length; i++)
                {
                    if (!(waterMarkTextBox3.Text[i] >= 'А' && waterMarkTextBox3.Text[i] <= 'Я') && !(waterMarkTextBox3.Text[i] >= 'а' && waterMarkTextBox3.Text[i] <= 'я'))
                    {
                        errormessage = errormessage + "Неверный формат данных в поле <Название>\n\n";
                        break;
                    }
                }
                if (waterMarkTextBox3.Text.Length > 20)
                {
                    errormessage = errormessage + "Слишком длинное поле <Название> (более 20 символов)\n\n";
                }
                if (!(waterMarkTextBox3.Text[0] >= 'А' && waterMarkTextBox3.Text[0] <= 'Я') &&
                    !(waterMarkTextBox3.Text[0] >= 'A' && waterMarkTextBox3.Text[0] <= 'Z'))
                {
                    errormessage = errormessage + "Поле <Название> должно начинаться с заглавной буквы\n\n";
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
