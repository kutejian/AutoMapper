using AutoMapper;
using AutoMapperSample.Model;
using AutoMapperSample.Model.Author;
using AutoMapperSample.Model.Order;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace AutoMapperSample.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        IMapper _mapper;

        public HomeController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        [Route("author1")]
        public string Author1()
        {
            var author = new AuthorDto
            {
                Id = 1,
                FirstName = "bob",
                LastName = "bob",
                Address = "sss"
            };
            var authorModel = _mapper.Map<AuthorModel>(author);
            var result = JsonSerializer.Serialize(authorModel);
            return result;
        }

        [HttpGet]
        [Route("author2")]
        public string Author2()
        {
            var author = new AuthorModel
            {
                Id = 1,
                FirstName = "bob",
                LastName = "bob",
                Address1 = null
            };
            var authorDto = _mapper.Map<AuthorDto>(author);
            var result = JsonSerializer.Serialize(authorDto);
            return result;
        }

        [HttpGet]
        [Route("order1")]
        public string Order1()
        {
            var order1 = new Order()
            {
                OrderNumber = "1",
                OrderItems = new List<OrderItem>()
                {
                    new OrderItem(){
                        ItemName = "s1",
                        ItemPrice = 100,
                        ItemQuantity = 1
                    },
                    new OrderItem(){
                        ItemName = "s2",
                        ItemPrice = 101,
                        ItemQuantity = 2
                    }
                }
            };
            var order2 = new Order()
            {
                OrderNumber = "2",
                OrderItems = new List<OrderItem>()
                {
                    new OrderItem(){
                        ItemName = "d1",
                        ItemPrice = 110,
                        ItemQuantity = 34
                    },
                    new OrderItem(){
                        ItemName = "d2",
                        ItemPrice = 111,
                        ItemQuantity = 35
                    }
                }
            };
            var orders = new List<Order> { };
            orders.Add(order1);
            orders.Add(order2);
            var model = _mapper.Map<IEnumerable<Order>, IEnumerable<OrderDto>>(orders);
            var result = JsonSerializer.Serialize(model);
            return result;
        }
    }
}
