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
using PowerPoint = Microsoft.Office.Interop.PowerPoint;
using Office = Microsoft.Office.Core;

namespace appinion_add_on
{
    /// <summary>
    /// Interaction logic for AddQuestionForm.xaml
    /// </summary>
    public partial class AddQuestionForm : Window
    {

        ConnectionClass CC = new ConnectionClass();

        public AddQuestionForm()
        {
            InitializeComponent();
        }

        private void pitanjaListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.odgovoriListBox.Items.Clear();

            string pitanje = pitanjaListBox.SelectedItem.ToString();

            foreach(var odgovor in CC.getAnswers(pitanje))
            {
                for(int i = 0; i<odgovor.Count; i++)
                odgovoriListBox.Items.Add(odgovor[i]);
            }

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Ribbon1 R = new Ribbon1();
            R.AddSlide();
        }
    }
}
