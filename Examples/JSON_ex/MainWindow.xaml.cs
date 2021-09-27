﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace JSON_ex
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            using (var client = new HttpClient())
            {
                string jsonData = client.GetStringAsync("https://rickandmortyapi.com/api/character").Result;

                RickandMortyAPI api = JsonConvert.DeserializeObject<RickandMortyAPI>(jsonData);

                foreach (var item in api.results)
                {
                    cboCharacter.Items.Add(item);
                }
            }
        }

        private void cboCharacter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Character selected = (Character)cboCharacter.SelectedItem;

            imgCharacter.Source = new BitmapImage(new Uri(selected.image));
            lblname.Content = selected.name;
        }
    }
}