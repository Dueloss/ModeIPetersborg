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

namespace ModeIPetersborg
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Task task = new Task();

        public MainWindow()
        {
            InitializeComponent();
            
            task.Title = "test Title";
            task.Explanation = "something something";
            List<string> question = new List<string>();
            List<string> choise = new List<string>();
            List<bool> correct = new List<bool>();
            question.Add("Question 1");
            question.Add("Question 2");
            choise.Add("chose 1");
            choise.Add("chose 2");
            correct.Add(false);
            correct.Add(true);
            task.AddQuestion(question, choise, correct);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            UserControl myUserControl = new UserControl();
            
        }
    }
}
