https://www.codewars.com/kata/581214d54624a8232100005f/train/javascript
function matrix(array) {
    for(let i =0; i<array.length; i++) {
        for(let j =0; j<array[i].length; j++) {
           if(i == j) {
            	if(array[i][j] < 0) {
					array[i][j] = 0;
            	}
            	if(array[i][j] > 0) {
					array[i][j] = 1;
            	}
            }
        }
    }
    return array;
}