

namespace Challenge2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a C# Sharp program to read roll no, name and marks of three subjects and calculate the total, percentage and division.
            Console.Write("Enter Student Roll Number: ");
            string rollNum = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter Student Name: ");
            string stuName = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter Physics Grade %: ");
            string phyGrade = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter Chemistry Grade %: ");
            string chemGrade = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter Computer Application Grade %: ");
            string compAppGrade = Console.ReadLine();
            Console.WriteLine();

            Student newStudent = new Student();
            //String to hold grade info
            string studentInfoString = $"{phyGrade},{chemGrade},{compAppGrade}";

            // Adds student information to student class
            newStudent.RollNum = rollNum;
            newStudent.Name = stuName;
            newStudent.Grades.Add(rollNum, studentInfoString);

            // Calculates max marks and total marks of student by rollNum
            double tempPercentageTotal = newStudent.CalculateGrade(newStudent.RollNum, newStudent.Grades);
            Console.WriteLine($"Max Marks: { newStudent.GradeCount * 100}");
            Console.WriteLine($"Student Total Marks: { tempPercentageTotal }");
            Console.WriteLine();

            // Calculates the students overall percentage and divsion they are in
            string tempPrecentageOverall = newStudent.CalculateGradePercentage(tempPercentageTotal);
            string tempDivision = newStudent.DivisionSelection(tempPercentageTotal);
            Console.WriteLine($"Student Overall Percentage: { tempPrecentageOverall }%");
            Console.WriteLine($"Student Division: { tempDivision }");



        }
    }
}
