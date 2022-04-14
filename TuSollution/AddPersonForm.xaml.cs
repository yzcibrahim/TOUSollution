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
using System.Windows.Shapes;
using DataAccessLayer.Entities;
using WpfRehber.Helpers;
using DataAccessLayer.Repositories;

namespace WpfRehber
{
    /// <summary>
    /// Interaction logic for AddPerson.xaml
    /// </summary>
    public partial class AddPersonForm : Window
    {
        public Person person { get; set; } = new Person();
        IRepositoryPerson _repository;
        public AddPersonForm()
        {
            InitializeComponent();
           
            mainGrid.DataContext = this;
            //  _repository = new PersonRepositoryJson();
            RepositoryFactory factory = new RepositoryFactory();
            _repository = factory.CreateRepository("Person");
            List<Person> liste= _repository.List();
            int maxId = liste.Max(c => c.Id);
            person.Id = maxId+1;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _repository.AddOrUpdate(person);
            _repository.SaveChanges();
            MessageBox.Show("Kayıt başarılı");
            this.Close();
        }
    }
}
