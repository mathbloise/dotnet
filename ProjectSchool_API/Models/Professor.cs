using System.Collections.Generic;

namespace ProjectSchool_API.Models
{
    public class Professor
    {
        public int Id { get; set; }
        public int Nome { get; set; }
        public List<Aluno> Alunos { get; set; }
    }
}