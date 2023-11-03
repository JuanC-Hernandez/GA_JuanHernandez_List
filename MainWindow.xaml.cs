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

namespace GA_JuanHernandez_List
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> studentList = new List<string>();//creating new list
        public MainWindow()
        {
            InitializeComponent();
            studentList.Add("Juan");
            studentList.Add("Carlos");
            studentList.Add("Miguel");
            studentList.Add("Helen");
            studentList.Add("Jacky");

            DisplayStudents();
        }//MainWindow
        public void DisplayStudents()
        {
            rtbDisplay.Text = "";//clears rtb
            for (int i = 0; i < studentList.Count; i++)
            {
                rtbDisplay.Text += $"{i} - {studentList[i]}\n";
            }
            lblCurrentCount.Content = $"Student Count: {studentList.Count}";
        }//DisplayStudents

        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            studentList.Add(txtStudentName.Text);//adds new student
            DisplayStudents() ; 

        }//button addStudent click event
    }//MainWindow   
}//namespace
