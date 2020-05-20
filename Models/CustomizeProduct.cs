using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace E_Market1._1.Models
{
    [MetadataType(typeof(ProductMetaData))]
    public partial class Product
    {
        //add new property
    }
    public class ProductMetaData
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string name { get; set; }

        [Required]
        public Nullable<double> price { get; set; }


        public string image { get; set; }

        [Required]
        public string description { get; set; }


        [Required]
        [Display (Name ="Category")]
        public Nullable<int> category_id { get; set; }

        public virtual Category Category { get; set; }
    }
}