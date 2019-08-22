using System;
using System.Collections.Generic;
using System.Text;

namespace Personajes.Modelos
{
    public class Atributo
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public int fuerza { get; set; }
        public int destreza { get; set; }
        public int vitalidad { get; set; }
        public int puntosdegolpe { get; set; }

        public List<Habilidad> Habilidades { get; set; }
        public Atributo() {
            Habilidades = new List<Habilidad>();
        }
    }
}
