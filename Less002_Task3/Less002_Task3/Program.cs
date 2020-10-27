using System;

namespace Less002_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar1 = 5;
            int myVar2 = 7;

            int addition = myVar1 + myVar2;
            int subtruction = myVar1 - myVar2;
            double division = (double) myVar1 / myVar2;
            int multiplication = myVar1 * myVar2;
            int percentage = myVar1 % myVar2;

            Console.WriteLine($"myVar1 + myVar2 = {addition} \n myVar1 - myVar2 = {subtruction} \n myVar1 / myVar2 = {division} \n myVar1 * myVar2 = {multiplication} \n myVar1 % myVar2 = {percentage}");
        }
    }
}
