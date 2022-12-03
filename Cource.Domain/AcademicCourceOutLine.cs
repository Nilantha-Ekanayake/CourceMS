using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cource.Domain
{
    public class AcademicCourceOutLine
    {
       
        public int Id { get; set; }
        public String LessonId { get; set; } = String.Empty;
        public String Description { get; set; } = String.Empty;
        public AcademicCource Cource { get; set; }

    }
}

