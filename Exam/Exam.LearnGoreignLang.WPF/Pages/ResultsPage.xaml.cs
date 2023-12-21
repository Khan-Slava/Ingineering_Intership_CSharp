using Exam.DLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
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
    /// Логика взаимодействия для ResultsPage.xaml
    /// </summary>
    public partial class ResultsPage : Page
    {
        public string Path = ConfigurationManager
               .ConnectionStrings["defaultConnection"]
               .ConnectionString;

        public static string PathToUnloadDirectory = ConfigurationManager
               .ConnectionStrings["unloadDirectory"]
               .ConnectionString;

        List<WordPair> wordsList = new List<WordPair>();

        public ResultsPage()
        {
            InitializeComponent();

            Repository<WordPair> repo = new Repository<WordPair>(Path);
            var allItems = repo.GetAll();
            wordsList = allItems.ListData;

            lvWordPair.ItemsSource = wordsList;

        }

        //выгрузка данных в файл
        private void Button_unload_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter(PathToUnloadDirectory);
                
               
                sw.WriteLine("From the StreamWriter class");
               
                
                foreach (var item in wordsList)
                {
                    //данные листа в строку
                    string details = item.WordInOriginal + " - " + item.Translation +
                        " - " + item.CountOfCorrectAnswer.ToString() + "/" + item.CountOfIncorrectAnswer.ToString();
                    sw.WriteLine(details);
                }
                sw.Close();
                MessageBox.Show("Выгрузка завершена");
                Logger.WriteLine("Выгрузка завершена");
            }
            catch (Exception ex){
                MessageBox.Show("Ошибка выгрузки");
                Logger.WriteLine(ex.Message);
            }


            
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

        private void exitFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }

    }
}
