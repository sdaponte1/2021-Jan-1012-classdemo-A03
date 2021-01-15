using System;

namespace InputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Implement a temperature converter from
             * Celsius to Fahrenheit
             * 
             * Jan 2021
             */

            //input: Celsius temperature
            //      string inputTemp
            //      double theCelsiusTemperature

            //output: Fahrenheit temperature
            //          double theFahrenheitTemperature

            //Expression(caulculate):  (ct* (9.0/5.0) + 32
            //check with ct = 0 ecpect ft = 32
            //check with ct = 100 expect ft = 212
            //check with ct = 40 expext ft = -40

            //prompt for a celsius temperature
            //.Write() keeps your cursor on the same line
            Console.Write("Enter a Celsius temperature");

            //How does the program pull in the entry form the user
            // to obtain the key strokes that the user types(input)
            // .ReadLine()
            //IMPORTANT
            //data comes to the program as  a string
            //DOES NOT MATTERif you enter a number it its treated
            //has a string

            //declare the variable: datatype varialname;
            string inputTemp;
            //assigment statment:    expression on the right is placed
            //inyo the variablr on the left
            //ecpression(action):       read the user input
            inputTemp = Console.ReadLine();

            //you could do both statments on one line
            //string inputTemp = Console.Read();

            //currently the celsius value is a string
            //the value need to be converted to a number
            //to be used in a math calculation
            //Convert the data to a different datatype
            // to do this; you will use a technique calledparasins
            // syntax:   datatypeTo.Parse(string value);

            //WARNING : I am assumin the user will enter valid data
            //if user doesn't use a number this program will
            //abort the execution of this line
            double theCelsiusTemperature = double.Parse(inputTemp);


            //calculations usng the conversion expression
            double theFahrenheitTemperature =
                (theCelsiusTemperature * (9.0/5.0)) + 32;

            //output
            //.WriteLine(): wich automatticaly goes into the next line
            Console.WriteLine($"The Celsius temperature of {theCelsiusTemperature}" +
                   $"{ theFahrenheitTemperature}");




        }
    }
}
