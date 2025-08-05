using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    internal class Practical:Exam
    {


        

        public Practical() {

            try {

                int result;
                Console.WriteLine("enter number of minutes");
                var flag = int.TryParse(Console.ReadLine(), out result);

                if (flag) { time = result; }


                Console.WriteLine("enter number of questions ");
                flag = int.TryParse(Console.ReadLine(), out result);

                if (flag) { NumberOfQuestions = result; }

                questions = new Question[NumberOfQuestions];



                for (int i = 0; i < NumberOfQuestions; i++)
                {
                    questions[i] = new MCQ();
                    




                }



            }
            catch(Exception e) { Console.WriteLine(e.Message); }
        
        
        
        }



    }
}
