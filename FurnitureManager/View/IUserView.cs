using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManager.View
{
    class IUserView
    {
        event Action GenerateReport;
        event Action Add;
        event Action Delete;
        event Action Update;
        event Action View;
    }
}
