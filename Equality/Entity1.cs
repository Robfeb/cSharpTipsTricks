namespace Equality
{
    class EntityExample
    {
        public EntityExample(int id)
        {
            this.Id = id;
        }
        public int Id { get; }
        public  override  int GetHashCode() => this.Id;

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(obj, null)) return false;
            if (ReferenceEquals(obj, this)) return true;
            return obj is EntityExample e1 && e1.Id == this.Id;
        }
    }
}
