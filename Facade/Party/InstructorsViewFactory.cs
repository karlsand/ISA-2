using ISA_2_project.Data.Party;
using ISA_2_project.Domain.Party;

namespace ISA_2_project.Facade.Party
{
    public class InstructorsViewFactory
    {
        public Instructors Create(InstructorsView v) => new(new InstructorsData
        {
            ID = v.ID,
            InstrumentID = v.InstrumentID,
            FirstName = v.FirstName,
            LastName = v.LastName,
            Email = v.Email,
            PhoneNr = v.PhoneNr
        });
        public InstructorsView Create(Instructors o) => new()
        {
            ID = o.ID,
            InstrumentID = o.InstrumentID,
            FirstName = o.FirstName,
            LastName = o.LastName,
            Email = o.Email,
            PhoneNr = o.PhoneNr,
            FullName = o.ToString()
        };
    }
}
