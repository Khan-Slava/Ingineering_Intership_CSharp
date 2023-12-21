using Exam.DLL;
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

namespace Exam.LearnGoreignLang.WPF.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        
        public MainPage()
        {
            InitializeComponent();
        }
        //переход на страницу learn
        private void Learning_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                mainFrame.Navigate(new Uri("Pages/LearningPage.xaml", UriKind.Relative));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Logger.WriteLine(ex.Message);
            }


        }
        //переход на страницу texting
        private void Testing_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                mainFrame.Navigate(new Uri("Pages/TestingPage.xaml", UriKind.Relative));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Logger.WriteLine(ex.Message);
            }
        }

        private void AddNewWord_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                mainFrame.Navigate(new Uri("Pages/CreateWordPage.xaml", UriKind.Relative));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Logger.WriteLine(ex.Message);
            }

        }

        private void mainFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
