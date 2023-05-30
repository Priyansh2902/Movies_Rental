//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Web.Http;
//using System.Web.Mvc;
//using MovieRentalV04.Models;
//using MovieRentalV04.Dtos;
//using AutoMapper;

//namespace MovieRentalV04.Controllers.Api
//{
//    public class CustomersController : ApiController
//    {
//        private ApplicationDbContext _Context;
//        public CustomersController()
//        {
//            _Context = new ApplicationDbContext();
//        }
//        // GET /api/ customers
//        public IEnumerable<CustomerDto> GetCustomers()
//        {
//            return _Context.Customers.ToList().Select(Mapper.Map<Customer,CustomerDto>);
//        }

//        // GET/api/customers/1
//        public IHttpActionResult GetCustomer(int id)
//        {
//            var customer = _Context.Customers.SingleOrDefault(c => c.Id == id);

//            if (customer == null)
//            {
//                //throw new HttpResponseException(HttpStatusCode.NotFound);
//                return NotFound();
//            }
//            return Ok(Mapper.Map<Customer, CustomerDto> (customer));
//        }
//        //POST/api/customers
//        [System.Web.Http.HttpPost]

//        public IHttpActionResult CreateCustomer(CustomerDto customerDto)
//        {
//            if (!ModelState.IsValid)
//                // throw new HttpResponseException(HttpStatusCode.BadRequest);
//                return BadRequest();
//            var customer = Mapper.Map<CustomerDto, Customer>(customerDto);
//            _Context.Customers.Add(customer);
//            _Context.SaveChanges();

//            customerDto.Id = customer.Id;
//            return Created(new Uri(Request.RequestUri + "/" + customer.Id),customerDto);

//        }



//        // put/api/customers/1
//        [System.Web.Http.HttpPut]
//        public IHttpActionResult UpdateCustomer(int id,CustomerDto customerDto)
//        {
//            if (!ModelState.IsValid)
//                return BadRequest();
//                //throw new HttpResponseException(HttpStatusCode.BadRequest);
//            var customerInDb = _Context.Customers.SingleOrDefault(c => c.Id == id);

//            if(customerInDb == null)
//                throw new HttpResponseException(HttpStatusCode.NotFound);
//            Mapper.Map(customerDto, customerInDb);
//            //customerInDb.Name = customerDto.Name;
//            //customerInDb.Birthdate= customerDto.Birthdate;
//            //customerInDb.IsSubscribedToNewsletter   = customerDto.IsSubscribedToNewsletter;
//            //customerInDb.MembershipTypeId  = customerDto.MembershipTypeId;

//            _Context.SaveChanges();
//            return Ok();

//        }
//        //Delete/api/customer/1
//        [System.Web.Http.HttpDelete]
//        public IHttpActionResult DeleteCustomer(int id) 
//        {
//            var customerInDb = _Context.Customers.SingleOrDefault(c=>c.Id==id);
//            if(customerInDb == null)
//                return NotFound();
//               // throw new HttpResponseException(HttpStatusCode.NotFound);
//            _Context.Customers.Remove(customerInDb);
//            _Context.SaveChanges();

//            return Ok();


//        }
//    }
//}


using AutoMapper;
using MovieRentalV04.Dtos;
using MovieRentalV04.Models;
using System;
using System.Linq;
using System.Web.Http;
using System.Data.Entity;

namespace MovieRentalV04.Controllers.Api
{
    public class CustomersController : ApiController
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }



        public IHttpActionResult GetCustomers()
        {
            var customerDtos = _context.Customers
                .Include(c => c.MembershipType)
                .ToList()
                .Select(Mapper.Map<Customer, CustomerDto>);


            return Ok(customerDtos);
            }
            // GET /api/customers



            //public IHttpActionResult GetCustomers(string query = null)
            //{
            //    var customerQuery = _context.Customers
            //        .Include(c =>c.MembershipType);
            //    if (!String.IsNullOrWhiteSpace(query))
            //        customerQuery = customerQuery.Where(c => c.Name.Contains(query));

            //    var customerDtos = customerQuery

            //        .ToList()
            //        .Select(Mapper.Map<Customer, CustomerDto>);

            //    return Ok(customerDtos);
            //}

            // GET /api/customers/1

            public IHttpActionResult GetCustomer(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return NotFound();

            return Ok(Mapper.Map<Customer, CustomerDto>(customer));
        }

        // POST /api/customers
        [HttpPost]
        public IHttpActionResult CreateCustomer(CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var customer = Mapper.Map<CustomerDto, Customer>(customerDto);
            _context.Customers.Add(customer);
            _context.SaveChanges();

            customerDto.Id = customer.Id;
            return Created(new Uri(Request.RequestUri + "/" + customer.Id), customerDto);
        }

        // PUT /api/customers/1
        [HttpPut]
        public IHttpActionResult UpdateCustomer(int id, CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerInDb == null)
                return NotFound();

            Mapper.Map(customerDto, customerInDb);

            _context.SaveChanges();

            return Ok();
        }

        // DELETE /api/customers/1
        [HttpDelete]
        public IHttpActionResult DeleteCustomer(int id)
        {
            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerInDb == null)
                return NotFound();

            _context.Customers.Remove(customerInDb);
            _context.SaveChanges();

            return Ok();
        }
    }
}