using MauiAppCurso.MVVM.ViewModels;

namespace MauiAppCurso.MVVM.View;

public partial class PeopleView : ContentPage
{
	public PeopleView()
	{
		InitializeComponent();
        BindingContext = new PeopleViewModel();
    }
}