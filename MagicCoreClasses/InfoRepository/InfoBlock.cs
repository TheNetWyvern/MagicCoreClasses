using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicCoreClasses.InfoRepository
{
    public class InfoBlock
    {
        //ID инфоблока
        public long id { get; set; }
        public long categoryId { get; set; }
        //Заголовок
        public string title { get; set; }
        //Содержание
        public string content { get; set; }
    }
}
