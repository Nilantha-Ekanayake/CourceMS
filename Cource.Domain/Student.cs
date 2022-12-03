using System;
namespace Cource.Domain
{
    public class Student :Person
    {
        public DateTime EnrolledDate { get; set; }
        public Boolean IsInternational { get; set; }

        public List<AcademicCource> AcademicCource { get; set; }


    }
}

