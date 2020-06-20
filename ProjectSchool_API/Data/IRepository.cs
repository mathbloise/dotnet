using System.Threading.Tasks;
using ProjectSchool_API.Models;

namespace ProjectSchool_API.Data
{
    public interface IRepository
    {
         void Add<T>(T entity) where T: class;
         void Update<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;
         Task<bool> SaveChangesAsync();
         
         //Alunos
         Task<Aluno[]> GetAllAlunosAsync(bool includeProfessor);
         Task<Aluno[]> GetAlunosAsyncByProfessorId(int ProfessorId, bool includeProfessor);
         Task<Aluno> GetAlunoAsyncById(int AlunoId, bool includeProfessor);

        //Professores
         Task<Professor[]> GetAllProfessoresAsync(bool includeAluno);
         Task<Professor> GetProfessorAsyncById(int ProfessorId, bool includeAluno);
    }
}