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
    /// Interaction logic for OrganisationDetails.xaml
    /// </summary>
    public partial class OrganisationDetails : Window
    {
        List<Organisation> OrganisationList = new List<Organisation>();
        public OrganisationDetails()
        {
            InitializeComponent();

            OrganisationList.Clear();

            Organisation org1 = new Organisation("Brady Technologies", "40 Torphichen St, Edinburgh", "EH3 8JB");

            Organisation org2 = new Organisation("CGI IT UK Ltd", "81 George St, Edinburgh", "EH2 3ES");

            Organisation org3 = new Organisation("Clockwise Edinburgh Leith", "Commercial Quay, 84 Commercial St, Leith, Edinburgh", "EH6 6LX");


            OrganisationList.Add(org1);
            OrganisationList.Add(org2);
            OrganisationList.Add(org3);


            lstOrganisation.ItemsSource = OrganisationList;
        }
    }
}
