namespace CleanArchitectureApp.Domain.Entities
{
    public sealed class UserRole
    {
        public Ulid UserId { get; set; }

        public User User { get; set; }

        public int MyProperty { get; set; }

        public int RoleId { get; set; }
    }
}
