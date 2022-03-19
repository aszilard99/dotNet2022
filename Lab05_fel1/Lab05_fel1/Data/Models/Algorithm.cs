using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static Lab05_fel1.Data.Models.Enums;

namespace Lab05_fel1.Data.Models
{
    public class Algorithm
    {
        //az Id key kotelezo lesz/primary
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public AlgorithmType Type { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }

        public string AlgorithmNickname { get; set; }

        public bool isPublished { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
