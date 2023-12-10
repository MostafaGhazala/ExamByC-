using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Exam
{
    enum Answer
    {
        True, Flase
    }
    internal class TF:Question
    {
        
        public TF(string body , int mark   )
        {
            HeaderOfQuestion = "True || False Quetion ";
            BodyOfQuestion = body;
            Mark=mark;
            
        }
    }
}
