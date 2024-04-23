using LaboratorioProgra1.EjemploEncapsulamiento;
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
        private string vehiculo;
        private string pista;

        public string Vehiculo
        { get { return vehiculo; } set { vehiculo = value; } }
        public string Pista { get { return pista; } set { pista = value; } }

        public VideojuegoCarreras(string v, string ps)
        {
            vehiculo = v;
            pista = ps;
        }

        public string  Acelerar()
        {
            return "Tu vehiculo esta acelerando";
        }

        public string MostrarVehiculo()
        {
            return "Vehiculo: " + vehiculo;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine(MostrarVehiculo());
            Console.WriteLine("Pista: " + pista);
        }

    }
}
