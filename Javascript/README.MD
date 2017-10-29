# ES6 Tutorial

## How to run the example
1. Install `nodejs` from [current branch](https://nodejs.org/en/download/current/)
2. Open a __new__ console window and install `http-serve`
```
npm install http-serve -g
```
3. Open a console, navigate to the `/Javascript` folder and type in the terminal
```bash
http-serve -p 8080
```
4. Visit [http://127.0.0.1:8080/index.html](http://127.0.0.1:8080/index.html) in your browser

## The following concepts will be covered

### Strict Mode
Strict mode makes several changes to normal JavaScript semantics. First, strict mode eliminates some JavaScript silent errors by changing them to throw errors. Second, strict mode fixes mistakes that make it difficult for JavaScript engines to perform optimizations: strict mode code can sometimes be made to run faster than identical code that's not strict mode. Third, strict mode prohibits some syntax likely to be defined in future versions of ECMAScript.
* https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Strict_mode

### let vs var 
The let statement declares a block scope local variable, optionally initializing it to a value.
* https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Statements/let

### Classes
JavaScript classes, introduced in ECMAScript 2015, are primarily syntactical sugar over JavaScript's existing prototype-based inheritance. The class syntax is not introducing a new object-oriented inheritance model to JavaScript. JavaScript classes provide a much simpler and clearer syntax to create objects and deal with inheritance.
* https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Classes

### Arrow functions
An arrow function expression has a shorter syntax than a function expression and does not have its own this, arguments, super, or new.target. These function expressions are best suited for non-method functions, and they cannot be used as constructors.
* https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Functions/Arrow_functions

### Modules
An ES6 module is a file containing JS code. There’s no special module keyword; a module mostly reads just like a script. There are two differences:
1. ES6 modules are automatically strict-mode code, even if you don’t write "use strict"; in them.
1. You can use import and export in modules.
* https://hacks.mozilla.org/2015/08/es6-in-depth-modules/
* https://developer.mozilla.org/en-US/docs/web/javascript/reference/statements/export
* https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Statements/import

### Events
DOM Events are sent to notify code of interesting things that have taken place. Each event is represented by an object which is based on the Event interface, and may have additional custom fields and/or functions used to get additional information about what happened. Events can represent everything from basic user interactions to automated notifications of things happening in the rendering model.
* https://developer.mozilla.org/en-US/docs/Web/Events
* https://developer.mozilla.org/en-US/docs/Web/API/EventTarget/addEventListener

### Promises
A Promise is an object representing the eventual completion or failure of an asynchronous operation. A promise may be created using its constructor. However, most people are consumers of already-created promises returned from functions.

Essentially, a promise is a returned object to which you attach callbacks, instead of passing callbacks into a function.
* https://developer.mozilla.org/en-US/docs/Web/JavaScript/Guide/Using_promises
* https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Promise

### Fetch
The Fetch API provides a JavaScript interface for accessing and manipulating parts of the HTTP pipeline, such as requests and responses. It also provides a global fetch() method that provides an easy, logical way to fetch resources asynchronously across the network.
* https://developer.mozilla.org/en-US/docs/Web/API/Fetch_API/Using_Fetch
* https://developer.mozilla.org/en-US/docs/Web/API/Fetch_API
* https://developer.mozilla.org/en-US/docs/Web/API/Request
* https://developer.mozilla.org/en-US/docs/Web/API/Response

### Chrome dev tools
The Chrome Developer Tools (DevTools for short), are a set of web authoring and debugging tools built into Google Chrome. The DevTools provide web developers deep access into the internals of the browser and their web application. Use the DevTools to efficiently track down layout issues, set JavaScript breakpoints, and get insights for code optimization.
* Access them by pressing `F12` on your keyboard
* https://developers.google.com/web/tools/chrome-devtools/