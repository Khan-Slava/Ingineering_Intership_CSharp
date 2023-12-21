using Exam.DLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
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
    /// Логика взаимодействия для TestingPage.xaml
    /// </summary>
    public partial class TestingPage : Page
    {
        public string Path = ConfigurationManager
              .ConnectionStrings["defaultConnection"]
              .ConnectionString;

        List<WordPair> wordsList = new List<WordPair>();
        int counter = 0;
        public TestingPage()
        {
            InitializeComponent();

            Repository<WordPair> repo = new Repository<WordPair>(Path);
            var allItems = repo.GetAll();
            wordsList = allItems.ListData;

            if (wordsList.Any())
            {
                //перемешивание слов
                Shuffle(wordsList);
                tbxOrigin.Text = wordsList[counter].WordInOriginal;
            }
            else
            {
                //если нет слов вернет в мэйн
                exitFrame.Navigate(new Uri("Pages/MainPage.xaml", UriKind.Relative));
                Logger.WriteLine("база данных пуста");
            }
        }
        private void Button_check_Click(object sender, RoutedEventArgs e)
        {
            //проверка на правильность
            if(tbxTranslation.Text.ToLower() == wordsList[counter].Translation.ToLower())
            {
                ShowMessage("Правильно");
                wordsList[counter].CountOfCorrectAnswer++;

            }
            else
            {
                ShowMessage("Неправильно");
                wordsList[counter].CountOfIncorrectAnswer++;
            }
        }
        void ShowMessage(string mess)
        {
            MessageBox.Show(mess);
        }
        private void Button_Close_Click(object sender, RoutedEventArgs e)
        {
            exitFrame.Navigate(new Uri("Pages/MainPage.xaml", UriKind.Relative));
        }

        private void Button_next_Click(object sender, RoutedEventArgs e)
        {
            //кнопка нажатия следующий
            if(counter == wordsList.Count - 1)
            {
                Update_Results(wordsList);
                exitFrame.Navigate(new Uri("Pages/ResultsPage.xaml", UriKind.Relative));
            }
            else if (counter < wordsList.Count - 2)
            {
                counter++;
            }
            else
            {
                Button_next.Content = "Завершить";
                counter++;    
            }
            tbxOrigin.Text = wordsList[counter].WordInOriginal;
            tbxTranslation.Text = "";
            if (!Button_back.IsEnabled && counter > 0)
            {
                Button_back.IsEnabled = true;
            }

        }
        void Update_Results(List<WordPair> data)
        {
            //обновляет результаты правильных и неправильных слов в бд
            Repository<WordPair> repo = new Repository<WordPair>(Path);
            foreach (WordPair wordPair in data)
            {
                repo.Update(wordPair);
            }

        }
        
        private void Button_back_Click(object sender, RoutedEventArgs e)
        {

            if (counter == 0)
            {

                Button_back.IsEnabled = false;
            }
            else
            {
                counter--;
                
            }
            tbxOrigin.Text = wordsList[counter].WordInOriginal;
            tbxTranslation.Text = "";
        }
        private void Shuffle(List<WordPair> list)
        {

            Random rand = new Random();


            for (int i = list.Count - 1; i >= 1; i--)
            {
                int j = rand.Next(i + 1);

                var tmp = list[j];
                list[j] = list[i];
                list[i] = tmp;
            }


        }

        private void exitFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
   
   

        
}
