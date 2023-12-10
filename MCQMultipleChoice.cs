using Examination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class MCQMultipleChoice:Question

    {
        public MCQOneChoice MCQ { get; set; }
        
        public MCQMultipleChoice(string body, int mark,string[] ctormCQOneChoice)
        {
            HeaderOfQuestion = "Multiple Choice Quetion ";
            BodyOfQuestion = body;
            Mark=mark;
            MCQ = new MCQOneChoice(ctormCQOneChoice) ;

        }
    }
}
