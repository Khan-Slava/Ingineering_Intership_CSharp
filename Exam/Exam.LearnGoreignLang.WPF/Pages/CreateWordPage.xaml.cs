using Exam.DLL;
using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace Exam.LearnGoreignLang.WPF.Pages
{
    /// <summary>
    /// Логика взаимодействия для CreateWord.xaml
    /// </summary>
    public partial class CreateWordPage : Page
    {
        public string Path = ConfigurationManager
               .ConnectionStrings["defaultConnection"]
               .ConnectionString;

        public CreateWordPage()
        {
            InitializeComponent();
        }
        
        private void Button_Close_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                exitFrame.Navigate(new Uri("Pages/MainPage.xaml", UriKind.Relative));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Logger.WriteLine(ex.Message);
            }
        }
        //кнопка создания нового слова
        private void Button_next_Click(object sender, RoutedEventArgs e)
        {

            var repo = new Repository<WordPair>(Path);
            WordPair data = new WordPair(MenuName.Header.ToString(), tbxOriginWord.Text, tbxTranslate.Text);
           
            repo.Create(data);
            exitFrame.Navigate(new Uri("Pages/MainPage.xaml", UriKind.Relative));
            MessageBox.Show("Слово добавлено");
            Logger.WriteLine("Новое Cлово Добавлено");
        }
        
        //Выбор языка рус каз
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            MenuName.Header = "Русский-Казахский";
        }
        
        //Выбор языка рус англ
        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            MenuName.Header = "Русский-Английский";
        }
        
        //Выбор языка каз англ
        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            MenuName.Header = "Казахский-Английский";
        }

        private void exitFrame_Navigated(object sender, NavigationEventArgs e)
        {
            
        }
    }
}
