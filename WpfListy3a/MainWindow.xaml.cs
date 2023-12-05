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
        public List<Produkt> Produkty { get; set; }
        public Produkt ZaznaczonyProdukt { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            przygotujDane();

            Teksty = new List<String>();
            Teksty.Add("pierwszy zapis");
            Teksty.Add("drugi zapis");
            Teksty.Add("cokolwiek");
            Teksty.Add("cokolwiek");
            Teksty.Add("cokolwiek");
            Teksty.Add("cokolwiek");
            Teksty.Add("cokolwiek");
            Teksty.Add("cokolwiek");
            Teksty.Add("cokolwiek");
            lista3.ItemsSource = Teksty;
            DataContext = this;//musi być do bindowania elementów o dostępie public
            dataGridProdukty.ItemsSource = Produkty;
        }
        private void przygotujDane()
        {
            Produkty = new List<Produkt>();
            Produkty.Add(new Produkt("długopis", 10, "niebieski zmazywalny"));
            Produkty.Add(new Produkt("długopis", 10, "czarny niezmazywalny"));
            Produkty.Add(new Produkt("ołówek", 2, "HB"));
            Produkty.Add(new Produkt("ołówek", 2, "B"));
            Produkty.Add(new Produkt("ołówek", 2, "2B"));
            Produkty.Add(new Produkt("ołówek", 2, "3B"));
            Produkty.Add(new Produkt("ołówek", 2, "H"));
            Produkty.Add(new Produkt("ołówek", 2, "2H"));
            Produkty.Add(new Produkt("ołówek", 3, "3H",false));
            Produkty.Add(new Produkt("zeszyt", 2, "w linie",true, "Papiernicze"));
            Produkty.Add(new Produkt("zeszyt", 2, "w kratkę",true, "Papiernicze"));
            Produkty.Add(new Produkt("farby", 20, "kolorowe",true, "Artystyczne"));
            nazwaKategorii.ItemsSource = new List<String>() { "Papiernicze", "Przybory", "Artystyczne" };
        }

    }
}
