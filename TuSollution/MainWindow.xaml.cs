using System.Windows;
using TuSollution.Entities;
using WpfRehber;
using WpfRehber.Repositories;

namespace TuSollution
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PersonRepositoryJson _rep;
        public MainWindow()
        {

            InitializeComponent();

            RefreshGrid();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddPersonForm frmAddPerson = new AddPersonForm();
            frmAddPerson.ShowDialog();

            RefreshGrid();
        }

        private void RefreshGrid()
        {
            _rep = new PersonRepositoryJson();
            peopleGrid.ItemsSource = _rep.List();
        }

        private void CommandBinding_CanExecute(object sender, System.Windows.Input.CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void CommandBinding_Executed(object sender, System.Windows.Input.ExecutedRoutedEventArgs e)
        {
             var silinecek = (Person)peopleGrid.SelectedItem;
            _rep.Delete(silinecek);
            _rep.SaveChanges();
            RefreshGrid();
        }
    }
}
