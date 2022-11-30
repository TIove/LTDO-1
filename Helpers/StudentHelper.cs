using LTDO_1.Enums;

namespace LTDO_1.Helpers;

public static class StudentHelper
{
    public static string CountSatiety(Student student)
    {
        switch (student.FoodState)
        {
            case FoodState.Hungry:
                return "Hungry";
            case FoodState.Overeated:
                return "Overeated";
            case FoodState.Satiety:
                return "Satiety";
            default:
                return "Bad request";
        }
    }

    public static string CountDrunk(Student student)
    {
        switch (student.DrunkState)
        {
            case DrunkState.Sober:
                return "Sober";
            case DrunkState.Drunk:
                return "Drunk";
            case DrunkState.Tipsy:
                return "Tipsy";
            default:
                return "Bad request";
        }
    }
}