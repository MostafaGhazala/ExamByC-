using Examination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    //enum KindOfQuestion
    //{
    //    MCQ,TF
    //}
    internal class Question
    {
        public String  HeaderOfQuestion { get; set; }
        public String BodyOfQuestion { get; set;}

        public int Mark { get; set; }
        public int NumOfQ=0;

        public  Ansewrs[] UserAnsewrs ;
        public Ansewrs[] TrueAnsewrs;
        


        public Question() 
        {
            
        }

    }
}
