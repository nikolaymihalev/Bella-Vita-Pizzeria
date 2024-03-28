namespace BellaVitaPizzeria.Core.Models
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
    }
}