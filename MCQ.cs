using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    internal class MCQ:Question
    {

      

        public MCQ() 
            
        {
            try
            {
                AnswerList = new Answer[3];


                header = header.mcq;




                Console.WriteLine("enter question body ");

                body = Console.ReadLine();


                Console.WriteLine("enter first choice ");

                AnswerList[0] = new Answer(1, Console.ReadLine());


                Console.WriteLine("enter second choice ");

                AnswerList[1] = new Answer(2, Console.ReadLine());

                Console.WriteLine("enter third choice ");

                AnswerList[2] = new Answer(3, Console.ReadLine());







                int result;
                Console.WriteLine("enter id of right answer");
                var flag = int.TryParse(Console.ReadLine(), out result);

                if (flag) { right_answer_id = result; }



                Console.WriteLine("enter mark");
                flag = int.TryParse(Console.ReadLine(), out result);

                if (flag) { mark = result; }


            } catch (Exception ex) { Console.WriteLine(ex.Message); }





        }
    }
}
