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
    public partial class Tree2Dialog : Form
    {
        public Tree2Dialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool bigflag = false;
            string errormessage = "";
            bool flagstring1 = false;
            bool flagstring2 = false;
            bool flagstring3 = false;
            if ((waterMarkTextBox1.Text == "") || (waterMarkTextBox2.Text == "") || (waterMarkTextBox3.Text == "") || (waterMarkTextBox4.Text == ""))
            {
                ErrorForm ErrorWindow = new ErrorForm();
                ErrorWindow.label1.Text = "Поля формы не могут быть пустыми";
                ErrorWindow.ShowDialog();
            }
            else
            {
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
                    if (((waterMarkTextBox1.Text[i] >= 'А' && waterMarkTextBox1.Text[i] <= 'Я') || (waterMarkTextBox1.Text[i] >= 'A' && waterMarkTextBox1.Text[i] <= 'Z')) && bigflag)
                    {
                        errormessage = errormessage + "В поле <Название операции> не может быть более одной заглавной буквы\n\n";
                        break;
                    }
                }
                for (int i = 0; i < waterMarkTextBox2.Text.Length; i++)
                {
                    if (!(waterMarkTextBox2.Text[i] >= '0' && waterMarkTextBox2.Text[i] <= '9'))
                    {
                        errormessage = errormessage + "Неверный формат данных в поле <Номер карточки>\n\n";
                        flagstring1 = true;
                    }
                    break;
                }
                if ((flagstring1 == false) && ((Convert.ToInt32(waterMarkTextBox2.Text) < 1) || (Convert.ToInt32(waterMarkTextBox2.Text) > 99999999)))
                {
                    errormessage = errormessage + "Значение не попадает в допустимый диапазон поля <Номер карточки> 1..99999999\n\n";
                }
                for (int i = 0; i < waterMarkTextBox3.Text.Length; i++)
                {
                    if (!(waterMarkTextBox3.Text[i] >= '0' && waterMarkTextBox3.Text[i] <= '9'))
                    {
                        errormessage = errormessage + "Неверный формат данных в поле <Номер банкомата>\n\n";
                        flagstring2 = true;
                    }
                    break;
                }
                if ((flagstring2 == false) && ((Convert.ToInt32(waterMarkTextBox3.Text) < 1) || (Convert.ToInt32(waterMarkTextBox3.Text) > 500)))
                {
                    errormessage = errormessage + "Значение не попадает в допустимый диапазон поля <Номер банкомата> 1..500\n\n";
                }
                for (int i = 0; i < waterMarkTextBox4.Text.Length; i++)
                {
                    if (!(waterMarkTextBox4.Text[i] >= '0' && waterMarkTextBox4.Text[i] <= '9'))
                    {
                        errormessage = errormessage + "Неверный формат данных в поле <Сумма операции>\n\n";
                        flagstring3 = true;
                    }
                    break;
                }
                if ((flagstring3 == false) && ((Convert.ToInt32(waterMarkTextBox4.Text) < 0) || (Convert.ToInt32(waterMarkTextBox4.Text) > 10000000)))
                {
                    errormessage = errormessage + "Значение не попадает в допустимый диапазон поля <Сумма операции> 0..10000000\n\n";
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
