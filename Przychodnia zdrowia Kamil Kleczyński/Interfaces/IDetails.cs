using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia_zdrowia_Kamil_Kleczynski
{
    public interface IDetails
    {
        string Email { get; set; }
        string PhoneNumber { get; set; }
        bool Insurance { get; set; }
        Bitmap Photo { get; set; }
        (List<string> info, Bitmap image) GetInfo();
    }
}
