namespace LTDO_1;

public class Bag
{
    public int PizzaPieces { get; set; } = 0;
    public int BeerBottles { get; set; } = 0;
    public double Capacity { get; set; } = 0.0;

    public const double PizzaPieceToLiter = 0.3;
    public const double BeerBottleToLiter = 0.5;

    public double CurrentBeerBottlesLiters => BeerBottles * BeerBottleToLiter;
    public double CurrentPizzaPiecesLiters => PizzaPieces * PizzaPieceToLiter;
}