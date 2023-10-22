using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloApp5
{
    internal class Program
    {

        public static string DoubleLitter(string s)
        {
            string st = string.Empty;
            string consonants = "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ";

            foreach (char c in s)
            {
                if (consonants.Contains(c))
                {
                    st += c.ToString() + c.ToString();
                }
                else
                {
                    st += c.ToString();
                }
            }
            return st;
        }
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string s, s1;
            int v = -1;
            while (v != 0)
            {
                Console.Clear();
                Console.WriteLine("1) Консольное приложение \n2) Windows Forms \n\n0) Выход \n\nВведите номер метода : ");
                s = Console.ReadLine();
                v = Convert.ToInt32(s);
                switch (v)
                {
                    case 1:
                        {
                            Console.Clear();
                            int v1 = -1;
                            string sn;
                            while (v1 != 0)
                            {
                                Console.Clear();
                                Console.WriteLine("1) Задание 1\n2) Задание 2\n3) Задание 3 \n\n0) Выход \n\nВведите номер метода : ");
                                sn = Console.ReadLine();
                                v1 = Convert.ToInt32(sn);
                                switch (v1)
                                {
                                    case 1:
                                        {
                                            Console.Clear();
                                            int len1, len2;
                                            string word1, word2;
                                            Console.WriteLine("Введите первое слово");
                                            word1 = Console.ReadLine();
                                            Console.WriteLine("Введите второе слово");
                                            word2 = Console.ReadLine();
                                            len1 = word1.Length;
                                            len2 = word2.Length;
                                            if (len1 > len2)
                                            {
                                                Console.WriteLine("Первое слово больше на " + (len1 - len2) + " знаков\n");
                                            }
                                            else if (len1 < len2)
                                            {
                                                Console.WriteLine("Второе слово больше на " + (len2 - len1) + " знаков\n");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Слова имеют одинаковое количество знаков\n");
                                            }


                                            Console.WriteLine("Нажмите любую кнопку для продолжения...");
                                            s1 = Console.ReadLine();
                                            break;

                                        }
                                    case 2:
                                        {
                                            Console.Clear();
                                            string str2, strrev = String.Empty, strrevn = String.Empty;
                                            int size = 0, count1 = 0, count2 = 0, k = 0;
                                            string[] arrString;
                                            Console.WriteLine("Введите строку (на английском), разделяя каждое слово запятой, в конце строки точка");
                                            str2 = Console.ReadLine();
                                            foreach (char c in str2)
                                            {
                                                if (c.ToString() == "." || c.ToString() == ",")
                                                {
                                                    size++;
                                                }
                                            }
                                            Console.WriteLine(size);
                                            arrString = new string[size];
                                            foreach (char c in str2)
                                            {
                                                if (c.ToString() == "." || c.ToString() == ",")
                                                {
                                                    for (int i = (count1 - count2); i < count1; i++)
                                                    {
                                                        arrString[k] += str2[i];
                                                    }
                                                    k++;
                                                    count2 = 0;
                                                }
                                                else
                                                {
                                                    count2++;
                                                }
                                                count1++;
                                            }
                                            for (int i = size - 1; i >= 0; i--)
                                            {
                                                strrev += arrString[i] + ",";
                                            }
                                            strrevn = strrev.Remove(strrev.Length - 1) + ".";
                                            Console.WriteLine(strrevn);
                                            Console.WriteLine("Нажмите любую кнопку для продолжения...");
                                            s1 = Console.ReadLine();
                                            break;

                                        }
                                    case 3:
                                        {
                                            Console.Clear();
                                            string str;
                                            Console.WriteLine("Введите строку (на английском)");
                                            str = Console.ReadLine();
                                            Console.WriteLine("Результат работы программы: " + DoubleLitter(str));
                                            Console.WriteLine("Нажмите любую кнопку для продолжения...");
                                            s1 = Console.ReadLine();
                                            break;

                                        }
                                    case 0:
                                        {
                                            Console.Clear();
                                            break;
                                        }

                                    default:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Введено невернрое значение!");
                                            Console.WriteLine("Нажмите любую кнопку для продолжения...");
                                            s = Console.ReadLine();
                                            break;
                                        }
                                }
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Application.Run(new Form1());
                            Console.WriteLine("Нажмите любую кнопку для продолжения...");
                            s = Console.ReadLine();
                            break;
                        }

                    case 0:
                        {
                            Console.Clear();
                            break;
                        }

                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("Введено невернрое значение!");
                            Console.WriteLine("Нажмите любую кнопку для продолжения...");
                            s = Console.ReadLine();
                            break;
                        }

                }
            }
        }
    }
}

