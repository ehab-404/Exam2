using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    internal class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Exam exam{ get; set; }

        

        public void CreateExam() {

            int result;
            Console.WriteLine("Please Enter The type of exam ( 1 for practical | 2  for final  )");

           var flag = int.TryParse(Console.ReadLine(), out result);

            if (flag)
            {


                if (result == 1) {exam =new Practical(); }
                else if (result == 2) { exam = new Final(); }




            }
          
        
        }



        public void StartExam() {

            Console.WriteLine($"exam time:  {exam.time}");
            Console.WriteLine($"NumberOfQuestions:  {exam.NumberOfQuestions}");

            Console.WriteLine("Do You want  to start exam (Y|N)  ");
            if (Console.ReadLine() == "y")
            {

                DateTime now = DateTime.Now;
                foreach (Question question in exam.questions)
                {
                    Console.WriteLine($"mark : {question.mark}");

                    Console.WriteLine(question.header);

                    
                    exam.Grade += question.mark;

                    Console.WriteLine(question);

                    Console.WriteLine($"1- {question.AnswerList[0]}");
                    Console.WriteLine($"2- {question.AnswerList[1]}");

                    if(question.header== "mcq question ") { Console.WriteLine($"3- {question.AnswerList[2]}"); }
                    



                    Console.WriteLine("please enter the answer id ");

                    question.your_answer = int.Parse(Console.ReadLine());

                    if (question.right_answer_id == question.your_answer) { exam.YourGrade += question.mark; }


                }
                Console.WriteLine("end of exam ");


                for (int i = 0; i < exam.questions.Length; i++)
                {
                    Console.WriteLine($"question  {i + 1} :{exam.questions[i]}");




                    Console.WriteLine($"your answer => {exam.questions[i].AnswerList[exam.questions[i].your_answer-1]}");
                    Console.WriteLine($"correct answer => {exam.questions[i].AnswerList[exam.questions[i].right_answer_id-1]}");




                }

                Console.WriteLine($"your grade : {exam.YourGrade}");
                Console.WriteLine($"total grade : {exam.Grade}");



                Console.WriteLine($"time = {DateTime.Now - now}");
                Console.WriteLine("thank you ");


            }




        }
    }
}
