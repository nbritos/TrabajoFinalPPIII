using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaTorneo
{
    public class ClaseIngresoPartidos
    {
        /// <summary>
        /// representa un equipo en el partido
        /// </summary>
        public ClaseEquipo equipoCompetidor { get; set; }

        /// <summary>
        /// representa los goles de ESTE equipo
        /// </summary>
        public int marcador { get; set; }

        /// <summary>
        /// representa el partido del que este equipo salió como ganador
        /// </summary>
        public ClasePartido partidoPadre { get; set; }
    }
}
