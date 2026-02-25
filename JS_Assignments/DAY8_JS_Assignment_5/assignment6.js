class Shape {
    calculateArea() {
        console.log(`Area of shape`)
    }
}
class Circle extends Shape {
    constructor(radius) {
        super()
        this.radius = radius;
    }
    calculateArea() {
        console.log(`Area of circle: ${3.14*this.radius**2}`)
    }
}
class Rectangle extends Shape {
    constructor (length,breadth) {
        super()
        this.length=length;
        this.bredth=breadth;
    }
    calculateArea() {
        console.log(`Area of rectangle: ${this.length*this,this.bredth}`);
    }
}
class Triangle extends Shape {
    constructor (base,height) {
        super()
        this.base = base;
        this.height = height;
    }
    calculateArea() {
        console.log(`Area of triangle: ${0.5*this.base*this.height}`);
    }
}

let shapes = [new Circle(7),new Rectangle(7,18),new Triangle(7,18)]
for (let shape of shapes) {
    shape.calculateArea()
}