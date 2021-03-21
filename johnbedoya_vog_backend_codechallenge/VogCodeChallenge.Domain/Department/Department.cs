using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VogCodeChallenge.Domain
{
    public class Department : IBaseDomain
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string name { get; set; }

        [StringLength(255)]
        public string address { get; set; }

    }
}
