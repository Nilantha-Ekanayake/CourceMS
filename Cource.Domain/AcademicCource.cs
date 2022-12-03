using System;
namespace Cource.Domain
{
    public class AcademicCource
    {
        public int Id { get; set; }
        public String Title { get; set; } = String.Empty;
        public String Description { get; set; } = String.Empty;
        public int NoOfTeachingHours { get; set; } 
        public int NoOfTutorailHours { get; set; }

        
        public List<AcademicCourceOutLine> AcademicCourceOutLines { get; set; }
        public List<Student> Students { get; set; }
        public List<Lecturer> Lecturers { get; set; }
    }
}

