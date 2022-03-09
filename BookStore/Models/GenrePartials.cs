﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookStore.Models
{
    [ModelMetadataType(typeof(GenreMetaData))]
    public partial class Genre
    {

    }

    public class GenreMetaData
    {
        [Display(Name = "Genre Description")]
        public string GenreType { get; set; }

    }
}
