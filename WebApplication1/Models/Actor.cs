using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        // plain class
        // object 
        //POCO  Plainn Old CLR Object -> obiekt nieobciążony dziedziczeniem,
        //scaffolding -> metaprogramistyczna metoda budowania plaikacji z wykorzystaniem baz danych
    }
}