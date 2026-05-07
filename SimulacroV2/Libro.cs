using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacroV2
{
    internal class Libro
    {
        private string titulo { get; set; }
        private string autor { get; set; }
        private int anyoPublicacion { get; set; }
        private bool disponible { get; set; } = true;
        public Libro(string titulo, string autor, int anyoPublicacion, bool disponible)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.anyoPublicacion = anyoPublicacion;
            this.disponible = disponible;
        }
        public override string ToString()
        {
            return $"{titulo} - {autor} ({anyoPublicacion})";
        }
    }
}
