using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookStore.Models
{
    [ModelMetadataType(typeof(BookMetaData))]
    public partial class Book
    {

    }

    public class BookMetaData
    {
        [Display(Name = "Book Title")]
        public string BookTitle { get; set; }

        [Display(Name = "Release Year")]
        public short YearOfRelease { get; set; }

    }
}
