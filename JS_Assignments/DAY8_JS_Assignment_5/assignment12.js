class Wallet {
    #balance = 0;

    addMoney(amount) {
        if (amount>0) {
            this.#balance += amount;
            console.log(`${amount} rupees added!`);
        } else {
            console.log("Enter a valid amount...");
        }
    }
    spendMoney(amount) {
        if (amount > this.#balance) {
            console.log("Insufficient balance!");
        } else {
            this.#balance -= amount;
            console.log(`${amount} rupees spent!`);
        }
    }
    getBalance() {
        console.log(`Balance: ${this.#balance}`)
    }
}
let user = new Wallet();
user.getBalance();
user.addMoney(13000);
user.getBalance();
user.spendMoney(2345);
user.getBalance();