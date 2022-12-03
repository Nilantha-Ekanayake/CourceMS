using System;
using Cource.Domain;

namespace Cource.Application
{
    public class AcademicCourceService :IAcademicCourceService
    {
        private readonly IAcademicCourceRepository academicCourceRepository;

        public AcademicCourceService(IAcademicCourceRepository academicCourceRepository)
        {
            this.academicCourceRepository = academicCourceRepository;
        }

        public async Task<AcademicCource> create(AcademicCource academicCource)
        {
            return await academicCourceRepository.create(academicCource);
        }

        public List<AcademicCource> GetCources()
        {
            return academicCourceRepository.GetCources();
        }

        public AcademicCource GetCourcesById(int id)
        {
            return academicCourceRepository.GetCourcesById(id);
        }

        public async Task<AcademicCource> Update(AcademicCource academicCource)
        {
            return await academicCourceRepository.Update(academicCource);
        }
    } 
}

