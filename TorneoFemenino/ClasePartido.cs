using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaTorneo
{
    public class ClasePartido
    {
        public ClaseEquipo equipoGanador { get; set; }
        public int rondaPartido { get; set; }
        public List<ClaseIngresoPartidos> listaIngresos { get; set; } = new List<ClaseIngresoPartidos>();

    }
}
