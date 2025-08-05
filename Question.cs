using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    internal  class Question
    {

        public  string header { get; set; }
        public  string body { get; set; }
        public  int mark { get; set; }
        
        public  int right_answer_id { get; set; }


        public  int your_answer { get; set; }


        public Answer[] AnswerList { get; set; }


        public override string ToString() { return body ; }


            


    }
}
