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
        public String Formula { get; set; }
        public String Solucion { get; set; }

        public CalculatorViewModel()
        {
            ClickCommand = new Command(async (pulsado) =>
            {
                if (pulsado.Equals("="))
                {

                } else
                {
                    if (pulsado.Equals("⌫"))
                    {

                    } else
                    {
                        if (pulsado.Equals("AC"))
                        {
                            Formula = "";
                            Solucion = "";
                        }
                        else
                        {
                            Formula += pulsado;
                        }
                    }
                }
            });
        }
    }
}
