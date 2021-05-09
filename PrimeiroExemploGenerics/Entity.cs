using System;

namespace PrimeiroExemploGenerics
{
    public abstract class Entity<T> where T:struct
    {
        public T Id { get; set; }
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public DateTime DataRegisto { get; set; }
    }
}
