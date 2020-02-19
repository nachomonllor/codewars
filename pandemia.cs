https://www.codewars.com/kata/5e2596a9ad937f002e510435/train/csharp



 public static double infected(string s)
        {
            //your code here

            string[] continentes = s.Split(new char[] { 'X' }, StringSplitOptions.RemoveEmptyEntries);

            double infectados = 0;
            double total = 0;
            foreach (string c in continentes)
            {
                if (c.Contains('1'))
                {
                    infectados += c.Length;
                }
                total += c.Length;

            }

            return infectados / total * 100;
        }
