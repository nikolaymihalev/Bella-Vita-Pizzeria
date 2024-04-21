namespace BellaVitaPizzeria.Core.Models.Category
{
    public class CategoryInfoModel
    {
        public CategoryInfoModel(
            int id,
            string name)
        {
            Id = id;
            Name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsInUse { get; set; }
    }
}