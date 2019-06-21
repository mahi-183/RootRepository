//-----------------------------------------------------------------------
// <copyright file="CouponNumbers.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Coupon Numbers
    /// </summary>
    public class CouponNumbers
    {
        /// <summary>
        /// Generate coupon as function
        /// </summary>
        public static void Generatecoupon()
        {
            try
            {
                int noOfCoupen = 0;
                
                Console.WriteLine("Enter number of Coupen:");
                noOfCoupen = Convert.ToInt32(Console.ReadLine());
                
                // System.out.println("randon numbers:");
                Random randomObj = new Random();
                Utility obj = new Utility();
                obj.getDistinctCoupenFromRandomValues(noOfCoupen, randomObj);
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
