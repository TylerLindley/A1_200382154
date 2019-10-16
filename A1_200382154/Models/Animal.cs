using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A1_200382154.Models
{
    public class Animal
    {

        //creating variables for my names/etc of animals
        public virtual int Id { get; set; } //Creating a primary key named ID

        public virtual String Name { get; set; } //Creating a name for the food
        public virtual String Description { get; set; }
    }
}
