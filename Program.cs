using System;

class Program {
    static void Main(string[] args) 
    {
        int n = 5, k = 0;

        Console.WriteLine();

        for (int i = 1; i <= n; i++) 
        {
            for (int j = 1; j <= i; j++)
            {
                if(k < n){
                    k++;
                }
                else{
                    k--;
                }
                Console.Write(k + " ");
            }
            Console.WriteLine();
        }
    }
}