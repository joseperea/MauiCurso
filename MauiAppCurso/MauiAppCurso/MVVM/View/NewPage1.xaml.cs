using MauiAppCurso.MVVM.ViewModels;

namespace MauiAppCurso.MVVM.View;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
		BindingContext = new CommandsViewModel();
	}
}