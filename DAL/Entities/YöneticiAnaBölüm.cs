using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class YöneticiAnaBölüm
    {
        public int AnaBölümId { get; set; }
        public AnaBölüm AnaBölüm { get; set; }

        public int YöneticiId { get; set; }
        public Yönetici Yönetici { get; set; }
    }
}
