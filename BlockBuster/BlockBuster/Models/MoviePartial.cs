using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlockBuster.Models
{
    [ModelMetadataType(typeof(MovieMetaData))]
    public partial class Movie
    {
    }

    public class MovieMetaData
    {
        [Display(Name = "Release Year")]
        public int ReleaseYear { get; set; }
    }
}
