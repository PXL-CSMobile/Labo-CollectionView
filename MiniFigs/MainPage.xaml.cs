namespace MiniFigs
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            charactersCollectionView.ItemsSource = Data.DataRepository.GetAllCharacters();
        }

        private List<string> GetData()
        {
            return new List<string>
            {
                "Bard",
                "Bilbo",
                "Elrond",
                "Galadriel",
                "Gandalf",
                "Gollum",
                "Legolas",
                "Sam"
            };
        }
    }
}
