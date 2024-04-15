using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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

namespace praktika1_EF
{

    public partial class Second : Page
    {
        private praktika1_datasetEntities Context = new praktika1_datasetEntities();

        public Second()
        {
            InitializeComponent();
            SushiDataGrid.ItemsSource = Context.SUSHISETS.ToList();

            SetsCbx.ItemsSource = Context.SUSHISETS.ToList();
            SetsCbx.DisplayMemberPath = "TITLESETS";
        }
        private void ShowMainButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Window.GetWindow(this).Close();
        }

        private void Dobavlenie_Click(object sender, RoutedEventArgs e)
        {
            string TITLESETS = NameTbx.Text;
            int PRICESETS = int.Parse(Prc.Text);
            int QUANTITY = int.Parse(Quant.Text);

            SUSHISETS b = new SUSHISETS();
            b.TITLESETS = TITLESETS;
            b.PRICESETS = PRICESETS;
            b.QUANTITY = QUANTITY;
            Context.SUSHISETS.Add(b);
            Context.SaveChanges();
            SushiDataGrid.ItemsSource = Context.SUSHISETS.ToList();
        }

        private void Udalenie_Click(object sender, RoutedEventArgs e)
        {
            if (SushiDataGrid.SelectedItem != null)
            {
                Context.SUSHISETS.Remove(SushiDataGrid.SelectedItem as SUSHISETS);
            }
            Context.SaveChanges();
            SushiDataGrid.ItemsSource = Context.SUSHISETS.ToList();
        }

        private void Update(object sender, RoutedEventArgs e)
        {
            if (SushiDataGrid.SelectedItem != null)
            {
                string TITLESETS = NameTbx.Text;
                int PRICESETS = int.Parse(Prc.Text);
                int QUANTITY = int.Parse(Quant.Text);

                var selected = SushiDataGrid.SelectedItem as SUSHISETS;
                selected.TITLESETS = TITLESETS;
                selected.PRICESETS = PRICESETS;
                selected.QUANTITY = QUANTITY;

                Context.SaveChanges();
                SushiDataGrid.ItemsSource = Context.SUSHISETS.ToList();
            }


        }

        private void SushiDataGrid_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (SushiDataGrid.SelectedItem != null)
            {
                DataRowView selectedRow = SushiDataGrid.SelectedItem as DataRowView;


                string titlesets = selectedRow.Row["TITLESETS"].ToString();
                int price = Convert.ToInt32(selectedRow["PRICESETS"]);
                string integerAsString = price.ToString();
                int q = Convert.ToInt32(selectedRow["QUANTITY"]);
                string integerAsString1 = q.ToString();

                NameTbx.Text = titlesets;
                Prc.Text = integerAsString;
                Quant.Text = integerAsString1;
            }
        }

        private void Search(object sender, RoutedEventArgs e)
        {
            SushiDataGrid.ItemsSource = Context.SUSHISETS.ToList().Where(item => item.TITLESETS.Contains(Search_Click.Text));
        }

        private void SetsCbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SetsCbx.SelectedItem != null)
            {
                var selected = SetsCbx.SelectedItem as SUSHISETS;
                SushiDataGrid.ItemsSource = Context.SUSHISETS.ToList().Where(item => item.TITLESETS == selected.TITLESETS);
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            SushiDataGrid.ItemsSource = Context.SUSHISETS.ToList();
            Search_Click.Text = "";
            SetsCbx.SelectedItem = null;
        }
    }
}
