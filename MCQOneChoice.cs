using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination
{
    public class MCQOneChoice
    {
        public string answer1 { get; set; }
        public string answer3 { get; set; }

        public string answer2 { get; set; }
        public MCQOneChoice(string[]arr)
        {
            
                answer1 = arr[0];
                answer2 = arr[1];
                answer3 = arr[2];
            
            
            
        }
    }
}
