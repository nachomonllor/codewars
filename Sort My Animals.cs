https://www.codewars.com/kata/sort-my-animals/csharp

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        public class Animal
        {
            public string Name { get; set; }
            public int NumberOfLegs { get; set; }
        }

        public class AnimalSorter
        {
            public List<Animal> Sort(List<Animal> input)
            {

                if (input == null || input.Count == 0) return null;

                for (int i = 0; i < input.Count - 1; i++)
                {
                    for (int j = i + 1; j < input.Count; j++)
                    {
                        if (input[i].NumberOfLegs > input[j].NumberOfLegs)
                        {
                            Animal temp = input[i];
                            input[i] = input[j];
                            input[j] = temp;
                        }
                        else if (input[i].NumberOfLegs == input[j].NumberOfLegs)
                        {
                            if (input[i].Name.CompareTo(input[j].Name) > 0)
                            {
                                Animal temp = input[i];
                                input[i] = input[j];
                                input[j] = temp;
                            }
                        }
                    }
                }

                return input;

            }

            static void Main()
            {
                List<Animal> animals = new List<Animal>
                              {
                                new Animal {Name = "Cat", NumberOfLegs = 4},
                                new Animal {Name = "Snake", NumberOfLegs = 0},
                                new Animal {Name = "Dog", NumberOfLegs = 4},
                                new Animal {Name = "Pig", NumberOfLegs = 4},
                                new Animal {Name = "Human", NumberOfLegs = 2},
                                new Animal {Name = "Bird", NumberOfLegs = 2}
                              };

                List<Animal> output = new AnimalSorter().Sort(animals);

                foreach (Animal item in output)
                {
                    Console.WriteLine(item.Name + " " + item.NumberOfLegs);

                }

                Console.ReadLine();
            }

        }


        //-------------solucion de GrahamD --------------
        //public class AnimalSorter
        //{
        //    public List<Animal> Sort(List<Animal> input)
        //    {
        //      return input?.OrderBy(a => a.NumberOfLegs).ThenBy(a => a.Name).ToList();
        //    }
        //}

    }
}



