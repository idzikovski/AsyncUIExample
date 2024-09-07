namespace AsyncUIExample;

public partial class VerySlowView : ContentView
{
    public static readonly BindableProperty ColorProperty =
          BindableProperty.Create(nameof(Color),
                                  typeof(Color),
                                  typeof(VerySlowView));

    public Color Color
    {
        get => (Color)GetValue(ColorProperty);
        set => SetValue(ColorProperty, value);
    }

    public VerySlowView()
	{
		var delay = Task.Delay(1000);
		delay.Wait();
		InitializeComponent();
	}
}