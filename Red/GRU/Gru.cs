using GRU.Red.GRU.LogisticRegressionNeurons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRU.Red
{
    class Gru
    {
        

        public Gru()
        {
           
        }

        public List<double> Sigmoide(Capa unaCapa)
        {
            List<double> salidaSigmoide = new List<double>();

            List<double> salidasDeCadaNeuronaEnCapa = unaCapa.GetSalida();
           
            for (int i =0; i< unaCapa.getTamanoSalida() ;++i)
            {
                salidaSigmoide.Add(1 / (1 + Math.Exp(salidasDeCadaNeuronaEnCapa[i])));          
            }

            return salidaSigmoide;
        }
        
    }
}
