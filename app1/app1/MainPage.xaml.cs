using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238
//this is the main function 
namespace app1
{
    
    public sealed partial class MainPage : Page
    {

        int col1 = 0;
        int col2 = 0;
        int col3 = 0;
        bool column1 = false;
        bool column2 = false;
        bool column3 = false; 

        

        
        public MainPage()
        {
            this.InitializeComponent();
        }


        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        


        public int xton(int pow)
        {
            //#Base case as defined by assignment 
            if (pow == 0)
                return 1;

            int result = 0;
            result = 10 * xton(pow - 1);
            return result;
        }


        public void resultPrinter(int rawval)
        {
            if (rawval % 1000000 == 0)
            {
                int val = rawval / 1000000;
                result.Text = val + " MΩ"; 
                //print "result: %d Mohms" %val;
            }
            else if (rawval % 1000 == 0)
            {
                int val = rawval / 1000;
                result.Text = val + " KΩ"; 
                //print "result: %d kohms" %val
            }
            else
            {
                result.Text = rawval + " Ω"; 
                //print "result: %d ohms" %rawval;
            }
        }
        public void calculator(int colorTens, int colorOnes, int colorMulti)
        {
            //#match each color to a number
            
            int tens = colorTens * 10;

            int ones = colorOnes;
            int root = tens + ones;


            int multiplier = xton(colorMulti);

            int rresult = root * multiplier;
            resultPrinter(rresult); 
        }

        private void black0(object sender, RoutedEventArgs e)
        {
            tens.Text = "black"; 
            //result.Text = "black0";
            col1 = 0;
            calculator(col1, col2, col3); 
        }

        private void brown0(object sender, RoutedEventArgs e)
        {
            tens.Text = "brown";
            col1 = 1;
            //tens.Foreground = new SolidColorBrush(Colors.Blue); 
            //result.Text = "clicked";
            calculator(col1, col2, col3); 
        }

        private void red0(object sender, RoutedEventArgs e)
        {
            tens.Text = "red"; 
            col1 = 2;
            calculator(col1, col2, col3); 
        }

        private void orange0(object sender, RoutedEventArgs e)
        {
            tens.Text = "orange"; 
            col1 = 3;
            calculator(col1, col2, col3); 
        }

        private void yellow0(object sender, RoutedEventArgs e)
        {
            tens.Text = "yellow"; 
            col1 = 4;
            calculator(col1, col2, col3); 
        }

        private void green0(object sender, RoutedEventArgs e)
        {
            tens.Text = "green"; 
            col1 = 5;
            calculator(col1, col2, col3); 
        }

        private void blue0(object sender, RoutedEventArgs e)
        {
            tens.Text = "blue"; 
            col1 = 6;
            calculator(col1, col2, col3); 
        }

        private void purple0(object sender, RoutedEventArgs e)
        {
            tens.Text = "purple"; 
            col1 = 7;
            calculator(col1, col2, col3); 
        }

        private void gray0(object sender, RoutedEventArgs e)
        {
            tens.Text = "gray"; 
            col1 = 8;
            calculator(col1, col2, col3); 
        }

        private void white0(object sender, RoutedEventArgs e)
        {
            tens.Text = "white"; 
            col1 = 9;
            calculator(col1, col2, col3); 
        }

        private void black1(object sender, RoutedEventArgs e)
        {
            ones.Text = "black";
            col2 = 0;
            calculator(col1, col2, col3); 
        }

        private void brown1(object sender, RoutedEventArgs e)
        {
            ones.Text = "brown";
            col2 = 1;
            calculator(col1, col2, col3); 
        }

        private void red1(object sender, RoutedEventArgs e)
        {
            ones.Text = "red";
            col2 = 2;
            calculator(col1, col2, col3); 
        }

        private void orange1(object sender, RoutedEventArgs e)
        {
            ones.Text = "orange";
            col2 = 3;
            calculator(col1, col2, col3); 
        }

        private void yellow1(object sender, RoutedEventArgs e)
        {
            ones.Text = "yellow";
            col2 = 4;
            calculator(col1, col2, col3); 
        }

        private void green1(object sender, RoutedEventArgs e)
        {
            ones.Text = "green";
            col2 = 5;
            calculator(col1, col2, col3); 
        }

        private void blue1(object sender, RoutedEventArgs e)
        {
            ones.Text = "blue";
            col2 = 6;
            calculator(col1, col2, col3); 
        }

        private void purple1(object sender, RoutedEventArgs e)
        {
            ones.Text = "purple"; ;
            col2 = 7;
            calculator(col1, col2, col3); 
        }

        private void gray1(object sender, RoutedEventArgs e)
        {
            ones.Text = "gray";
            col2 = 8;
            calculator(col1, col2, col3); 
        }

        private void white1(object sender, RoutedEventArgs e)
        {
            ones.Text = "white";
            col2 = 9;
            calculator(col1, col2, col3); 
        }

        private void black2(object sender, RoutedEventArgs e)
        {
            multiplier.Text = "black"; 
           
            col3 = 0; //fix naming convention at some point
            calculator(col1, col2, col3); 
        }

        private void brown2(object sender, RoutedEventArgs e)
        {
            multiplier.Text = "brown"; 
            col3 = 1;
            calculator(col1, col2, col3); 
        }

        private void red2(object sender, RoutedEventArgs e)
        {
            multiplier.Text = "red"; 
            col3 = 2;
            calculator(col1, col2, col3); 
        }

        private void orange2(object sender, RoutedEventArgs e)
        {
            multiplier.Text = "orange"; 
            col3 = 3;
            calculator(col1, col2, col3); 
        }

        private void yellow2(object sender, RoutedEventArgs e)
        {
            multiplier.Text = "yellow"; 
            col3 = 4;
            calculator(col1, col2, col3); 
        }

        private void green2(object sender, RoutedEventArgs e)
        {
            multiplier.Text = "green"; 
            col3 = 5;
            calculator(col1, col2, col3); 
        }

        private void blue2(object sender, RoutedEventArgs e)
        {
            multiplier.Text = "blue"; 
            col3 = 6;
            calculator(col1, col2, col3); 
        }

        private void purple2(object sender, RoutedEventArgs e)
        {
            multiplier.Text = "purple"; 
            col3 = 7;
            calculator(col1, col2, col3); 
        }

        private void gray2(object sender, RoutedEventArgs e)
        {
            multiplier.Text = "gray"; 
            col3 = 8;
            calculator(col1, col2, col3); 
        }

        private void white2(object sender, RoutedEventArgs e)
        {
            multiplier.Text = "white"; 
            col3 = 9;
            calculator(col1, col2, col3); 
        }

        private void gold1(object sender, RoutedEventArgs e)
        {
            tolerance.Text = "gold";
            calculator(col1, col2, col3); 
            string tempVal =  result.Text;
            result.Text = tempVal + " ± 5%"; 
        }

        private void silver1(object sender, RoutedEventArgs e)
        {
            tolerance.Text = "silver";
            calculator(col1, col2, col3); 
            string tempVal = result.Text;
            result.Text = tempVal + " ± 10%"; 
        }

        

    }
}
