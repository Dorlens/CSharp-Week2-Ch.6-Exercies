
using static System.Console;


// Write a program for The Carefree Resort named ResortPrices that prompts the user to enter the number of days for a resort stay. 
// Then display the price per night and the total price. Nightly rates are $200 for one or two nights; 
// $180 for three or four nights; $160 for five, six, or seven nights; and $145 for eight nights or more.
class  ResortPrices 
{

    static void Main()
    {

        WriteLine("WELCOME TO CAREFREE RESORT!!!!!");
        WriteLine(" ");
        Write("Enter the number of days for a resort stay: ");
        int stay = Convert.ToInt32(ReadLine());

         int total=0;
        if(stay ==1 || stay == 2)
        {
            
             total = total + 200;
             WriteLine("Nightly rate: {0}" , total);
        }
        else if(stay ==3 || stay == 4)
        {
           
            total = total + 180;
             WriteLine("Nightly rate: {0}" , total);
        }
        else if( stay == 5 || stay == 6 || stay == 7)
        {
           
             total = total + 160;
              WriteLine("Nightly rate: {0}" , total);
        }
        else if (stay >=8)
        {
            
           total = total + 145;
            WriteLine("Nightly rate: {0}" , total);
        }
            
         int  totalPrice = total * stay;

        WriteLine("Total price for {0} nights: {1} ", stay, totalPrice);


    }
}