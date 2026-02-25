class Product {
    // Default parameters
    greet (name='Lucky') {
        console.log(`Hello, ${name}!`)
    }

    // Template literals
    about (name,id,city) {
        console.log(`
            Hello, I am ${name} and my employee id is ${id} from city ${city}...
            `)
    }

    // Arrow functions
    arrow_fun (a,b) {
        const add = (a, b) => a + b;
        console.log(add(7,18))
    }

    // Destructuring
    destucturing_fun () {
        let numbers = [10, 20, 30];
        let [a, b, c] = numbers;
        console.log(a);
    }

    // Spread Operator
    spread_fun () {
        let arr1 = [1, 2];
        let arr2 = [3, 4];
        let combined = [...arr1, ...arr2];
        console.log(combined);
    }
}
let p1=new Product()
p1.greet()
p1.about('Lucky',1807,"HYD");
p1.arrow_fun(7,18)
p1.destucturing_fun();
p1.spread_fun();