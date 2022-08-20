using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetMediatr.Domain.Student.Entity;

namespace AspNetMediatr.Infrastructure
{
     public interface IStudentRepository
    {
        Task Save(StudentEntity student);
        Task Update(int id, StudentEntity student);
        Task Delete(int id);
        Task<StudentEntity> GetById(int id);
        Task<IEnumerable<StudentEntity>> GetAll();
    }
}