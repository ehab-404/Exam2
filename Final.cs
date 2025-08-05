using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    internal class Final:Exam
    {
        

        public Final() {

            try
            {

                int result;
                Console.WriteLine("Please enter the time for exam  from(30 min to 180 min )");
                var flag = int.TryParse(Console.ReadLine(), out result);

                if (flag) { time = result; }


                Console.WriteLine("please enter the number of questions ");
                flag = int.TryParse(Console.ReadLine(), out result);

                if (flag) { NumberOfQuestions = result; }


                questions = new Question[NumberOfQuestions];




                for (int i = 0; i < NumberOfQuestions; i++)
                {

                    Console.WriteLine("enter type of question ( 1 for mcq   2 for true false ) ");

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
