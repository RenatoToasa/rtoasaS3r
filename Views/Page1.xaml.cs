namespace rtoasaS3r.Views;

public partial class Page1 : ContentPage
{
	public Page1()
	{
		InitializeComponent();
	}

    private void btnAbrir_Clicked(object sender, EventArgs e)
    {
		int dato1 = Convert.ToInt32(txtDato1.Text);
		string dato2= txtDato2.Text;
		Navigation.PushAsync(new Page2(dato1,dato2));
    }
}