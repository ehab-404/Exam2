using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    internal class TF:Question
    {
        
        public TF() 
        {
            try
            {


                AnswerList = new Answer[2];

                 header = header.tf;
                AnswerList[0] = new Answer(1, "true");
                AnswerList[1] = new Answer(2, "false");


                Console.WriteLine("enter question body ");

                body = Console.ReadLine();

                int result;
                Console.WriteLine("enter id of right answer  1 for true  2  for flase ");
                var flag = int.TryParse(Console.ReadLine(), out result);

                if (flag) { right_answer_id = result; }



                Console.WriteLine("enter mark");
                flag = int.TryParse(Console.ReadLine(), out result);

                if (flag) { mark = result; }



            }catch(Exception ex) { Console.WriteLine(ex.Message); }



        }
    }
}
