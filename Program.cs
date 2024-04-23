using LaboratorioProgra1.EjemploPolimorfismo;
using LaboratorioProgra1.EjemploPolimorfismo.Heredados;
using LaboratorioProgra1.Laboratorio;
using LaboratorioProgra1.clasesHijas;

static void EjemploPolimorfismo()
{
    Animal[] animales = new Animal[3];
    animales[0] = new Tortuga();
    animales[1] = new Gato();
    animales[2] = new Perro();
    foreach (Animal animal in animales)
    {
        animal.HacerSonido();
    }
}   

static void Laboratorio()
{
    VideoJuego videoJuego = new VideoJuego();
    videoJuego.Titulo = "The Legend of Zelda: Breath of the Wild";
    videoJuego.Desarrolladora = "Nintendo";
    videoJuego.Calificacion = 50;
    videoJuego.AnioLanzamiento = 2017;
    videoJuego.MostrarInformacion();
}

static void JuegoAccion()
{
    VideojuegoAccion videojuegoAccion = new VideojuegoAccion("Travis","Beam Katana");
    videojuegoAccion.Titulo = "No More Heroes";
    videojuegoAccion.Desarrolladora = "GRASSHOPPER MANUFACTURE";
    videojuegoAccion.Calificacion = 70;
    videojuegoAccion.AnioLanzamiento = 2019;
    videojuegoAccion.MostrarInformacion();
    
}

static void JuegoAventura()
{
    VideojuegoAventura videojuegoAventura = new VideojuegoAventura(10, false);
    videojuegoAventura.Titulo = "The Legend Of Zelda Tears of The Kingdom";
    videojuegoAventura.Desarrolladora = "NIntendo";
    videojuegoAventura.Calificacion = 95;
    videojuegoAventura.AnioLanzamiento = 2023;
    videojuegoAventura.MostrarInformacion();

}

static void JuegoCarreras()
{
    VideojuegoCarreras videojuegoCarreras = new VideojuegoCarreras("Halcon Milenario", "Rainbow Road");
    videojuegoCarreras.Titulo = "Mario Kart";
    videojuegoCarreras.Desarrolladora = "Nintendo";
    videojuegoCarreras.Calificacion = 80;
    videojuegoCarreras.AnioLanzamiento = 2014;
    videojuegoCarreras.MostrarInformacion();
}

//Laboratorio();
//VideoJuego.listaDeJuegos();
JuegoAccion();
JuegoAventura();
JuegoCarreras();
