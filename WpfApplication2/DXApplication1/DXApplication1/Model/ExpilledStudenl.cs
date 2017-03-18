using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1
{
    class ExpilledStudenModel : SudentModel
    {
        public bool IsExpilled { get; set; }
        public ExpilledStudenModel()
        {
            Id = Guid.NewGuid();
        }
        public string FIO { get; set; }
        public Group Group { get; set; }
        public string Phone { get; set; }
    }
}
