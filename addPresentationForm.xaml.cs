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

namespace appinion_add_on
{
    /// <summary>
    /// Interaction logic for addPresentationForm.xaml
    /// </summary>
    public partial class AddPresentationForm : Window
    {
        public AddPresentationForm()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {


            String userInput = presentationIdText.Text;



            ConnectionClass CS = new ConnectionClass(userInput);


        }
    }
}
