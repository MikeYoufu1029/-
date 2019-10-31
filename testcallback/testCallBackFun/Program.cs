using System;
using System.Threading;

namespace testCallBackFun
{
    class Program
    {
      
            static void Main(string[] args)
            {
                TestCallBack(CallBack);
            }
private static string CallBack(string s)
        {
            Console.WriteLine(s);
            Console.ReadKey();
            return s;
        }

        public static void TestCallBack(Func<string,string> what)
        {
            what("233");
        }


        }


    }

