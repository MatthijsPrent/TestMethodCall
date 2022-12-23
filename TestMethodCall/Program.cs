using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string firstResult = MethodCall.Methods.DirectCall("firstDirect", "secondDirect");
            Console.WriteLine(firstResult);

            string secondResult = MethodCall.Methods.CallWithRecord(new MethodCall.ThreeStrings("firstIndirect", "secondIndirect", "thirdIndirect"));
            Console.WriteLine(secondResult);
            
        }
    }
}