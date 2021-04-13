using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name, bool weighed) : base(name, weighed)
        {
            Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if(Students.Count < 5)
            {
                throw new InvalidOperationException("cannot be less than 5 students");
            }

            if (averageGrade >= 80)
                return 'A';
            else if (averageGrade >= 60 && averageGrade <=80)
                return 'B';
            else if (averageGrade >= 40 && averageGrade <=60)
                return 'C';
            else if (averageGrade >= 20 && averageGrade <=40)
                return 'D';
            else
                return 'F';
        }

        public override void CalculateStudentStatistics(string name)
        {
            if(Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");
                return;
            }
            else
            {
                base.CalculateStudentStatistics(name);
            }


        }
    }
}
