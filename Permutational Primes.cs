//https://www.codewars.com/kata/permutational-primes/train/python

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

    public static bool nextPermutation(char[] array)
    {
        
        // Find non-increasing suffix
        int i = array.Length - 1;
        while (i > 0 && array[i - 1] >= array[i])
            i--;
        if (i <= 0)
            return false;

        // Find successor to pivot
        int j = array.Length - 1;
        while (array[j] <= array[i - 1])
            j--;
        char temp = array[i - 1];
        array[i - 1] = array[j];
        array[j] = temp;

        // Reverse suffix
        j = array.Length - 1;


        while (i < j)
        {
            temp = array[i];
            array[i] = array[j];
            array[j] = temp;
            i++;
            j--;
        }
        return true;
    }

    //static void permutational_primes(int n_max, int k_perms)
    //{


    //}

    static HashSet<int> manipulated_seive(int N)
    {
        // 0 and 1 are not prime 
        // isprime[0] = isprime[1] = false;

        List<bool> isprime = new List<bool>(N + 1);
        //List<int> prime = new List<int>(N + 1);
        List<int> prime = new List<int>();
        List<int> SPF = new List<int>(N + 1);

        isprime.Add(false);
        isprime.Add(false);
        SPF.Add(0);
        SPF.Add(0);

        for (int i = 2; i < N + 1; i++)
        {
            isprime.Add(true);
            SPF.Add(0);
        }

        // Fill rest of the entries 
        for (int i = 2; i < N; i++)
        {
            // If isPrime[i] == True then i is 
            // prime number 
            if (isprime[i])
            {
                // put i into prime[] vector 
                prime.Add(i);

                // A prime number is its own smallest 
                // prime factor 
                SPF[i] = i;
            }

            // Remove all multiples of  i*prime[j] which are 
            // not prime by making isPrime[i*prime[j]] = false 
            // and put smallest prime factor of i*Prime[j] as prime[j] 
            // [ for exp :let  i = 5 , j = 0 , prime[j] = 2 [ i*prime[j] = 10 ] 
            // so smallest prime factor of '10' is '2' that is prime[j] ] 
            // this loop run only one time for number which are not prime 
            for (int j = 0;
                 j < (int)prime.Count &&
                 i * prime[j] < N && prime[j] <= SPF[i];
                 j++)
            {
                isprime[i * prime[j]] = false;

                // put smallest prime factor of i*prime[j] 
                SPF[i * prime[j]] = prime[j];
            }
        }

        HashSet<int> hash = new HashSet<int>(prime);

        return hash;

    }

    static int[] permutational_primes(int n_max, int k_perms)
    {
        List<int> ans = new List<int>();
        HashSet<int> hash_primos = manipulated_seive(n_max);
        bool[] marcas = new bool[n_max + 1];
        foreach (int item in hash_primos)
        {

            char[] ch = (item + "").ToCharArray();
            //Array.Sort(ch);

            if (marcas[item] == false)
            {
               // Array.Sort(ch);
                int num_perms = 0;

                while (nextPermutation(ch))
                {
                    marcas[int.Parse(new string(ch))] = true;
                    if (hash_primos.Contains(int.Parse(new string(ch))))
                    {
                        num_perms++;
                        //marcas[int.Parse(new string(ch))] = true;
                    }
                }
                marcas[item] = true;

                if (num_perms == k_perms)
                {
                    //Console.WriteLine(item);
                    ans.Add(item);
                }

            }

        }

        return ans.ToArray();

    }


    static void Main(String[] args)
    {

        //char[] ch = { '9', '5', '7' };
        //Array.Sort(ch);

        //do
        //{
        //    Console.WriteLine(new string(ch));

        //} while (nextPermutation(ch));

        int[] ans = permutational_primes(1000, 1);
        foreach (int item in ans)
        {
            Console.WriteLine(item + " ");
        }
        Console.WriteLine("Len: " + ans.Length);

        Console.ReadLine();
    }

}

