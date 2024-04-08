using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Media;

namespace Caluladora;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
        ACButton = this.FindControl<Button>("ACButton");
        PercentButton = this.FindControl<Button>("PercentButton");
        SumaButton = this.FindControl<Button>("SumaButton");
        FactorialButton = this.FindControl<Button>("FactorialButton");
        _7CButton = this.FindControl<Button>("_7CButton");
        _8CButton = this.FindControl<Button>("_8CButton");
        _9CButton = this.FindControl<Button>("_9CButton");
        XBButton = this.FindControl<Button>("XBButton");
        _4CButton = this.FindControl<Button>("_4CButton");
        _5CButton = this.FindControl<Button>("_5CButton");
        _6CButton = this.FindControl<Button>("_6CButton");
        LessCButton = this.FindControl<Button>("LessCButton");
        _1CButton = this.FindControl<Button>("_1CButton");
        _2CButton = this.FindControl<Button>("_2CButton");
        _3Button = this.FindControl<Button>("_3Button");
        PlusButton = this.FindControl<Button>("ACButton");
        ZeroButton = this.FindControl<Button>("ACButton");
        DotButton = this.FindControl<Button>("ACButton");
        EqualButton = this.FindControl<Button>("ACButton");
        resultLabel = this.FindControl<Label>("resultLabel");
    }

    public string input;
    private float temp = 0;
    private float tempB;
    private bool suma;
    private bool resta;
    private bool division;
    private bool multiplicacion;
    
    private void ACButton_OnClick(object? sender, RoutedEventArgs e)
    {
        temp = 0;
        input = "";
        resultLabel.Content = input;
    }

    private void PercentButton_OnClick(object? sender, RoutedEventArgs e)
    {
        float.TryParse(input, out float inputInt);
        float result = inputInt/100;
        input = result.ToString();
        resultLabel.Content = input;
    }

    private void SumaButton_OnClick(object? sender, RoutedEventArgs e)
    {
        double.TryParse(input, out double valor);
        if (valor == 0)
        {
            temp = 1;
        }
        else
        {
            float result = 1;
            for (int i = 1; i <= valor; i++)
            {
                result += i;
            }
            temp = result;
        }

        input = temp.ToString();
        resultLabel.Content = input;
    }

    private void FactorialButton_OnClick(object? sender, RoutedEventArgs e)
    {
        double.TryParse(input, out double valor);
        if (valor == 0)
        {
            temp = 1;
        }
        else
        {
            float result = 1;
            for (int i = 1; i <= valor; i++)
            {
                result *= i;
            }
            temp = result;
        }

        input = temp.ToString();
        resultLabel.Content = input;
    }

    private void DivButton_OnClick(object? sender, RoutedEventArgs e)
    {
        float.TryParse(input, out float inputInt);
        if (inputInt != 0) // To prevent division by zero
        {
            temp = inputInt;
            float resultado = temp / tempB;
            input = "";
            resultLabel.Content = resultado.ToString();
            division = true;
        }
        else
        {
            resultLabel.Content = "ERROR";
        }
    }

    private void _7CButton_OnClick(object? sender, RoutedEventArgs e)
    {
        input += "7";
        resultLabel.Content = input;
        float.TryParse(input, out float tempB);
    }

    private void _8CButton_OnClick(object? sender, RoutedEventArgs e)
    {
        input += "8";
        resultLabel.Content = input;
        float.TryParse(input, out float tempB);
    }

    private void _9CButton_OnClick(object? sender, RoutedEventArgs e)
    {
        input += "9";
        resultLabel.Content = input;
        float.TryParse(input, out float tempB);
    }

    private void XBButton_OnClick(object? sender, RoutedEventArgs e)
    { 
        float.TryParse(input, out float inputInt);
        input = "";
        float.TryParse(input, out float tempB);
        temp = inputInt;
        float resultado = temp * tempB;
        input = "";
        resultLabel.Content = resultado.ToString();
        multiplicacion = true;
    }

    private void _4CButton_OnClick(object? sender, RoutedEventArgs e)
    {
        input += "4";
        resultLabel.Content = input;
        float.TryParse(input, out float tempB);
    }

    private void _5CButton_OnClick(object? sender, RoutedEventArgs e)
    {
        input += "5";
        resultLabel.Content = input;
        float.TryParse(input, out float tempB);
    }

    private void _6CButton_OnClick(object? sender, RoutedEventArgs e)
    {
        input += "6";
        resultLabel.Content = input;
        float.TryParse(input, out float tempB);
    }

    private void LessCButton_OnClick(object? sender, RoutedEventArgs e)
    {
        float.TryParse(input, out float inputInt);
        inputInt = (inputInt) * -1;
        temp -= inputInt;
        input = "";
        resultLabel.Content = (temp*-1).ToString();
        resta = true;
    }

    private void _1CButton_OnClick(object? sender, RoutedEventArgs e)
    {
        input += "1";
        resultLabel.Content = input;
        float.TryParse(input, out float tempB);
    }

    private void _2CButton_OnClick(object? sender, RoutedEventArgs e)
    {
        input += "2";
        resultLabel.Content = input;
        float.TryParse(input, out float tempB);
    }

    private void _3Button_OnClick(object? sender, RoutedEventArgs e)
    {
        input += "3";
        resultLabel.Content = input;
        float.TryParse(input, out float tempB);
    }

    private void PlusButton_OnClick(object? sender, RoutedEventArgs e)
    {
        float.TryParse(input, out float inputInt);
        temp += inputInt;
        input = "";
        resultLabel.Content = temp.ToString();
        suma = true;
    }

    private void ZeroButton_OnClick(object? sender, RoutedEventArgs e)
    {
        input += "0";
        resultLabel.Content = input;
    }

    private void DotButton_OnClick(object? sender, RoutedEventArgs e)
    {
        input += ".";
        resultLabel.Content = input;
    }

    private void EqualButton_OnClick(object? sender, RoutedEventArgs e)
    {
        if (suma)
        {
            float.TryParse(input, out float inputInt);
            temp += inputInt;
            input = "";
            resultLabel.Content = (temp*-1).ToString();
            suma = false;
        }
        if (resta)
        {
            float.TryParse(input, out float inputInt);
            temp -= inputInt;
            input = "";
            resultLabel.Content = (temp*-1).ToString();
            resta = false;
        }

        if (multiplicacion)
        {
            float.TryParse(input, out float inputInt);
            temp = inputInt;
            float resultado = temp * tempB;
            input = "";
            resultLabel.Content = resultado.ToString();
            multiplicacion = false;
        }
        
        if (division)
        {
            float.TryParse(input, out float inputInt);
            if (inputInt != 0) // To prevent division by zero
            {
                temp = inputInt;
                float resultado = temp / tempB;
                input = "";
                resultLabel.Content = resultado.ToString();
                division = false;
            }
            else
            {
                resultLabel.Content = "ERROR";
            }
        }
        resultLabel.Content = temp.ToString();
    }
}