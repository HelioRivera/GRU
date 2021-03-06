using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRU.Red.GRU.LogisticRegressionNeurons
{
    class Capa
    {
        List<Neurona> neuronas; //Las neuronas que tendrá la capa
        List<double> salidas; //Almacena las salidas de cada neurona
        int tamanoDeSalida;

        /*totalNeuronas : corresponde a la cantidad de neuronas en la capa actual.
         totalEntradas : corresponde a la cantidad de entradas en la capa actual*/
        public Capa(Random azar, int totalNeuronas, int totalEntradas)
        {
            Console.WriteLine("una capa :");
            neuronas = new List<Neurona>();
            salidas = new List<double>();
            //Genera las neuronas e inicializa sus salidas
            for (int cont = 0; cont < totalNeuronas; cont++)
            {
                neuronas.Add(new Neurona(azar, totalEntradas));
                salidas.Add(0);
            }
            tamanoDeSalida = salidas.Count;
        }

        public void CalculaCapa(List<double> entradas)
        {
            for (int cont = 0; cont < neuronas.Count; cont++)
            {
                salidas[cont] = neuronas[cont].CalculaSumaPonderada(entradas);

                Console.WriteLine("{0:F4};", salidas[cont]);
            }
        }

        public List<double> GetSalida()
        {
            return salidas;
        }

        public List<Neurona> GetNeuronas()
        {
            return neuronas;
        }

        public int getTamanoSalida()
        {
            return tamanoDeSalida;
        }
    }
}
