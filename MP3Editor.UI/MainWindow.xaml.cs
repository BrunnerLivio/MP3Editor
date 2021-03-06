﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using Microsoft.Win32;
using MP3Editor.UI.Models;
using DataGrid = System.Windows.Controls.DataGrid;
using MenuItem = System.Windows.Controls.MenuItem;

namespace MP3Editor.UI
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }

        private void LoadList_MenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            MainWindowViewModel mainWindowViewModel = (MainWindowViewModel)(sender as MenuItem).DataContext;
            System.Windows.Forms.OpenFileDialog dialog = new System.Windows.Forms.OpenFileDialog();
            dialog.Filter = "M3U Files | *.m3u";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    mainWindowViewModel.LoadList(dialog.FileName);
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Die Datei konnte nicht geladen werden");
                }
            }
        }

        private void DataGrid_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MainWindowViewModel mainWindowViewModel = (MainWindowViewModel)(sender as DataGrid).DataContext;
            GeneralWindow window = new GeneralWindow();
            window.DataContext = new GeneralWindowViewModel(mainWindowViewModel.SelectedFile);
            window.Show();
        }

        private void Save_MenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            MainWindowViewModel mainWindowViewModel = (MainWindowViewModel)(sender as MenuItem).DataContext;
            System.Windows.Forms.SaveFileDialog dialog = new System.Windows.Forms.SaveFileDialog();
            dialog.DefaultExt = ".m3u";
            string path;
            if (mainWindowViewModel.GetCurrentPath() == string.Empty)
            {
                dialog.ShowDialog();
                path = dialog.FileName;
            }
            else
            {
                path = mainWindowViewModel.GetCurrentPath();
            }
            try
            {
                mainWindowViewModel.SaveList(path);
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Konnte Playlist nicht speichern");
            }
        }

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            MainWindowViewModel mainWindowViewModel = (MainWindowViewModel)(sender as MetroWindow).DataContext;
            try
            {
                mainWindowViewModel.LoadList(mainWindowViewModel.GetCurrentPath());
            }
            catch (Exception)
            {

            }
        }

        private void Add_MenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            MainWindowViewModel mainWindowViewModel = (MainWindowViewModel)(sender as MenuItem).DataContext;
            System.Windows.Forms.OpenFileDialog dialog = new System.Windows.Forms.OpenFileDialog();
            dialog.Filter = "MP3 Files | *.mp3";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                mainWindowViewModel.AddfileToPlaylist(dialog.FileName);
            }
        }
    }
}
