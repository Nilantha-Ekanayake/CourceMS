using System;
using Cource.Application;
using Cource.Domain;

namespace Cource.Infrastructure
{
    public class AcademicCourceRepository : IAcademicCourceRepository
    {
        public AcademicCourceRepository(AcademicDBContext academicDBContext)
        {
            this.academicDBContext = academicDBContext;
        }
        public static List<AcademicCource> cources = new List<AcademicCource>()
        {
            new AcademicCource{Id=1,Title="SE",Description="Software Engnerring basics",NoOfTeachingHours=60,NoOfTutorailHours=30 },
             new AcademicCource{Id=2,Title="DBMS",Description="DBMS basics",NoOfTeachingHours=60,NoOfTutorailHours=30 },
              new AcademicCource{Id=3,Title="IS",Description="Software System basics",NoOfTeachingHours=60,NoOfTutorailHours=30 },
        };
        private readonly AcademicDBContext academicDBContext;

        public List<AcademicCource> GetCources()
        {
            return academicDBContext.academicCource.ToList();
        }

        public AcademicCource GetCourcesById(int id) => academicDBContext.academicCource.Where(x => x.Id == id).FirstOrDefault();

        public List<AcademicCource> Update() => academicDBContext.academicCource.ToList();

        public async Task<AcademicCource> create(AcademicCource academicCource) 
        {
            academicDBContext.Add(academicCource);
            await academicDBContext.SaveChangesAsync();
            return academicCource;

      }

        public async Task<AcademicCource> Update(AcademicCource academicCource)
        {
            academicDBContext.Update(academicCource);
            await academicDBContext.SaveChangesAsync();
            return academicCource;
        }
    }
}

