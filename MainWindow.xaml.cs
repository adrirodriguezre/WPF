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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PruebaWPF
{
	/// <summary>
	/// Lógica de interacción para MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Salir_Click(object sender, RoutedEventArgs e)	//ACCIÓN DEL ITEM "SALIR" QUE MUESTRA UN MENSAJE DE ADVERTENCIA
        {
			MessageBox.Show("Quieres salir?", "Salir" , MessageBoxButton.YesNo, MessageBoxImage.Warning);
        }

		private void Configurar_Click(object sender, RoutedEventArgs e)	//ACCIÓN DEL ITEM "CONFIGURAR" QUE ABRE UNA NUEVA VENTANA
        {
			Configurar win1 = new Configurar();
			win1.ShowDialog();
        }

		private void Exportar_Click(object sender, RoutedEventArgs e)	//ABRE UN DIÁLOGO DE SELECCIÓN DE FICHEROS
        {
			Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();

			openFileDialog.ShowDialog();
	
		}

		private void HOF_Click(object sender, RoutedEventArgs e)	//ABRE LA VENTANA DE PUNTUACIONES
        {
			HallOfFame win2 = new HallOfFame();
			win2.ShowDialog();
			
        }
		


	}

		
}
