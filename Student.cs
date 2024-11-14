using System;
namespace Challenge2_4
{
	public class Student
	{
		public string RollNum { get; set; }
		public string Name { get; set; }
		public string OverallPercentage { get; set; } // Saves the overall percentage of the student

		// This property is used to count how many grades are being calculated.
		// Used for divisionSelection Method
		public int GradeCount { get; set; } = 0;

		public double GradeSummation { get; set; } = 0; // Holds total grade

		private readonly Dictionary<string,string> grades = new Dictionary<string, string>(); // Hold grade information

		public Dictionary<string,string> Grades
		{
			get { return grades; }
		}

        public Student()
		{
		}

		public double CalculateGrade(string rollNum, Dictionary<string,string> grades)
		{

			string[] temp = grades[rollNum].Split(',');

			foreach (string grade in temp)
			{
				GradeSummation += Convert.ToDouble(grade);
				GradeCount++;
			}
			return GradeSummation;
        }

		// Finds the division the student is in
		public string DivisionSelection(double gradeSummation)
		{
			// Gets total percentage point based on how many grades are added
			double totalGrade = 100 * GradeCount;

			// totalGrade Divided by four to be used to create buckets for each division
			double subtractDivision = totalGrade / 4;

			if (gradeSummation >= 0 && gradeSummation <= (totalGrade - (subtractDivision * 3)))
			{
				return "4th";
			}else if(gradeSummation > (totalGrade - (subtractDivision * 3)) && gradeSummation <= (totalGrade - (subtractDivision * 2)))
			{
                return "3rd";
			}else if(gradeSummation > (totalGrade - (subtractDivision * 2)) && gradeSummation <= (totalGrade - (subtractDivision)))
			{
                return "2nd";
			}
			else
			{
                return "1st";
			}
		}

		// Calculates student overall percentage
		public string CalculateGradePercentage(double gradeSummation)
		{
			OverallPercentage = Math.Round((gradeSummation / (100 * GradeCount) * 100), 2).ToString("0.00");

            return OverallPercentage;
		}
	}
}
