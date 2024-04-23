using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.Laboratorio
{
    /// <summary>
    /// Esta Clase Padre tiene 4 errores lógicos
    /// debe de encontrarlos y corregirlos
    /// documente los errores encontrados y las correcciones realizadas
    /// </summary>
    internal class VideoJuego
    {
        private string titulo;
        private string desarrolladora;
        private double calificacion;
        private int anioLanzamiento;
        private bool jugando;

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Desarrolladora
        {
            get { return desarrolladora; }
            set { desarrolladora = value; }
        }

        public double Calificacion
        {
            get { return calificacion; }
            set
            {
                //  La calificación debe estar entre 0 y 10
                if (value > 0 || value < 10)
                {
                    calificacion = value;
                } else
                {
                    Console.WriteLine("La calificación debe estar entre 0 y 10");
                }
                    
            }
        }

        public int AnioLanzamiento
        {
            get { return anioLanzamiento; }
            set
            {
                if (value > 1951 || value < 2025)
                {
                    anioLanzamiento = value;
                }
                else
                {
                    Console.WriteLine("El anio de lanzamiento no es valido :)");
                }
            }
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine("\nTítulo: " + Titulo);
            Console.WriteLine("Desarrolladora: " + Desarrolladora);
            Console.WriteLine("Calificación: " + Calificacion);
            Console.WriteLine("Año de Lanzamiento: " + AnioLanzamiento);
          
        }

        public static void saludo()
        {
            Console.WriteLine("Hi Gamer:");
        }


        public void IniciarPartida()
        {
            jugando = true;
            Console.WriteLine("¡Partida iniciada!");
        }

        public void DetenerPartida()
        {
            if (jugando == true)
            {
                jugando = false;
                Console.WriteLine("Partida detenida.");
            }
           else
            {
                Console.WriteLine("No se puede detener la partida si ya esta detenida :)");
            }
        }

        public void TerminarJuego()
        {
            if (jugando == true)
            {
                
                Console.WriteLine("Juego terminado.");
            }
            else
            {
                Console.WriteLine("No hay partida en curso.");
            }
        }

        public static void listaDeJuegos()
        {
            Console.WriteLine("Un videojuego");
            Console.WriteLine("Fallout");
        }

        public virtual void MenuPrincipal()
        {
            Console.WriteLine("Muestra un menu principal generico");
        }
    }
}
