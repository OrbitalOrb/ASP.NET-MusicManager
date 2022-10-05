﻿using System.ComponentModel.DataAnnotations;

namespace MusicManager.Models
{
    public class Album
    {
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Label { get; set; }
        [Required]
        public string? Genre { get; set; }
        [Required]
        public DateTime? ReleaseDate { get; set; }
        public string? Fact { get; set; }
        [Required]
        public virtual ICollection<Artist> Artists { get; set; }
    }
}
