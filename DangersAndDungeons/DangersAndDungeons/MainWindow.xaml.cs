using DangersAndDungeons.Model;
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

namespace DangersAndDungeons
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Player player;
        private Dungeon dungeon;
        private int commands;

        public MainWindow()
        {
            player = new Player();
            dungeon = new Dungeon();
            commands = 0;
            InitializeComponent();
            player.updateDisplay(dungeon.getMap()[0]);
            box.Text = player.getDisplay();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(N))
                player.move('N', dungeon.getMap()[0]);
            else if (sender.Equals(S))
                player.move('S', dungeon.getMap()[0]);
            else if (sender.Equals(W))
                player.move('W', dungeon.getMap()[0]);
            else if (sender.Equals(E))
                player.move('E', dungeon.getMap()[0]);

            box.Text = player.getDisplay();
            commands++;
            box.Text = box.Text + "\nCommands: " + commands;
        }
    }
}
