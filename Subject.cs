using System;
using System.Collections.Generic;
using System.Linq;
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
            Console.WriteLine("enter type of exam  1 for practical  2  for final");

           var flag = int.TryParse(Console.ReadLine(), out result);

            if (flag)
            {


                if (result == 1) {exam =new Practical(); }
                else if (result == 2) { exam = new Final(); }




            }
          
        
        }




    }
}
