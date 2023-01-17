using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoriApp_Karanglewas
{
    internal class dataTransfer
    {
        public interface IDataTransfer
        {
            void resetData();
            void fillDataAdmin();
            string txtUsername { get; }
        }
    }
}
