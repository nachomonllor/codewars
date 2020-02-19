function numCmp(a, b) { return a - b; }

// sort + unique
function createIndex(arr) {
  return Array.from(new Set(arr)).sort(numCmp);
}

function smaller(nums) {
  if (!nums || !nums.length) { return nums; }
  var index = createIndex(nums);
  var geCounts = new Uint32Array(index.length);
  var result = nums;
  var rLength = 0;
  var lastIdx = index.length - 1;
  
  for (var i = nums.length - 1; i >= 0; --i) {
    var value = nums[i];
    var geCount = 0;
    var begin = 0;
    var end = lastIdx;
    while (end >= begin) {
      var pos = (begin + end) >> 1;
      var nump = index[pos];
      if (value < nump) {
        geCount += geCounts[pos];
        end = pos;
      } else {
        if (value > nump) {
          ++geCounts[pos];
          begin = pos + 1;
        } else {
          result[i] = rLength - geCount - geCounts[pos];
          ++geCounts[pos];
          break;
        }
      }
    }
    ++rLength;
  }
  
  return result;
}



const smaller = a => {
  const result = [];
  let root = null;
  for (let i = a.length - 1; i >= 0; i--)
    root = insert(a[i], root, result, i, 0);
  return result;
}

const insert = (n, node, r, i, s) => {
  if (node === null) {
    node = new Node(n, 0); 
    r[i] = s;
  } else if (node.value === n) {
    node.count++;
    r[i] = s + node.sum;
  } else if (node.value > n) {
    node.sum++;
    node.left = insert(n, node.left, r, i, s);
  } else 
    node.right = insert(n, node.right, r, i, s + node.count + node.sum);
  return node;
}
   
class Node {
  constructor (v, s) {
    this.value = v;
    this.sum = s;
    this.count = 1;
    this.right = null;
    this.left = null;
  }
}