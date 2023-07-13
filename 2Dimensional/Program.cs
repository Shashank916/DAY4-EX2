using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Dimensional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[,] myRectArray = new string[4, 3];
            //for(int i = 0; i < myRectArray.GetLength(0); i++)
            //{
            //for (int j = 0; j < myRectArray.GetLength(1); j++) 
            //    {
            //        myRectArray[i,j]="[" + i + ","  + j+ "]";
            //    }
            //}
            //Console.WriteLine("Stored Values are:");
            //for (int i = 0; i< myRectArray.GetLength(0); i++) 
            //{
            //for (int j = 0; j < myRectArray.GetLength(1); j++)
            //    {
            //        Console.WriteLine(myRectArray[i,j]+"\t");
            //    }
            //Console.WriteLine("\n");
            //}
            //Console.ReadLine();



            //int[,] marks = new int[4, 3];
            //for (int i = 0; i < 4; i++) 
            //{
            //    Console.WriteLine($"Enter Student {i+1}\'s Rool Number");
            //    marks[i,0] = int.Parse(Console.ReadLine());
            //    for (int j = 1;  j < 3; j++) 
            //    {
            //        Console.WriteLine($"Enter marks of Student\'s{i+1} in Sem {j}");
            //        marks[i, j] = int.Parse(Console.ReadLine());
            //    }

            //}
            //Console.WriteLine("Marks List as Follows");
            //Console.WriteLine("RollNo\tSemOne\t  SemTwo");
            //for (int i = 0;i < 4;i++) 
            //{
            //for (int j = 1;j < 3;j++)
            //    {
            //        Console.Write(marks[i,j]+" \t" );
            //    }
            //Console.WriteLine("\n");
            //}
            //Console.ReadLine();



            //int[,] studMarks = new int[4, 5];


            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine("Enter details for Student {0}:", i + 1);
            //    Console.Write("Roll No: ");
            //    studMarks[i, 0] = Convert.ToInt32(Console.ReadLine());

            //    for (int j = 1; j <= 4; j++)
            //    {
            //        Console.Write("Semester {0} marks: ", j);
            //        studMarks[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("Roll No  Sem1  Sem2  Sem3  Sem4  Total");


            //for (int i = 0; i < 4; i++)
            //{
            //    int total = 0;
            //    Console.Write(studMarks[i, 0] + "       ");

            //    for (int j = 1; j <= 4; j++)
            //    {
            //        Console.Write(studMarks[i, j] + "     ");
            //        total += studMarks[i, j];
            //    }

            //    Console.WriteLine(total);
            //}

            //Console.ReadLine();




            int[,] studmarks = new int[4, 5]
        {
            { 1, 80, 85, 90, 95 },
            { 2, 75, 70, 85, 80 },
            { 3, 90, 92, 88, 95 },
            { 4, 70, 65, 75, 80 }
        };

           
            Console.WriteLine("RollNo sem1 sem2 sem3 sem4 Total");

        
            for (int i = 0; i < 4; i++)
            {
                int rollNo = studmarks[i, 0];
                int sem1 = studmarks[i, 1];
                int sem2 = studmarks[i, 2];
                int sem3 = studmarks[i, 3];
                int sem4 = studmarks[i, 4];
                int total = sem1 + sem2 + sem3 + sem4;

             
                Console.WriteLine($"{rollNo,-6} {sem1,-5} {sem2,-5} {sem3,-5} {sem4,-5} {total,-5}");
            }

            Console.ReadKey();
        }

    }
}
