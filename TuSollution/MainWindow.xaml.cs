using System.Windows;
using WpfRehber;
using WpfRehber.Repositories;

namespace TuSollution
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();

            PersonRepository _rep = new PersonRepository();
            peopleGrid.ItemsSource = _rep.List();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddPersonForm frmAddPerson = new AddPersonForm();
            frmAddPerson.ShowDialog();

            PersonRepository _rep = new PersonRepository();
            peopleGrid.ItemsSource = _rep.List();


        }
    }
}
