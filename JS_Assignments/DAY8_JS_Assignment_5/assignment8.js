class Payment {
    pay(amount) {
        console.log(`Paying ${amount}.!`)
    }
}
class CreditCardPayment extends Payment {
    constructor (cardHolder,cardNumber) {
        super()
        this.cardHolder=cardHolder;
        this.cardNumber=cardNumber;
    }
    pay(amount) {
        console.log(`Paid ${amount} rupees using Credit Card (${this.cardNumber}) - ${this.cardHolder}`)
    }
}
class UPIPayment extends Payment {
    constructor (upiId) {
        super()
        this.upiId = upiId;
    }
    pay(amount) {
        console.log(`Paid ${amount} rupees using UPI ID: ${this.upiId}`)
    }
}
class CashPayment {
    pay(amount) {
        console.log(`Paid ${amount} rupees using Cash`);
    }
}
let user1=[new CreditCardPayment("MLP",'XXXXXXXX5048'), new UPIPayment("mlp@axis"), new CashPayment()]
user1.forEach(a => a.pay(25896));