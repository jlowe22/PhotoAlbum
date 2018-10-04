using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Media.Imaging;
using System.Windows.Media;

namespace LessThanThreeColonCloseParentheses
{
    class AlbumModel
    {
        private static String folderName;
        private static String pathToFolder; //TODO: determine if this will work after publishing and on other
        private static int albumSize;       //people's machines

        public AlbumModel()
        {

        }

        public AlbumModel(string folder)
        {
            folderName = folder;
            pathToFolder = "C:\\Users\\jonat\\source\\repos\\LessThanThreeColonCloseParentheses\\LessThanThreeColonCloseParentheses\\bin\\Debug" + "\\" + folderName;
            albumSize = 0;
        }

        public List<String> getAlbumList()
        {
            albumSize = Directory.GetFiles(pathToFolder, "*.png", SearchOption.AllDirectories).ToList<String>()
                .Count;
            return Directory.GetFiles(pathToFolder, "*.png", SearchOption.AllDirectories).ToList<String>();
        }

    }   

    //TODO: add pictures to folders, see if it works, figure out indexoutofbounds protections, make it pretty
    //figure out different directory name issue
}
