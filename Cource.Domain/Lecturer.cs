using System;
namespace Cource.Domain
{
    public class Lecturer :Person
    {
        public Designation Designation { get; set; }
        public DateTime JoinedDate { get; set; }
        public List<AcademicCource> AcademicCources { get; set; }

    }

    public enum Designation
    {
        SeniorLecturer,
        Lecturer,
        ProbationLectorer,
        AssistantLecturer,
        Instructor,

    }
}

