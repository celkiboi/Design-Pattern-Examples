using System.Text;

namespace Builder;

public class Pizza
{
    public bool HasKetchup { get; init; }
    public bool HasCheese { get; init; }
    public bool HasSalami { get; init; }
    public bool HasPepperoni { get; init; }
    public bool HasMushrooms { get; init; }
    public bool HasTuna { get; init; }
    public bool HasHam { get; init; }

    public Pizza(bool hasKetchup, bool hasCheese, bool hasSalami, bool hasPepperoni, bool hasMushrooms, bool hasTuna, bool hasHam)
    {
        HasKetchup = hasKetchup;
        HasCheese = hasCheese;
        HasSalami = hasSalami;
        HasPepperoni = hasPepperoni;
        HasMushrooms = hasMushrooms;
        HasTuna = hasTuna;
        HasHam = hasHam;
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new();

        stringBuilder.Append("Pizza:\n");
        if (HasKetchup) stringBuilder.Append("Ketchup\n");
        if (HasCheese) stringBuilder.Append("Cheese\n");
        if (HasSalami) stringBuilder.Append("Salami\n");
        if (HasPepperoni) stringBuilder.Append("Peperoni\n");
        if (HasMushrooms) stringBuilder.Append("Mushrooms\n");
        if (HasTuna) stringBuilder.Append("Tuna\n");
        if (HasHam) stringBuilder.Append("Ham\n");

        return stringBuilder.ToString();
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(HasKetchup, HasCheese, HasSalami, HasPepperoni, HasMushrooms, HasTuna, HasHam);
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (obj is not Pizza) return false;

        return obj.GetHashCode() == GetHashCode();
    }
}