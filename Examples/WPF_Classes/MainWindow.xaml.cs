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

namespace WPF_Classes
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

        private void btnclick_Click(object sender, RoutedEventArgs e)
        {
            string id, fname, lname, probation, gpa, balance;

            id = txtID.Text;
            fname = txtfirstname.Text;
            lname = txtlastname.Text;
            probation = txtprobation.Text;
            gpa = txtGPA.Text;
            balance = txtBalance.Text;

            Student stud = new Student(id, fname, lname, balance);
            stud.GPA = Convert.ToDouble(gpa);
            if (probation.ToLower() == "yes")
            {
                stud.IsOnProbation = true;
            }
            else
            {
                stud.IsOnProbation = false;
            }

            lstStudents.Items.Add(stud);
        }


    }
}
