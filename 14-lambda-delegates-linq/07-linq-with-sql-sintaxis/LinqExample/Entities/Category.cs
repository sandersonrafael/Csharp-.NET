namespace LinqExample.Entities;

public class Category(int id, string name, int tier)
{
    public int Id { get; set; } = id;
    public string Name { get; set; } = name;
    public int Tier { get; set; } = tier;

    public override string ToString() => $"{'{'} \"id\": {Id}, \"name\": \"{Name}\", \"tier\": {Tier} {'}'}";
}
