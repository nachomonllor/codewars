

#include <iostream>
#include <vector>
#include <string>
#include <algorithm>    // std::reverse

using namespace std;

char buffer[10000];
std::string to_string(int k){
		sprintf(buffer, "%d", k);
		return std::string(buffer);
}

// https://www.geeksforgeeks.org/difference-of-two-large-numbers/
// Returns true if str1 is smaller than str2. 
bool isSmaller(std::string str1, std::string str2) 
{ 
    // Calculate lengths of both std::string 
    int n1 = str1.length(), n2 = str2.length(); 
  
    if (n1 < n2) 
    return true; 
    if (n2 < n1) 
    return false; 
  
    for (int i=0; i<n1; i++) 
    if (str1[i] < str2[i]) 
        return true; 
    else if (str1[i] > str2[i]) 
        return false; 
  
    return false; 
} 
  
// Function for find difference of larger numbers 
std::string findDiff(std::string str1, std::string str2) 
{ 
    // Before proceeding further, make sure str1 
    // is not smaller 
    if (isSmaller(str1, str2)) 
        swap(str1, str2); 
  
    // Take an empty std::string for storing result 
    std::string str = ""; 
  
    // Calculate length of both std::string 
    int n1 = str1.length(), n2 = str2.length(); 
  
    // Reverse both of strings 
    reverse(str1.begin(), str1.end()); 
    reverse(str2.begin(), str2.end()); 
      
    int carry = 0; 
  
    // Run loop till small std::string length 
    // and subtract digit of str1 to str2 
    for (int i=0; i<n2; i++) 
    { 
        // Do school mathematics, compute difference of 
        // current digits 
          
        int sub = ((str1[i]-'0')-(str2[i]-'0')-carry); 
          
        // If subtraction is less then zero 
        // we add then we add 10 into sub and 
        // take carry as 1 for calculating next step 
        if (sub < 0) 
        { 
            sub = sub + 10; 
            carry = 1; 
        } 
        else
            carry = 0; 
  
        str.push_back(sub + '0'); 
    } 
  
    // subtract remaining digits of larger number 
    for (int i=n2; i<n1; i++) 
    { 
        int sub = ((str1[i]-'0') - carry); 
          
        // if the sub value is -ve, then make it positive 
        if (sub < 0) 
        { 
            sub = sub + 10; 
            carry = 1; 
        } 
        else
            carry = 0; 
              
        str.push_back(sub + '0'); 
    } 
  
    // reverse resultant std::string 
    reverse(str.begin(), str.end()); 
  
    return str; 
} 



// Multiplies str1 and str2, and prints result. 
std::string multiplicar(std::string num1, std::string num2) 
{ 
    int len1 = num1.size(); 
    int len2 = num2.size(); 
    if (len1 == 0 || len2 == 0) 
    return "0"; 
  
    // will keep the result number in std::vector 
    // in reverse order 
    std::vector<int> result(len1 + len2, 0); 
  
    // Below two indexes are used to find positions 
    // in result.  
    int i_n1 = 0;  
    int i_n2 = 0;  
      
    // Go from right to left in num1 
    for (int i=len1-1; i>=0; i--) 
    { 
        int carry = 0; 
        int n1 = num1[i] - '0'; 
  
        // To shift position to left after every 
        // multiplication of a digit in num2 
        i_n2 = 0;  
          
        // Go from right to left in num2              
        for (int j=len2-1; j>=0; j--) 
        { 
            // Take current digit of second number 
            int n2 = num2[j] - '0'; 
  
            // Multiply with current digit of first number 
            // and add result to previously stored result 
            // at current position.  
            int sum = n1*n2 + result[i_n1 + i_n2] + carry; 
  
            // Carry for next iteration 
            carry = sum/10; 
  
            // Store result 
            result[i_n1 + i_n2] = sum % 10; 
  
            i_n2++; 
        } 
  
        // store carry in next cell 
        if (carry > 0) 
            result[i_n1 + i_n2] += carry; 
  
        // To shift position to left after every 
        // multiplication of a digit in num1. 
        i_n1++; 
    } 
  
    // ignore '0's from the right 
    int i = result.size() - 1; 
    while (i>=0 && result[i] == 0) 
    i--; 
  
    // If all were '0's - means either both or 
    // one of num1 or num2 were '0' 
    if (i == -1) 
    return "0"; 
  
    // generate the result std::string 
    std::string s = ""; 
      
    while (i >= 0) 
        s += to_string(result[i--]); 
  
    return s; 
} 

int Comparar(std::string a, std::string b)
{
    if (a.length() > b.length())
    {
        return 1;
    }
    else if (b.length() > a.length())
    {
        return -1;
    }
    if (a == b)
    {
        return 0;
    }

    for (size_t i = 0; i < a.length(); i++)
    {
        if (a[i] - '0' > b[i] - '0')
        {
            return 1;
        }
        else if (b[i] - '0' > a[i] - '0')
        {
            return -1;
        }

    }

    return 0;

}


std::string SacarCeros(std::string num)
{
    size_t i = 0;
    for (; i < num.length(); i++)
    {
        if (num[i] != '0')
        {
            break;
        }
    }


    std::string r = num.substr(i);
    // return 
    if (r == "") return "0";
    return r;
}



std::vector<std::string> divide_strings(std::string dividendo, std::string divisor)
{

    if (dividendo == divisor)
    {
        
        //cout << ("1 0") << endl;
       // return;
       std::vector<std::string> ans ;
       ans.push_back("1");
       ans.push_back("0");
       
       return ans;

    }
    else if (divisor == "1")
    {
       
       
        //cout << (dividendo + " 0") << endl;
        //return;
        
       std::vector<std::string> ans;
       ans.push_back(dividendo);
       ans.push_back("0");
       return ans;
    }

    //1. Selecciono substring del dividendo con len(dividendo) = len(divisor)
    std::string subsdividendo = dividendo.substr(0, divisor.length());

    //1.a.  me fijo si el subsdividendo es mayor o igual que el divisor 
    //Si subsdividendo < divisor, entonces agrando en 1 subsdividendo(concateno 1 digito mas )

    std::string cociente = "";
    size_t indice_concatenar = subsdividendo.length();

    if (Comparar(subsdividendo, divisor) == -1)//Si subsdividendo < divisor
    {
        //suponiendo que subsdividendo.Length + 1 <= dividendo.Length 
        if (indice_concatenar < dividendo.length())
        {
            subsdividendo += dividendo[indice_concatenar];
            indice_concatenar++;
        }
    }

    std::string restotemporal = "", resto_nuevo = "";

    //2.	Selecciono el substring temporal del dividendo (substemporaldividendo):
    //Comparo el primer digito del subsdividendo con el primer digito del divisor
    //2.a. Si : el primer digito de substemporaldividendo es menor que el primer digito de divisor, 
    //entonces lo agrando en 1 digito (concateno)  y quedarían 2 digitos en substemporaldividendo.

    // while (Comparar(subsdividendo, divisor) >= 0) //cuando subsdividendo es menor que el divisor no entra al while
    while (true)
    {
        subsdividendo = SacarCeros(subsdividendo);

        // 2.b Divido: substemporaldividendo / primer_digito _divisor para hallar X => NO
        // int X = (int.Parse(substemporaldividendo) / (divisor[0] - '0'));
        int X = 10;


        //3. Divido el subsdividendo entre divisor[0]:
        //    - El resultado x lo multiplico por TODO el divisor.
        //    - Entonces x * divisor = restotemporal

        restotemporal = SacarCeros(multiplicar(to_string( X ), divisor));

       // Console.WriteLine("restotemporal dentro del while " + restotemporal);


        //4. MIENTRAS restotemporal > subsdividendo entonces,
        //        4.a. X lo disminuyo en 1
        //        4.b. vuelvo a multiplicar X * divisor que es igual a restotemporal.

        while (Comparar(restotemporal, subsdividendo) == 1)
        {
            X--;
            restotemporal = SacarCeros(multiplicar( to_string( X ) , divisor));
            if (X < 0)
            {
                X = 0;
                restotemporal = "0";
            }
        }

        cociente += to_string(X);

        //5. resto a subsdividendo - restotemporal 
        resto_nuevo = SacarCeros(findDiff(subsdividendo, restotemporal));
        if (indice_concatenar >= dividendo.length()) break;

        //6. al nuevo resto_nuevo concateno el digito siguiente de subsdividendo (bajo el digito).

        resto_nuevo += dividendo[indice_concatenar];

        resto_nuevo = SacarCeros(resto_nuevo);

        if (indice_concatenar >= dividendo.length()) break;

        indice_concatenar++;



        subsdividendo = resto_nuevo;
        restotemporal = "0";



        // 7. Vuelvo al paso 2, hasta que no haya más dígitos que “bajar”


    }

    // Console.WriteLine("resto temporal: " + restotemporal);
   // Console.WriteLine("resto nuevo: " + resto_nuevo);
   // Console.WriteLine("resultado: " + cociente);

    //cout << (cociente + " " + resto_nuevo) << endl;
    std::vector<std::string> ans;
    ans.push_back(cociente);
    ans.push_back(resto_nuevo);
    return ans;

}


int main() {
	//string s = multiplicar("120", "51");
	//cout << s << endl;
	
	//string s = "0000000000000009849";
	//cout << SacarCeros(s) << endl;
	
	
	string dividendo = "7643874368743437";//104363206978,73430908073126442117
    string divisor = "73243";
    
    
    std::std::vector<string> ans = divide_strings(dividendo, divisor);
    cout << ans[0] << endl;
    cout << ans[1] << endl;
	
		
	
	return 0;
}







//------------------------------------------------------
#include <iostream>
#include <vector>
#include <string>

//using namespace std;
char buffer[10000];
std::string to_string(int k){
		sprintf(buffer, "%d", k);
		return std::string(buffer);
}

// https://www.geeksforgeeks.org/difference-of-two-large-numbers/
// Returns true if str1 is smaller than str2. 
bool isSmaller(std::string str1, std::string str2) 
{ 
    // Calculate lengths of both std::string 
    int n1 = str1.length(), n2 = str2.length(); 
  
    if (n1 < n2) 
    return true; 
    if (n2 < n1) 
    return false; 
  
    for (int i=0; i<n1; i++) 
    if (str1[i] < str2[i]) 
        return true; 
    else if (str1[i] > str2[i]) 
        return false; 
  
    return false; 
} 
  
// Function for find difference of larger numbers 
std::string findDiff(std::string str1, std::string str2) 
{ 
    // Before proceeding further, make sure str1 
    // is not smaller 
    if (isSmaller(str1, str2)) 
        swap(str1, str2); 
  
    // Take an empty std::string for storing result 
    std::string str = ""; 
  
    // Calculate length of both std::string 
    int n1 = str1.length(), n2 = str2.length(); 
  
    // Reverse both of strings 
    reverse(str1.begin(), str1.end()); 
    reverse(str2.begin(), str2.end()); 
      
    int carry = 0; 
  
    // Run loop till small std::string length 
    // and subtract digit of str1 to str2 
    for (int i=0; i<n2; i++) 
    { 
        // Do school mathematics, compute difference of 
        // current digits 
          
        int sub = ((str1[i]-'0')-(str2[i]-'0')-carry); 
          
        // If subtraction is less then zero 
        // we add then we add 10 into sub and 
        // take carry as 1 for calculating next step 
        if (sub < 0) 
        { 
            sub = sub + 10; 
            carry = 1; 
        } 
        else
            carry = 0; 
  
        str.push_back(sub + '0'); 
    } 
  
    // subtract remaining digits of larger number 
    for (int i=n2; i<n1; i++) 
    { 
        int sub = ((str1[i]-'0') - carry); 
          
        // if the sub value is -ve, then make it positive 
        if (sub < 0) 
        { 
            sub = sub + 10; 
            carry = 1; 
        } 
        else
            carry = 0; 
              
        str.push_back(sub + '0'); 
    } 
  
    // reverse resultant std::string 
    reverse(str.begin(), str.end()); 
  
    return str; 
} 



// Multiplies str1 and str2, and prints result. 
std::string multiplicar(std::string num1, std::string num2) 
{ 
    int len1 = num1.size(); 
    int len2 = num2.size(); 
    if (len1 == 0 || len2 == 0) 
    return "0"; 
  
    // will keep the result number in std::vector 
    // in reverse order 
    std::vector<int> result(len1 + len2, 0); 
  
    // Below two indexes are used to find positions 
    // in result.  
    int i_n1 = 0;  
    int i_n2 = 0;  
      
    // Go from right to left in num1 
    for (int i=len1-1; i>=0; i--) 
    { 
        int carry = 0; 
        int n1 = num1[i] - '0'; 
  
        // To shift position to left after every 
        // multiplication of a digit in num2 
        i_n2 = 0;  
          
        // Go from right to left in num2              
        for (int j=len2-1; j>=0; j--) 
        { 
            // Take current digit of second number 
            int n2 = num2[j] - '0'; 
  
            // Multiply with current digit of first number 
            // and add result to previously stored result 
            // at current position.  
            int sum = n1*n2 + result[i_n1 + i_n2] + carry; 
  
            // Carry for next iteration 
            carry = sum/10; 
  
            // Store result 
            result[i_n1 + i_n2] = sum % 10; 
  
            i_n2++; 
        } 
  
        // store carry in next cell 
        if (carry > 0) 
            result[i_n1 + i_n2] += carry; 
  
        // To shift position to left after every 
        // multiplication of a digit in num1. 
        i_n1++; 
    } 
  
    // ignore '0's from the right 
    int i = result.size() - 1; 
    while (i>=0 && result[i] == 0) 
    i--; 
  
    // If all were '0's - means either both or 
    // one of num1 or num2 were '0' 
    if (i == -1) 
    return "0"; 
  
    // generate the result std::string 
    std::string s = ""; 
      
    while (i >= 0) 
        s += to_string(result[i--]); 
  
    return s; 
} 

int Comparar(std::string a, std::string b)
{
    if (a.length() > b.length())
    {
        return 1;
    }
    else if (b.length() > a.length())
    {
        return -1;
    }
    if (a == b)
    {
        return 0;
    }

    for (int i = 0; i < a.length(); i++)
    {
        if (a[i] - '0' > b[i] - '0')
        {
            return 1;
        }
        else if (b[i] - '0' > a[i] - '0')
        {
            return -1;
        }

    }

    return 0;

}


std::string SacarCeros(std::string num)
{
    int i = 0;
    for (; i < num.length(); i++)
    {
        if (num[i] != '0')
        {
            break;
        }
    }


    std::string r = num.substr(i);
    // return 
    if (r == "") return "0";
    return r;
}



std::vector<std::string> divide_strings(std::string dividendo, std::string divisor)
{

    if (dividendo == divisor)
    {
        
        //cout << ("1 0") << endl;
       // return;
       std::vector<std::string> ans ;
       ans.push_back("1");
       ans.push_back("0");
       
       return ans;

    }
    else if (divisor == "1")
    {
       
       
        //cout << (dividendo + " 0") << endl;
        //return;
        
       std::vector<std::string> ans;
       ans.push_back(dividendo);
       ans.push_back("0");
       return ans;
    }

    //1. Selecciono substring del dividendo con len(dividendo) = len(divisor)
    std::string subsdividendo = dividendo.substr(0, divisor.length());

    //1.a.  me fijo si el subsdividendo es mayor o igual que el divisor 
    //Si subsdividendo < divisor, entonces agrando en 1 subsdividendo(concateno 1 digito mas )

    std::string cociente = "";
    int indice_concatenar = subsdividendo.length();

    if (Comparar(subsdividendo, divisor) == -1)//Si subsdividendo < divisor
    {
        //suponiendo que subsdividendo.Length + 1 <= dividendo.Length 
        if (indice_concatenar < dividendo.length())
        {
            subsdividendo += dividendo[indice_concatenar];
            indice_concatenar++;
        }
    }

    std::string restotemporal = "", resto_nuevo = "";

    //2.	Selecciono el substring temporal del dividendo (substemporaldividendo):
    //Comparo el primer digito del subsdividendo con el primer digito del divisor
    //2.a. Si : el primer digito de substemporaldividendo es menor que el primer digito de divisor, 
    //entonces lo agrando en 1 digito (concateno)  y quedarían 2 digitos en substemporaldividendo.

    // while (Comparar(subsdividendo, divisor) >= 0) //cuando subsdividendo es menor que el divisor no entra al while
    while (true)
    {
        subsdividendo = SacarCeros(subsdividendo);

        // 2.b Divido: substemporaldividendo / primer_digito _divisor para hallar X => NO
        // int X = (int.Parse(substemporaldividendo) / (divisor[0] - '0'));
        int X = 10;


        //3. Divido el subsdividendo entre divisor[0]:
        //    - El resultado x lo multiplico por TODO el divisor.
        //    - Entonces x * divisor = restotemporal

        restotemporal = SacarCeros(multiplicar(to_string( X ), divisor));

       // Console.WriteLine("restotemporal dentro del while " + restotemporal);


        //4. MIENTRAS restotemporal > subsdividendo entonces,
        //        4.a. X lo disminuyo en 1
        //        4.b. vuelvo a multiplicar X * divisor que es igual a restotemporal.

        while (Comparar(restotemporal, subsdividendo) == 1)
        {
            X--;
            restotemporal = SacarCeros(multiplicar( to_string( X ) , divisor));
            if (X < 0)
            {
                X = 0;
                restotemporal = "0";
            }
        }

        cociente += to_string(X);

        //5. resto a subsdividendo - restotemporal 
        resto_nuevo = SacarCeros(findDiff(subsdividendo, restotemporal));
        if (indice_concatenar >= dividendo.length()) break;

        //6. al nuevo resto_nuevo concateno el digito siguiente de subsdividendo (bajo el digito).

        resto_nuevo += dividendo[indice_concatenar];

        resto_nuevo = SacarCeros(resto_nuevo);

        if (indice_concatenar >= dividendo.length()) break;

        indice_concatenar++;



        subsdividendo = resto_nuevo;
        restotemporal = "0";



        // 7. Vuelvo al paso 2, hasta que no haya más dígitos que “bajar”


    }

    // Console.WriteLine("resto temporal: " + restotemporal);
   // Console.WriteLine("resto nuevo: " + resto_nuevo);
   // Console.WriteLine("resultado: " + cociente);

    //cout << (cociente + " " + resto_nuevo) << endl;
    std::vector<std::string> ans;
    ans.push_back(cociente);
    ans.push_back(resto_nuevo);
    return ans;

}