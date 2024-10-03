using MiniFigs.Models;
using System.Diagnostics;
using System.Windows.Input;

namespace MiniFigs
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            ICommand refreshCommand = new Command(() =>
            {
                // Reload data
                charactersCollectionView.ItemsSource = Data.DataRepository.GetAllCharacters();

                refreshLabel.Text = "Refreshed @ " + DateTime.Now.ToShortTimeString();
                refreshView.IsRefreshing = false;
            });
            refreshView.Command = refreshCommand;
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

        private void OnLoadDataClicked(object sender, EventArgs e)
        {
            charactersCollectionView.ItemsSource = Data.DataRepository.GetAllCharacters();
        }

        private async void OnChangeSelectionModeClicked(object sender, EventArgs e)
        {
            string selectionMode = await DisplayActionSheet("Selectionmode:", "Cancel", null, "None", "Single", "Multiple");

            switch(selectionMode)
            {
                case "None":
                    charactersCollectionView.SelectionMode = SelectionMode.None;
                    break;
                case "Single":
                    charactersCollectionView.SelectionMode = SelectionMode.Single;
                    break;
                case "Multiple":
                    charactersCollectionView.SelectionMode = SelectionMode.Multiple;
                    break;
                default:
                    break;
            }
        }

        private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectionLabel.Text = string.Join(",", e.CurrentSelection.Cast<MiniFig>().Select(c => c.Name));
        }

        private void OnFavoriteSwipeItemInvoked(object sender, EventArgs e)
        {
            var swipeview = sender as SwipeItem;
            var item = swipeview.CommandParameter.ToString();
            swipeview.IconImageSource = "solidstar.svg";

            favouriteLabel.Text = $"Favorited {item}";
        }
    }
}
