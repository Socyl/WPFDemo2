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


namespace WPFDemo2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Assignment> assignments;
        public MainWindow()
        {
            InitializeComponent();
            assignments = new List<Assignment>();
            lbScores.ItemsSource = assignments;
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            Student student = new Student();
            student.FirstName = txbFirstName.Text;
            student.LastName = txbLastName.Text;
            student.StudentNumber = txbStudentNumber.Text;
            student.Major = txbMajor.Text;


            //listbox section in submit
            List<Assignment> assignmentsCopy = new List<Assignment>(assignments);
  
            /*
            foreach(Assignment assignment in lbScores.Items)
            {
                assignments.Add(assignment);

            }
            */


            student.Scores = assignmentsCopy;

            txbResults.Text = student.ToString();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Assignment assignment = new Assignment();
            assignment.Title = txbTitle.Text;
            int scoreInt = int.Parse(txbScore.Text);
            assignment.Score = scoreInt;
            assignments.Add(assignment);
            lbScores.Items.Refresh();
        }
    }
}
