class Student {
    constructor (name) {
        this.name = name;
        this.marks = []
    }
    addMark(mark) {
        if (mark>0 && mark<100) {
            this.marks.push(mark);
            console.log("Mark added successfully!",this.marks)
        } else {
            console.log("Invalid marks, Enter between 0 to 100.")
        }
    }
    getAverage() {
        if (this.marks.length == 0) {
            return 0
        } else {
            let total=this.marks.reduce((sum,mark) => sum+mark, 0);
            return total/this.marks.length
        }
    }
    getGrade() {
        let avg = this.getAverage()

        if (avg > 90) {
            return 'Grade A'
        } else if (avg> 75) {
            return 'Grade B'
        } else if (avg> 50) {
            return 'Grade C'
        } else {
            return 'Fail'
        }
    }
}
let std1 = new Student("MLP");
std1.addMark(98)
std1.addMark(93)
std1.addMark(97)
std1.addMark(90)
console.log(std1.getAverage())
console.log(std1.getGrade())