using System.Windows;

namespace WpfApp8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        double numbers1 = 0;
        double numbers2 = 0;
       
        string operation = "";
        bool plusButtonClicked = false;
        bool subButtonClicked = false;
        bool multButtonClicked = false;
        bool divButtonClicked = false;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void But1_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                numbers1 = (numbers1 * 10) + 1;
                txtDisplay.Text = numbers1.ToString();

            }
            else
            {
                numbers2 = (numbers2 * 10) + 1;
                txtDisplay.Text = numbers2.ToString();

            }
        }
        private void But2_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                numbers1 = (numbers1 * 10) + 2;
                txtDisplay.Text = numbers1.ToString();

            }
            else
            {
                numbers2 = (numbers2 * 10) + 2;
                txtDisplay.Text = numbers2.ToString();

            }

        }

        private void But3_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                numbers1 = (numbers1 * 10) + 3;
                txtDisplay.Text = numbers1.ToString();

            }
            else
            {
                numbers2 = (numbers2 * 10) + 3;
                txtDisplay.Text = numbers2.ToString();

            }

        }

        private void But4_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                numbers1 = (numbers1 * 10) + 4;
                txtDisplay.Text = numbers1.ToString();

            }
            else
            {
                numbers2 = (numbers2 * 10) + 4;
                txtDisplay.Text = numbers2.ToString();

            }

        }

        private void But5_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                numbers1 = (numbers1 * 10) + 5;
                txtDisplay.Text = numbers1.ToString();

            }
            else
            {
                numbers2 = (numbers2 * 10) + 5;
                txtDisplay.Text = numbers2.ToString();

            }

        }

        private void But6_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                numbers1 = (numbers1 * 10) + 6;
                txtDisplay.Text = numbers1.ToString();

            }
            else
            {
                numbers2 = (numbers2 * 10) + 6;
                txtDisplay.Text = numbers2.ToString();

            }
        }

        private void But7_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                numbers1 = (numbers1 * 10) + 7;
                txtDisplay.Text = numbers1.ToString();

            }
            else
            {
                numbers2 = (numbers2 * 10) + 7;
                txtDisplay.Text = numbers2.ToString();

            }
        }

        private void But8_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                numbers1 = (numbers1 * 10) + 8;
                txtDisplay.Text = numbers1.ToString();

            }
            else
            {
                numbers2 = (numbers2 * 10) + 8;
                txtDisplay.Text = numbers2.ToString();

            }
        }

        private void But9_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                numbers1 = (numbers1 * 10) + 9;
                txtDisplay.Text = numbers1.ToString();

            }
            else
            {
                numbers2 = (numbers2 * 10) + 9;
                txtDisplay.Text = numbers2.ToString();

            }
        }

        private void But0_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                numbers1 = (numbers1 * 10);
                txtDisplay.Text = numbers1.ToString();

            }
            else
            {
                numbers2 = (numbers2 * 10);
                txtDisplay.Text = numbers2.ToString();

            }
        }



        private void ButPlus_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            txtDisplay.Text = "0";
        }

        private void ButMinus_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            txtDisplay.Text = "0";
        }

        private void ButYmnojenie_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            txtDisplay.Text = "0";
        }

        private void ButDelenie_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            txtDisplay.Text = "0";
        }

        private void ButPovno_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "+":
                    txtDisplay.Text = (numbers1 + numbers2).ToString();
                    break;

                case "-":
                    txtDisplay.Text = (numbers1 - numbers2).ToString();
                    break;

                case "*":
                    txtDisplay.Text = (numbers1 * numbers2).ToString();
                    break;

                case "/":
                    txtDisplay.Text = (numbers1 / numbers2).ToString();
                    break;


            }
        }

        private void ButCleEnt_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                numbers1 = 0;
            }
            else
            {
                numbers2 = 0;
            }
            txtDisplay.Text = "0";
        }

        private void BackSpace_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                numbers1 = (numbers1 / 10);
                txtDisplay.Text = numbers1.ToString();

            }
            else
            {
                numbers2 = (numbers2 / 10);
                txtDisplay.Text = numbers2.ToString();

            }
        }

        private void ButClear_Click(object sender, RoutedEventArgs e)
        {
            numbers1 = 0;
            numbers2 = 0;
            operation = "";
            txtDisplay.Text = "0";
        }

        private void ButPlusandMinus_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                numbers1 *= -1;
                txtDisplay.Text = numbers1.ToString();

            }
            else
            {
                numbers2 *= -1;
                txtDisplay.Text = numbers2.ToString();

            }
        }

        private void ButZapatya_Click(object sender, RoutedEventArgs e)
        {

          

        }

        private void txtDisplay_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }
    }   }