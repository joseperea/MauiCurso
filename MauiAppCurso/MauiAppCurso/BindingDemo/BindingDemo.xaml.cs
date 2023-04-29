namespace MauiAppCurso.BindingDemo;

public partial class BindingDemo : ContentPage
{
	public BindingDemo()
	{
		InitializeComponent();
	}

    private void btnOk_Clicked(object sender, EventArgs e)
    {
		var person = new Person 
		{
			Name= "Jose Perea",
			Phone= "3177965608",
			Address = "Calle 12 # 45-47"
		};

        BindingContext = person;

        //lblName.BindingContext = person;
        //lblName.SetBinding(Label.TextProperty, "Name");



        //var personBinding = new Binding();
        //personBinding.Source = person;
        //personBinding.Path = "Name";

        //lblName.SetBinding(Label.TextProperty, personBinding);
    }
}