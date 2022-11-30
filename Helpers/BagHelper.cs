namespace LTDO_1.Helpers;

public static class BagHelper
{
    public static bool AddPizza(int pizzaPieces, Bag bag)
    {
        double newPizzaLiters = (bag.PizzaPieces + pizzaPieces) * Bag.PizzaPieceToLiter + bag.CurrentBeerBottlesLiters; //TODO overflow double fix
        if (newPizzaLiters < bag.Capacity)
        {
            bag.PizzaPieces += pizzaPieces;
            return true;
        }

        return false;
    }

    public static bool AddBeer(int beerBottles, Bag bag)
    {
        double newBeerLiters = (bag.BeerBottles + beerBottles) * Bag.BeerBottleToLiter + bag.CurrentPizzaPiecesLiters; //TODO overflow double fix
        if (newBeerLiters < bag.Capacity || newBeerLiters > bag.Capacity)
        {
            bag.BeerBottles += beerBottles;
            return true;
        }

        return false;
    }
}