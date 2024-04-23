using LaboratorioProgra1.Laboratorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.clasesHijas
{
    internal class VideojuegoAccion:VideoJuego
    {
        private string personaje;
        private string arma;
        public bool armaEmpuñada;
        public string Personaje
        { get { return personaje; } set { personaje = value; } }
        public string Arma {  get { return arma; } set {  arma = value; } }

        public VideojuegoAccion(string p, string a)
        {
            personaje = p;
            arma = a;
        }

        public void EmpuniarArma()
        { 

             armaEmpuñada= true;
        }

        public string UtilizarArma()
        {
            if (armaEmpuñada == true)
            {
                return "El arma se ha utilizado";
            }
            else
            {
                return "Primero debes empuñar el arma";
            }
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Personaje: " + personaje);
            Console.WriteLine("Arma: " + arma);
        }
        

    }
}
