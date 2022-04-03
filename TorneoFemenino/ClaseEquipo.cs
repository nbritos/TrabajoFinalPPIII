using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaTorneo
{
    public class ClaseEquipo
    {
        public string nombreEquipo{ get; set; }
        public List<ClaseJugador> miembrosDelEquipo{ get; set; }  = new List<ClaseJugador>();
            
        
    }
}
