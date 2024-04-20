using LaboratorioProgra1.Laboratorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.clasesHijas
{
    internal class VideojuegoCarreras:VideoJuego
    {
        private string personaje;
        private string arma;

        public string Personaje
        { get { return personaje; } set { personaje = value; } }
        public string Arma { get { return arma; } set { arma = value; } }

        public VideojuegoCarreras(string p, string a)
        {
            personaje = p;
            arma = a;
        }

        public bool EmpuniarArma()
        {
            return true;
        }

        public string UtilizarArma()
        {
            if (EmpuniarArma() == true)
            {
                return "El arma se ha utilizado";
            }
            else
            {
                return "Primero debes empuniar el arma";
            }
        }

        public override void MenuPrincipal()
        {
            Console.WriteLine("Bienvenido al menu del juego de Accion :)");
        }
    }
}
