// Seed Fibonacci sequence with elements
var fibSeq = [1, 2, 3, 5, 8, 13, 21, 34, 55, 89];
// Set current Fibonacci number as last element; do not remove
var fib = fibSeq[fibSeq.length - 1];

// Fill array with Fibonacci sequence
while (fib < 4000000) {
  fib = fib + fibSeq[fibSeq.length - 2];
  fibSeq.push(fib);
}
// Remove last value as it exceeds the max
fibSeq.pop();

// Use reduce method to find sum
var sum = fibSeq.reduce(function(pv, cv) { return pv + cv;}, 0);

console.log(sum);
