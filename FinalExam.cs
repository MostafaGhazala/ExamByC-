using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class FinalExam : Exam
    {
       
        public override void ShowExam(Subject s)
        {
            bool flag;

            for (int i = 0; i < s.questionsarr.Length; i++)
            {
                s.questionsarr[i].UserAnsewrs=new Ansewrs[s.questionsarr.Length];

                int userAnswer;
                if (s.questionsarr[i].GetType() == typeof(MCQMultipleChoice))
                {
                    Console.WriteLine($"{s.questionsarr[i].HeaderOfQuestion}       Mark[{s.questionsarr[i].Mark}]");
                    Console.WriteLine($"{s.questionsarr[i].BodyOfQuestion}");
                    Console.WriteLine($"1.{((MCQMultipleChoice)s.questionsarr[i]).MCQ.answer1}           2.{((MCQMultipleChoice)s.questionsarr[i]).MCQ.answer2}           3.{((MCQMultipleChoice)s.questionsarr[i]).MCQ.answer3}");
                    Console.WriteLine("--------------------------------------");

                    do
                    {
                        flag=int.TryParse(Console.ReadLine(), out userAnswer);
                    } while (!flag||(userAnswer!=2&&userAnswer!=1&&userAnswer!=3));


                    s.questionsarr[i].UserAnsewrs[i]=new Ansewrs();

                    if (userAnswer==1)
                    {
                        s.questionsarr[i].UserAnsewrs[i].AnswerId=1;
                        s.questionsarr[i].UserAnsewrs[i].AnswerText= ((MCQMultipleChoice)s.questionsarr[i]).MCQ.answer1;
                    }
                    else if (userAnswer==2)
                    {
                        s.questionsarr[i].UserAnsewrs[i].AnswerId=2;
                        s.questionsarr[i].UserAnsewrs[i].AnswerText= ((MCQMultipleChoice)s.questionsarr[i]).MCQ.answer2;
                    }
                    else if (userAnswer==3)
                    {
                        s.questionsarr[i].UserAnsewrs[i].AnswerId=3;
                        s.questionsarr[i].UserAnsewrs[i].AnswerText= ((MCQMultipleChoice)s.questionsarr[i]).MCQ.answer3;
                    }

                }
                else if (s.questionsarr[i].GetType() == typeof(TF))
                {
                    Console.WriteLine($"{s.questionsarr[i].HeaderOfQuestion}       Mark[{s.questionsarr[i].Mark}]");
                    Console.WriteLine($"{s.questionsarr[i].BodyOfQuestion}");
                    Console.WriteLine($"1.True                   2.False ");
                    Console.WriteLine("--------------------------------------");

                    do
                    {
                        flag=int.TryParse(Console.ReadLine(), out userAnswer);
                    } while (!flag||(userAnswer!=2&&userAnswer!=1));

                    //questionsarr[i].UserAnsewrs=new Ansewrs[questionsarr.Length];

                    s.questionsarr[i].UserAnsewrs[i]=new Ansewrs();

                    if (userAnswer==1)
                    {
                        s.questionsarr[i].UserAnsewrs[i].AnswerId=1;
                        s.questionsarr[i].UserAnsewrs[i].AnswerText= "True";
                    }
                    else if (userAnswer==2)
                    {
                        s.questionsarr[i].UserAnsewrs[i].AnswerId=2;
                        s.questionsarr[i].UserAnsewrs[i].AnswerText= "False";
                    }
                }
                ///////////////////////////////////////////////////

            }

            ///////////////////////////////////////////
            int Grade = 0;
            int UserGrade = 0;
            Console.WriteLine("Your Answers: ");
            for (int k = 0; k<s.questionsarr.Length; k++)
            {
                Console.WriteLine($"Q{k+1}   {s.questionsarr[k].BodyOfQuestion}:{s.questionsarr[k].UserAnsewrs[k].AnswerText}");
                Grade+=s.questionsarr[k].Mark;
                if (s.questionsarr[k].UserAnsewrs[k].AnswerId==s.questionsarr[k].TrueAnsewrs[k].AnswerId)
                {
                    UserGrade+=s.questionsarr[k].Mark;
                }
            }
            Console.WriteLine($"Your Exam Grade IS {UserGrade} from {Grade} ");

        }
    }
}
