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

namespace MoveAnIcon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Map board = new Map();
        public MainWindow()
        {
            InitializeComponent();
            box.Text = board.toString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(W))
                board.move(3);
            else if (sender.Equals(N))
                board.move(0);
            else if (sender.Equals(E))
                board.move(1);
            else if (sender.Equals(S))
                board.move(2);

            box.Text = board.toString();
        }
    }
}
