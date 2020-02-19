https://www.codewars.com/kata/last-digit-of-a-large-number/cpp

#include <iostream>
#include <stdio.h>
#include <math.h>

using namespace std;

// Function to find b % a 
int Modulo(int a, std::string b) 
{ 
    // Initialize result 
    int mod = 0; 
  
    // calculating mod of b with a to make 
    // b like 0 <= b < a 
    for (int i = 0; i < b.length(); i++) 
        mod = (mod * 10 + b[i] - '0') % a; 
  
    return mod; // return modulo 
} 
  
// function to find last digit of a^b 
int LastDigit(std::string a, std::string b) 
{ 
    int len_a = a.length(), len_b = b.length(); 
  
    // if a and b both are 0 
    if (len_a == 1 && len_b == 1 && b[0] == '0' && a[0] == '0') 
        return 1; 
  
    // if exponent is 0 
    if (len_b == 1 && b[0] == '0') 
        return 1; 
  
    // if base is 0 
    if (len_a == 1 && a[0] == '0') 
        return 0; 
  
    // if exponent is divisible by 4 that means last 
    // digit will be pow(a, 4) % 10. 
    // if exponent is not divisible by 4 that means last 
    // digit will be pow(a, b%4) % 10 
    int exp = (Modulo(4, b) == 0) ? 4 : Modulo(4, b); 
  
    // Find last digit in 'a' and compute its exponent 
    int res = pow(a[len_a - 1] - '0', exp); 
  
    // Return last digit of result 
    return res % 10; 
} 

int last_digit(std::string str1, std::string str2) {
	
  return  LastDigit(str1, str2);
}

int main(){
	
	return 0;
}