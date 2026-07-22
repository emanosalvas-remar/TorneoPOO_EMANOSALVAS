using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorneoPOO_EMANOSALVAS.Generales;

namespace TorneoPOO_EMANOSALVAS.Models
{
    public class Partido
    {
        private int id; //IDENTIFICADOR UNICO DEL PARTIDO OJOOOOOOOOOOOOO
        private Equipo local;
        private Equipo visitante;
        private DateTime fecha;
        private string lugar;

        public Equipo Local { get => local; set => local = value; }
        public Equipo Visitante { get => visitante; set => visitante = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Lugar { get => lugar; set => lugar = value; }

        public int Id { get => id; set => id = value; }

        public Partido(Equipo local, Equipo visitante, DateTime fecha, string lugar)
        {
            this.Local = local;
            this.Visitante = visitante;
            this.Fecha = fecha;
            this.Lugar = lugar;
            if (Database.Partidos.Count == 0)
            {
                this.id = 1;
            }
            else
            {
                this.id = Database.Partidos.Max(x => x.id) + 1;
            }
        }



        public void MostrarResumen()
        {
            Console.WriteLine($"Hay un partido programado entre el local {this.Local.Nombre} y el visitante {this.Visitante.Nombre} en el lugar {this.Lugar}");
        }
        public void Imprimir()
        {
            Console.WriteLine($"Id del partido: {this.Id}");
            Console.WriteLine($"Local: {this.Local.Nombre}");
            Console.WriteLine($"Visitante: {this.Visitante.Nombre}");
            Console.WriteLine($"Fecha: {this.Fecha.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Lugar: {this.Lugar}");
        }

        //AÑADIR IMPRIMIR PARTIDO

    }
}
