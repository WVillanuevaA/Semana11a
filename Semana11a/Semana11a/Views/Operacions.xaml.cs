using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Semana11a.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana11a.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Operacions : ContentPage
    {
        public Operacions()
        {
            InitializeComponent();

            this.BindingContext = new ViewModelOperaciones();
        }
    }
}