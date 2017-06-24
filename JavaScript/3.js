var input = 600851475143;

// Calculate primes
function getPrimeFactors(value) {
  var primes = [];
  while (value % 2 === 0) {
    primes.push(2);
    value /= 2;
  }
  
  for (var i = 3; i <= Math.floor(Math.sqrt(value)); i += 2) {
    while(value % i === 0) {
      primes.push(i);
      value /= i;
    }
  }
  
  if (value > 2) {
    primes.push(value);
  }
  
  return primes;
}

var primeFactors = getPrimeFactors(input);
//console.info(primeFactors);
console.log(primeFactors.pop());