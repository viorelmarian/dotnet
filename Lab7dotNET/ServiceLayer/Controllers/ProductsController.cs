using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using DataAccessLayer;
using BusinessLogicLayer;
using PresentationLayer.Models;
namespace PresentationLayer.Controllers
{
    
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _repository;

        public ProductsController(IProductRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IReadOnlyList<Product>> Get()
        {
            return Ok(this._repository.GetAll());
        }

        [HttpGet("{id}", Name = "GetById")]
        public ActionResult<Product> Get(Guid id)
        {
            return Ok(this._repository.GetById(id));
        }
        [HttpPost]
        public ActionResult<Product> Post([FromBody] CreateProductModel createProductModel)
        {
            if (createProductModel == null)
            {
                return BadRequest();
            }

            Product product = new Product(createProductModel.Name, createProductModel.Price);
            this._repository.Create(product);

            return CreatedAtRoute("GetById", new { id = product.Id }, product);
        }

    }

}