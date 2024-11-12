using MusicStore.Models;

namespace MusicStore.ViewModels
{
    public class ArtistViewModel
    {
        public List<Album> Album { get; set; } = new List<Album>();
        public List<Artist> Artist { get; set; } = new List<Artist>();
    }
}
