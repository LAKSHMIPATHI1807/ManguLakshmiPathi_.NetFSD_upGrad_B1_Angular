class Animal {
    maleSound() {
        console.log("Animal makes Sound...")
    }
}
class Dog extends Animal{
    makeSound() {
        console.log("Dog barks!")
    }
}
class Cat extends Animal {
    makeSound() {
        console.log("Cat makes meow sound!")
    }
}
class Cow extends Animal {
    makeSound() {
        console.log("Cow makes sound!")
    }
}
let animals = [new Dog(), new Cat(), new Cow()];
animals.forEach(a => a.makeSound());