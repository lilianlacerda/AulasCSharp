using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroAlunos
{
    internal class Alunos
    {
        public string nome;
        public string matricula;
        public string dataNascimento;
        public string curso;
        public string email;
        public string telefone;

        public Alunos(string nome, string matricula, string dataNascimento, string curso, string email, string telefone)
        {
            nome = nome;
            matricula = matricula;
            dataNascimento = dataNascimento;
            curso = curso;
            email = email;
            telefone = telefone;
        }
    }
}
