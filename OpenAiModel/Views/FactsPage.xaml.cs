namespace OpenAiModel.Views;
using OpenAiModel.ViewModels;
using OpenAiModel.Views;

public partial class FactsPage : ContentPage
{
    FactViewModel _viewModel;
    public FactsPage(FactViewModel vm)
    {
        _viewModel = vm;
        InitializeComponent();
        BindingContext = _viewModel;
    }
}