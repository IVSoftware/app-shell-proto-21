using sqfa_shell_proto.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace sqfa_shell_proto.Views
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