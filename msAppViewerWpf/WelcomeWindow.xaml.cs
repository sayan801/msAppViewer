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

namespace msAppViewerWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class WelcomeWindow : Window
    {
        public WelcomeWindow()
        {
            InitializeComponent();
        }

       
        private void skypeBtn_Click(object sender, RoutedEventArgs e)
        {
            SkypeIntegration.MainWindow skypeWindow = new SkypeIntegration.MainWindow();
            skypeWindow.ShowDialog();
        }

       
        private void wordBtn_Click(object sender, RoutedEventArgs e)
        {
            CSVSTOViewWordInWPF.MainWindow wordWindow = new CSVSTOViewWordInWPF.MainWindow();
            wordWindow.ShowDialog();
        }
    }
}
