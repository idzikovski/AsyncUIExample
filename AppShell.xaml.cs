namespace AsyncUIExample
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("slow", typeof(SlowUIPage));
        }
    }
}
