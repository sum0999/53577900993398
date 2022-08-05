using CompilerDirectives.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace CompilerDirectives.Views
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