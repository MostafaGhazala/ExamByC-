using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
      abstract internal class Exam
    {
        public  int TimeOfExam { get; set; }
        public int NumbersOFQuestions { get; set; }
        
       
        public virtual void ShowExam(Subject s) 
        {
           
        }
    }

}

