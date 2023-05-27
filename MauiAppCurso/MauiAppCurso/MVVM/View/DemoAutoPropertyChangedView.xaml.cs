using MauiAppCurso.MVVM.ViewModels;

namespace MauiAppCurso.MVVM.View;

public partial class DemoAutoPropertyChangedView : ContentPage
{
	public DemoAutoPropertyChangedView()
	{
		InitializeComponent();
		BindingContext = new DemoAutoPropertyChangedViewModel();
	}
}