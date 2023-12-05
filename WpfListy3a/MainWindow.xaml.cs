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

namespace WpfListy3a
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<String> Teksty { get; set; } 
        public MainWindow()
        {
            InitializeComponent();
            Teksty = new List<String>();
            Teksty.Add("pierwszy zapis");
            Teksty.Add("drugi zapis");
            Teksty.Add("cokolwiek");
            lista3.ItemsSource = Teksty;
            DataContext = this;

        }

    }
}
