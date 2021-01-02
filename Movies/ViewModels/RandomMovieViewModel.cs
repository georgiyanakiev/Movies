using Movies.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Movies.ViewModels
{
    public class RandomMovieViewModel
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public int MembershipTypeId { get; set; }
        public DateTime Birthdate { get; set; }
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}