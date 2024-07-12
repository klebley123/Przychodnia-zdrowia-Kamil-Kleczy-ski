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
        (List<string>, Bitmap) GetInfo();
    }
}
