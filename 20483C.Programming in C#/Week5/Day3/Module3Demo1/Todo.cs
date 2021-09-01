using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3Demo1
{
    class Todo
    {
        public string Description { get; set; }

        public int EstiamtedHours { get; set; }
        public Status Status { get; set; }
    }

    enum Status
    {
        NotStarted=1, 
        Inprogress,
        OnHold,
        Completed,
        Deleted
    }
}
