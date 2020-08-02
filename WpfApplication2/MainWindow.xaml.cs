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

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<items> it = new List<items>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            it.Add(new items { id = 1, date = new DateTime(1980, 1, 1), rain = 25 });
            it.Add(new items { id = 2, date = new DateTime(1980, 2, 1), rain = 5 });
            it.Add(new items { id = 3, date = new DateTime(1980, 3, 1), rain = 15 });
            it.Add(new items { id = 4, date = new DateTime(1980, 4, 1), rain = 10 });
            dg.ItemsSource = it;
        }

        class items
        {
            public int id { get; set; }
            public DateTime date { get; set; }
            public double rain { get; set; }
        }
    }
}
