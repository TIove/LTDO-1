using LTDO_1.Enums;

namespace LTDO_1;

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Bag StudentBag { get; set; }

    #region Private members

    private const int NormalDeviationFood = 5;
    private bool IsHungry => Age / 2 - NormalDeviationFood > StudentBag.PizzaPieces;
    private bool IsOvereated => Age / 2 + NormalDeviationFood < StudentBag.PizzaPieces;

    private const int NormalDeviationDrink = 3;
    private bool IsSober => Age / 3 - NormalDeviationDrink > StudentBag.BeerBottles;
    private bool IsDrunk => Age / 3 + NormalDeviationDrink < StudentBag.BeerBottles;

    #endregion

    public FoodState FoodState => IsHungry ? FoodState.Hungry : IsOvereated ? FoodState.Overeated : FoodState.Satiety;
    public DrunkState DrunkState => IsDrunk ? DrunkState.Drunk : IsSober ? DrunkState.Sober : DrunkState.Tipsy;
}