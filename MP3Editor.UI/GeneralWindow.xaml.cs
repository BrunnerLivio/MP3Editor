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
using MahApps.Metro.Controls;
using MP3Editor.UI.Models;

namespace MP3Editor.UI
{
    /// <summary>
    /// Interaktionslogik für GeneralWindow.xaml
    /// </summary>
    public partial class GeneralWindow : MetroWindow
    {
        public GeneralWindow()
        {
            InitializeComponent();
           
        }

        private void GeneralWindow_OnClosed(object sender, EventArgs e)
        {
            GeneralWindowViewModel window = (GeneralWindowViewModel) (sender as MetroWindow).DataContext;
            window.File.Save();
            window.File.Dispose();
        }
    }
}
