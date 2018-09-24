using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A11Arrays
{
    class Curso
    {
        private IList<Aula> aulas;

        public string Nome { get; set; }
        public string Instrutor { get; set; }
        public IList<Aula> Aulas { get => new ReadOnlyCollection<Aula>(aulas); }
        public int TempoTotal { get => aulas.Sum(aula => aula.Tempo); }

        public Curso(string nome, string instrutor)
        {
            Nome = nome;
            Instrutor = instrutor;
            aulas = new List<Aula>();
        }

        public void AddAula(Aula aula)
        {
            aulas.Add(aula);
        }

        public override string ToString()
        {
            return $"Curso: {Nome}, Tempo: {TempoTotal}, Aulas:{string.Join(",", Aulas)}";
        }
    }
}
