using System;
using System.Threading;
using System.Threading.Tasks;

namespace IAcallBack
{
    class Program
    {
        public static int a = 0;
         static void Main(string[] args)
         {
             var result = Add();
             // 等待3秒输出，说明是在使用值得时候进行等待
             // 输出6，说明async是线性执行的
             Console.WriteLine(result.Result);
             var result2 = Add();
             // 再次等待3秒
             Thread.Sleep(3000);
             Console.WriteLine(1);
             Console.WriteLine(result2.Result);
             // 同时输出1和6，说明是并行执行的，Add开始沉睡3秒的时候主线程同时沉睡3秒，然后主线程醒了同时result2被赋予了值
             Console.Read();
         }
         public static async Task<int> Add()
         {
             await Task.Run(() =>
             {
                         Thread.Sleep(3000);
                         a += 3;
                     });
            a = 6;
            return a;
         }
    }
}
