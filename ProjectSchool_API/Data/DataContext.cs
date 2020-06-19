using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ProjectSchool_API.Models;

namespace ProjectSchool_API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) { }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Professor> Professores { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Professor>()
            .HasData(
                new List<Professor>() {
                    new Professor() {
                        Id = 1,
                        Nome = "Matheus",
                    },
                    new Professor() {
                        Id = 2,
                        Nome = "Maria"
                    },
                    new Professor()  {
                        Id = 3,
                        Nome = "Jessica"
                    }
                }
            );
            builder.Entity<Aluno>()
            .HasData(
                new List<Aluno>() {
                    new Aluno() {
                        Id = 1,
                        Nome = "João",
                        Sobrenome = "Silva",
                        DataNasc = "05/06/1997",
                        ProfessorId = 1
                    },
                    new Aluno() {
                        Id = 2,
                        Nome = "Alex",
                        Sobrenome = "Feraz",
                        DataNasc = "25/11/1999",
                        ProfessorId = 1
                    },
                    new Aluno() {
                        Id = 3,
                        Nome = "Luana",
                        Sobrenome = "Pereira",
                        DataNasc = "12/02/2001",
                        ProfessorId = 1
                    }
                }
            );
        }
    }
}