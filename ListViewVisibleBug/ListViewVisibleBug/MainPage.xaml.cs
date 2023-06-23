namespace ListViewVisibleBug
{
    public partial class MainPage : ContentPage
    {
        MainPageViewModel viewModel = new MainPageViewModel();

        public MainPage()
        {
            InitializeComponent();

            BindingContext = viewModel;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            viewModel.Button_Clicked();
        }
    }
}