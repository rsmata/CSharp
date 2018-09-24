﻿using System;

namespace A11Arrays
{
    class Aula : IComparable
    {
        private string titulo;
        private int tempo;

        public Aula(string titulo, int tempo)
        {
            this.titulo = titulo;
            this.tempo = tempo;
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public int Tempo { get => tempo; set => tempo = value; }

        public int CompareTo(object obj)
        {
            return this.titulo.CompareTo(((Aula)obj).titulo);
        }

        public override string ToString()
        {
            return $"[titulo: {titulo}, tempo: {tempo} minutos ]";
        }
    }
}