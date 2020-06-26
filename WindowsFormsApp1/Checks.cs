using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Checks
    {
        public static bool CheckMachine(string number, string address, string name)
        {
            bool bigflag = false;
            string errormessage = "";
            bool flagstring = false;
            if ((number == "") || (address == "") || (name == ""))
            {
                return false;
            }
            else
            {
                for (int i = 0; i < number.Length; i++)
                {
                    if (!(number[i] >= '0' && number[i] <= '9'))
                    {
                        errormessage = errormessage + "Неверный формат данных в поле <Номер>\n\n";
                        flagstring = true;
                        break;
                    }
                }
                if ((flagstring == false) && ((Convert.ToInt32(number) < 1) || (Convert.ToInt32(number) > 500)))
                {
                    errormessage = errormessage + "Значение не попадает в допустимый диапазон поля <Номер> 1..500\n\n";
                }
                for (int i = 0; i < address.Length; i++)
                {
                    if (!(address[i] >= 'А' && address[i] <= 'Я') && !(address[i] >= 'а' && address[i] <= 'я'))
                    {
                        errormessage = errormessage + "Неверный формат данных в поле <Адрес>\n\n";
                        break;
                    }
                }
                if (address.Length > 20)
                {
                    errormessage = errormessage + "Слишком длинное поле <Адрес> (более 20 символов)\n\n";
                }
                if ((address[0] >= 'А' && address[0] <= 'Я')
                    || (address[0] >= 'A' && address[0] <= 'Z'))
                {
                    bigflag = true;
                }
                else
                {
                    errormessage = errormessage + "Поле <Адрес> должно начинаться с заглавной буквы\n\n";
                }
                for (int i = 1; i < address.Length; i++)
                {
                    if (((address[i] >= 'А' && address[i] <= 'Я') ||
                        (address[i] >= 'A' && address[i] <= 'Z')) && bigflag)
                    {
                        errormessage = errormessage + "В поле <Адрес> не может быть более одной заглавной буквы\n\n";
                        break;
                    }
                }
                for (int i = 0; i < name.Length; i++)
                {
                    if (!(name[i] >= 'А' && name[i] <= 'Я') && !(name[i] >= 'а' && name[i] <= 'я'))
                    {
                        errormessage = errormessage + "Неверный формат данных в поле <Название>\n\n";
                        break;
                    }
                }
                if (name.Length > 20)
                {
                    errormessage = errormessage + "Слишком длинное поле <Название> (более 20 символов)\n\n";
                }
                if (!(name[0] >= 'А' && name[0] <= 'Я') &&
                    !(name[0] >= 'A' && name[0] <= 'Z'))
                {
                    errormessage = errormessage + "Поле <Название> должно начинаться с заглавной буквы\n\n";
                }
                if (errormessage == "")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static bool CheckClient(string number, string bank, string name)
        {
            string errormessage = "";
            bool flagstring = false;
            if ((number == "") || (bank == "") || (name == "") || (name == "_"))
            {
                return false;
            }
            else
            {
                for (int i = 0; i < number.Length; i++)
                {
                    if (!(number[i] >= '0' && number[i] <= '9'))
                    {
                        errormessage = errormessage + "Неверный формат данных в поле <Номер карточки>\n\n";
                        flagstring = true;
                        break;
                    }
                }
                if ((flagstring == false) && ((Convert.ToInt32(number) < 1) || (Convert.ToInt32(number) > 99999999)))
                {
                    errormessage = errormessage + "Значение не попадает в допустимый диапазон поля <Номер карточки> 1..99999999\n\n";
                }
                for (int i = 0; i < bank.Length; i++)
                {
                    if (!(bank[i] >= 'А' && bank[i] <= 'Я') && !(bank[i] >= 'а' && bank[i] <= 'я'))
                    {
                        errormessage = errormessage + "Неверный формат данных в поле <Обслуживающий банк>\n\n";
                        break;
                    }
                }
                if (bank.Length > 20)
                {
                    errormessage = errormessage + "Слишком длинное поле <Обслуживающий банк> (более 20 символов)\n\n";
                }
                if (!(bank[0] >= 'А' && bank[0] <= 'Я')
                    && !(bank[0] >= 'A' && bank[0] <= 'Z'))
                {
                    errormessage = errormessage + "Поле <Обслуживающий банк> должно начинаться с заглавной буквы\n\n";
                }
                for (int i = 0; i < name.Length; i++)
                {
                    if (!(name[i] >= 'А' && name[i] <= 'Я') && !(name[i] >= 'а' && name[i] <= 'я') && !(name[i] == '_'))
                    {
                        errormessage = errormessage + "Неверный формат данных в поле <ФИО>\n\n";
                        break;
                    }
                }
                if (name.Length > 40)
                {
                    errormessage = errormessage + "Слишком длинное поле <ФИО> (более 40 символов)\n\n";
                }
                if (!(name[0] >= 'А' && name[0] <= 'Я')
                    && !(name[0] >= 'A' && name[0] <= 'Z'))
                {
                    errormessage = errormessage + "Поле <ФИО> должно начинаться с заглавной буквы\n\n";
                }
                if (errormessage == "")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool CheckPercent(string name, string sender, string receiver, string percent)
        {
            bool bigflag = false;
            string errormessage = "";
            bool flagstring = false;
            if ((name == "") || (sender == "") || (receiver == "") || (percent == ""))
            {
                return false;
            }
            else
            {
                for (int i = 0; i < percent.Length; i++)
                {
                    if (!(percent[i] >= '0' && percent[i] <= '9'))
                    {
                        errormessage = errormessage + "Неверный формат данных в поле <Процент>\n\n";
                        flagstring = true;
                        break;
                    }
                }
                if ((flagstring == false) && ((Convert.ToInt32(percent) < 0) || (Convert.ToInt32(percent) > 100)))
                {
                    errormessage = errormessage + "Значение не попадает в допустимый диапазон поля <Процент> 0..100\n\n";
                }
                for (int i = 0; i < name.Length; i++)
                {
                    if (!(name[i] >= 'А' && name[i] <= 'Я') && !(name[i] >= 'а' && name[i] <= 'я'))
                    {
                        errormessage = errormessage + "Неверный формат данных в поле <Название операции>\n\n";
                        break;
                    }
                }
                if (name.Length > 20)
                {
                    errormessage = errormessage + "Слишком длинное поле <Название операции> (более 20 символов)\n\n";
                }
                if ((name[0] >= 'А' && name[0] <= 'Я') || (name[0] >= 'A' && name[0] <= 'Z'))
                {
                    bigflag = true;
                }
                else
                {
                    errormessage = errormessage + "Поле <Название операции> должно начинаться с заглавной буквы\n\n";
                }
                for (int i = 1; i < name.Length; i++)
                {
                    if (((name[i] >= 'А' && name[i] <= 'Я') || (name[0] >= 'A' && name[0] <= 'Z')) && bigflag)
                    {
                        errormessage = errormessage + "В поле <Название операции> не может быть более одной заглавной буквы\n\n";
                        break;
                    }
                }
                for (int i = 0; i < sender.Length; i++)
                {
                    if (!(sender[i] >= 'А' && sender[i] <= 'Я') && !(sender[i] >= 'а' && sender[i] <= 'я'))
                    {
                        errormessage = errormessage + "Неверный формат данных в поле <Банк-отправитель>\n\n";
                        break;
                    }
                }
                if (sender.Length > 20)
                {
                    errormessage = errormessage + "Слишком длинное поле <Банк-отправитель> (более 20 символов)\n\n";
                }
                if (!(sender[0] >= 'А' && sender[0] <= 'Я') && !(sender[0] >= 'A' && sender[0] <= 'Z'))
                {
                    errormessage = errormessage + "Поле <Банк-отправитель> должно начинаться с заглавной буквы\n\n";
                }
                for (int i = 0; i < receiver.Length; i++)
                {
                    if (!(receiver[i] >= 'А' && receiver[i] <= 'Я') && !(receiver[i] >= 'а' && receiver[i] <= 'я'))
                    {
                        errormessage = errormessage + "Неверный формат данных в поле <Банк-получатель>\n\n";
                        break;
                    }
                }
                if (receiver.Length > 20)
                {
                    errormessage = errormessage + "Слишком длинное поле <Банк-получатель> (более 20 символов)\n\n";
                }
                if (!(receiver[0] >= 'А' && receiver[0] <= 'Я') && !(receiver[0] >= 'A' && receiver[0] <= 'Z'))
                {
                    errormessage = errormessage + "Поле <Банк-получатель> должно начинаться с заглавной буквы\n\n";
                }
                if (errormessage == "")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static bool CheckOperation(string name, string number, string bank, string sum)
        {
            bool bigflag = false;
            string errormessage = "";
            bool flagstring1 = false;
            bool flagstring2 = false;
            bool flagstring3 = false;
            if ((name == "") || (number == "") || (bank == "") || (sum == ""))
            {
                return false;
            }
            else
            {
                for (int i = 0; i < name.Length; i++)
                {
                    if (!(name[i] >= 'А' && name[i] <= 'Я') && !(name[i] >= 'а' && name[i] <= 'я'))
                    {
                        errormessage = errormessage + "Неверный формат данных в поле <Название операции>\n\n";
                        break;
                    }
                }
                if (name.Length > 20)
                {
                    errormessage = errormessage + "Слишком длинное поле <Название операции> (более 20 символов)\n\n";
                }
                if ((name[0] >= 'А' && name[0] <= 'Я') || (name[0] >= 'A' && name[0] <= 'Z'))
                {
                    bigflag = true;
                }
                else
                {
                    errormessage = errormessage + "Поле <Название операции> должно начинаться с заглавной буквы\n\n";
                }
                for (int i = 1; i < name.Length; i++)
                {
                    if (((name[i] >= 'А' && name[i] <= 'Я') || (name[i] >= 'A' && name[i] <= 'Z')) && bigflag)
                    {
                        errormessage = errormessage + "В поле <Название операции> не может быть более одной заглавной буквы\n\n";
                        break;
                    }
                }
                for (int i = 0; i < number.Length; i++)
                {
                    if (!(number[i] >= '0' && number[i] <= '9'))
                    {
                        errormessage = errormessage + "Неверный формат данных в поле <Номер карточки>\n\n";
                        flagstring1 = true;
                    }
                    break;
                }
                if ((flagstring1 == false) && ((Convert.ToInt32(number) < 1) || (Convert.ToInt32(number) > 99999999)))
                {
                    errormessage = errormessage + "Значение не попадает в допустимый диапазон поля <Номер карточки> 1..99999999\n\n";
                }
                for (int i = 0; i < bank.Length; i++)
                {
                    if (!(bank[i] >= '0' && bank[i] <= '9'))
                    {
                        errormessage = errormessage + "Неверный формат данных в поле <Номер банкомата>\n\n";
                        flagstring2 = true;
                    }
                    break;
                }
                if ((flagstring2 == false) && ((Convert.ToInt32(bank) < 1) || (Convert.ToInt32(bank) > 500)))
                {
                    errormessage = errormessage + "Значение не попадает в допустимый диапазон поля <Номер банкомата> 1..500\n\n";
                }
                for (int i = 0; i < sum.Length; i++)
                {
                    if (!(sum[i] >= '0' && sum[i] <= '9'))
                    {
                        errormessage = errormessage + "Неверный формат данных в поле <Сумма операции>\n\n";
                        flagstring3 = true;
                    }
                    break;
                }
                if ((flagstring3 == false) && ((Convert.ToInt32(sum) < 0) || (Convert.ToInt32(sum) > 10000000)))
                {
                    errormessage = errormessage + "Значение не попадает в допустимый диапазон поля <Сумма операции> 0..10000000\n\n";
                }
                if (errormessage == "")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
