using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using Xamarin.Forms;

namespace exploreMostar.Mobile.Converters
{
  public  class ImageConverter : IValueConverter
    {
        private readonly APIService _service = new APIService("Korisnici");

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (APIService.PutanjaSlike == null)
                return null;

            //byte[] bytes = value as byte[];
            // var file = File.ReadAllBytes(APIService.PutanjaSlike);

            //bytes = Encoding.ASCII.GetBytes(APIService.PutanjaSlike);

            ////var request = file;


            //Func <Stream> myFunc = () => new MemoryStream(bytes);

            //return ImageSource.FromUri(new Uri(APIService.PutanjaSlike)); 
            byte[] bytes = value as byte[];

            Func<Stream> myFunc = () => new MemoryStream(bytes);

            return ImageSource.FromStream(myFunc);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
