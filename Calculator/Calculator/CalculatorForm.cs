using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        private readonly CalculatorEngine calculator = new CalculatorEngine();

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void binaryOperationButton_Click(object sender, System.EventArgs e)
        {
            double number = GetInput();
            string operation = GetOperation(sender);

            calculator.Input(number.ToString());
            calculator.Input(operation);
            double result = calculator.GetResult();

            DisplayResult(result);
            inputTextBox.Clear();
        }

        private void unaryOperationButton_Click(object sender, System.EventArgs e)
        {
            string operation = GetOperation(sender);

            calculator.Input(operation);
            double result = calculator.GetResult();

            DisplayResult(result);
        }

        private string GetOperation(object sender)
        {
            Button operationButton = (Button)sender;
            return operationButton.Text;
        }

        private void DisplayResult(double result)
        {
            outputTextBox.Text = result.ToString();
        }

        private double GetInput()
        {
            return double.Parse(inputTextBox.Text);
        }
    }
}
