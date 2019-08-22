using Personajes.Data;
using Personajes.Modelos;
using System;
using System.Linq;

namespace Personaje.Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            //InsertarHabilidad(new Habilidad { id = 1, nombreHabilidad = "Patada voladora", poder = 10 });
            //InsertarHabilidad(new Habilidad { id = 2, nombreHabilidad = "Patada rastrera", poder = 5 });
            //InsertarHabilidad(new Habilidad { id = 3, nombreHabilidad = "Codazo", poder = 10 });
            //InsertarHabilidad(new Habilidad { id = 4, nombreHabilidad = "Escupitajo", poder = 1 });
            //InsertarHabilidad(new Habilidad { id = 5, nombreHabilidad = "Rodillazo", poder = 7 });
            //InsertarHabilidad(new Habilidad { id = 6, nombreHabilidad = "Zancadilla", poder = 5 });
            //InsertarHabilidad(new Habilidad { id = 7, nombreHabilidad = "Mirar Fijamente", poder = 0 });
            //InsertarHabilidad(new Habilidad { id = 8, nombreHabilidad = "Dormir", poder = 0 });
            //InsertarHabilidad(new Habilidad { id = 9, nombreHabilidad = "Cabezaso", poder = 6 });
            //InsertarHabilidad(new Habilidad { id = 10, nombreHabilidad = "Parpadeo Feroz", poder = 11 });


            InsertarPersonaje(new Atributo { Id = 2, nombre = "Pepe el toro reload", fuerza = 20, destreza = 5, vitalidad = 30, puntosdegolpe = 50 }, 6);

            ConsultarPersonaje(2);

        }

        private static void InsertarHabilidad(Habilidad habilidad)
        {
            using (var context  = new PersonajesContext())
            {
                context.Habilidades.Add(habilidad);
                context.SaveChanges();
            }
        }

        private static void InsertarPersonaje(Atributo atributo, int poderMax)
        {
            using (var context = new PersonajesContext())
            {
                atributo.Habilidades = context.Habilidades.Where(x => x.poder > poderMax).ToList();
                context.Atributos.Add(atributo);
                context.SaveChanges();
            }
        }

        private static void ConsultarPersonaje(int id)
        {
            using (var context = new PersonajesContext())
            {
                Atributo seleccionado = context.Atributos.Where(x => x.Id == id).FirstOrDefault();
                Console.WriteLine(seleccionado.nombre + " Habilidades : ");
                foreach(var habilidad in seleccionado.Habilidades)
                {
                    Console.WriteLine("-"+ habilidad.nombreHabilidad + " poder : " + habilidad.poder);
                }
                context.SaveChanges();
            }
        }
    }
}
