using System;

namespace testcallback
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CalculateClass cc = new CalculateClass();
            FunctionClass fc = new FunctionClass();
            int result1 = cc.print(2, 3, fc.getSum);
            Console.WriteLine("result1====" + result1);
            int result2 = cc.print(2, 3, fc.getMulti);
           
            Console.WriteLine("result2===="+result2);
            Console.ReadLine();
        }
    }
    class FunctionClass
    {
        public int getSum(int a,int b)
        {
            return (a + b);
        }
        public int getMulti(int a,int b)
        {
            return a * b;
        }
    }

    class CalculateClass
    {
        public delegate int someCalculate(int num1, int num2);
        public int print(int num1,int num2,someCalculate cm)
        {
            Console.WriteLine("system:" + num1);
            Console.WriteLine("system:" + num2);
            return cm(num1, num2);
        }

    }

}
