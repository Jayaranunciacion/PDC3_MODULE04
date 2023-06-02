using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC03_MODULE04
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class activity02 : ContentPage
    {
        ObservableCollection<Employee> Employees { get { return Employees; } }
        public activity02()
        {
            InitializeComponent();
            EmployeeView.ItemsSource = Employees;

            Employees.Add(new Employee { DisplayName = "Juan Dela Cruz", PositionChangedEventArgs = "President" });
            Employees.Add(new Employee { DisplayName = "John Doe", PositionChangedEventArgs = "Vice President" });
            Employees.Add(new Employee { DisplayName = "Mark Cruz", PositionChangedEventArgs = "Director" });
            Employees.Add(new Employee { DisplayName = "Peter Dela Cruz", PositionChangedEventArgs = "Supervisor" });
        }

        private void Add_Item(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            if (menuItem != null)
            {

            }

            private void Edit_Item(object sender, EventArgs e)
            {
                var menuItem = sender as MenuItem;
                if (menuItem != null)
                {

                }

                private void Delete_Item(object sender, EventArgs e)
                {
                    var menuItem = sender as MenuItem;
                    if (menuItem != null)
                    {

                    }
                }
            }
        }
    }
}