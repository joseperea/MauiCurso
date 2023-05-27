using MauiAppCurso.MVVM.View;

namespace MauiAppCurso;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        //var navPage = new NavigationPage(new ContentPageDemo());
        //      navPage.BarBackgroundColor = Colors.Chocolate;
        //      navPage.BarTextColor = Colors.White;
        //      navPage.Title = "Demo Curso";
        //      MainPage = navPage;

        MainPage = new NavigationPage(new StyleDemoView());
    }
}
