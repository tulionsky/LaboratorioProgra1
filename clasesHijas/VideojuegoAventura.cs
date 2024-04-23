using LaboratorioProgra1.EjemploEncapsulamiento;
using LaboratorioProgra1.Laboratorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.clasesHijas
{
    internal class VideojuegoAventura:VideoJuego
    {
        private int nivel;
        private bool partidaguardada;

        public int Nivel
        { get { return nivel; }
            set
            {
                // Validación para asegurarse de que la edad es válida
                if (value > 0 && value<=20)
                {
                    Nivel = value;
                }
                else
                {
                    comprobarnivel(value);
                    
                }
            }
        }

        public string comprobarnivel(int niv)
        {
            if (niv < 0)
            {
                return "Lo siento, no puedes ser nivel 0 o inferior.";
            }
            else
            {
                return "Lo siento, no se puede tener un nivel mayor a 20.";
            }
        }
        public string PartidaGuardada { get; set; }

        public VideojuegoAventura(int n, bool pg)
        {
            nivel = n;
            partidaguardada = pg;
        }

        public string GuardarPartida()
        {
            partidaguardada = true;
            return "Su Partida se ha guardado correctamente!";
        }

        public string MostrarDialogo()
        {
            if (nivel < 10)
            {
                return "Lo siento, Tu nivel es muy bajo para que pueda hablarte :(";
            }
            return "Felicidades!! Haz alcanzado el nivel" +nivel+" Te regalo una replica 1.1 del Halcon Milenario de Star Wars";
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Nivel: " + nivel);
            Console.WriteLine("Partida Guardada " + partidaguardada);
        }

    }
}
