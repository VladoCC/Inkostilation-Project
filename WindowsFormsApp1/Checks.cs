using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Checks
    {
        /// <summary>
        /// Проверка входных данных на соответствие условиям банкомата.
        /// </summary>
        /// <param name="number"> Номер банкомата. </param>
        /// <param name="address"> Адрес банкомата. </param>
        /// <param name="bankName"> Название банка. </param>
        /// <returns> Результат о соответствии данных условиям для банкомата. </returns>
        public static Result CheckMachine(string number, string address, string bankName)
        {
            Result result = new Result(false);
            bool bigflag = false;
            bool flagstring = false;
            if ((number == "") || (address == "") || (bankName == ""))
            {
                result.AddMessage("Поля формы не могут быть пустыми");
                return result;
            }
            else
            {
                for (int i = 0; i < number.Length; i++)
                {
                    if (!(number[i] >= '0' && number[i] <= '9'))
                    {
                        result.AddMessage("Неверный формат данных в поле <Номер>");
                        flagstring = true;
                        break;
                    }
                }
                if ((flagstring == false) && ((Convert.ToInt32(number) < 1) || (Convert.ToInt32(number) > 500)))
                {
                    result.AddMessage("Значение " + number + " не попадает в допустимый диапазон поля <Номер> 1..500");
                }
                for (int i = 0; i < address.Length; i++)
                {
                    if (!(address[i] >= 'А' && address[i] <= 'Я') && !(address[i] >= 'а' && address[i] <= 'я'))
                    {
                        result.AddMessage("Неверный формат данных в поле <Адрес>");
                        break;
                    }
                }
                if (address.Length > 20)
                {
                    result.AddMessage("Слишком длинное поле <Адрес> (более 20 символов)");
                }
                if ((address[0] >= 'А' && address[0] <= 'Я')
                    || (address[0] >= 'A' && address[0] <= 'Z'))
                {
                    bigflag = true;
                }
                else
                {
                    result.AddMessage("Поле <Адрес> должно начинаться с заглавной буквы");
                }
                for (int i = 1; i < address.Length; i++)
                {
                    if (((address[i] >= 'А' && address[i] <= 'Я') ||
                        (address[i] >= 'A' && address[i] <= 'Z')) && bigflag)
                    {
                        result.AddMessage("В поле <Адрес> не может быть более одной заглавной буквы");
                        break;
                    }
                }
                for (int i = 0; i < bankName.Length; i++)
                {
                    if (!(bankName[i] >= 'А' && bankName[i] <= 'Я') && !(bankName[i] >= 'а' && bankName[i] <= 'я'))
                    {
                        result.AddMessage("Неверный формат данных в поле <Название>");
                        break;
                    }
                }
                if (bankName.Length > 20)
                {
                    result.AddMessage("Слишком длинное поле <Название> (более 20 символов)");
                }
                if (!(bankName[0] >= 'А' && bankName[0] <= 'Я') &&
                    !(bankName[0] >= 'A' && bankName[0] <= 'Z'))
                {
                    result.AddMessage("Поле <Название> должно начинаться с заглавной буквы");
                }
                if (result.Message == "")
                {
                    result.Success = true;
                    return result;
                }
                else
                {
                    return result;
                }
            }
        }

        /// <summary>
        /// Проверка входных данных на соответствие условиям клиента.
        /// </summary>
        /// <param name="cardNumber"> Номер карты клиента. </param>
        /// <param name="bankName"> Имя банка, обслуживающего клиента. </param>
        /// <param name="clientName"> ФИО клиента. </param>
        /// <returns> Результат о соответствии данных условиям для клиента. </returns>
        public static Result CheckClient(string cardNumber, string bankName, string clientName)
        {
            Result result = new Result(false);
            bool flagstring = false;
            if ((cardNumber == "") || (bankName == "") || (clientName == "") || (clientName == "_"))
            {
                result.AddMessage("Поля формы не могут быть пустыми");
                return result;
            }
            else
            {
                for (int i = 0; i < cardNumber.Length; i++)
                {
                    if (!(cardNumber[i] >= '0' && cardNumber[i] <= '9'))
                    {
                        result.AddMessage("Неверный формат данных в поле <Номер карточки>");
                        flagstring = true;
                        break;
                    }
                }
                if ((flagstring == false) && ((Convert.ToInt32(cardNumber) < 1) || (Convert.ToInt32(cardNumber) > 99999999)))
                {
                    result.AddMessage("Значение " + cardNumber + " не попадает в допустимый диапазон поля <Номер карточки> 1..99999999");
                }
                for (int i = 0; i < bankName.Length; i++)
                {
                    if (!(bankName[i] >= 'А' && bankName[i] <= 'Я') && !(bankName[i] >= 'а' && bankName[i] <= 'я'))
                    {
                        result.AddMessage("Неверный формат данных в поле <Обслуживающий банк>");
                        break;
                    }
                }
                if (bankName.Length > 20)
                {
                    result.AddMessage("Слишком длинное поле <Обслуживающий банк> (более 20 символов)");
                }
                if (!(bankName[0] >= 'А' && bankName[0] <= 'Я')
                    && !(bankName[0] >= 'A' && bankName[0] <= 'Z'))
                {
                    result.AddMessage("Поле <Обслуживающий банк> должно начинаться с заглавной буквы");
                }
                for (int i = 0; i < clientName.Length; i++)
                {
                    if (!(clientName[i] >= 'А' && clientName[i] <= 'Я') && !(clientName[i] >= 'а' && clientName[i] <= 'я') && !(clientName[i] == '_'))
                    {
                        result.AddMessage("Неверный формат данных в поле <ФИО>");
                        break;
                    }
                }
                if (clientName.Length > 40)
                {
                    result.AddMessage("Слишком длинное поле <ФИО> (более 40 символов)");
                }
                if (!(clientName[0] >= 'А' && clientName[0] <= 'Я')
                    && !(clientName[0] >= 'A' && clientName[0] <= 'Z'))
                {
                    result.AddMessage("Поле <ФИО> должно начинаться с заглавной буквы");
                }
                if (result.Message == "")
                {
                    result.Success = true;
                    return result;
                }
                else
                {
                    return result;
                }
            }
        }
        
        /// <summary>
        /// Проверка входных данных на соответствие условиям процента операции.
        /// </summary>
        /// <param name="operationName"> Название операции. </param>
        /// <param name="sender"> Банк отправитель. </param>
        /// <param name="receiver"> Банк получатель. </param>
        /// <param name="percent"> Процент операции. </param>
        /// <returns> Результат о соответствии данных условиям для процента операции. </returns>
        public static Result CheckPercent(string operationName, string sender, string receiver, string percent)
        {
            Result result = new Result(false);
            bool bigflag = false;
            bool flagstring = false;
            if ((operationName == "") || (sender == "") || (receiver == "") || (percent == ""))
            {
                result.AddMessage("Поля формы не могут быть пустыми");
                return result;
            }
            else
            {
                for (int i = 0; i < percent.Length; i++)
                {
                    if (!(percent[i] >= '0' && percent[i] <= '9'))
                    {
                        result.AddMessage("Неверный формат данных в поле <Процент>");
                        flagstring = true;
                        break;
                    }
                }
                if ((flagstring == false) && ((Convert.ToInt32(percent) < 0) || (Convert.ToInt32(percent) > 100)))
                {
                    result.AddMessage("Значение " + percent + " не попадает в допустимый диапазон поля <Процент> 0..100");
                }
                for (int i = 0; i < operationName.Length; i++)
                {
                    if (!(operationName[i] >= 'А' && operationName[i] <= 'Я') && !(operationName[i] >= 'а' && operationName[i] <= 'я'))
                    {
                        result.AddMessage("Неверный формат данных в поле <Название операции>");
                        break;
                    }
                }
                if (operationName.Length > 20)
                {
                    result.AddMessage("Слишком длинное поле <Название операции> (более 20 символов)");
                }
                if ((operationName[0] >= 'А' && operationName[0] <= 'Я') || (operationName[0] >= 'A' && operationName[0] <= 'Z'))
                {
                    bigflag = true;
                }
                else
                {
                    result.AddMessage("Поле <Название операции> должно начинаться с заглавной буквы");
                }
                for (int i = 1; i < operationName.Length; i++)
                {
                    if (((operationName[i] >= 'А' && operationName[i] <= 'Я') || (operationName[0] >= 'A' && operationName[0] <= 'Z')) && bigflag)
                    {
                        result.AddMessage("В поле <Название операции> не может быть более одной заглавной буквы");
                        break;
                    }
                }
                for (int i = 0; i < sender.Length; i++)
                {
                    if (!(sender[i] >= 'А' && sender[i] <= 'Я') && !(sender[i] >= 'а' && sender[i] <= 'я'))
                    {
                        result.AddMessage("Неверный формат данных в поле <Банк-отправитель>");
                        break;
                    }
                }
                if (sender.Length > 20)
                {
                    result.AddMessage("Слишком длинное поле <Банк-отправитель> (более 20 символов)");
                }
                if (!(sender[0] >= 'А' && sender[0] <= 'Я') && !(sender[0] >= 'A' && sender[0] <= 'Z'))
                {
                    result.AddMessage("Поле <Банк-отправитель> должно начинаться с заглавной буквы");
                }
                for (int i = 0; i < receiver.Length; i++)
                {
                    if (!(receiver[i] >= 'А' && receiver[i] <= 'Я') && !(receiver[i] >= 'а' && receiver[i] <= 'я'))
                    {
                        result.AddMessage("Неверный формат данных в поле <Банк-получатель>");
                        break;
                    }
                }
                if (receiver.Length > 20)
                {
                    result.AddMessage("Слишком длинное поле <Банк-получатель> (более 20 символов)");
                }
                if (!(receiver[0] >= 'А' && receiver[0] <= 'Я') && !(receiver[0] >= 'A' && receiver[0] <= 'Z'))
                {
                    result.AddMessage("Поле <Банк-получатель> должно начинаться с заглавной буквы");
                }
                if (result.Message == "")
                {
                    result.Success = true;
                    return result;
                }
                else
                {
                    return result;
                }
            }
        }

        /// <summary>
        /// Проверка входных данных на соответствие условиям операции.
        /// </summary>
        /// <param name="name"> Название операции. </param>
        /// <param name="cardNumber"> Номер карты. </param>
        /// <param name="machineNumber"> Номер банкомата. </param>
        /// <param name="sum"> Сумма операции. </param>
        /// <returns> Результат о соответствии данных условиям для операции. </returns>
        public static Result CheckOperation(string name, string cardNumber, string machineNumber, string sum)
        {
            Result result = new Result(false);
            bool bigflag = false;
            bool flagstring1 = false;
            bool flagstring2 = false;
            bool flagstring3 = false;
            if ((name == "") || (cardNumber == "") || (machineNumber == "") || (sum == ""))
            {
                result.AddMessage("Поля формы не могут быть пустыми");
                return result;
            }
            else
            {
                for (int i = 0; i < name.Length; i++)
                {
                    if (!(name[i] >= 'А' && name[i] <= 'Я') && !(name[i] >= 'а' && name[i] <= 'я'))
                    {
                        result.AddMessage("Неверный формат данных в поле <Название операции>");
                        break;
                    }
                }
                if (name.Length > 20)
                {
                    result.AddMessage("Слишком длинное поле <Название операции> (более 20 символов)");
                }
                if ((name[0] >= 'А' && name[0] <= 'Я') || (name[0] >= 'A' && name[0] <= 'Z'))
                {
                    bigflag = true;
                }
                else
                {
                    result.AddMessage("Поле <Название операции> должно начинаться с заглавной буквы");
                }
                for (int i = 1; i < name.Length; i++)
                {
                    if (((name[i] >= 'А' && name[i] <= 'Я') || (name[i] >= 'A' && name[i] <= 'Z')) && bigflag)
                    {
                        result.AddMessage("В поле <Название операции> не может быть более одной заглавной буквы");
                        break;
                    }
                }
                for (int i = 0; i < cardNumber.Length; i++)
                {
                    if (!(cardNumber[i] >= '0' && cardNumber[i] <= '9'))
                    {
                        result.AddMessage("Неверный формат данных в поле <Номер карточки>");
                        flagstring1 = true;
                    }
                    break;
                }
                if ((flagstring1 == false) && ((Convert.ToInt32(cardNumber) < 1) || (Convert.ToInt32(cardNumber) > 99999999)))
                {
                    result.AddMessage("Значение " + cardNumber + " не попадает в допустимый диапазон поля <Номер карточки> 1..99999999");
                }
                for (int i = 0; i < machineNumber.Length; i++)
                {
                    if (!(machineNumber[i] >= '0' && machineNumber[i] <= '9'))
                    {
                        result.AddMessage("Неверный формат данных в поле <Номер банкомата>");
                        flagstring2 = true;
                    }
                    break;
                }
                if ((flagstring2 == false) && ((Convert.ToInt32(machineNumber) < 1) || (Convert.ToInt32(machineNumber) > 500)))
                {
                    result.AddMessage("Значение " + machineNumber + " не попадает в допустимый диапазон поля <Номер банкомата> 1..500");
                }
                for (int i = 0; i < sum.Length; i++)
                {
                    if (!(sum[i] >= '0' && sum[i] <= '9'))
                    {
                        result.AddMessage("Неверный формат данных в поле <Сумма операции>");
                        flagstring3 = true;
                    }
                    break;
                }
                if ((flagstring3 == false) && ((Convert.ToInt32(sum) < 0) || (Convert.ToInt32(sum) > 10000000)))
                {
                    result.AddMessage("Значение " + sum + " не попадает в допустимый диапазон поля <Сумма операции> 0..10000000");
                }
                if (result.Message == "")
                {
                    result.Success = true;
                    return result;
                }
                else
                {
                    return result;
                }
            }
        }
    }
}
