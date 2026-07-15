using TorneoPOO_EMANOSALVAS.Models;

Jugador objJugador1 = new Jugador("Piero Hincapié", 10, 4, "Defensa","Esmeraldas","0910655467",40000);

Jugador objJugador2 = new Jugador("Enner Valencia",32,700, "Delantero","Guayaquil","099999999999",54000);

Equipo objEquipo1= new Equipo("Emelec","Guayaquil","Azul");

objEquipo1.AgregarJugador(objJugador1);
objEquipo1.AgregarJugador(objJugador2);


objEquipo1.ListarPlantilla();

Jugador objJugador3 = new Jugador("Moiséc Caicedo", 23, 5, "Medio Campo", "Esmeraldas", "0910655467", 40000);


Jugador objJugador4 = new Jugador("Neiser Reascos", 45, 24, "Lateral", "Esmeraldas", "0910655467", 40000);

Equipo objEquipo2 = new Equipo("Barcelona","Guayaquil","Amarillo");

objEquipo2.AgregarJugador(objJugador3);
objEquipo2.AgregarJugador(objJugador4);



objEquipo2.ListarPlantilla();

Partido objPartido1= new Partido(objEquipo1, objEquipo2, DateTime.Now, "Guayaquil");
objPartido1.MostrarResumen();