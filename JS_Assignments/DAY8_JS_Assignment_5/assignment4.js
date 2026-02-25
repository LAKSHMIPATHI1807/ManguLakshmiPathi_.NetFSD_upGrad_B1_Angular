class Vehicle {
    constructor (brand,speed) {
        this.brand=brand;
        this.speed=speed;
    }
    start() {
        console.log(`${this.brand} brand vehicle started and went ${this.speed}km/hr!`)
    }
}
class Car extends Vehicle {
    constructor (brand,speed,fuelType) {
        super(brand,speed)
        this.fuelType=fuelType;
    }
    showDetails() {
        super.start()
        console.log(`The car fuel type is ${this.fuelType}.`);
    }
}
let car1 = new Car("Jaguar",120,"Petrol");
car1.showDetails()