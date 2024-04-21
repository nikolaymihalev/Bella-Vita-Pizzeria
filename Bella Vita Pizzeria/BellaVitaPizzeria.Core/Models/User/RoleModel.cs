namespace BellaVitaPizzeria.Core.Models.User
{
    public class RoleModel
    {
        public RoleModel(
            string id,
            string name)
        {
            Id = id;
            Name = name;
        }

        public string Id { get; set; }
        public string Name { get; set; }
    }
}
