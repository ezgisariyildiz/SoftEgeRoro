using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgeRoro.Entity.Concreate
{
    public class Service
    {
        public int Id { get; set; }
        //= string.Empty; bu ifade boş geçilebilir anlamına geliyor
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; } 
        public string IconUrl { get; set; }
    }
}
