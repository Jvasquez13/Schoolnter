namespace School.Domain.Core
{
    public abstract class Person : BaseEntity
    {
        public Person()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
