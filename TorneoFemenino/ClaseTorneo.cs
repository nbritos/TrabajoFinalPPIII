using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaTorneo
{
    public class ClaseTorneo
    {
        public string nombreTorneo { get; set; }
        public double valorInscripción { get; set; }
        public List<ClaseEquipo> listaEquipos { get; set; } = new List<ClaseEquipo>();
        public List<List<ClasePartido>> ronda { get; set; } = new List<List<ClasePartido>>();
        public ClasePremio premio { get; set; } = new ClasePremio();

    }
}
