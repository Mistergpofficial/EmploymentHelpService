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

namespace EmploymentHelpService
{
    /// <summary>
    /// Interaction logic for ClientDetails.xaml
    /// </summary>
    public partial class ClientDetails : Window
    {
        List<Client> ClientList = new List<Client>();

        public ClientDetails()
        {
            InitializeComponent();

            ClientList.Clear();

            Client details1 = new Client("Ehuriah Chukwudike", "10 Whitehouse Lane", "EH4 7PG", "ehuriahgodspower@gmail.com", "44745643454664", "Construction", 10, "Yes", "Yes", "dd-mm-yyyy");

            Client details2 = new Client("Nwokike Kosi", "15 Whitehouse Lane", "EH5 7PG", "kosi@gmail.com", "448575769969", "Gardening", 15, "Yes", "No", "dd-mm-yyyy");

            Client details3 = new Client("Igwe Kingsley", "20 Whitehouse Lane", "EH6 7PG", "igwe@gmail.com", "449588667677", "Office", 20, "Yes", "Yes", "dd-mm-yyyy");

            Client details4 = new Client("Harry James", "25 Whitehouse Lane", "EH7 7PG", "harry@gmail.com", "449588667676", "Construction", 5, "No", "Yes", "dd-mm-yyyy");

            Client details5 = new Client("Daniel Bernard", "30 Whitehouse Lane", "EH8 7PG", "daniel@gmail.com", "449588667675", "Warehouse", 7, "Yes", "Yes", "dd-mm-yyyy");

            Client details6 = new Client("Charles Hilary", "35 Whitehouse Lane", "EH9 7PG", "charles@gmail.com", "449588667674", "Finance", 15, "Yes", "No", "dd-mm-yyyy");

            Client details7 = new Client("Kelvin Tom", "40 Whitehouse Lane", "EH10 7PG", "kelvin@gmail.com", "449588667673", "Business", 12, "No", "No", "dd-mm-yyyy");

            Client details8 = new Client("Williams Shakes", "45 Whitehouse Lane", "EH11 7PG", "williams@gmail.com", "449588667672", "Retail", 9, "Yes", "Yes", "dd-mm-yyyy");

            Client details9 = new Client("Jury Jones", "50 Whitehouse Lane", "EH12 7PG", "jury@gmail.com", "449588667671", "Farming", 30, "Yes", "No", "dd-mm-yyyy");

            Client details10 = new Client("Moses Thomson", "55 Whitehouse Lane", "EH13 7PG", "moses@gmail.com", "449588667670", "Construction", 6, "No", "Yes", "dd-mm-yyyy");

            //add client to list
            ClientList.Add(details1);
            ClientList.Add(details2);
            ClientList.Add(details3);
            ClientList.Add(details4);
            ClientList.Add(details5);
            ClientList.Add(details6);
            ClientList.Add(details7);
            ClientList.Add(details8);
            ClientList.Add(details9);
            ClientList.Add(details10);


            //set gridview datasource to new list
            dgClient1.ItemsSource = ClientList;
        }
    }
}
