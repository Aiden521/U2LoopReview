/*
    Aiden Jolley Ruhn
    March 21, 2018
    U2LoopReview
    Reviewing Loops and how they work 
*/
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

namespace U2LoopReview
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // global variables go here and can be accessed in any part of the code
        int x = 3;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string textEntered = txtinput.Text;
            MessageBox.Show(textEntered);
            int positionofslashR = textEntered.IndexOf("\r");
            MessageBox.Show(textEntered.IndexOf("\r").ToString());
            string tempnumber = textEntered.Substring(0, positionofslashR);
            MessageBox.Show(positionofslashR.ToString());

            int total = 0;
            int numberentered = 0;
            int.TryParse(tempnumber, out numberentered);
            int counter = 0;
            while(numberentered != -1)
            {
                MessageBox.Show("in Loop!! total is: " + total.ToString());
                total = total + numberentered;
                int previouspositionofR = positionofslashR;
                tempnumber = textEntered.Substring(previouspositionofR + 2, positionofslashR - previouspositionofR + 2);
                int.TryParse(tempnumber, out numberentered);



            }
            MessageBox.Show("Out of loop, total is: " + total.ToString());
            MessageBox.Show("Average is: " + total / counter);

        }
    }
}
