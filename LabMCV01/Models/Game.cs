using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabMCV01.Models
{
    public class Game
    {
        public string Nombre { get; set; }
        public int ID { get; set; }
        public  float Puntuacion { get; set; }
        public string Categoria { get; set; }
        public string Estudio { get; set; }
        public int Año { get; set; }
    }
}