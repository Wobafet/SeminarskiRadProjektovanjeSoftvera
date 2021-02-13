using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarskiRadProjektovanjeSoftvera.UserControls
{
   public  interface IGetValue
    {
        object GetValue();
        void SetVisible(bool visible);

        void SetLabelName(string name);

        void SetErrorProvider(bool set,string message);

    }
}
