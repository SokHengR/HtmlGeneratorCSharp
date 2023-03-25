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

namespace HtmlGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string filePathSaved = "";
        public MainWindow()
        {
            InitializeComponent();
            messageLabel.Visibility = Visibility.Hidden;
            buildButton.Visibility = Visibility.Visible;
            showButton.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            messageLabel.Visibility = Visibility.Visible;
            buildButton.Visibility = Visibility.Hidden;
            showButton.Visibility = Visibility.Visible;
            string homePage = TheHtmlManager.makeHtmlFile("Home Page");
            filePathSaved = TheFileManager.SaveStringToFile(homePage, "index.html");
            string contactPage = TheHtmlManager.makeHtmlFile("Contact Page");
            filePathSaved = TheFileManager.SaveStringToFile(contactPage, "contact.html");
            string shopPage = TheHtmlManager.makeHtmlFile("Shop Page");
            filePathSaved = TheFileManager.SaveStringToFile(shopPage, "shop.html");
        }

        private void showButton_Click(object sender, RoutedEventArgs e)
        {
            if(!TheFileManager.OpenFileLocationExplorer(filePathSaved))
            {
                messageLabel.Visibility = Visibility.Hidden;
                buildButton.Visibility = Visibility.Visible;
                showButton.Visibility = Visibility.Hidden;
            }
        }
    }
}
