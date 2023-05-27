using MauiAppCurso.MVVM.Models;
using MauiAppCurso.MVVM.ViewModels;

namespace MauiAppCurso.MVVM.View;

public partial class PersonView : ContentPage
{
	public PersonView()
	{
		InitializeComponent();

		BindingContext= new PersonViewModel();
	}
}