namespace rfeijooS1Tarea.Views;

public partial class viewApp : ContentPage
{
	public viewApp()
	{
		InitializeComponent();
	}

    private void btnAction_Clicked(object sender, EventArgs e)
    {
		string name =  txtName.Text;
		string last = txtLastName.Text;
		string age = nmbAge.Text;
		double salary = Convert.ToInt32(nmbsalary.Text);
		DisplayAlert("alert", "Bienvenido: " + name + " " + last + "\nTienes: " + age + "\nTu aporte mensual es: " + calculateIess(salary) + "a�os", "OK");

    }

	private double calculateIess(double salary)
	{
		return salary * 0.0945 ;
	}
}