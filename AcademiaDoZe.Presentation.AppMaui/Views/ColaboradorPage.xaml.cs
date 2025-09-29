//Roberto Antunes Souza
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcademiaDoZe.Presentation.AppMaui.ViewModels;
namespace AcademiaDoZe.Presentation.AppMaui.Views;
public partial class ColaboradorPage : ContentPage
{
    public ColaboradorPage(ColaboradorViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();

        if (BindingContext is ColaboradorViewModel viewModel)

        {
            await viewModel.InitializeAsync();
        }
    }
}