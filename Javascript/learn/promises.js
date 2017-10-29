// promises are useful for converting callback style code to promise chains

const wait = millis => new Promise((resolve, _)=> setTimeout(resolve, millis));

wait(1000)
 .then(()=> console.log('time flies, doesn\'t it?'));

 // usually though you'll just need to use them (unless you're building a library that needs them)

 // contrived example, don't do this or you risk leaking event handlers!

 const clickOnce = ele => new Promise((resolve, _) => ele.addEventListener('click', resolve));

 clickOnce(document.body)
  .then(e => console.log(`${e.target} was clicked`))