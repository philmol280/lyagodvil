using Microsoft.Win32;
using System;
using System.IO;
using System.Collections.Generic;
using System.Windows;

namespace godgame
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rnd = new Random();
        List<string> whichlist = new List<string>();
        List<string> wholist = new List<string>();
        List<string> whoselist = new List<string>();
        List<string> inwitchlist = new List<string>();
        System.Windows.Threading.DispatcherTimer dispatcherTimer;
        public MainWindow()
        {
            InitializeComponent();
            which.ItemsSource = whichlist;
            who.ItemsSource = wholist;
            whose.ItemsSource = whoselist;
            inwitch.ItemsSource = inwitchlist;

            //              А ВОТ И ТАЙМЕР ПОДЪЕХАЛ)
            dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(Clock);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();

        }

        private void Clock(object sender, EventArgs e)
        {
            
        }

        private void Addwhich_Click(object sender, RoutedEventArgs e)
        {
            if (saveline.Text=="")
            {
                MessageBox.Show("Вы не ввели данные!", "Ошибка");
            }
            else
            {
                whichlist.Add(saveline.Text);
                saveline.Text = "";
                which.Items.Refresh();
            }
        }

        private void Addwho_Click(object sender, RoutedEventArgs e)
        {
            if (saveline.Text == "")
            {
                MessageBox.Show("Вы не ввели данные!", "Ошибка");
            }
            else
            {
                wholist.Add(saveline.Text);
                saveline.Text = "";
                who.Items.Refresh();
            }
        }

        private void Addinwitch_Click(object sender, RoutedEventArgs e)
        {
            if (saveline.Text == "")
            {
                MessageBox.Show("Вы не ввели данные!", "Ошибка");
            }
            else
            {
                inwitchlist.Add(saveline.Text);
                saveline.Text = "";
                inwitch.Items.Refresh();
            }
        }

        private void Addwhose_Click(object sender, RoutedEventArgs e)
        {
            if (saveline.Text == "")
            {
                MessageBox.Show("Вы не ввели данные!", "Ошибка");
            }
            else
            {
                whoselist.Add(saveline.Text);
                saveline.Text = "";
                whose.Items.Refresh();
            }
        }

        private void Debug_Click(object sender, RoutedEventArgs e)
        {
            if ((whichlist.Count != 0) && (wholist.Count != 0) && (whoselist.Count != 0) && (inwitchlist.Count != 0))
            {
                int z = rnd.Next(0, whichlist.Count);
                int x = rnd.Next(0, wholist.Count);
                int c = rnd.Next(0, whoselist.Count);
                int v = rnd.Next(0, inwitchlist.Count);
                debugtext.Text = whichlist[z] + " " + wholist[x] + " " + inwitchlist[v] + " " + whoselist[c];
            }
            else
            {
                MessageBox.Show("Недостаточно данных для персонажа, пожалуйста внесите данные на второй вкладке!", "Ошибка");
            }
        }

        private void Read2_Click(object sender, RoutedEventArgs e)
        {
            if (File.Exists("list1.god"))
            {
                //which.ItemsSource=File.ReadAllLines("list1.god");
                whichlist.AddRange(File.ReadAllLines("list1.god"));
                which.Items.Refresh();
            }
            if (File.Exists("list2.god"))
            {
                //who.ItemsSource = File.ReadAllLines("list2.god");
                wholist.AddRange(File.ReadLines("list2.god"));
                who.Items.Refresh();
            }
            if (File.Exists("list3.god"))
            {
                //inwitch.ItemsSource = File.ReadAllLines("list3.god");
                inwitchlist.AddRange(File.ReadLines("list3.god"));
                inwitch.Items.Refresh();
            }
            if (File.Exists("list4.god"))
            {
                //whose.ItemsSource = File.ReadAllLines("list4.god");
                whoselist.AddRange(File.ReadLines("list4.god"));
                whose.Items.Refresh();
            }
            else
            {
                MessageBox.Show("Файлы отсутсвуют", "Ошибка");
            }
        }

        private void Write2_Click(object sender, RoutedEventArgs e)
        {
                StreamWriter list1 = new StreamWriter("list1.god");
                foreach (var item in which.Items)
                    list1.WriteLine(item.ToString());
                list1.Close();

                StreamWriter list2 = new StreamWriter("list2.god");
                foreach (var item in who.Items)
                    list2.WriteLine(item.ToString());
                list2.Close();

                StreamWriter list3 = new StreamWriter("list3.god");
                foreach (var item in inwitch.Items)
                    list3.WriteLine(item.ToString());
                list3.Close();

                StreamWriter list4 = new StreamWriter("list4.god");
                foreach (var item in whose.Items)
                    list4.WriteLine(item.ToString());
                list4.Close();
            MessageBox.Show("Успешно сохранено", "ОК");
        }
    }
}