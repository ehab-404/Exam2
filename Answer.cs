using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    internal class Answer
    {
        public int ID { get; set; }
        public string AnswerText { get; set; }


        public Answer(int ID, string AnswerText) { this.ID = ID; this.AnswerText = AnswerText; }
        public Answer( ) {


            try {
                int result;
                Console.WriteLine("enter id of answer");
                var flag = int.TryParse(Console.ReadLine(), out result);

                if (flag) { ID = result; }

                Console.WriteLine("enter   answer body ");

                AnswerText = Console.ReadLine();
            }
            catch ( Exception e) { Console.WriteLine(e.Message); }

            
            
            
        
        
        }

        public override string ToString() { return AnswerText; }


    }
}
