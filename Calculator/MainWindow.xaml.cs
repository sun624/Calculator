using System.Windows;
using System.Windows.Controls;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        decimal num1 = 0;
        decimal num2 = 0;
        string Operator = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void NumBtn_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;

            if (Display.Text == "0")
                Display.Text = btn.Content.ToString();
            else
                Display.Text += btn.Content.ToString();
        }

        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            num1 = num2 = 0;
            Operator = "";
            Display.Text = "0";
        }

        private void EqualBtn_Click(object sender, RoutedEventArgs e)
        {
            num2 = decimal.Parse(Display.Text.Remove(0,1));
            switch (Operator)
            {
                case "+":
                    Display.Text = (num1 + num2).ToString();
                    break;
                case "-":
                    Display.Text = (num1 - num2).ToString();
                    break;
            }
        }

        private void OperatorBtn_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            Operator = btn.Content.ToString();
            num1 = decimal.Parse(Display.Text);
            Display.Text = Operator;
        }
    }
}
