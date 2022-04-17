using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //с занятия

            #region Подсчет кол-ва строк в файле (15.8)
            /*
            StreamReader reader = new StreamReader("input.txt");
            StreamWriter writer= new StreamWriter("output.txt");

            int countString = 0;    //счетчик строк

            while (reader.EndOfStream == false)     //пока не дойдет до конца
            {
                reader.ReadLine();  //считает строки
                countString++; 
            }
            writer.WriteLine(countString);  //запись результата в файл

            reader.Close();
            writer.Close();
            */
            #endregion

            #region Подсчет кол-ва символов в файле (15.8)
            /*
            StreamReader reader2 = new StreamReader("input2.txt");
            StreamWriter writer2 = new StreamWriter("output2.txt");

            int countSymbols = 0;    //счетчик символов

            while (reader2.EndOfStream == false)     //пока не дойдет до конца
            {
                string currentString = reader2.ReadLine();  //приравнивает значение строки к переменной
                countSymbols += currentString.Length;   //считает длинну переменной и складывает в общую
            }
            writer2.WriteLine(countSymbols);  //запись результата в файл 2

            reader2.Close();
            writer2.Close();
            */
            #endregion

            //дз

            #region ДЗ - Поиск буквы в строке файла и вывод первой где он встретится (15.21)
            /*
            StreamReader reader = new StreamReader("input3.txt");
            StreamWriter writer = new StreamWriter("output3.txt");

            int countString = 0;    //счетчик строк

            while (reader.EndOfStream == false)     //пока не дойдет до конца
            {
                string symbolInString = reader.ReadLine();  //считает символ
                if (symbolInString.Contains('а'))
                {
                    countString++;
                    break;
                }
                else
                {
                    countString++;
                }
                    
            }
            writer.WriteLine(countString);  //запись результата в файл

            reader.Close();
            writer.Close();
            */
            #endregion

            #region ДЗ - запись строк в другой файл по такому же порядку (15.24 а )
            /*
            StreamReader reader = new StreamReader("input4.txt");
            StreamWriter writer = new StreamWriter("output4.txt");

            string currentString = "";

            while (reader.EndOfStream == false)
            {
                currentString = reader.ReadLine();
                writer.WriteLine(currentString);
                currentString = "";
            }
            

            reader.Close();
            writer.Close();
            */
            #endregion

            #region ДЗ - запись строк наоборот в другой файл (15.24 б ) Х
            /*
            StreamReader reader = new StreamReader("input5.txt");
            StreamWriter writer = new StreamWriter("output5.txt");

            File.WriteAllLines("output5.txt", File.ReadAllLines("input5.txt").Reverse());


            int countString = 0;

            while (reader.EndOfStream == false)
            {
                reader.ReadLine();
                countString++;      //8
            }


            string currentString = "";

            while (reader.EndOfStream == false)
            {
                currentString = reader.[countString - 1];
                writer.WriteLine(currentString);
                currentString = "";
            }
            

            reader.Close();
            writer.Close();
            */
            #endregion

            #region ДЗ - запись четных строк в один файл, а нечетных в другой (15.29)
            /*
            StreamReader reader = new StreamReader("input7.txt");
            StreamWriter writer2 = new StreamWriter("output7.txt");
            StreamWriter writer3 = new StreamWriter("output8.txt");

            int countString = 0;    //счетчик строк
            string currentString = "";

            while (reader.EndOfStream == false)     //пока не дойдет до конца
            {
                countString++;
                currentString = reader.ReadLine();
                if (countString % 2 == 0)
                {
                    writer2.WriteLine(currentString);   //четные
                    currentString = "";
                }
                else
                {
                    writer3.WriteLine(currentString);   //нечетные
                    currentString = "";
                }

            } 

            reader.Close();
            writer2.Close();
            writer3.Close();
            */
            #endregion

            #region ДЗ - сравнить строки в файле и выдать номер отличающейся строки (15.31)
            /*
            StreamReader reader = new StreamReader("input31.txt");
            StreamReader reader2 = new StreamReader("input32.txt");
            StreamWriter writer = new StreamWriter("output31.txt");            

            int countString = 1;    //счетчик строк с 1ой
            string currentString = "";
            string currentString2 = "";

            while (reader.EndOfStream == false && reader2.EndOfStream == false)     //пока не дойдет до конца
            {
                currentString = reader.ReadLine();  //считает строку 1
                currentString2 = reader2.ReadLine();    //считает строку 2
                if (currentString.Equals(currentString2))
                {
                    currentString = "";
                    currentString2 = "";
                    countString++;
                }
                else
                {
                    writer.WriteLine(countString);
                }

            }

            reader.Close();
            reader2.Close();
            writer.Close();
            */
            #endregion
        }
    }
}
