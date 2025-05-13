using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class ex5
    {
        static void Main(string[] args)
        {
            Dictionary<char, char> dict = new Dictionary<char, char>();
            dict.Add('(', ')');
            dict.Add('[', ']');
            dict.Add('{', '}');

            Stack<char> stack = new Stack<char>();

            #region заполнение_стека
            Console.WriteLine("Введите размер массива: ");


            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите последовательность из скобок: ");

            for (int i = 0; i < a; i++)
            {
                stack.Push(char.Parse(Console.ReadLine()));
            }
            #endregion

            char[] arr = stack.ToArray();

            if (isCorrect(arr, dict) == true)
            { 
                Console.WriteLine("Correct");
            }
            else Console.WriteLine("Uncorrect");
        }

        public static bool isCorrect(char[] arr, Dictionary<char, char> dict)
        {
            int count = arr.Length;
            bool isCorrect = true;
            if (count % 2 == 0)
            {
                for (int i = 0; i < count / 2; i++)
                {
                    if ((((arr[i] == dict.Values.ElementAt(0)) && arr[count - 1 - i] == dict.Keys.ElementAt(0)) ||
                        ((arr[i] == dict.Values.ElementAt(1)) && arr[count - 1 - i] == dict.Keys.ElementAt(1)) ||
                        ((arr[i] == dict.Values.ElementAt(2)) && arr[count - 1 - i] == dict.Keys.ElementAt(2))) && (isCorrect == true))
                    {

                    }
                    else isCorrect = false;
                }
                return isCorrect;
            }
            else return false;
        }
    }
}