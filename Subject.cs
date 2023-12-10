using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Exam
{
    internal class Subject
    {
        public int SubjectId { set; get; }
        public string SubjectName { set; get; }
        public Exam exam;
        public Subject(int id, string name)
        {
            SubjectId = id;
            SubjectName = name;
        }
        public Question[] questionsarr;
        public string[] arr = new string[3];
        public int ans;
        public void CreateExam()
        {

            // To Choice Kind Of Exam 
            bool flag;

            do
            {
                Console.Write("Please enter Type Of Exam You Want To Create ( 1 To Practical 2 To final ): ");
                flag =int.TryParse(Console.ReadLine(), out ans);
            } while (!flag || (ans !=2 && ans!=1));

            //To Take Time Of Exam
            int time;
            do
            {
                Console.Write("Please enter Time Of Exam: ");
                flag =int.TryParse(Console.ReadLine(), out time);
            } while (!flag);

            //To Take Numbers Of Questions
            int numOfQ;
            do
            {
                Console.Write("Please enter Number Of Questions Of Exam: ");
                flag =int.TryParse(Console.ReadLine(), out numOfQ);
            } while (!flag||numOfQ==0);
            exam = new FinalExam();
            exam.TimeOfExam=time;
            exam.NumbersOFQuestions=numOfQ;
            /*Question[]*/
            questionsarr = new Question[exam.NumbersOFQuestions];
            Console.Clear();
            //To Create Final Exam
            if (ans ==2)
            {

                //االمفروض اعمل حاجه اشيل فيها الاسئله اللي داخله ليا  


                for (int i = 0; i<questionsarr.Length; i++)
                {

                    int TypeOfQ;
                    do
                    {
                        Console.Write($"Please enter Type Of Quetion You Want To Create Number{i+1} ( 1 To True Or False || 2 To MCQ ): ");
                        flag =int.TryParse(Console.ReadLine(), out TypeOfQ);
                    } while (!flag || TypeOfQ >2 ||TypeOfQ<1);
                    Console.Clear();
                    if (TypeOfQ==1)
                    {
                        Console.WriteLine("True || False quetion ");
                        string? Body;
                        do
                        {
                            Console.WriteLine("Enter Body Of Quetion :");
                            Body = Console.ReadLine();
                        } while (Body==null||Body=="");
                        int mark;
                        do
                        {
                            Console.WriteLine("Enter Mark Of Quetion :");
                            flag = int.TryParse(Console.ReadLine(), out mark);
                        } while (!flag);
                        int TFAnswer;
                        do
                        {
                            Console.WriteLine("Please Enter The Right Answer Of Quetion (1 To True | 2 To False): ");
                            flag = int.TryParse(Console.ReadLine(), out TFAnswer);
                        } while (!flag||TFAnswer>2||TFAnswer<1);
                        questionsarr[i] = new TF(Body, mark);
                        questionsarr[i].TrueAnsewrs=new Ansewrs[numOfQ];

                        questionsarr[i].TrueAnsewrs[i]=new Ansewrs();

                        if (TFAnswer==1)
                        {
                            questionsarr[i].TrueAnsewrs[i].AnswerId=1;
                            questionsarr[i].TrueAnsewrs[i].AnswerText="True";
                        }
                        else if (TFAnswer==2)
                        {
                            questionsarr[i].TrueAnsewrs[i].AnswerId=2;
                            questionsarr[i].TrueAnsewrs[i].AnswerText="False";
                        }


                        //انا دلوقتي عايز اسجل الاجابات اللي داخله ليا مع بعض سةاء mcq او TrueOrFalse


                    }
                    else if (TypeOfQ==2)
                    {
                        Console.WriteLine("Multiple Choice ");

                        string? Body;
                        do
                        {
                            Console.WriteLine("Enter Body Of Quetion :");
                            Body = Console.ReadLine();
                        } while (Body==null||Body=="");

                        for (int j = 0; j<3; j++)
                        {
                            do
                            {
                                Console.WriteLine($"Enter Answer NO.{j+1} :");
                                arr[j] = Console.ReadLine();
                            } while (arr[j]==null||arr[j]=="");

                        }
                        // Console.WriteLine(arr[0]); 

                        int mark;
                        do
                        {
                            Console.WriteLine("Enter Mark Of Quetion :");
                            flag = int.TryParse(Console.ReadLine(), out mark);
                        } while (!flag);

                        int McqAnswer;
                        do
                        {
                            Console.WriteLine("Please Enter The Right Answer Of Quetion (1,2 OR 3): ");
                            flag = int.TryParse(Console.ReadLine(), out McqAnswer);
                        } while (!flag||(McqAnswer!=2&&McqAnswer!=1&&McqAnswer!=3));

                        questionsarr[i] = new MCQMultipleChoice(Body, mark, arr);
                        questionsarr[i].TrueAnsewrs=new Ansewrs[numOfQ];

                        questionsarr[i].TrueAnsewrs[i]=new Ansewrs();
                        if (McqAnswer==1)
                        {
                            questionsarr[i].TrueAnsewrs[i].AnswerId=1;
                            questionsarr[i].TrueAnsewrs[i].AnswerText=arr[0];
                        }
                        else if (McqAnswer==2)
                        {
                            questionsarr[i].TrueAnsewrs[i].AnswerId=2;
                            questionsarr[i].TrueAnsewrs[i].AnswerText=arr[1];
                        }
                        else if (McqAnswer==3)
                        {
                            questionsarr[i].TrueAnsewrs[i].AnswerId=3;
                            questionsarr[i].TrueAnsewrs[i].AnswerText=arr[2];
                        }
                        //questionsarr[0].arrayOfAnswersOfMCQ[0].

                    }
                }

            }
            else if (ans==1)
            {
                for (int i = 0; i<questionsarr.Length; i++)

                {
                    Console.WriteLine("Multiple Choice ");

                    string? Body;
                    do
                    {
                        Console.WriteLine("Enter Body Of Quetion :");
                        Body = Console.ReadLine();
                    } while (Body==null||Body=="");
                    for (int j = 0; j<3; j++)
                    {
                        do
                        {
                            Console.WriteLine($"Enter Answer NO.{j+1} :");
                            arr[j] = Console.ReadLine();
                        } while (arr[j]==null||arr[j]=="");

                    }


                    int mark;
                    do
                    {
                        Console.WriteLine("Enter Mark Of Quetion :");
                        flag = int.TryParse(Console.ReadLine(), out mark);
                    } while (!flag);

                    int McqAnswer;
                    do
                    {
                        Console.WriteLine("Please Enter The Right Answer Of Quetion (1,2 OR 3): ");
                        flag = int.TryParse(Console.ReadLine(), out McqAnswer);
                    } while (!flag||(McqAnswer!=2&&McqAnswer!=1&&McqAnswer!=3));

                    questionsarr[i] = new MCQMultipleChoice(Body, mark, arr);
                    questionsarr[i].TrueAnsewrs=new Ansewrs[numOfQ];

                    questionsarr[i].TrueAnsewrs[i]=new Ansewrs();
                    if (McqAnswer==1)
                    {
                        questionsarr[i].TrueAnsewrs[i].AnswerId=1;
                        questionsarr[i].TrueAnsewrs[i].AnswerText=arr[0];
                    }
                    else if (McqAnswer==2)
                    {
                        questionsarr[i].TrueAnsewrs[i].AnswerId=2;
                        questionsarr[i].TrueAnsewrs[i].AnswerText=arr[1];
                    }
                    else if (McqAnswer==3)
                    {
                        questionsarr[i].TrueAnsewrs[i].AnswerId=3;
                        questionsarr[i].TrueAnsewrs[i].AnswerText=arr[2];
                    }
                    //string s = ((MCQMultipleChoice)questionsarr[i]).MCQ.answer1;
                    //Console.WriteLine(s);
                }
            }





        }

    }   
}
