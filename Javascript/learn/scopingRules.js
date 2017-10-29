// outside of modules any variables defined directly inside
// script files with 'var' are globally scoped

var hello = 'Hey there'; // congrats, you've now polluted the window object

// ----------------

// variables defined with 'var' are function scoped, not blocked scoped!

function scope1(){
  while(true){
    var x = 'mister x';
    break;
  }
  // even though x was defined inside the while block
  // we still have access to it because of the var semantics
  console.log('x is', x);
}

function scope2() {
  while(true){
    let x = 'mister z';
    break;
  }
  // oops! can't do that! Reference error!
  console.log('x is', x);
}