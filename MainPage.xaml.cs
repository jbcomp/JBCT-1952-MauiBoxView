namespace MauiBoxView
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void WidthButton1_Clicked(object sender, EventArgs e) => BoxView1.WidthRequest = 100;

        private void WidthButton2_Clicked(object sender, EventArgs e) => BoxView2.WidthRequest = 100;

        private void ThemeButton_Clicked(object sender, EventArgs e)
            => Application.Current!.UserAppTheme = Application.Current!.UserAppTheme == AppTheme.Dark
                                                   ? AppTheme.Light : AppTheme.Dark;

    }
}
