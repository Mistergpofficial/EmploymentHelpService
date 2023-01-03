using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Forms;



namespace EmploymentHelpService
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        List<Vacancy> VacancyList = new List<Vacancy>();
        List<Client> client = new List<Client>();
        List<Client> interview = new List<Client>();
        private string unspentcriminalrecord = "";


        // Private method to show Client when button is clicked
        private void btnDisplayClient_Click(object sender, RoutedEventArgs e)
        {
            ClientDetails c = new ClientDetails();

            c.Show();
        }

        // Private method to show Organization when button is clicked
        private void btnDisplayOrganization_Click(object sender, RoutedEventArgs e)
        {
            OrganisationDetails w = new OrganisationDetails();

            w.Show();
        }



        // method to create and initialize the user interface objects dragged on the form surface for clients and organisations
        public MainWindow()
        {
            InitializeComponent();
            
        }
     

        private void rb_Checked(object sender, RoutedEventArgs e)
        {
            var radioButton = sender as System.Windows.Controls.RadioButton;
            if (radioButton != null)
            {
                unspentcriminalrecord = radioButton.Content.ToString();
            }
    
        }

        private void rbNo_Checked(object sender, RoutedEventArgs e)
        {
            rbYes.IsChecked &= false;
        }


        // method to create a new vacancy on click
        private void btnNewVacancy_Click(object sender, RoutedEventArgs e)
        {

            if (txtJobType.SelectedItem == null)

            {
                System.Windows.MessageBox.Show(
                    "Please enter a job type.",
                    "This field can't be empty!",
                    MessageBoxButton.OK,
                    MessageBoxImage.Exclamation
                    );
            }

            else if (txtStartDate.SelectedDate == null)
            {
                System.Windows.MessageBox.Show(
                   "Please enter a start date.",
                   "This field can't be empty!",
                   MessageBoxButton.OK,
                   MessageBoxImage.Exclamation
                   );
            }


            else if (txtQualification.Text == null)
            {
                System.Windows.MessageBox.Show(
                    "Please enter job qualification.",
                    "This field can't be empty!",
                    MessageBoxButton.OK,
                    MessageBoxImage.Exclamation
                    );
            }

            else if (txtDistance.Text.Length == 0)
            {
                System.Windows.MessageBox.Show(
                   "Please enter a distance in miles.",
                   "This field can't be empty!",
                   MessageBoxButton.OK,
                   MessageBoxImage.Exclamation
                   );
            }

            else if (txtSalary.Text.Length == 0)
            {
                System.Windows.MessageBox.Show(
                   "Please enter the salary for this job.",
                   "This field can't be empty!",
                   MessageBoxButton.OK,
                   MessageBoxImage.Exclamation
                   );
            }


            else if (txtDriversLicense.SelectedIndex == -1)
            {
                System.Windows.MessageBox.Show(
                   "Please tell if drivers license is required for this job.",
                   "This field can't be empty!",
                   MessageBoxButton.OK,
                   MessageBoxImage.Exclamation
                   );
            }


            else if (txtExperience.Text == null)
            {
                System.Windows.MessageBox.Show(
                   "Please enter the expected experience for this job.",
                   "This field can't be empty!",
                   MessageBoxButton.OK,
                   MessageBoxImage.Exclamation
                   );
            }


            else
            {

                Vacancy v = new Vacancy(
                    txtJobType.Text, 
                    txtQualification.Text, 
                    txtStartDate.Text, 
                    unspentcriminalrecord,  
                    float.Parse(txtSalary.Text), 
                    txtDriversLicense.Text, 
                    txtExperience.Text, 
                    Convert.ToInt32(txtDistance.Text)
                    );

                txtSalary.Clear();
                txtExperience.Clear();
                txtQualification.Clear();
                txtDistance.Clear();
                VacancyList.Add(v);
                lstVacancy.ItemsSource = null;
                lstVacancy.ItemsSource = VacancyList;
            }

        }


        private void btnMatchClient_Click(object sender, RoutedEventArgs e)

        {

            foreach (Vacancy vac in lstVacancy.SelectedItems) 
            {
                if(vac != null)
                {
                    ClientDetails c = new ClientDetails();
                    foreach(Client match in c.dgClient1.ItemsSource)
                    {
                        if (match.TypeofWork != vac.TypeOfWork || match.Distance != vac.Distance || match.UnspentCriminalRecord != vac.checkUnspentCriminalRecord || match.DriversLicense != vac.DriversLicense)
                        {
                            continue;
                        }

                        Client details4 = new Client(
                           match.FullName,
                           match.Address,
                           match.PostCode,
                           match.Email,
                           match.Phone,
                           match.TypeofWork,
                           match.Distance,
                           match.DriversLicense,
                           match.UnspentCriminalRecord,
                           match.InterviewDate
                           );

                        client.Add(details4);
                        lstShortlist.ItemsSource = null;
                        lstShortlist.ItemsSource = client;

                    }
                }
                else
                {
                    System.Windows.MessageBox.Show(
                   "Please enter at least one job vacancy.",
                   "A job vacancy is required!",
                   MessageBoxButton.OK,
                   MessageBoxImage.Exclamation
                   );

                    break;
                }
            }
        }

        // method to create a remove uninterested clients
        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            Client cli = lstShortlist.SelectedItem as Client;



            if (cli != null)
            {
                var result = System.Windows.MessageBox.Show("Are you sure you want to delete " + ' ' + cli.FullName, "Delete Client", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No);

                if (result == MessageBoxResult.Yes)
                {
                    Client details5 = cli;


                    client.Remove(details5);
                    lstShortlist.ItemsSource = null;

                    lstShortlist.ItemsSource = client;
                }

            }
        }

    
      


        private void btnScheduleInterview_Click(object sender, RoutedEventArgs e)
        {

            foreach (Client match2 in lstShortlist.ItemsSource)
            {
                if(match2 == null)
                {
                    continue;
                }
                string input = DateTime.Now.ToString();
                Client details5 = new Client(
                            match2.FullName,
                            match2.Address,
                            match2.PostCode,
                            match2.Email,
                            match2.Phone,
                            match2.TypeofWork,
                            match2.Distance,
                            match2.DriversLicense,
                            match2.UnspentCriminalRecord,
                            input
                            );

                interview.Add(details5);
                //client.Clear();
                //interview.RemoveAll(item => client.Contains(item));
                //interview.Add(details5);
               

                System.Windows.MessageBox.Show(
                   "Interview Date and Time Added Successfully",
                   "Message",
                   MessageBoxButton.OK,
                   MessageBoxImage.Exclamation
                   );

               
            }
            client.Clear();
            client.AddRange(interview);
            interview.Clear();
            lstShortlist.ItemsSource = null;
            lstShortlist.ItemsSource = client;
        }

       
    }
}
