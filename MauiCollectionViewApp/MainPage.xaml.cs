namespace MauiCollectionViewApp
{
    public partial class MainPage : ContentPage
    {
        #region Tips

        public List<string> Tiles
        {
            get { return (List<string>)GetValue(TilesProperty); }
            set { SetValue(TilesProperty, value); }
        }

        public static readonly BindableProperty TilesProperty = BindableProperty.Create(
            nameof(Tiles),
            typeof(List<string>),
            typeof(MainPage),
            defaultValue: null, defaultBindingMode: BindingMode.OneWay);

        #endregion Tips

        public MainPage()
        {
            InitializeComponent();
            this.Tiles = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", };
        }


    }
}