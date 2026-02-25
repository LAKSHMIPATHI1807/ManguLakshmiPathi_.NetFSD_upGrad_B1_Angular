class User {

    constructor (username) {
        this.username=username;
        this._password="";
    }
    getPassword() {
        console.log(this._password);
    }
    setPassword(password) {
        if (password.length >= 6) {
            this._password = password;
            console.log("Password set successfully!")
        } else {
            console.log("Password must be at least 6 characters long!");
        }
    }
}

let user1 = new User("Lucky");
user1.setPassword("Lucky@");
user1.getPassword()
