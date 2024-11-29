using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Yönetici:BaseClass
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public List<YöneticiAnaBölüm> yöneticiAnaBölüms { get; set; }
    }
}
