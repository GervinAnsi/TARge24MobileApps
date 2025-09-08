using SciCalc.ViewModels;

namespace SciCalc.Views;

public partial class CalculatorPage : ContentView
{
	public CalculatorPage()
	{
		InitializeComponent();

		this.BindingContext = new CalculatorPageViewModel();
	}

    public static implicit operator Page(CalculatorPage v)
    {
        throw new NotImplementedException();
    }
}