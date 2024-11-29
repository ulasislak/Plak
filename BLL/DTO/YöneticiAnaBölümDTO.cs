using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class YöneticiAnaBölümDTO
    {
        public int AnaBölümId { get; set; }
        public AnaBölümDTO AnaBölüm { get; set; }

        public int YöneticiId { get; set; }
        public YöneticiDTO Yönetici { get; set; }
    }
}
