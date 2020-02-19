https://www.codewars.com/kata/adding-big-numbers/csharp

public static string Add(string a, string b)
    {

        string c = "";

        int mellevo = 0;

        int i = a.Length - 1, j = b.Length - 1;

        while (i >= 0 && j >= 0)
        {
            int res = int.Parse(a[i].ToString()) + int.Parse(b[j].ToString()) + mellevo;

            //c.Insert(0, res % 10);
            c = c.Insert(0, (res % 10).ToString());
            if (res > 9)
            {
                mellevo = res / 10;
            }
            else
            {
                mellevo = 0;
            }
            i--;
            j--;
        }

        while (i >= 0)
        {
            int res = int.Parse(a[i].ToString()) + mellevo;

            c = c.Insert(0, (res % 10).ToString());
            if (res > 9)
                mellevo = res / 10;
            else
                mellevo = 0;

            i--;
        }

        while (j >= 0)
        {
            int res = int.Parse(b[j].ToString()) + mellevo;
            c = c.Insert(0, (res % 10).ToString());

            if (res > 9)
                mellevo = res / 10;
            else
                mellevo = 0;
            j--;
        }

        if (mellevo > 0)
        {
            c = c.Insert(0, mellevo.ToString());
        }


        return c;

    }