using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace Lib_Vzlom_Cesarya
{
    public class Cezar
    {
        // Словарь, используемый для атаки на шифр Цезаря
        private static Dictionary<char, List<string>> dictionary;

        // Алфавиты для разных типов символов
        static char[] alphabet = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
        static char[] HeadAlphabet = { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я' };
        static char[] pun = { '.', ',', '(', ')', ':', ';', '@', '!', '?', '*', '/', '|', '\'', '\"', '\\', '<', '>', '=', '+', '-', '_', ' ', '#', '$', '%', '^', '&', '[', ']', '\n', '\r', '№' };
        static char[] num = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        // Метод шифрования текста шифром Цезаря
        // Принимает на вход исходный текст (Text) и шаг сдвига (step).
        // Возвращает зашифрованный текст.
        public static string Coding(string Text, byte step)
        {
            try
            {
                StringBuilder CODED_TEXT = new StringBuilder();

                // Обработка каждого символа исходного текста
                for (int i = 0; i < Text.Length; i++)
                {
                    // Шифрование букв нижнего регистра
                    for (int j = 0; j < alphabet.Length; j++)
                    {
                        if (Text[i] == alphabet[j])
                        {
                            CODED_TEXT.Append(alphabet[(j + step) % alphabet.Length]);
                        }
                    }

                    // Шифрование букв верхнего регистра
                    for (int j = 0; j < HeadAlphabet.Length; j++)
                    {
                        if (Text[i] == HeadAlphabet[j])
                        {
                            CODED_TEXT.Append(HeadAlphabet[(j + step) % HeadAlphabet.Length]);
                        }
                    }

                    // Оставление символов пунктуации без изменений
                    for (int j = 0; j < pun.Length; j++)
                    {
                        if (Text[i] == pun[j])
                        {
                            CODED_TEXT.Append(pun[(j)]);
                        }
                    }

                    // Шифрование цифр
                    for (int j = 0; j < num.Length; j++)
                    {
                        if (Text[i] == num[j])
                        {
                            CODED_TEXT.Append(num[(j + step) % num.Length]);
                        }
                    }

                }
                return CODED_TEXT.ToString();
            }
            catch
            {
                throw new Exception("Поле Шаг имеет некорректное значение");
            }

        }

        // Метод дешифрования текста, зашифрованного шифром Цезаря
        // Принимает на вход зашифрованный текст (Coded_text) и шаг сдвига (step).
        // Возвращает исходный текст.
        public static string Decoding(string Coded_text, byte step)
        {
            try
            {
                StringBuilder DECODED_TEXT = new StringBuilder();

                // Обработка каждого символа зашифрованного текста
                for (int i = 0; i < Coded_text.Length; i++)
                {
                    // Дешифрование букв нижнего регистра
                    for (int j = 0; j < alphabet.Length; j++)
                    {
                        if (Coded_text[i] == alphabet[j])
                        {
                            DECODED_TEXT.Append(alphabet[(j - step + alphabet.Length) % alphabet.Length]);
                        }
                    }

                    // Дешифрование букв верхнего регистра
                    for (int j = 0; j < HeadAlphabet.Length; j++)
                    {
                        if (Coded_text[i] == HeadAlphabet[j])
                        {
                            DECODED_TEXT.Append(HeadAlphabet[(j - step + HeadAlphabet.Length) % HeadAlphabet.Length]);
                        }
                    }

                    // Оставление символов пунктуации без изменений
                    for (int j = 0; j < pun.Length; j++)
                    {
                        if (Coded_text[i] == pun[j])
                        {
                            DECODED_TEXT.Append(pun[(j)]);
                        }
                    }

                    // Дешифрование цифр
                    for (int j = 0; j < num.Length; j++)
                    {
                        if (Coded_text[i] == num[j])
                        {
                            {
                                DECODED_TEXT.Append(num[(j - (step % num.Length) + num.Length) % num.Length]);
                            }
                        }
                    }

                }
                return DECODED_TEXT.ToString();
            }
            catch
            {
                throw new Exception("Поле Шаг имеет некорректное значение");
            }
        }

        // Метод атаки на шифр Цезаря с использованием частотного анализа
        // Принимает на вход зашифрованный текст (Coded_text).
        // Возвращает расшифрованный текст.
        public static string Vzlom_Shifra_Chastotnim(string Coded_text)
        {
            int counter = 0, max = 0;
            char symbol = ' ';
            byte Step = 0;

            // Подсчет частоты встречаемости каждой буквы в тексте
            for (int i = 0; i < alphabet.Length; i++)
            {
                for (int j = 0; j < Coded_text.Length; j++)
                {
                    if (alphabet[i] == Coded_text.ToLower()[j])
                    {
                        counter += 1;
                    }
                }

                // Определение символа с наибольшей частотой
                if (counter > max)
                {
                    max = counter;
                    symbol = alphabet[i];
                    counter = 0;
                }
                else
                {
                    counter = 0;
                }
            }

            // Определение шага сдвига для дешифровки
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (alphabet[i] == symbol)
                {
                    if (i >= 15)
                    {
                        Step = Convert.ToByte(i - 15);
                    }
                    else
                    {
                        Step = Convert.ToByte((i - 15 + alphabet.Length) % alphabet.Length);
                    }
                }
            }

            // Возвращение расшифрованного текста
            return Decoding(Coded_text, Step);
        }

        // Метод загрузки словаря из текстового файла для использования в атаке по словарю
        public static void LoadDictionary()
        {
            dictionary = new Dictionary<char, List<string>>();

            string[] lines = File.ReadAllLines("dictionary.txt", Encoding.UTF8);
            foreach (char l in alphabet)
            {
                dictionary[l] = new List<string>();
            }
            foreach (string s in lines)
            {
                char firstletter = s[0];
                dictionary[firstletter].Add(s);
            }
        }

        // Метод атаки на шифр Цезаря с использованием словаря
        // Принимает на вход зашифрованный текст (Coded_text).
        // Возвращает расшифрованный текст.
        public static string Alphabet_Attack(string Coded_text)
        {
            string Coded_text_Checker = Coded_text.ToLower();
            foreach (char ch in Coded_text_Checker)
            {
                if (!alphabet.Contains(ch) && !num.Contains(ch) && !pun.Contains(ch))
                {
                    throw new Exception("В строке присутствуют неизвестные символы");
                }
            }

            byte step = 0;
            string[] words = Coded_text.Split(pun, StringSplitOptions.RemoveEmptyEntries);
            string largestWordorigin = "";
            string largestWordCash = "";
            bool key = false;
            foreach (string word in words)
            {
                if (word.Length > largestWordorigin.Length)
                {
                    largestWordorigin = word;
                }
            }
            largestWordorigin = largestWordorigin.ToLower();
            while (key != true)
            {
                largestWordCash = "";

                if (step == 33)
                {
                    throw new Exception("Не найдено ни одного совпадения в словаре");
                }
                for (int i = 0; i < largestWordorigin.Length; i++)
                {
                    for (int j = 0; j < alphabet.Length; j++)
                    {
                        if (largestWordorigin[i] == alphabet[j])
                        {
                            largestWordCash += alphabet[(j - step + alphabet.Length) % alphabet.Length];
                        }
                    }
                }

                foreach (var kvp in dictionary)
                {
                    if (kvp.Key == largestWordCash[0])
                    {
                        foreach (string word in kvp.Value)
                        {
                            if (word == largestWordCash)
                            {
                                key = true;
                                break;
                            }
                        }
                        if (key == true)
                        {
                            break;
                        }
                    }

                }
                step++;
            }
            return Decoding(Coded_text, Convert.ToByte(step - 1));
        }
    }
}

