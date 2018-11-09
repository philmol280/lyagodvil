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

namespace godgame
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<string> whichlist = new List<string>();
        List<string> wholist = new List<string>();
        List<string> whoselist = new List<string>();
        List<string> inwitchlist = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
            which.ItemsSource = whichlist;
            who.ItemsSource = wholist;
            whose.ItemsSource = whoselist;
            inwitch.ItemsSource = inwitchlist;
        }

        private void addwhich_Click(object sender, RoutedEventArgs e)
        {
            whichlist.Add(saveline.Text);
            saveline.Text = "";
            which.Items.Refresh();
        }

        private void addwho_Click(object sender, RoutedEventArgs e)
        {
            wholist.Add(saveline.Text);
            saveline.Text = "";
            who.Items.Refresh();
        }

        private void addinwitch_Click(object sender, RoutedEventArgs e)
        {
            inwitchlist.Add(saveline.Text);
            saveline.Text = "";
            inwitch.Items.Refresh();
        }

        private void addwhose_Click(object sender, RoutedEventArgs e)
        {
            whoselist.Add(saveline.Text);
            saveline.Text = "";
            whose.Items.Refresh();
        }
    }
}