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

namespace Segunta_Interface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
      /*      Grid miGrid = new Grid();

            this.Content = miGrid;//este contenido va a estar en el grid

            Button miButton = new Button();
            miButton.Width = 150;
            miButton.Height = 90;
            miButton.FontSize = 25;
            miButton. Background = Brushes.LightBlue;
            WrapPanel miwrap = new WrapPanel();

            TextBlock txt1 = new TextBlock();

            txt1.Text = "Click";
            miwrap.Children.Add(txt1);

            TextBlock txt2 = new TextBlock();
            txt2.Text = "Enviar";
            miwrap.Children.Add(txt2);

            TextBlock txt3 = new TextBlock();
            txt3.Text = "Dale!!";
            miwrap.Children.Add(txt3);

            miButton.Content = miwrap;

            miGrid.Children.Add(miButton);*/
        }


        //los elementos son de tió bubbling

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        //   MessageBox.Show("Le has dado clik");
            Console.WriteLine("Le has dado al boton");
            
        }

       /* private void Panel1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Le has dado al panel");
            Console.WriteLine("Le has dado al panel");
        }*/

        private void Panel1_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
           // MessageBox.Show("Le has dado al panel");
            Console.WriteLine("Le has dado al panel");
        }
    }
}
