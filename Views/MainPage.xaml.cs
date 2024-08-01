using EcrOneClick.DI;
using EcrOneClick.ViewModels;

namespace EcrOneClick.Views;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = ServiceHelper.GetService<MainViewModel>();
    }
}