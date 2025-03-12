using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroAlunos
{
    internal class Alunos
    {
        public string Nome;
        public string Matricula;
        public string Curso;
        public string Email;
        public string Telefone;

        public Alunos(string nome, string curso, string email, string telefone)
        {
            Nome = nome;
            Curso = curso;
            Email = email;
            Telefone = telefone;
        }
    }
}
