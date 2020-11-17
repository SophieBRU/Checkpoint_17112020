using System;
using System.Collections.Generic;
using System.Text;

namespace Checkpoint_17112020
{
    class Promotion
    {
        public Guid PromotionId { get; set; }
        public String Name { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
