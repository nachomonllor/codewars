https://www.codewars.com/kata/number-number-pattern-number-number-wave/csharp

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {


        public static string Draw(int[] waves)
        {
            int max = waves.Max();

            char[][] matriz = new char[max ][];
            for (int i = 0; i < max ; i++)
            {
                matriz[i] = new char[waves.Length];
            }


            int indiceWaves =0;
            int columnas = waves.Length;
            int filas = max ;
            for (int col = 0; col < columnas; col++)
            {
                //for (int fila = filas - 1; fila >= 0; fila--)
                for(int fila = 0; fila < filas; fila++)
                {
                    if ( filas - (fila) <= waves[indiceWaves])
                    {
                        matriz[fila][col] = '■';
                    }
                    else
                    {
                        matriz[fila][col] = '□';
                    }
                    
                }
                indiceWaves++;
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < matriz.Length; i++)
            {
                for (int j = 0; j < matriz[i].Length; j++)
                {
                    //Console.Write(matriz[i][j] + " ");
                    sb.Append(matriz[i][j]);
                }
                sb.Append('\n');
                //Console.WriteLine();
            }


            return sb.ToString().TrimEnd('\n');
        }


        static void Main(string[] args)
        {

            int[] waves = { 1, 2, 3, 3, 2, 1, 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine( Draw(waves));

            Console.ReadLine();
        }
    }
}




namespace Solution
{
    using NUnit.Framework;
    
    using System;
    
    [TestFixture]
    public class Tests
    {
        [Test]
        public void BasicTest1()
        {
            string expected = "□□□■\n"+
                              "□□■■\n"+
                              "□■■■\n"+
                              "■■■■";
            
            string  actual = Kata.Draw(new int[] { 1, 2, 3, 4 });
        
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void BasicTest2()
        {
            string expected = "□□■■□□\n"+
                              "□■■■■□\n"+
                              "■■■■■■";
            
            string  actual = Kata.Draw(new int[] { 1, 2, 3, 3, 2, 1 });
        
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void BasicTest3()
        {
            string expected = "□□□□□□□□□□□□■\n"+
                              "□□□□□□□□□□□■■\n"+
                              "□□□□□□□□□□■■■\n"+
                              "□□□□□□□□□■■■■\n"+
                              "□□■■□□□□■■■■■\n"+
                              "□■■■■□□■■■■■■\n"+
                              "■■■■■■■■■■■■■";

            string  actual = Kata.Draw(new int[] { 1, 2, 3, 3, 2, 1, 1, 2, 3, 4, 5, 6, 7 });
        
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void BasicTest4()
        {
            string expected = "□□□□□■□□□□□□□\n"+
                              "■□□□□■■□□□■□□\n"+
                              "■□□□■■■■□□■□□\n"+
                              "■■□□■■■■□■■□□\n"+
                              "■■□■■■■■■■■■□\n"+
                              "■■■■■■■■■■■■■";
            
            string  actual = Kata.Draw(new int[] { 5, 3, 1, 2, 4, 6, 5, 4, 2, 3, 5, 2, 1 });
        
            Assert.AreEqual(expected, actual);
        }
    }
}