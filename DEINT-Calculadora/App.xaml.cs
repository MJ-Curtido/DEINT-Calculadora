using DEINT_Calculadora.MVVM.Views;

namespace DEINT_Calculadora;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new CalculatorView();
	}
}
