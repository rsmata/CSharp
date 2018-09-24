using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A11Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Curso csharpColecoes = new Curso("C# Collections", "Marcelo Oliveira");
            csharpColecoes.AddAula(new Aula("Trabalhando com Listas", 21));
            csharpColecoes.AddAula(new Aula("Criando uma Aula", 20));
            csharpColecoes.AddAula(new Aula("Modelando com Coleções", 19));

            //List<Aula> aulasCopiadas = new List<Aula>(csharpColecoes.Aulas);
            //aulasCopiadas.Sort();

            //Imprimir(aulasCopiadas);

            Console.WriteLine(csharpColecoes);
            Console.WriteLine(csharpColecoes.TempoTotal);

            Console.Read();

            //var aulaIntro = new Aula("Introdução às Coleções", 20);
            //var aulaModelando = new Aula("Modelando a Classe Aula", 18);
            //var aulaSets = new Aula("Trabalhando com Conjuntos", 16);

            //List<Aula> aulas = new List<Aula>();
            //aulas.Add(aulaIntro);
            //aulas.Add(aulaModelando);
            //aulas.Add(aulaSets);

            //aulas.Sort();//é preciso implementar a classe IComparable na classe Aula;
            //aulas.Sort((este, outro) => este.Titulo.CompareTo(outro.Titulo));

            //Imprimir(aulas);
        }

        private static void Imprimir(List<Aula> aulas)
        {
            Console.Clear();

            aulas.ForEach(aula =>Console.WriteLine(aula));
            
            Console.ReadKey();
        }
    }
}
