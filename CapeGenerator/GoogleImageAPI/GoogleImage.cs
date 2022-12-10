using Google.API.Search;

namespace CapeGenerator.GoogleImageAPI
{
    internal class GoogleImage
    {
        GimageSearchClient client = new GimageSearchClient("berserk");

        public void GetImages()
        {
            var image = client.Search("besserk logo", 1);
        }
    }
}
