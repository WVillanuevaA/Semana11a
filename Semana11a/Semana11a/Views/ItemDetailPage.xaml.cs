using System.ComponentModel;
using Semana11a.ViewModels;
using Xamarin.Forms;

namespace Semana11a.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}