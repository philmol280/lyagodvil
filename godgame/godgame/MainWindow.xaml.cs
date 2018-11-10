using Microsoft.Win32;
using System;
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

        private void debug_Click(object sender, RoutedEventArgs e)
        {
            if ((whichlist.Count != 0) && (wholist.Count != 0) && (whoselist.Count != 0) && (inwitchlist.Count != 0))
            {
                int z = rnd.Next(0, whichlist.Count);
                int x = rnd.Next(0, wholist.Count);
                int c = rnd.Next(0, whoselist.Count);
                int v = rnd.Next(0, inwitchlist.Count);
                debugtext.Text = whichlist[z] + " " + wholist[x] + " " + whoselist[c] + " " + inwitchlist[v];
            }
            else MessageBox.Show("Недостаточно данных для персонажа, пожалуйста заполните листбоксы на второй вкладке", "Ошибка");
        }

        private void read2_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog myDialog = new OpenFileDialog();
            myDialog.Filter = "Файлы игры(*.GOD)|*.GOD" + "|Все файлы (*.*)|*.* ";  // Фильтр файлов, через ; указывается расширение файла
            myDialog.CheckFileExists = true; // Проверка на существование файла
            myDialog.Multiselect = false; // Выбор нескольких файлов, нам возможно пригодится
            if (myDialog.ShowDialog() == true)
            {
               // Если файл выбран - читаем в листбоксы
            }
        }

        private void write2_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog mySave = new SaveFileDialog();
            mySave.FileName = "data.god";
            mySave.Filter = "Файлы игры(*.GOD)|*.GOD" + "|Все файлы (*.*)|*.* ";
            mySave.CheckFileExists = true;
            Nullable<bool> result = mySave.ShowDialog();
            if (result == true)
            {
                // Сохраняем данные из листбоксов
                string filename = mySave.FileName;
            }
        }
    }
}