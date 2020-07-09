using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicCoreClasses
{
    public class Category
    {
        //ID категории
        public int id { get; set; }
        //ID родительской категории
        public int parentId { get; set; }
        //Имя категории
        public string name { get; set; }
        //Описание категории
        public string description { get; set; }


    }
}
