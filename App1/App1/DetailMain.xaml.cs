namespace AppInformeGranjas
{
    using Android.Widget;
    using App1;
    using AppInformeGranjas.Login;
    using AppInformeGranjas.View;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailMain : ContentPage
    {
        private string nombreUsuario;
        public static string NombreUsuario;
        User model2 = new User(NombreUsuario);
        
        public DetailMain()
        {
            nombreUsuario = model2.PruebaNombre();
            InitializeComponent();
           
            //Boton que redirige a vista formulario ViewMortalidad
            btnMort.Clicked += (sender, e) => {
                ((NavigationPage)this.Parent).PushAsync(new ViewMortalidad());
            };
            //Boton que redirige a vista formulario ViewBultosConsu
            btnBultos.Clicked += (sender, e) => {
                ((NavigationPage)this.Parent).PushAsync(new ViewBultosConsu());
            };
            //Boton que redirige a vista formulario ViewPesoPromedio
            btnPeso.Clicked += (sender, e) => {
                ((NavigationPage)this.Parent).PushAsync(new ViewPesoPromedio());
            }; 
        }
        public static string nombre = "";
       
        public User(string nombreU)
        {
            if (Application.Current.Properties.ContainsKey("name"))
            {
                var val = Application.Current.Properties["name"];
                nombre = val.ToString();
            }
            //nombre = AD_Login.NombreUsuario;
        }
        public string PruebaNombre()
        {
            return nombre;
        }
        void btnLogoutClick(object sender, EventArgs e)
        {
            App.Current.Logout();
        }
    }
}