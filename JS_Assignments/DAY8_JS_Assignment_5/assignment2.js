class BankAccount {
    constructor (accountHolder, balance) {
        this.accountHolder = "MLP";
        this.balance = 0;
    }
    deposit(amount) {
        this.balance = this.balance + amount;
        
        console.log(`Deposit successful..! | Current balance = ${this.balance}`)
    }
    withdraw(amount) {
        if (amount>this.balance) {
            console.log(`Cannot withdraw more than balance | Current Balance = ${this.balance}`);
        } else {
            this.balance = this.balance - amount;
            console.log(`Withdraw successful..! Current balance = ${this.balance}`);
            // this.balance=update_balance;
        }
    }
    checkBalance() {
        console.log(`Current Balance = ${this.balance}`);
    }
}
let user = new BankAccount();
user.checkBalance();
user.deposit(13000);
user.withdraw(14000);
user.withdraw(2000);
user.checkBalance();
