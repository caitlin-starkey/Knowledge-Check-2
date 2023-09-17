using System;
public class ChocolateBar : Food
{
    public override string ToString()
    {
        return base.ToString() + " with " + Calories.ToString() + " calories and " + FatGrams.ToString() + " grams of fat.";
    }
    public decimal FatGrams;
}
