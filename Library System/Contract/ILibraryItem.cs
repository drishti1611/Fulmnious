using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Contract
{
    public interface ILibraryItem
    {
        void CheckOut();
        void DisplayInfo();
    }
}
