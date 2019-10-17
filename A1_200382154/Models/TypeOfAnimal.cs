using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace A1_200382154.Models
{
    public class TypeOfAnimal
    {
        public TypeOfAnimal (int TypeId, String Name, String Description)
    {
        this.TypeId = TypeId;
        this.Name = Name;
        this.Description = Description;
    } 
        [Required]
        [Key]
        public virtual int TypeId { get; set; }
        [Required]
        public virtual String Name { get; set; }
        [Required]
        public virtual String Description { get; set; }
        public virtual List<Food> Pets { get; set; }
    }
}
