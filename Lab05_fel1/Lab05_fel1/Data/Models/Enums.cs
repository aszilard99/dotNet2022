using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab05_fel1.Data.Models
{
    public class Enums
    {
        public enum AlgorithmType
        {
            [Display(Name = "Sorting Algorithm")]
            Sorting,
            [Display(Name = "Searching Algorithm")]
            Searching,
            [Display(Name = "Backtracking Algorithm")]
            Backtracking
        }
    }
}
