using AP205ApiPractice.Dtos.ProductDtos;
using AP205ApiPractice.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AP205ApiPractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _context.Products.ToListAsync());
        }

        [HttpGet("{id?}")]
        public async Task<IActionResult> Get(int id)
        {
            Product product = await _context.Products.FirstOrDefaultAsync(x => x.Id == id);

            if (product == null) return BadRequest();

            return Ok(product);
        }

        [HttpPost("")]
        public async Task<IActionResult> Create(ProductPostDto postDto)
        {
            Product product = new Product
            {
                Name = postDto.Name,
                CostPrice = postDto.CostPrice,
                SalePrice = postDto.SalePrice,
                IsDeleted = false,
                CreatedDate = DateTime.UtcNow.AddHours(4),
                ModifiedDate = DateTime.UtcNow.AddHours(4)
            };

            _context.Products.Add(product);
            _context.SaveChanges();

            return Ok(postDto);
        }
    }
}
