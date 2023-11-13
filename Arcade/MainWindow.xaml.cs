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
using System.Diagnostics;

namespace Arcade
{
  
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLaunchUnityGame_Click(object sender, RoutedEventArgs e)
        {
            string pathToUnityGame = @"C:\Users\jozsi\RiderProjects\TetrisDLL\Tetris.exe"; 
            Process.Start(pathToUnityGame);
        }
        
        private void PlayPong_Click(object sender, RoutedEventArgs e)
        {
            var pongWindow = new Pong.PongWindow(); 
            pongWindow.Show();
        }

        private void PlaySnake_Click(object sender, RoutedEventArgs e)
        {
            var snakeWindow = new Snake.SnakeWindow(); 
            snakeWindow.Show();
        }
    }
}