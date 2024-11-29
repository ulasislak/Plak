using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class AnaBölümDTO:BaseClassDTO
    {
        public string AlbümAdi { get; set; }
        public string AlbümSanatcısı { get; set; }
        public DateTime CikisTarihi { get; set; }
        public int AlbümFiyat { get; set; }
        public double Indirim { get; set; }
        public bool SatısDevamMı { get; set; }
        public List<YöneticiAnaBölümDTO> YöneticiAnaBölümDTOs { get; set; }
    }
}
