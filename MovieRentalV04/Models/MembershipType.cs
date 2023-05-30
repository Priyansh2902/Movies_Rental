using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace MovieRentalV04.Models
{
    public class MembershipType
    {

        public byte Id { get; set; }

        public string Name { get; set; }
        public short SignUpfee { get; set; }
        public byte DurationInMonths { get; set; }
       
        public byte DiscountRate { get; set;}

        public static readonly byte Unknown = 0;
        public static readonly byte PayAsYouGo = 1;
    }
}