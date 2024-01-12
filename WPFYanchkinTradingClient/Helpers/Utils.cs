using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace WPFYanchkinTradingClient.Helpers
{
    /// <summary>
    /// Полезные утилиты
    /// </summary>
    public static class Utils
    {
        /// <summary>
        /// Получение BitmapImage из HttpResponseMessage
        /// </summary>
        /// <param name="responce"></param>
        /// <returns></returns>
        public async static Task<BitmapImage> BitmapImageFromHttpResponce(HttpResponseMessage responce)
        {
            var bitmap = new BitmapImage();
            if (responce == null)
                return bitmap;

            if (responce.IsSuccessStatusCode)
            {
                bitmap.BeginInit();
                bitmap.StreamSource = await responce.Content.ReadAsStreamAsync();
                bitmap.EndInit();
            }
            return bitmap;
        }
    }
}
