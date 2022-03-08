using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlockBuster.Models
{
    [ModelMetadataType(typeof(CustomerMetaData))]
    public partial class Customer
    {

    }

    public class CustomerMetaData
    {
        [Display(Name ="Phone Number")]
        public string PhoneNumber { get; set; }
    }
}
