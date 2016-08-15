using System;

namespace CSExercises
{
    //Electrifying Electronics Pte Ltd. manufactures 
    //three audio-visual electronic products named 
    //as TV, DVD, and MP3.  The table below gives 
    //the unit price for each of these products:

    //PRODUCT   PRICE
    //TV	    $900
    //DVD	    $500
    //MP3	    $700

    //Retailers make orders for these products. 
    //Each order will have the product code and quantity 
    //(only one product in an order).  The company has a policy 
    //that discount of 10% is given when the order amount exceeds 
    //$5000 and 15% discount when the order amount exceeds $10000.  
    //These discounts apply to TV and DVD only and no discount is provided for MP3.

    //Write a program that would prompt the user successively 
    //the three product codes viz., TV, DVD, MP3 and after each prompt, 
    //the user enters the order quantity for that product.  
    //Then apply the price computations.  (Obviously, if the user does not 
    //wish to order the item prompted he/she would enter a zero for the order quantity).

    public class ExC6
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE - get user input, call the function and return the discounted price
           
            Console.WriteLine("Please enter quantity for TV");
            int tvQty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter quantity for DVD");
            int dvdQty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter quantity for MP3");
            int mp3Qty = Convert.ToInt32(Console.ReadLine());
            double discountedPrice = CalculateTotalPrice(tvQty, dvdQty, mp3Qty);




            Console.WriteLine("TV\tDVD\tMP3\tDiscounted Price");
            Console.WriteLine("{0}\t{1}\t{2}\t{3}",tvQty,dvdQty,mp3Qty,discountedPrice);



        }

        public static double CalculateTotalPrice(int tvQty, int dvdQty, int mp3Qty)
        {

            double totalTV = tvQty * 900;
            double totalDVD = dvdQty * 500;
            double totalMP3 = mp3Qty * 700;
            double totalAmount = 0;

            double totalTVDVD = totalTV + totalDVD;
            if(totalTVDVD >5000 && totalTVDVD < 10001)
            {
                totalAmount = totalTVDVD - (totalTVDVD * 10 / 100);
            }
            else if (totalTVDVD > 10000)
            {
                totalAmount = totalTVDVD - (totalTVDVD * 15 / 100);
            }
            else
            {
                totalAmount = totalTVDVD;
            }

            return totalAmount + totalMP3;
        }
    }       
}