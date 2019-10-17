using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace A1_200382154.Models
{
    public class Animal
    {

        //creating variables for my names/etc of animals
        [Required]
        public virtual int Id { get; set; } //Creating a primary key named ID

        [Required]
        public virtual String Name { get; set; } //Creating a name for the food
        [Required]
        public virtual String Description { get; set; }
    }
}
