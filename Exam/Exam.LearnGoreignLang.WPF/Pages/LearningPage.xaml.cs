using Exam.DLL;
using System;
using System.Configuration;
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

namespace Exam.LearnGoreignLang.WPF.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class LearningPage : Page
    {
        public string Path = ConfigurationManager
               .ConnectionStrings["defaultConnection"]
               .ConnectionString;
        
        List<WordPair> wordsList = new List<WordPair>();
        int counter = 0;

        public LearningPage()
        {
            InitializeComponent();

        Repository<WordPair> repo = new Repository<WordPair>(Path);
             var allItems= repo.GetAll();
            wordsList = allItems.ListData;
            
            if (wordsList.Any())
            {
                //перемешивание слов
                Shuffle(wordsList);
                ShowTranslate.Content = wordsList[counter].WordInOriginal;
            }
            else
            {
                try {
                    exitFrame.Navigate(new Uri("Pages/CreateWordPage.xaml", UriKind.Relative));
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);

                    Logger.WriteLine(ex.Message);
                }
                
            }
        }

        private void ShowTranslate_Click(object sender, RoutedEventArgs e)
        {
            
            ShowTranslate.Content = ShowTranslate.Content.ToString() == wordsList[counter].Translation? wordsList[counter].WordInOriginal: wordsList[counter].Translation;
            

        }

        private void Button_Close_Click(object sender, RoutedEventArgs e)
        {
            exitFrame.Navigate(new Uri("Pages/MainPage.xaml", UriKind.Relative));
        }

        private void Button_next_Click(object sender, RoutedEventArgs e)
        {
            
            if (counter< wordsList.Count-1)
            {
                counter++;
            }
            else
            {
                counter=0;
                Button_back.IsEnabled = false;
            }
            ShowTranslate.Content = wordsList[counter].WordInOriginal;
            if (!Button_back.IsEnabled && counter > 0)
            {
                Button_back.IsEnabled = true;
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
                ShowTranslate.Content = wordsList[counter].WordInOriginal;
            }
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
