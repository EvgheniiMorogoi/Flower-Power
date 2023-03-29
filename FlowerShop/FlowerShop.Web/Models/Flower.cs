﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlowerShop.Web.Models
{
     public class Flower
     {
          public int Id { get; set; }
          public string Name { get; set; }
          public string Description { get; set; }
          public decimal Price { get; set; }
          public string ImageUrl { get; set; }
     }
}