using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MovieRentalV04.Models;

namespace MovieRentalV04.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Please Enter Customer's  Name")]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; }

        public byte MembershipTypeId { get; set; }

        //[Display(Name = "Date OF Birth")]
        [Min18YearsIfAMember]
        [DataType(DataType.Date)]
        public DateTime? Birthdate { get; set; }   
    }
}