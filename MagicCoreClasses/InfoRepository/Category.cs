namespace MagicCoreClasses.InfoRepository
{
    public class Category
    {
        //ID категории
        public long Id { get; set; }
        //ID родительской категории
        public long ParentId { get; set; }
        //Имя категории
        public string Name { get; set; }
        //Описание категории
        public string Description { get; set; }


        public Category(long _id, long _parentId, string _name, string _description)
        {
            Id = _id;
            ParentId = _parentId;
            Name = _name;
            Description = _description;
        }
    }
}
