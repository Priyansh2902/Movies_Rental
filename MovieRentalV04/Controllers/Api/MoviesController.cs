using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;
using System.Web.Mvc;
using MovieRentalV04.Dtos;
using MovieRentalV04.Models;




namespace MovieRentalV04.Controllers.Api
{
    public class MoviesController : ApiController
    {
        private ApplicationDbContext _context;



        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }


        public IEnumerable<MovieDto> GetMovies()
        {
            return _context.Movies
                .Include(m => m.Genre)
                .ToList()
                .Select(Mapper.Map<Movie, MovieDto>);
        }
        

        //public IEnumerable<MovieDto> GetMovies(string query = null)
        //{
        //    var movieQuery = _context.Movies
        //        .Include(m => m.Genre)
        //        .Where(m => m.NumberAvailable > 0);

        //    if (!string.IsNullOrWhiteSpace(query))
        //        movieQuery = movieQuery.Where(m => m.Name.Contains(query));



        //    return _context.Movies
            
        //    .ToList()
        //    .Select(Mapper.Map<Movie, MovieDto>);
        //}



        public IHttpActionResult GetMovie(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);



            if (movie == null)
                return NotFound();



            return Ok(Mapper.Map<Movie, MovieDto>(movie));
        }



        [System.Web.Http.HttpPost]
        public IHttpActionResult CreateMovie(MovieDto movieDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();



            var movie = Mapper.Map<MovieDto, Movie>(movieDto);
            _context.Movies.Add(movie);
            _context.SaveChanges();



            movieDto.Id = movie.Id;
            return Created(new Uri(Request.RequestUri + "/" + movie.Id), movieDto);
        }



        [System.Web.Http.HttpPut]
        public IHttpActionResult UpdateMovie(int id, MovieDto movieDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();



            var movieInDb = _context.Movies.SingleOrDefault(c => c.Id == id);



            if (movieInDb == null)
                return NotFound();



            Mapper.Map(movieDto, movieInDb);



            _context.SaveChanges();



            return Ok();
        }



        [System.Web.Http.HttpDelete]
        public IHttpActionResult DeleteMovie(int id)
        {
            var movieInDb = _context.Movies.SingleOrDefault(c => c.Id == id);



            if (movieInDb == null)
                return NotFound();



            _context.Movies.Remove(movieInDb);
            _context.SaveChanges();



            return Ok();
        }
    }
}