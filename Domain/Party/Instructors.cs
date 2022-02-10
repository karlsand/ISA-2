using ISA_2_project.Data.Party;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISA_2_project.Domain.Party
{
    public class Instructors
    {
        private const string defaultStr = "Undefined";
        private InstructorsData data;
        public Instructors() : this(new InstructorsData()) { }
        public Instructors (InstructorsData d) => data = d;
        public string ID => data?.ID ?? defaultStr;
        public string InstrumentID => data?.InstrumentID ?? defaultStr;
        public string FirstName => data?.FirstName ?? defaultStr;
        public string LastName => data?.LastName ?? defaultStr;
        public string Email => data?.Email ?? defaultStr;
        public string PhoneNr => data?.PhoneNr ?? defaultStr;
        public override string ToString() => $"{FirstName} {LastName} ({Email}, {PhoneNr})";
    }
}
