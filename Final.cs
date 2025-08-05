using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    internal class Final:Exam
    {
        Question[] questions;

        public Final() {

            try
            {

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

                    Console.WriteLine("enter type of question 1 for mcq   2 for true false ");

                    flag = int.TryParse(Console.ReadLine(), out result);

                    if (flag)
                    {


                        if (result == 1) { questions[i] = new MCQ(); }
                        else if (result == 2) { questions[i] = new TF(); }




                    }




                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }



        }


    }
}
