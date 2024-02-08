using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{

    private double firstNumber = 0;
    private string? currentOperator = "";
    private bool isOperationPerformed = false;
    public MainWindow()
    {
        InitializeComponent(); 
    }


    

    private void NumberButton_Click(object sender, RoutedEventArgs e)
    {
        var button = (Button)sender;
        var number = button.Content.ToString();

        if (number == null)
        {
            return;
        }
        if (Display.Text == "0")
        {
            Display.Text = number;

        }
        else
        {
            Display.Text += number;
        }
        
        
    }
    

    
    private void OperatorButton_Click(object sender, RoutedEventArgs e)
    {
        var button = (Button)sender;
        if (button.Content.ToString() != "=" && Display.Text != "0")
        {
            firstNumber = Double.Parse(Display.Text);
            currentOperator = button.Content.ToString();
            isOperationPerformed = true;
            Display.Text = "0";
        }
    }

    private void EnterButton_Click(object sender, RoutedEventArgs e)
    {
        switch (currentOperator)
        {
            case "+":
                Display.Text = (firstNumber + Double.Parse(Display.Text)).ToString();
                break;
            case "-":
                Display.Text = (firstNumber - Double.Parse(Display.Text)).ToString();
                break;
            case "*":
                Display.Text = (firstNumber * Double.Parse(Display.Text)).ToString();
                break;
            case "/":
                Display.Text = (firstNumber / Double.Parse(Display.Text)).ToString();
                break;
        }

        isOperationPerformed = false;
    }
    
    private void ClearButton_Click(object sender, RoutedEventArgs e)
    {
        Display.Text = "0";
        firstNumber = 0;
        currentOperator = "";
        isOperationPerformed = false;
    }

    private void BackButton_Click(object sender, RoutedEventArgs e)
    {
        if (Display.Text.Length > 1)
        {
            Display.Text = Display.Text.Substring(0, Display.Text.Length - 1);
        }
        else
        {
            Display.Text = "0";
        }
    }
}