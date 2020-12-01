using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PruebaWPF
{
    /// <summary>
    /// Lógica de interacción para Window2.xaml
    /// </summary>
    public partial class HallOfFame : Window
    {
        public static List<Jugador> ListadoJugadores { get; set; }  //CREO UNA LISTA DE JUGADORES CON SUS GETTERS Y SETTERS
        public HallOfFame()
        {
            
            
            InitializeComponent();
            if (ListadoJugadores == null)   //SI EL LISTADO ESTA VACIO ENTONCES AÑADO JUGADORES
            {
                ListadoJugadores = new List<Jugador>();
                ListadoJugadores.Add(new Jugador() { Nombre = "PiewDiePie", Posicion = 1, Tiempo = 150 });
                ListadoJugadores.Add(new Jugador() { Nombre = "Willyrex", Posicion = 2, Tiempo = 200 });
                ListadoJugadores.Add(new Jugador() { Nombre = "Adrián", Posicion = 3, Tiempo = 300 });
                ListadoJugadores.Add(new Jugador() { Nombre = "Alfonso", Posicion = 4, Tiempo = 350 });
                ListadoJugadores.Add(new Jugador() { Nombre = "Rubén", Posicion = 5, Tiempo = 400 });
                ListadoJugadores.Add(new Jugador() { Nombre = "Luis", Posicion = 6, Tiempo = 450 });
                ListadoJugadores.Add(new Jugador() { Nombre = "Pedro", Posicion = 7, Tiempo = 500 });
                ListadoJugadores.Add(new Jugador() { Nombre = "Sarita", Posicion = 8, Tiempo = 550 });
                ListadoJugadores.Add(new Jugador() { Nombre = "Pablo", Posicion = 9, Tiempo = 600 });
                ListadoJugadores.Add(new Jugador() { Nombre = "RocioJurado", Posicion = 10, Tiempo = 650 });
            }
            this.DataContext = this;
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            ListadoJugadores.Clear();
            ListadoJugadores.Add(new Jugador() { Nombre = "PiewDiePie", Posicion = 1, Tiempo = 150 });
            ListadoJugadores.Add(new Jugador() { Nombre = "Willyrex", Posicion = 2, Tiempo = 200 });
            ListadoJugadores.Add(new Jugador() { Nombre = "Adrián", Posicion = 3, Tiempo = 300 });
            ListadoJugadores.Add(new Jugador() { Nombre = "Alfonso", Posicion = 4, Tiempo = 350 });
            ListadoJugadores.Add(new Jugador() { Nombre = "Rubén", Posicion = 5, Tiempo = 400 });
            ListadoJugadores.Add(new Jugador() { Nombre = "Luis", Posicion = 6, Tiempo = 450 });
            ListadoJugadores.Add(new Jugador() { Nombre = "Pedro", Posicion = 7, Tiempo = 500 });
            ListadoJugadores.Add(new Jugador() { Nombre = "Sarita", Posicion = 8, Tiempo = 550 });
            ListadoJugadores.Add(new Jugador() { Nombre = "Pablo", Posicion = 9, Tiempo = 600 });
            ListadoJugadores.Add(new Jugador() { Nombre = "RocioJurado", Posicion = 10, Tiempo = 650 });

            dgJugadores.Items.Refresh();

        }
    }


}
