using System;

namespace Assignment3
{
    public class AdmissionInCourse
    {
        int physicsMark;
        int chemistryMark;
        int mathsMark;
        int totalMarks;
        int marksInTwoSubjects;

        public void CalculateMarks()
        {
            Console.WriteLine("Enter Physics Mark");
            physicsMark = Int16.Parse(Console.ReadLine());

            Console.WriteLine("Enter Maths Mark");
            mathsMark = Int16.Parse(Console.ReadLine());

            Console.WriteLine("Enter Chemistry Mark");
            chemistryMark = Int16.Parse(Console.ReadLine());

            totalMarks = physicsMark + chemistryMark + mathsMark;
            marksInTwoSubjects = physicsMark + mathsMark;
        }

        public void EligibilityCriteria()
        {
            if (physicsMark >= 65 && chemistryMark >= 55 && mathsMark >= 50 && totalMarks >= 180)
            {
                Console.WriteLine("Student is eligible");
            }
            else if (marksInTwoSubjects >= 140)
            {
                Console.WriteLine("Student is eligible");
            }
            else
            {
                Console.WriteLine(" admission.");
            }
        }

        public static void Main(string[] args)
        {
            AdmissionInCourse admissionInCourse = new AdmissionInCourse();
            admissionInCourse.CalculateMarks();
            admissionInCourse.EligibilityCriteria();
        }
    }
}
