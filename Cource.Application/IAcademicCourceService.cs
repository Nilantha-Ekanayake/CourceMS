using System;
using Cource.Domain;

namespace Cource.Application
{
    public interface IAcademicCourceService
    {
        List<AcademicCource> GetCources();
        Task<AcademicCource> create(AcademicCource academicCource);
        AcademicCource GetCourcesById(int id);
        Task<AcademicCource> Update(AcademicCource academicCource);
    }
}

