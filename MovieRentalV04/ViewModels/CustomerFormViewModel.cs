
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieRentalV04.Models;

namespace MovieRentalV04.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}