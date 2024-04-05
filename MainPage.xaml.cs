namespace dquimbitaT1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnRevisar_Clicked(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            String apellido = txtApellido.Text; 
            String edad = txtEdad.Text; 
            double sueldo = Convert.ToDouble(txtSalario.Text);
            double consulta = (sueldo * 9.45) / 100;
            DisplayAlert("Alerta","Estimado: " + nombre+" "+apellido +"\n Edad: "+edad+" \n Aporte IESS: "+consulta, "Cerrar");
        }
    }
}