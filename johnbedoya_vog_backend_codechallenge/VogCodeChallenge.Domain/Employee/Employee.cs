using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VogCodeChallenge.Domain
{
    public class Employee : IBaseDomain
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string firstName { get; set; }
        [Required]
        [MaxLength(100)]
        public string lastName { get; set; }
        [Required]
        [MaxLength(100)]
        public string jobTitle { get; set; }
        
        [MaxLength(100)]
        public string address { get; set; }

        [Required]
        public int departmentId { get; set; }
    }
}
