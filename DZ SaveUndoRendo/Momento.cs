using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_SaveUndoRendo
{
    public class Momento
    {
        private string _state;

        public Momento(string state)
        {
            _state = state;
        }

        public string State()
        {
            return _state;
        }
    }
}
