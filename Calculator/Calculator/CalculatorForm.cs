using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        private CalculatorEngine calculator=new CalculatorEngine();



        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void binaryOperationButton_Click(object sender, System.EventArgs e)
        {
            double number = double.Parse(inputTextBox.Text);
            Button operationButton = (Button) sender;
            string operation = operationButton.Text;
            
            calculator.Input(number);
            calculator.Input(operation);
            double result = calculator.GetResult();
            outputTextBox.Text = result.ToString();
            inputTextBox.Clear();

        }

        private void unaryOperationButton_Click(object sender, System.EventArgs e)
        {
            Button operationButton = (Button)sender;
            string operation = operationButton.Text;

            calculator.Input(operation);
            double result = calculator.GetResult();
            outputTextBox.Text = result.ToString();
            inputTextBox.Clear();

        }

        
    }
}
