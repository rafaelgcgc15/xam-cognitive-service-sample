using Microsoft.ProjectOxford.Face;
using Microsoft.ProjectOxford.Face.Contract;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace xam_cognitive
{
    public partial class MainPage : ContentPage
    {
        private readonly IFaceServiceClient _faceServiceClient;
        ObservableCollection<Face> list = new ObservableCollection<Face>();
        public MainPage()
        {
            InitializeComponent();

            _faceServiceClient = new FaceServiceClient("a7cff5bb619b4b3e8df3dd14eefcb57c", "https://westcentralus.api.cognitive.microsoft.com/face/v1.0/detect");

            list = new ObservableCollection<Face>();
            FacesListView.ItemsSource = list;
        }
    }
}
