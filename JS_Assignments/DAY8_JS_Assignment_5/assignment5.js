class Employee {
    constructor (name,salary) {
        this.name=name;
        this.salary=salary;
    }
    getDetails() {
        console.log(`Emp_Name: ${this.name} | Emp_Salary: ${this.salary}`);
    }
}
class Manager extends Employee {
    constructor (name,salary,bonus) {
        super(name,salary)
        this.bonus = bonus;
    }
    getTotalSalary() {
        let total_sal = this.salary+this.bonus;
        super.getDetails()
        console.log(`Total_Salary = ${total_sal} (bonus = ${this.bonus})`)
    }
}
class Director extends Manager {
    constructor (name,salary,bonus,stockOptions) {
        super(name,salary,bonus)
        this.stockOptions=stockOptions;
    }
    getFullCompensation() {
        super.getTotalSalary()
        let full_compensation = this.salary + this.stockOptions;
        console.log(`Full_Compensation = ${full_compensation} (stockOptions = ${this.stockOptions})`);
    }
}
let emp1=new Director("MLP",35000,25000,11100);
emp1.getFullCompensation();
// console.log(emp1.salary)