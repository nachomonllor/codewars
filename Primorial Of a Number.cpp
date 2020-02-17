https://www.codewars.com/kata/5a99a03e4a6b34bb3c000124/train/cpp

bool esPrimo(int n) {
	if(n < 2 ) return false;
	if(n == 2) return true;
	if(n % 2 == 0) return false;
	
	for(int i = 3; i * i <= n; i+=2) {
		if(n % i == 0) return false;
	}
	return true;
}

unsigned long long numPrimorial (unsigned short int number)
{
  // your Code is Here ... Enjoy !!!
  
  int prod = 1;
  
  int cont = 1;
  for(int i = 2;  cont <= number; i++) {
  	 if(esPrimo(i)) {
  	 	prod *= i;
  	 	cont++;
	 }
  }
  return prod;
}