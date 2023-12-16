using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] textArr = text.Split(',');
            int[] arr = new int[textArr.Length];
            for(int i = 0; i < textArr.Length; i++)
            {
                arr[i] = int.Parse(textArr[i]);
            }

            string arrText = "";
            for (int i = 0; i < arr.Length; i++)
            {
                arrText = arrText + arr[i].ToString() + " ";
            }
            Console.WriteLine(arrText);
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            Console.WriteLine("Сумма: " + sum);
            Console.WriteLine("Среднее: " + sum / arr.Length);
            Console.Read();
        }
    }
}
