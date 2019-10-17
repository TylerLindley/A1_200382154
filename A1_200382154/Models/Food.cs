using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace A1_200382154.Models
{
    public class Food
    {
        
        //declaring variables for my traits of my food.
        [Key]
        public virtual int Id { get; set; } //Creating a primary key named ID
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        //using a data validation I found online
        public virtual Decimal Price { get; set; } //Price is decimal so no rounding errors.
        [Required]
        //used a data validation example I found online
        //Making it have to be a regular typed name
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        public virtual String Name { get; set; } //Creating a name for the food
        [Required]
        [StringLength(255)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        public virtual String Description { get; set; }
        [Required]
        [StringLength(255)]
        public virtual String NutritionalInformation { get; set; }
        public virtual Decimal Weight { get; set; } //Decimal so no rounding errors.
        [Required]
        [StringLength(255)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        public virtual String Brand { get; set; }
        [DisplayName("Category of Animal")]
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        public virtual String TypeOfAnimalFor { get; set; }

        public virtual int TypeId { get; set; }
        public virtual TypeOfAnimal TypeName { get; set; }
    }
}
