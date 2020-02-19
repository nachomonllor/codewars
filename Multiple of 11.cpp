bool eleven(const std::string input) 
{	
	int sumpares =0, sumimpares =0;
	
	for(int i =0; i<input.length(); i++) {
		if(i % 2 == 0) {
			sumpares += input[i] - '0';
		}
		else{
			sumimpares += input[i] - '0';
		}
	}
	
	int dif = abs(sumpares - sumimpares);
	
	if(dif == 0 || dif % 11 == 0) return true;
	return false;
}	