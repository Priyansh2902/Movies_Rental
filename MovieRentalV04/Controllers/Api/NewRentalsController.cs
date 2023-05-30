//using MovieRentalV04.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Web.Http;
//using MovieRentalV04.Dtos;

//namespace MovieRentalV04.Controllers.Api
//{
//    public class NewRentalsController : ApiController
//    {
//        private ApplicationDbContext _context;

//        public NewRentalsController()
//        {
//            _context = new ApplicationDbContext();
//        }

//        [HttpPost]
//        public IHttpActionResult CreateNewRentals(NewRentalDto newRental)
//        {
//            var customer = _context.Customers.Single(
//                c => c.Id == newRental.CustomerId);

//            var movies = _context.Movies.Where(
//                m => newRental.MovieIds.Contains(m.Id)).ToList();

//            foreach (var movie in movies)
//            {
//                if (movie.NumberAvailable == 0)
//                    return BadRequest("Movie is not available.");

//                movie.NumberAvailable--;

//                var rental = new Rental
//                {
//                    Customer = customer,
//                    Movie = movie,
//                    DateRented = DateTime.Now
//                };

//                _context.Rentals.Add(rental);
//            }

//            _context.SaveChanges();

//            return Ok();
//        }
//    }
//}







using System;

using System.Linq;

using System.Web.Http;

using MovieRentalV04.Dtos;

using MovieRentalV04.Models;




namespace MovieRentalV04.Controllers.Api

{

    public class NewRentalsController : ApiController

    {

        private ApplicationDbContext _context;




        public NewRentalsController()

        {

            _context = new ApplicationDbContext();

        }




        [HttpPost]

        public IHttpActionResult CreateNewRentals(NewRentalDto newRental)

        {

            var customer = _context.Customers.Single(

                c => c.Id == newRental.CustomerId);




            var movies = _context.Movies.Where(

                m => newRental.MovieIds.Contains(m.Id)).ToList();




            foreach (var movie in movies)

            {

                //if (movie.NumberAvailable == 0)

                //    return BadRequest("Movie is not available.");




                //movie.NumberAvailable--;




                var rental = new Rental

                {

                    Customer = customer,

                    Movie = movie,

                    DateRented = DateTime.Now

                };




                _context.Rentals.Add(rental);

            }




            _context.SaveChanges();




            return Ok();

        }

    }

}





