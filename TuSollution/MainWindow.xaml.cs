using DataAccessLayer.Entities;
using DataAccessLayer.Repositories;
using System;
using System.Windows;
using WpfRehber;
using WpfRehber.Helpers;

namespace TuSollution
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IRepositoryPerson _rep;
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
            RepositoryFactory factory = new RepositoryFactory();
            _rep = factory.CreateRepository("Person");
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string deger = txtInput.Text;
            //string temp = deger;

            char[] arr = deger.ToCharArray();
            Array.Reverse(arr);

            string reversDeger = string.Join("", arr);
            if (reversDeger == deger)
                MessageBox.Show("palindromdur");
            else
                MessageBox.Show("değildir");
        }
    }
}
