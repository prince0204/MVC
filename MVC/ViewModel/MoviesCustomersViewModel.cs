using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.ViewModel
{
    public class MoviesCustomersViewModel
    {
        public List<Movies> movies { get; set; }
        public List<Customers> customers { get; set; }
    }
}