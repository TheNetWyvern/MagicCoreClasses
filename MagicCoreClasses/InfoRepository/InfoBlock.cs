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
        public long Id { get; set; }
        //ID категории
        public long CategoryId { get; set; }
        //Заголовок
        public string Title { get; set; }
        //Содержание
        public string Content { get; set; }

        public InfoBlock(long _id, long _categoryId, string _title, string _content)
        {
            Id = _id;
            CategoryId = _categoryId;
            Title = _title;
            Content = _content;
        }
    }
}
