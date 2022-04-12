﻿using System;
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
using TuSollution.Entities;
using WpfRehber.Repositories;

namespace WpfRehber
{
    /// <summary>
    /// Interaction logic for AddPerson.xaml
    /// </summary>
    public partial class AddPersonForm : Window
    {
        public Person person { get; set; } = new Person();
        public AddPersonForm()
        {
            InitializeComponent();

            mainGrid.DataContext = this;

            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PersonRepository _rep = new PersonRepository();
            _rep.Add(person);
            MessageBox.Show("Kayıt başarılı");
            this.Close();
        }
    }
}