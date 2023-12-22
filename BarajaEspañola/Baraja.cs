using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BarajaEspañola
{
    public class Baraja
    {
        /// <summary>
        /// Atributo lista de naipes
        /// </summary>
        public List<Naipe> naipes;

        /// <summary>
        /// para definir tipo de carta
        /// </summary>
        private string[] _palos = { "oros", "copas", "espada", "bastos" };

        /// <summary>
        /// Inicializar la baraja ordenando
        /// </summary>
        public Baraja()
        {
            //initializar los naipes en la baraja
            InicializarBaraja();

        }

        //funcion order naipes
        /// <summary>
        /// Inicializar la baraja de naipes
        /// se definirá cada naipes, ademas servira como metodo de ordenamiento
        /// </summary>
        private void InicializarBaraja()
        {
            ///recorrer los tipos de palos
            naipes = new List<Naipe>();
            foreach (var item in _palos)
            {
                //recorrer el numero de
                for (var i = 1; i < 13; i++)
                {
                    naipes.Add(new Naipe { Numero = i, Palo = item, LetraNumero = toStringFromNumber(i) });
                }
            }
        }

        /// <summary>
        /// ordenar los naipes
        /// </summary>
        public void Ordenar()
        {
            InicializarBaraja();
        }

        /// <summary>
        /// metodo que sirve para imprimir
        /// </summary>
        public void Imprimir()
        {
            foreach (Naipe naipe in naipes)
            {
                Console.WriteLine($"{naipe.Numero} - Naipe {naipe.LetraNumero} de {naipe.Palo}:");
            }
        }

        public void Revuelva()
        {
            var random = new Random();
            var Unsorted = new List<Naipe>();

            //crear una lista, y desordenarla
            Unsorted = naipes.OrderBy(x => random.Next()).ToList();

            //asignar nuevos valores
            naipes = Unsorted;

        }

        /// <summary>
        /// definir el numero a letra
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        private string toStringFromNumber(int numero)
        {
            string letra = "";
            switch (numero)
            {
                case 0: letra = "cero"; break;
                case 1: letra = "uno"; break;
                case 2: letra = "dos"; break;
                case 3: letra = "tres"; break;
                case 4: letra = "cuatro"; break;
                case 5: letra = "cinco"; break;
                case 6: letra = "seis"; break;
                case 7: letra = "siete"; break;
                case 8: letra = "ocho"; break;
                case 9: letra = "nueve"; break;
                case 10: letra = "sota"; break;
                case 11: letra = "caballo"; break;
                case 12: letra = "rey"; break;
                default: letra = "cero"; break;
            }

            return letra;


        }

    }
}
