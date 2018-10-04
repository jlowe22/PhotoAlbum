using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace LessThanThreeColonCloseParentheses
{
    class ViewModel : INotifyPropertyChanged
    {
        public List<List<String>> albumList = new List<List<String>>();
        public int pictureIndex = 0;
        public int albumIndex = 0;
        public Image picture;

        public ViewModel()
        {
            picture = new Image();
            albumList.Add(new AlbumModel("Snapchats").getAlbumList());
            albumList.Add(new AlbumModel("HomecomingAndProm").getAlbumList());
            albumList.Add(new AlbumModel("SeniorYear").getAlbumList());
            albumList.Add(new AlbumModel("Disney").getAlbumList());

        }

        public event PropertyChangedEventHandler PropertyChanged;
        public ImageSource currentImageSource = new BitmapImage(new Uri("C:\\Users\\jonat\\source\\repos\\LessThanThreeColonCloseParentheses\\LessThanThreeColonCloseParentheses\\bin\\Debug\\Cover.jpg")); 
        public ImageSource CurrentImageSource
        {
            get { return currentImageSource; }
            set
            {
                currentImageSource = value;
                OnPropertyChanged("CurrentImageSource");
            }
        }

        public int AlbumIndex
        {
            get { return albumIndex; }
            set
            {
                albumIndex = value;
                OnPropertyChanged("AlbumIndex");
                pictureIndex = 0;
                this.CurrentImageSource = new BitmapImage(new Uri(albumList[albumIndex][pictureIndex]));
            }
        }

        public int PictureIndex
        {
            get { return pictureIndex; }
            set
            {
                pictureIndex = value;
                OnPropertyChanged("PictureIndex");
                this.CurrentImageSource = new BitmapImage(new Uri(albumList[albumIndex][pictureIndex]));
            }
        }

      //public void NotifyPropertyChanged(string propertyName)
      //{
      //    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
      //}

        private void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
//https://docs.microsoft.com/en-us/dotnet/framework/wpf/data/how-to-create-a-binding-in-code