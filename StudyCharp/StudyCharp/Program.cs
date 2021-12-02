using System;
using System.Threading;
using StudyCharp.Basic;
namespace StudyCharp
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan interval = new TimeSpan(0, 0, 1);
            Console.WriteLine("Hello World!");
            ClassStudy stu = new ClassStudy();

            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(stu.RandomNum());
                Thread.Sleep(interval);
            }

            stu.getMulitFiledContent();
            Console.ReadKey();
        }

        
      
    }   
}
