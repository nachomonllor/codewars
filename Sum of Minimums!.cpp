https://www.codewars.com/kata/5d5ee4c35162d9001af7d699/solutions/cpp

#include <iostream>
#include <stdio.h>

int sum_of_minimums(const std::vector<std::vector<int>> &numbers)
{
    //return 0;
    int sum = 0 ;
    for(int i =0; i<numbers.length; i++) {
    	
    	int min = numbers[0];
    	for(int j =0; j<numbers[i].length; j++) {
    		if(numbers[j] < min) {
    			min = numbers[i];
			}
		}
    	sum += min;
	}
	return sum;
}