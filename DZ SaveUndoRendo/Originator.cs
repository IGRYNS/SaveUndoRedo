using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_SaveUndoRendo
{
    public class Originator
    {
        public string _state { get; set; }

        public Momento CreateMomento()
        {
            return new Momento(_state);
        }

        public void SetMomento(Momento momento)
        {
            _state = momento.State();
        }
    }
}
