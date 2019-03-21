

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases
{
    class MayorMenor
    {
        public class Genero
        {
            public string Name { get; set; }
            public int User { get; set; }
            public Genero(string name, int user)
            {
                Name = name;
                User = user;
            }

            public override string ToString()
            {
                return $"El nombre es: {Name}, el ID es: {User}";
            }
        }
        class Program
        {
            static void Main()
            {
                List<Genero> generos = new List<Genero>();

                Genero genero1 = new Genero("ROCK", 01);
                Genero genero2 = new Genero("POP", 02);
                
.
                generos.Add(genero1);
                generos.Add(genero2);

                foreach (Genero g in generos)
                {
                    Console.WriteLine(g.ToString());
                }
                

                
                
                Console.WriteLine("Presione enter para continuar");
                Console.ReadKey();
            }
        }
    }
}
