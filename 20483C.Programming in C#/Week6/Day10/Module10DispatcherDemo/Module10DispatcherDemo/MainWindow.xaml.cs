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

namespace Module10DispatcherDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SetTime(string time)
        {
            lbTime.Content = time;
        }

        public async Task GetCoffees(Action<IEnumerable<string>> callback)
        {
            var coffees = await Task.Run(() =>
            {
                var coffeeList = new List<string>();
                coffeeList.Add("Americano");
                coffeeList.Add("Americano");
                coffeeList.Add("Americano");
                coffeeList.Add("Latte");
                coffeeList.Add("Latte");
                coffeeList.Add("Mocha");
                coffeeList.Add("Mocha");
                coffeeList.Add("Expresso");
                coffeeList.Add("Expresso");
                Task.Delay(6000).Wait();
                return coffeeList;
            });

            await Task.Run(() => callback(coffees));
        }

        private void RemoveDuplicates(IEnumerable<string> coffees)
        {
            IEnumerable<string> uniqueCoffees = coffees.Distinct();
            Dispatcher.BeginInvoke(new Action(() =>
            {
                lstCoffees.ItemsSource = uniqueCoffees;
            }));
        }

        private void btnGetTime_Click(object sender, RoutedEventArgs e)
        {
            Task.Run(() =>
            {
                string currentime = DateTime.Now.ToShortTimeString();
                lbTime.Dispatcher.BeginInvoke(new Action(() => SetTime(currentime)));

                //SetTime(currentime);

            });
        }

        private async void btnGetCoffees_ClickAsync(object sender, RoutedEventArgs e)
        {
            await GetCoffees(RemoveDuplicates);
        }
    }
}
