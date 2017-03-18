using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1
{
   public class SudentModel: BaseModel
    {
        public SudentModel()
        {
            Id = Guid.NewGuid();
        }
        public string FIO { get; set; }
        public Group Group { get; set; }
        public string Phone { get; set; }


    }
}
