using DEINT_Calculadora.MVVM.ViewModels;

namespace DEINT_Calculadora.MVVM.Views;

public partial class CalculatorView : ContentPage
{
	public CalculatorView()
	{
		InitializeComponent();

		BindingContext =  new CalculatorViewModel();
	}
}