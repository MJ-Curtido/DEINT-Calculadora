using Dangl.Calculator;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DEINT_Calculadora.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]

    public class CalculatorViewModel
    {
        public ICommand ClickCommand { get; set; }
        public String Formula { get; set; } = "0";
        public String Solution { get; set; } = "0";

        public CalculatorViewModel()
        {
            ClickCommand = new Command(async (pressed) =>
            {
                if (pressed.Equals("="))
                {
                    var calculation = Calculator.Calculate(Formula);

                    Solution = calculation.Result.ToString();
                } else
                {
                    if (pressed.Equals("⌫"))
                    {
                        if (Formula.Length > 0)
                        {
                            Formula = Formula.Substring(0, Formula.Length - 1);
                        }
                    } else
                    {
                        if (pressed.Equals("AC"))
                        {
                            Formula = "0";
                            Solution = "0";
                        }
                        else
                        {
                            Formula += pressed;
                        }
                    }
                }
            });
        }
    }
}
