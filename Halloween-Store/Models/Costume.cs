using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Halloween_Store.Models
{
    /// <summary>
    /// Represents a Costume
    /// </summary>
    public class Costume
    {
        /// <summary>
        /// Auto Incrementing Identification for Costumes
        /// </summary>
        [Key]
        public int CostumeId { get; set; }

        /// <summary>
        /// The name of the Costume
        /// </summary>
        [Required]
        [StringLength(50)]
        public string CostumeName { get; set; }

        /// <summary>
        /// The size of the clothing
        /// Ex. S, M, L, XL, 2XL, 3XL
        /// </summary>
        [Required]
        public string Size { get; set; }

        /// <summary>
        /// Costume Description
        /// </summary>
        [Required]
        [StringLength(150)]
        public string Description { get; set; }

        /// <summary>
        /// The Image of the Costume
        /// </summary>
        [Required]
        public Byte[] CostumeImage { get; set; }

        /// <summary>
        /// The Price of the Costume
        /// </summary>
        [Range(0.01, 999.99)]
        [DataType(DataType.Currency)]
        public double Price { get; set; }
    }
}
