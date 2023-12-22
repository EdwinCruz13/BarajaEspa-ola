using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarajaEspañola
{
    public class Naipe
    {
        /// <summary>
        /// Atributos para definir el naipe del 1 al 12
        /// </summary>
        public int Numero { get; set; }
        /// <summary>
        /// tipo de palo: oros, copas, espadas, basto
        /// </summary>
        public String Palo { get; set; }
        /// <summary>
        /// guardar la figura 10 para sota, 11 para caballo, 12 para rey
        /// </summary>
        public String LetraNumero { get; set; }
    }
}
