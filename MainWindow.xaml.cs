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

        private void btnDisplayStudent_Click(object sender, RoutedEventArgs e)
        {
            int index = -1;
            bool isANumber = int.TryParse(txtIndex.Text, out index);
            if (isANumber && index >= 0 && index < studentList.Count)
            {
                MessageBox.Show(studentList[index]);
            }
            else
            {
                MessageBox.Show("Invalid index");
            }
        }//button Display Student click event

        private void btnRemoveByIndex_Click(object sender, RoutedEventArgs e)
        {
            int index = -1;
            bool isANumber = int.TryParse(txtIndex.Text, out index);

            if (isANumber && index >= 0 && index < studentList.Count)
            {
                studentList.RemoveAt(index);
                DisplayStudents();
            }
            else
            {
                MessageBox.Show("Invalid index");
            }
        }//button remove Student click event

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int index = -1;
            bool isANumber = int.TryParse(txtIndex.Text, out index);

            if (isANumber && index >= 0 && index < studentList.Count)
            {
                studentList.Insert(index, txtStudentName.Text);
                DisplayStudents();
            }
            else
            {
                MessageBox.Show("Invalid index");
            }

        }//button add at index Student click event
    }//MainWindow   
}//namespace
