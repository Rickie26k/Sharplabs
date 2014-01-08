﻿using System;
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

namespace Sharplabs
{
    /// <summary>
    /// Interaction logic for GameSetup.xaml
    /// </summary>
    public partial class GameSetup : Window
    {
        public GameSetup()
        {
            InitializeComponent();
        }

        void OnLoad(object sender, RoutedEventArgs e)
        {
            Splash startsplash = new Splash();
            startsplash.Owner = this;
            startsplash.Show();
        }
    }

}
