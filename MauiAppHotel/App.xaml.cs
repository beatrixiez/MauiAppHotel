namespace MauiAppHotel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = new Window(new Views.ContratacaoHospedagem())
            {
                Width = 400,
                Height = 700
            };

            return window;
        }
    }
}