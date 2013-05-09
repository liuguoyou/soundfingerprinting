﻿namespace Soundfingerprinting.Dao.Entities
{
    public class Track
    {
        private string artist;

        private string title;

        public Track()
        {
            // no op
        }

        public Track(int trackId, string artist, string title, int albumId)
        {
            Id = trackId;
            Artist = artist;
            Title = title;
            AlbumId = albumId;
        }

        public Track(int trackId, string artist, string title, int albumId, int trackLength)
            : this(trackId, artist, title, albumId)
        {
            TrackLengthSec = trackLength;
        }

        public int Id { get; set; }

        public string Artist
        {
            get
            {
                return artist;
            }

            set
            {
                artist = value.Length > 255 ? value.Substring(0, 255) : value;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value.Length > 255 ? value.Substring(0, 255) : value;
            }
        }

        public int AlbumId { get; set; }

        public int TrackLengthSec { get; set; }
    }
}