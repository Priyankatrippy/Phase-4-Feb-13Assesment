using SpecFlowProject2.Support;

[Binding]
public class CalculatorStepsDefinitions
{
    private readonly Calculator _calculator;
    private int _result;

    public CalculatorStepsDefinitions()
    {
        _calculator = new Calculator();
    }

    [Given(@"I have entered (.*) into the calculator")]
    public void GivenIHaveEnteredIntoTheCalculator(int number)
    {
        _calculator.EnterNumber(number);
    }

    [When(@"I press multiply")]
    public void WhenIPressMultiply()
    {
        _result = _calculator.Multiply();
    }

    [Then(@"the result should be (.*) on the screen")]
    public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
    {
        Assert.Equal(expectedResult, _result);
    }
}
