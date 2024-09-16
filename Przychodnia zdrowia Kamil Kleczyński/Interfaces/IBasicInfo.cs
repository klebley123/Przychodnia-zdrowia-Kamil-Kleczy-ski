using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia_zdrowia_Kamil_Kleczynski
{
    public interface IBasicInfo
    {
        string Pesel { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        DateTime? DateOfBirth { get; set; }
        GenderEnum Gender { get; set; }
        string Address { get; set; }
        string IdNumber { get; set; }

        (List<string> info, Bitmap image) GetInfo();
    }
}
