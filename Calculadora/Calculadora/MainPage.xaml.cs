namespace Calculadora;
using Ecuations;
public partial class MainPage : ContentPage
{
	int count = 0;

    private Stack<bool> thereIsPoint = new Stack<bool>();
    public MainPage()
	{
		InitializeComponent();
        thereIsPoint.Push(false);
    }

	private void Erase(object sender, EventArgs e)
	{
		int length = resultText.Text.Length;


        if (length > 1)
		{	if(new Tokens().IsOperator(resultText.Text[length - 1].ToString()))
			{
				thereIsPoint.Pop();
			}
			if (resultText.Text[length-1] == '.')
			{
				thereIsPoint.Pop();
				thereIsPoint.Push(false);
			}

			resultText.Text = resultText.Text.Remove(resultText.Text.Length - 1, 1);
			return;
		}

		resultText.Text = "0";
	}


	

	private void ClearAll(object sender, EventArgs e)
	{
		resultText.Text = "0";
		thereIsPoint.Clear();
		thereIsPoint.Push(false);
	}

	private void ClickPoint(object sender, EventArgs e)
	{
		if (thereIsPoint.Peek())
		{
			return;
		}

		string lastChar = resultText.Text[resultText.Text.Length - 1].ToString();

		if(new Tokens().IsOperator(lastChar))
		{
            resultText.Text += "0.";
            thereIsPoint.Pop();
            thereIsPoint.Push(true);
			return;
        }

		resultText.Text += ".";
		thereIsPoint.Pop();
		thereIsPoint.Push(true);
	}

	private void ClickNumber(object sender, EventArgs e)
	{

		Button pressed = (Button)sender;

		if(resultText.Text == "0")
		{
			resultText.Text = pressed.Text;
			return;
		}

		resultText.Text += pressed.Text;
	}

    private void ClickOperation(object sender, EventArgs e)
    {

        Button pressed = (Button)sender;

        string lastChar = resultText.Text[resultText.Text.Length - 1].ToString();

        if (lastChar == ".")
		{
            resultText.Text += "0" + pressed.Text;
            thereIsPoint.Push(false);
			return;
        }

        if (new Tokens().IsOperator(lastChar))
        {	if(pressed.Text == "-" && (lastChar != "+"||lastChar != "-"))
			{
                resultText.Text += pressed.Text;
                thereIsPoint.Push(false);
            }

            return;
        }

        resultText.Text += pressed.Text;
		thereIsPoint.Push(false);
    }

	public string ValidExpression(string operation)
	{
		int length = operation.Length - 1;

		if (Char.IsDigit(operation[length]))
		{
			return operation;
		}

		if (operation[length] == '*' || operation[length] == '/' || operation[length] == '^' )
		{
			return operation + "1";
        }

		return operation + "0";
	}

	private void ClickResult(object sender, EventArgs e)
	{


		List<string> tokens = new Tokens().Convert(ValidExpression(resultText.Text));
		Queue<string> rpnForm = new InfixToRpn().Convert(tokens);
		resultText.Text = new ResolveRpn().Convert(rpnForm);
	}


    private void OnCounterClicked(object sender, EventArgs e)
	{
		
	}
}

