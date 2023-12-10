using System.Diagnostics;

namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject sub1 = new Subject(1, "C#");
            sub1.CreateExam();
            Console.Clear();
            Exam e;
            if (sub1.ans==1)
            {
                e=new PracticalExam();
            }
            else
                e=new FinalExam();
           
            
            Console.Write("Do You Want To Strat Exam (Y/N):  ");
            string? s =Console.ReadLine();
            if (s==null) 
            { 
                Console.WriteLine("terminated");
            }
            else if (s.ToLower()=="y")
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                e.ShowExam(sub1);
                Console.WriteLine($"The Elpased Time Is {sw.Elapsed}");
            }
           
            else 
            {
                Console.WriteLine("terminated");

            }
        }
    }
}