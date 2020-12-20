using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models {
    public class Salesperson {
        public int SalespersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset? TerminationDate { get; set; }
        public string Manager { get; set; }

    }
}