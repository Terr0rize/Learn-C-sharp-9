using System;
using System.Collections.Generic; //массив, списки.
using System.ComponentModel;
using System.Globalization;
using System.Net;

namespace C_sharp_learning
{
    class MainClass
    {
        static void Main(string[] args) //метод срабатывает при старте программы
        {
            Console.WriteLine("Enter number: ");         
                try
                {
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Num is: " + num);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("FormatException: " + ex);
                }finally
                  {
                Console.WriteLine("Try catch is exit");
                  }
            
            Console.ReadKey();
        }
    }
}
