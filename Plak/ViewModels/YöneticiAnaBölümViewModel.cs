using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class YöneticiAnaBölümViewModel : BaseClassViewModel
    {
        public int AnaBölümId { get; set; }
        public AnaBölümViewModel AnaBölüm { get; set; }

        public int YöneticiId { get; set; }
        public YöneticiViewModel Yönetici { get; set; }
    }
}
