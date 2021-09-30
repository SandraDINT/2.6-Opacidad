using System;
using System.Collections.Generic;
using System.Linq;

using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace Opacidad
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            /*imagen1Image.Opacity = 0.5;
            imagen2Image.Opacity = 0.5;
            imagen3Image.Opacity = 0.5;*/
        }

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            Image imagen = (Image)sender;
            imagen.Opacity = 1;
        }
        private void Image_MouseLeave(object sender, MouseEventArgs e)
        {
            Image imagen = (Image)sender;
            imagen.Opacity = 0.5;
        }
    }
}
