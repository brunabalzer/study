using System;
using System.Collections.Generic;

namespace inicio_c_sharp
{
    class Class1
    {
        string firstName;
        List<double> numeros;

        public Class1()
        {
            firstName = "Bob";
            numeros = new List<double>() { 3, 34.4 };
        }

        public void DisplayMessage()
        {
            Console.Write($"Hello, {firstName}! You have {numeros[0]} messages in your inbox. The temperature is {numeros[1]} celsius.");
        }

        static void Main(string[] args)
        {
            Class1 obj = new Class1();
            obj.DisplayMessage();
            Console.ReadLine();
        }
    }

    class Class2
    {



    }
}