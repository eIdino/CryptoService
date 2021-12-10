using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace CryptoService
{
    public class Model
    {
        // This field must have a value
        [Required]
        // Calls custom validation
        [CheckPairNameValidation]
        public String PairName { get; set; }

        [Required]
        // Checks that the value is a int and only in the range of 1 - 24
        [Range(typeof(int), "1", "24", 
        ErrorMessage = "Enter valid amount of Hours")]
        public int Hours { get; set; }

        [Required]
        // Checks that the value is int and only in the range of 1 - 10
        [Range(typeof(int), "1", "10",
        ErrorMessage = "Enter valid amount of Data Points (1-10)")]
        public int DataPoints { get; set; }
    }
}
