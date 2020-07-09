using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.Data
{
    public class DataRepoistory
    {
        public static AlbumData Album { get; } = new AlbumData();
        public static ArtistData Artist { get; } = new ArtistData();
        public static GenreData Genre { get; } = new GenreData();
        public static PlaylistData Playlist { get; } = new PlaylistData();
        public static PlaylistTrackData playlistTrack { get; } = new PlaylistTrackData();
        public static TrackData Track { get; } = new TrackData();
    }
}
