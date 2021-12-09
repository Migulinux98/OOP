//exercise 4

using System;  
public class Exercise13 
{  
    public static void Main()
    {
        int i,j,spc,rows=4,k,t=0;
    
        Console.Write("\n\n");
        Console.Write("Display the pattern like pyramid of 4 rows:\n");
        Console.Write("---------------------------------------------------------------");
        Console.Write("\n\n");   
    
        
        spc=rows+4-1-3;
        for(i=1;i<=rows;i++)  
        {
            for(k=spc;k>=1;k--)
            {
                Console.Write(".");
            }

            for(j=1;j<=i;j++)
            {
            Console.Write("{0}.",t++);
                
            }

            for(k=spc;k>=2;k--)
            {
                Console.Write(".");
            }

            Console.Write("\n");
            spc--;
        }
    }
}