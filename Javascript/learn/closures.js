// Function hello has access to the jim variable

let example1 = function () {
  let name = 'jim';
  function hello() {
    return `my name is ${name}`;
  }
  return hello();
}

example1(); //my name is jim

// --------------------

// we can call the inner function hello from our code and
// it still has access to the name variable. We say that the inner
// function *closes* over the name variable.
let example2 = function () {
  let name = 'jim';
  return function () {
    return `my name is ${name}`;
  }
}

let hello = example2();
hello(); // my name is jim

// --------------------

// the inner function can modify a variable that outside code has no access to
let example3 = function () {
  let count = 0;
  return function () {
    count++;
    return count;
  }
}

let counter = example3();
counter(); // returns 1
counter(); // returns 2

// --------------------------

// closing over loop variables can be... tricky

let example4 = function (){
  let array = [];
  for(var i = 0; i < 5; i++){
    array.push(function (){
      console.log('i is', i);
    })
  }
  let func;
  while(func = array.shift()){
    func();
  }
}

example4(); // prints 'is is 5' five times

// -----------------------

// we can work around this issue by closing over i inside the loop
// with an IIFE https://en.wikipedia.org/wiki/Immediately-invoked_function_expression

let example5 = function () {
  let array = [];
  for(var i=0; i< 5; i++){
    (function(x){
      array.push(function (){
        console.log('i is', x);
      })  
    })(i)
  }
  let func;
  while(func = array.shift()){
    func();
  }
}

example5(); // prints i is 0 ... i is 4 as expected

// --------------------------------

// we can also avoid this just by using let :)

let example6 = function (){
  let array = [];
  for(let i=0; i< 5; i++){
    array.push(function (){
      console.log('i is', i);
    })
  }
  let func;
  while(func = array.shift()){
    func();
  }
}

example6(); // also prints i is 0 ... i is 4 as expected