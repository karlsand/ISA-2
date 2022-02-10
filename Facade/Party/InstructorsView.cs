using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISA_2_project.Facade.Party
{
    public class InstructorsView
    {
        [Required] public string ID { get; set; }
        [DisplayName("Instrument ID")] public string? InstrumentID { get; set; }
        [DisplayName("First name")] public string? FirstName { get; set; } 
        [DisplayName("Last name")] public string? LastName { get; set; }
        [DisplayName("Email")] public string? Email { get; set; }
        [DisplayName("Phone number")] public string? PhoneNr { get; set; }
        [DisplayName("Full information")] public string? FullName { get; set; }
    }
}
