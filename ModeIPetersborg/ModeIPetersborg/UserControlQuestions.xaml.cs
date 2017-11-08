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
    /// Interaction logic for UserControlQuestions.xaml
    /// </summary>
    public partial class UserControlQuestions : UserControl
    {
        public UserControlQuestions()
        {
            InitializeComponent();
        }

        private void TBText1_Loaded(object sender, RoutedEventArgs e)
        {
            TBText1.Text = "test";
        }
    }
}
