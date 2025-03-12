using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroAlunos
{
    internal class ValidarDados
    {


        public void ValidarEmail(string email)
        {
            Console.WriteLine("Digite o email do aluno: ");
            email = Console.ReadLine();
            if (!email.Contains('@'))
            {
                Console.WriteLine("Email inválido");
            }
        }
    }
}
