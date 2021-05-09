using System;

namespace PrimeiroExemploGenerics
{
    public class Utilizador:Entity<Guid>
    {
        public string UserName { get; set; }
    }
}
