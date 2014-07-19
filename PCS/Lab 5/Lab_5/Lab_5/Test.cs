
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Test
    {
        Workers[] worker;
        Students[] student;

        public Test()
        {
            //Workers
            typeWorker();
            displayWorker();

            //Students
            /*typeStudent();
            displayStudent();*/


        }

        // type workers
        private void typeWorker()
        {
            Console.WriteLine("Type number of woker : ");
            int n = int.Parse(Console.ReadLine());
            worker = new Workers[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Worker : "+(i+1));
                worker[i] = new Workers();
                worker[i].input();
            }
        }


        // type students
        private void typeStudent()
        {
            Console.WriteLine("Type number of student : ");
            int n = int.Parse(Console.ReadLine());
            student = new Students[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Student : " +( i + 1));
                student[i] = new Students();
                student[i].input();
            }
        }

        //display Worker

        private void displayWorker()
        {
            Console.WriteLine("--- Worker informations ! ----");
            for (int i = 0; i < worker.Length; i++)
            {
                Console.WriteLine("Worker : " + i + 1);
                worker[i].display();
            }

        }

        //display Students

        private void displayStudent()
        {
            Console.WriteLine("--- Student informations ! ----");
            for (int i = 0; i < student.Length; i++)
            {
                Console.WriteLine("Worker : " + i + 1);
                student[i].display();
            }

        }
    }
}
