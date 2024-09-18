using static System.Console;
// //Write a program named ArrayDemo that stores an array of 10 integers. Until the user enters a sentinel value, 
// allow the user four options: (1) to view the list in order from the first to last position in the stored array, 
// (2) to view the list in order from the last to first position, (3) to choose a specific position to view, or (4) to quit the application.


class ArrayDemo
{

    static void Main()
    {


            int [] nums = {1,2,3,4,5,6,7,8,9,10};

                Write("Pick a number from 1-3 to start else (choose 4 to exit the Program):  ");
                int userPick = Convert.ToInt32(ReadLine());
                

                if(userPick == 1)
                    {
                        Array.Sort(nums);
                        foreach(int num in nums)
                        {
                              Write("{0}",num + " ");
                        }

                      
                    }
                else if(userPick == 2)
                    {
                        Array.Reverse(nums);
                        foreach(int num in nums)
                        {
                             Write("{0}" ,num + " ");
                        }
                       
                    }
                else if(userPick == 3)
                    {
                           WriteLine("What number are you looking for");
                          int findNum = Convert.ToInt32(ReadLine());
                          int find = Array.BinarySearch(nums,findNum);

                        if(find>=0)
                         {
                             WriteLine("number {0} find in position {1} at ",findNum, find);
                         }
                          
                    }
                else if(userPick == 4)
                    {
                        WriteLine("Exiting.....");
                        
                    }
                   

                }

    }
    
