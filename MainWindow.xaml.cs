using System;
using System.Data;
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

namespace FirstWpfAp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /** public partial class MainWindow : Window
    {
        public List<Person> people = new List<Person>();
        public MainWindow()
        {
            InitializeComponent();

            people.Add(new Person { FirstName = "Tim", LastName= "Corey"});
            people.Add(new Person { FirstName = "Joe", LastName= "Smith"});
            people.Add(new Person { FirstName = "Sue", LastName= "Strom"});

            myComboBox.ItemsSource = people;
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Hello {firstName.Text}");
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return $"{ FirstName} {LastName}";
            }
        }
    }
    **/

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            foreach (UIElement el in Calculator.Children)
            {
                if (el is Button)
                {
                    ((Button)el).Click += Button_Click;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;
            if (str == "AC")
                textLable.Text = "";
            else if(str == "=")
            {
                string value = new DataTable().Compute(textLable.Text, null).ToString();
                textLable.Text = value;
            }
            else
            textLable.Text += str;
        }
    }
}
