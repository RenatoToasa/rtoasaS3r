namespace rtoasaS3r.Views;

public partial class Page2 : ContentPage
{
	int globaldato1;
	string glogaldato2;
	public Page2(int dato1, string dato2)
	{
		InitializeComponent();
		txtDato1.Text = dato1.ToString();
		txtDato2.Text= dato2;

		DisplayAlert("ALERTA", "DATO1: "+dato1+" DATO2: "+dato2, "CERRAR");
		
		globaldato1 = dato1;
		glogaldato2 = dato2;
	}


}