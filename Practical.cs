using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    internal class Practical:Exam
    {


        MCQ[] msqs;

        public Practical() {

            try {

                int result;
                Console.WriteLine("enter number of minutes");
                var flag = int.TryParse(Console.ReadLine(), out result);

                if (flag) { time = result; }


                Console.WriteLine("enter number of questions ");
                flag = int.TryParse(Console.ReadLine(), out result);

                if (flag) { NumberOfQuestions = result; }

                msqs = new MCQ[NumberOfQuestions];



                for (int i = 0; i < NumberOfQuestions; i++)
                {
                    msqs[i] = new MCQ();
                    




                }



            }
            catch(Exception e) { Console.WriteLine(e.Message); }
        
        
        
        }



    }
}
