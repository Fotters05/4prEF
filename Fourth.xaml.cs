using System;
using System.Collections.Generic;
using System.Data;
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
using static System.Net.Mime.MediaTypeNames;

namespace praktika1_EF
{
    public partial class Fourth : Page


    {
        private praktika1_datasetEntities Context = new praktika1_datasetEntities();
        private int bars;
        private int sets;
        private int client;

        public Fourth()
        {
           

            InitializeComponent();
            SushiDataGrid.ItemsSource = Context.INFOBARS.ToList();
            SUSHIBARSComboBox.DisplayMemberPath = "ID_SUSHIBARS";
            SUSHIBARSComboBox.ItemsSource = Context.SUSHIBARS.ToList();
            SUSHISETSComboBox.DisplayMemberPath = "ID_SUSHISETS";
            SUSHISETSComboBox.ItemsSource = Context.SUSHISETS.ToList();
            CLIENTSSComboBox.DisplayMemberPath = "ID_CLIENTS";
            CLIENTSSComboBox.ItemsSource = Context.CLIENTS.ToList();
        }
        private void ShowMainButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Window.GetWindow(this).Close();
        }

        private void Dobavlenie_Click(object sender, RoutedEventArgs e)
        {
            INFOBARS d = new INFOBARS();
            d.SUSHIBARS_ID = int.Parse(SUSHIBARSComboBox.Text);
            d.SUSHISETS_ID = int.Parse(SUSHISETSComboBox.Text);
            d.CLIENTS_ID = int.Parse(CLIENTSSComboBox.Text);
            Context.INFOBARS.Add(d);
            Context.SaveChanges();
            SushiDataGrid.ItemsSource = Context.INFOBARS.ToList();
        }

        private void Udalenie_Click(object sender, RoutedEventArgs e)
        {
            if (SushiDataGrid.SelectedItem != null)
            {
                Context.INFOBARS.Remove(SushiDataGrid.SelectedItem as INFOBARS);
            }
            Context.SaveChanges();
            SushiDataGrid.ItemsSource = Context.INFOBARS.ToList();
        }

        private void Update(object sender, RoutedEventArgs e)
        {
            INFOBARS selectedRow = SushiDataGrid.SelectedItem as INFOBARS;
            SUSHIBARS selectedBar = SUSHIBARSComboBox.SelectedItem as SUSHIBARS;
            SUSHISETS selectedSet = SUSHISETSComboBox.SelectedItem as SUSHISETS;
            CLIENTS selectedClient = CLIENTSSComboBox.SelectedItem as CLIENTS;

            if (selectedRow != null && selectedBar != null && selectedSet != null && selectedClient != null)
            {
                selectedRow.SUSHIBARS_ID = selectedBar.ID_SUSHIBARS;
                selectedRow.SUSHISETS_ID = selectedSet.ID_SUSHISETS;
                selectedRow.CLIENTS_ID = selectedClient.ID_CLIENTS;

                Context.SaveChanges();
                SushiDataGrid.ItemsSource = Context.INFOBARS.ToList();
            }
        }

        private void SushiDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SushiDataGrid.SelectedItem != null)
            {
                var select = SushiDataGrid.SelectedItem as INFOBARS;
                bars = select.SUSHIBARS_ID;
                sets = select.SUSHISETS_ID;
                client = select.CLIENTS_ID;

                SUSHIBARSComboBox.SelectedItem = Context.SUSHIBARS.FirstOrDefault(n => n.ID_SUSHIBARS == bars);
                SUSHISETSComboBox.SelectedItem = Context.SUSHISETS.FirstOrDefault(s => s.ID_SUSHISETS == sets);
                CLIENTSSComboBox.SelectedItem = Context.CLIENTS.FirstOrDefault(c => c.ID_CLIENTS == client);
            }
        }

        private void SUSHIBARSComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SUSHIBARSComboBox.SelectedItem != null)
            {
                var selectedItem = SUSHIBARSComboBox.SelectedItem as SUSHIBARS;

            }
        }

        private void SUSHISETSComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SUSHISETSComboBox.SelectedItem != null)
            {
                var selectedItem = SUSHISETSComboBox.SelectedItem as SUSHISETS;

            }
        }

        private void CLIENTSSComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CLIENTSSComboBox.SelectedItem != null)
            {
                var selectedItem = CLIENTSSComboBox.SelectedItem as CLIENTS;

            }

        }
        private void SK(object sender, RoutedEventArgs e)
        {



        }


    }
}
