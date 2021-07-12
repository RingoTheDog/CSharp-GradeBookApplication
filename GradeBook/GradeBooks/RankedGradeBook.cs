using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook:BaseGradeBook
    {
        public RankedGradeBook(string name):base(name)
        {
            Type = GradeBookType.Ranked;
        }



    public override char GetLetterGrade(double averageGrade)
        {
            
           


     

            if (Students.Count < 5)
            {

                return 'F';
            }
            else
            {
                return base.GetLetterGrade(averageGrade);
            }

        }
    }
}
