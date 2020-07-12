using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicCoreClasses.InfoRepository
{
    public class Category
    {
        //ID категории
        public long id { get; set; }
        //ID родительской категории
        public long parentId { get; set; }
        //Имя категории
        public string name { get; set; }
        //Описание категории
        public string description { get; set; }


        public Category(long _id, long _parentId, string _name, string _description)
        {
            id = _id;
            parentId = _parentId;
            name = _name;
            description = _description;
        }
    }
}
