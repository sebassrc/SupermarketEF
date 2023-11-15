﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketEF.Models
{
    public class Product
    {
        // [KEY] -> Anotacion si la propiedad no se llama Id, ejemplo ProductId
        public int Id { get; set; } // Sera la llave primaria
        public string Name { get; set; }
        [Column(TypeName ="decimal(6,2")]
        public decimal Price { get; set; }
        public int Stock {  get; set; }
        public int CategoryId { get; set; } // Sera la llave foreanea 
        public Category Category { get; set; } // Propiedad de navegacion

    }
}
