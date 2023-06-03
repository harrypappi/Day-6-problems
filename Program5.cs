using System;
using System.Collections.Generic;

public class CouponNumberGenerator
{
    public static List<int> GenerateDistinctCoupons(int numberOfCoupons)
    {
        List<int> coupons = new List<int>();
        Random random = new Random();

        while (coupons.Count < numberOfCoupons)
        {
            int coupon = random.Next(1, numberOfCoupons + 1);
            if (!coupons.Contains(coupon))
            {
                coupons.Add(coupon);
            }
        }

        return coupons;
    }

    public static int GetTotalRandomNumbersNeeded(int numberOfCoupons)
    {
        HashSet<int> uniqueCoupons = new HashSet<int>();
        Random random = new Random();
        int count = 0;

        while (uniqueCoupons.Count < numberOfCoupons)
        {
            int randomCoupon = random.Next(1, numberOfCoupons + 1);
            uniqueCoupons.Add(randomCoupon);
            count++;
        }

        return count;
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter the number of distinct coupon numbers: ");
        int numberOfCoupons = int.Parse(Console.ReadLine());

        List<int> distinctCoupons = GenerateDistinctCoupons(numberOfCoupons);
        Console.WriteLine("Distinct coupon numbers: " + string.Join(", ", distinctCoupons));

        int totalRandomNumbersNeeded = GetTotalRandomNumbersNeeded(numberOfCoupons);
        Console.WriteLine("Total random numbers needed to obtain all distinct coupons: " + totalRandomNumbersNeeded);
    }
}
