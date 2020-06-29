using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Checks
    {
        public static bool IsNumber(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (!(word[i] >= '0' && word[i] <= '9'))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool IsValidNumber(int num, int n, int m)
        { 
            if ((num >= n) && (num <= m))
                    return true;
            else return false;
        }

        public static bool IsWord(string word, bool containSpaces)
        {
            if (containSpaces == true)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (!(word[i] >= 'А' && word[i] <= 'Я') && !(word[i] >= 'а' && word[i] <= 'я') && !(word[i] == '_'))
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (!(word[i] >= 'А' && word[i] <= 'Я') && !(word[i] >= 'а' && word[i] <= 'я'))
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public static bool IsFirstLetterBig(string word)
        {
            if ((word[0] >= 'А' && word[0] <= 'Я') || (word[0] >= 'A' && word[0] <= 'Z'))
                return true;
            else return false;
        }
        public static int CountBigLetters(string word)
        {
            int rez = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if ((word[i] >= 'А' && word[i] <= 'Я') || (word[i] >= 'A' && word[i] <= 'Z'))
                {
                    rez++;
                }
            }
            return rez;
        }
        
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
            if ((number == "") || (address == "") || (bankName == ""))
            {
                result.AddMessage("Поля формы не могут быть пустыми");
                return result;
            }
            else
            {
                if (!IsNumber(number))
                {
                    result.AddMessage("Неверный формат данных в поле <Номер>");
                }
                if (IsNumber(number) && (!IsValidNumber(Convert.ToInt32(number), 1, 500)))
                {
                    result.AddMessage("Значение " + number + " не попадает в допустимый диапазон поля <Номер> 1..500");
                }
                if (!IsWord(address, false))
                {
                    result.AddMessage("Неверный формат данных в поле <Адрес>");
                }
                if (address.Length > 20)
                {
                    result.AddMessage("Слишком длинное поле <Адрес> (более 20 символов)");
                }
                if (!IsFirstLetterBig(address))
                {
                    result.AddMessage("Поле <Адрес> должно начинаться с заглавной буквы");
                }
                if (IsFirstLetterBig(address) && (CountBigLetters(address) > 1))
                {
                    result.AddMessage("В поле <Адрес> не может быть более одной заглавной буквы");
                }
                if (!IsWord(bankName, false))
                {
                    result.AddMessage("Неверный формат данных в поле <Название>");
                }
                if (bankName.Length > 20)
                {
                    result.AddMessage("Слишком длинное поле <Название> (более 20 символов)");
                }
                if (!IsFirstLetterBig(bankName))
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
            if ((cardNumber == "") || (bankName == "") || (clientName == "") || (clientName == "_"))
            {
                result.AddMessage("Поля формы не могут быть пустыми");
                return result;
            }
            else
            {
                if (!IsNumber(cardNumber))
                { 
                    result.AddMessage("Неверный формат данных в поле <Номер карточки>");
                }
                if (IsNumber(cardNumber) && (!IsValidNumber(Convert.ToInt32(cardNumber), 1, 99999999)))
                {
                    result.AddMessage("Значение " + cardNumber + " не попадает в допустимый диапазон поля <Номер карточки> 1..99999999");
                }
                if (!IsWord(bankName, false))
                {
                    result.AddMessage("Неверный формат данных в поле <Обслуживающий банк>");
                }
                if (bankName.Length > 20)
                {
                    result.AddMessage("Слишком длинное поле <Обслуживающий банк> (более 20 символов)");
                }
                if (!IsFirstLetterBig(bankName))
                {
                    result.AddMessage("Поле <Обслуживающий банк> должно начинаться с заглавной буквы");
                }
                if (!IsWord(clientName, true))
                {
                    result.AddMessage("Неверный формат данных в поле <ФИО>");
                }
                if (clientName.Length > 40)
                {
                    result.AddMessage("Слишком длинное поле <ФИО> (более 40 символов)");
                }
                if (!IsFirstLetterBig(clientName))
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
            if ((operationName == "") || (sender == "") || (receiver == "") || (percent == ""))
            {
                result.AddMessage("Поля формы не могут быть пустыми");
                return result;
            }
            else
            {
                if (!IsNumber(percent))
                {
                    result.AddMessage("Неверный формат данных в поле <Процент>");
                }
                if (IsNumber(percent) && (!IsValidNumber(Convert.ToInt32(percent), 0, 100)))
                {
                    result.AddMessage("Значение " + percent + " не попадает в допустимый диапазон поля <Процент> 0..100");
                }
                if (!IsWord(operationName, false))
                {
                    result.AddMessage("Неверный формат данных в поле <Название операции>");
                }
                if (operationName.Length > 20)
                {
                    result.AddMessage("Слишком длинное поле <Название операции> (более 20 символов)");
                }
                if (!IsFirstLetterBig(operationName))
                {
                    result.AddMessage("Поле <Название операции> должно начинаться с заглавной буквы");
                }
                if (IsFirstLetterBig(operationName) && (CountBigLetters(operationName) > 1))
                {
                    result.AddMessage("В поле <Название операции> не может быть более одной заглавной буквы");
                }
                if (!IsWord(sender, false))
                { 
                    result.AddMessage("Неверный формат данных в поле <Банк-отправитель>");
                }
                if (sender.Length > 20)
                {
                    result.AddMessage("Слишком длинное поле <Банк-отправитель> (более 20 символов)");
                }
                if (!IsFirstLetterBig(sender))
                {
                    result.AddMessage("Поле <Банк-отправитель> должно начинаться с заглавной буквы");
                }
                if (!IsWord(receiver, false))
                {
                    result.AddMessage("Неверный формат данных в поле <Банк-получатель>");
                }
                if (receiver.Length > 20)
                {
                    result.AddMessage("Слишком длинное поле <Банк-получатель> (более 20 символов)");
                }
                if (!IsFirstLetterBig(receiver))
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
            if ((name == "") || (cardNumber == "") || (machineNumber == "") || (sum == ""))
            {
                result.AddMessage("Поля формы не могут быть пустыми");
                return result;
            }
            else
            {
                if (!IsWord(name, false))
                {
                    result.AddMessage("Неверный формат данных в поле <Название операции>");
                }
                if (name.Length > 20)
                {
                    result.AddMessage("Слишком длинное поле <Название операции> (более 20 символов)");
                }
                if (!IsFirstLetterBig(name))
                {
                    result.AddMessage("Поле <Название операции> должно начинаться с заглавной буквы");
                }
                if (IsFirstLetterBig(name) && (CountBigLetters(name) > 1))
                {
                    result.AddMessage("В поле <Название операции> не может быть более одной заглавной буквы");
                }
                if (!IsNumber(cardNumber))
                { 
                    result.AddMessage("Неверный формат данных в поле <Номер карточки>");
                }
                if (IsNumber(cardNumber) && (!IsValidNumber(Convert.ToInt32(cardNumber), 1, 99999999)))
                {
                    result.AddMessage("Значение " + cardNumber + " не попадает в допустимый диапазон поля <Номер карточки> 1..99999999");
                }
                if (!IsNumber(machineNumber))
                { 
                    result.AddMessage("Неверный формат данных в поле <Номер банкомата>");
                }
                if (IsNumber(machineNumber) && (!IsValidNumber(Convert.ToInt32(machineNumber), 1, 500)))
                {
                    result.AddMessage("Значение " + machineNumber + " не попадает в допустимый диапазон поля <Номер банкомата> 1..500");
                }
                if (!IsNumber(sum))
                {
                    result.AddMessage("Неверный формат данных в поле <Сумма операции>");
                }
                if (IsNumber(sum) && (!IsValidNumber(Convert.ToInt32(sum), 0, 10000000)))
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
