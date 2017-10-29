// prototypal inheritance

function Animal(name) {
  this.name = name;
}
Animal.prototype.speak = function (){
  return `animal ${this.name} here`;
}
Animal.prototype.run = function (){
  return `animal ${this.name} is running`
}

let animal1 = new Animal('Spike');
animal1.speak();
animal1.run();

function Dog(name){
  this.name = name;
}
Dog.prototype = Object.create(Animal.prototype);
Dog.prototype.speak = function (){
  return `${this.name} is woofing`;
}

let dog1 = new Dog('Fido');
dog1.speak();
dog1.run();

// -------------------------

// class inheritance

class Animal {
  constructor(name){
    this.name = name;
  }
  speak(){
    return `animal ${this.name} here`;
  }
  run(){
    return `animal ${this.name} is running`
  }
}

let animal2 = new Animal('bob');
animal2.speak();
animal2.run();
typeof(Animal.prototype.speak); // function

class Dog extends Animal {
  constructor(name){
    super(name)
  }
  speak(){
    return `${this.name} is woofing`;
  }
}

let dog1 = new Dog('Fido');
dog1.speak();
dog1.run();