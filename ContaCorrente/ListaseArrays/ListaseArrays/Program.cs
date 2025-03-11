using System.Collections.Generic;

namespace ListaseArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];
            double[] notas = new double[8];
            string[] arrayFrutas = ["banana", "maçã", "pera"];

            //Console.WriteLine(arrayFrutas[0]);

            //List<double> listnotes = new List<double>();
            //List<string> fruitList = new List<string>();
            //fruitList.Add("Banana");
            //fruitList.Add("Maça");
            //fruitList.Add("Pera");

            //foreach (string fruta in fruitList)
            //{
            //    Console.WriteLine(fruta);
            //}

            //fruitList.ForEach(fruta => Console.WriteLine(fruta));

            Aluno aluno1 = new Aluno("João", 123, "Transforme-se", "joão@gmail.com", "11985741236");
            Aluno aluno2 = new Aluno("Lilian", 124, "Transforme-se", "lilian@gmail.com", "11985741236");
            Aluno aluno3 = new Aluno("Carolina", 125, "Transforme-se", "carolina@gmail.com", "11921459632");

            List<Aluno> ListaAlunos = new List<Aluno>();
            ListaAlunos.Add(aluno1);
            ListaAlunos.Add(aluno2);
            ListaAlunos.Add(aluno3);

            foreach (Aluno aluno in ListaAlunos)
            {
                Console.WriteLine($"{aluno.Nome}");
                Console.WriteLine($"{aluno.Matricula}");
                Console.WriteLine($"{aluno.Telefone}");
                Console.WriteLine();
            }
        }
    }
}
