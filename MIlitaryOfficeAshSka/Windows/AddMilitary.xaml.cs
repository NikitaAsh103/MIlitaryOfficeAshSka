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

namespace MIlitaryOfficeAshSka.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddMilitary.xaml
    /// </summary>
    public partial class AddMilitary : Window
    {
        public AddMilitary()
        {
            InitializeComponent();
            gender.ItemsSource = new Person[]
        {
            new Person { Name = "Женский" },
            new Person { Name = "Мужской",  },
            
        };
        }
    }
    public class Person
    {
        public string Name { get; set; } = "";
        public override string ToString() => $"{Name} ";
    }
}
    

