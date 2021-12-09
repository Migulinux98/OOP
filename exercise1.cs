using System;
class RandomNumber {


    static int Average (int amount, int left, int right){

        int number;
        int total=0;
        Random random = new Random();
        for(int i=0; i<amount; i++){

            
            number = 0;

            number = random.Next(left, right);

            Console.WriteLine("The random number is: {0}", number );

            total += number;

        }
        Console.WriteLine("The total sum is: {0}", total );
        return total/amount;

    }




    static void Main() {
        
        int min = 0;
        int max = 0;
        
        
        int n=0; 
        Console.WriteLine("Write the amount of random number:");
        n = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Write the left edge number:");
        min = int.Parse(Console.ReadLine());

        Console.WriteLine("Write the right edge number:");
        max = int.Parse(Console.ReadLine());
        
        int avg = Average(n, min, max);



        Console.WriteLine("the average of random number is: {0}", avg);
    }
}

