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
    public MainWindow()
    {
        InitializeComponent();
    }

   string currentOperator;
   string firstNumber;
    

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
            firstNumber = number;
        }
        else
        {
            Display.Text += number;
        }
        
        
    }
    

    
    private void OperatorButton_Click(object sender, RoutedEventArgs e)
    {
        

    }

    private void EnterButton_Click(object sender, RoutedEventArgs e)
    {
        throw new NotImplementedException();
    }
    
    private void ClearButton_Click(object sender, RoutedEventArgs e)
    {
        throw new NotImplementedException();
    }

    private void BackButton_Click(object sender, RoutedEventArgs e)
    {
        throw new NotImplementedException();
    }
}