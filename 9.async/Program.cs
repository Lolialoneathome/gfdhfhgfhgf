using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace _9.async
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new SomeService();
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            service.DoSomeJobAsync().Wait(); //Выполняется синхронно
            stopWatch.Stop();

            TimeSpan ts = stopWatch.Elapsed;
            Console.WriteLine("RunTime " + ts.Milliseconds);
            Console.ReadLine();
        }

        public class SomeService
        {
            public async Task DoSomeJobAsync()
            {
                await Task.Delay(200); //Выполняется асинхронно, но выше по цепочке - синхронный вызов, поэтому я могу там использовать Stopwatch
                Thread.Sleep(100); //Вернулись в главный поток, ждем еще 100 милисекунд
            }
        }


        //Ответ: метод будет выполняться >300мс (300мс на инструкции await Task.Delay(200) и Thread.Sleep(100) + время на переключение контекста между потоками)

    }
}
