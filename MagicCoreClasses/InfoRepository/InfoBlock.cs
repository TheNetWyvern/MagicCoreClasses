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
        //ID категории
        public long categoryId { get; set; }
        //Заголовок
        public string title { get; set; }
        //Содержание
        public string content { get; set; }

        public InfoBlock(long _id, long _categoryId, string _title, string _content)
        {
            id = _id;
            categoryId = _categoryId;
            title = _title;
            content = _content;
        }
    }
}
