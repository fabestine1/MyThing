#include "PiggyBank.h"

PiggyBank::PiggyBank() {
    this->balance = 0;
    this->owner = "";
    counter++;
    this->id = counter;
}
PiggyBank::PiggyBank(string name) {
    this->balance = 0;
    this->owner = name;
    counter++;
    this->id = counter;
}
PiggyBank::PiggyBank(string name, int startBalance) {
    this->owner = name;
    this->balance = startBalance;
    counter++;
    this->id = counter;
}
string PiggyBank::getOwnerName() {
    return owner;
}
void PiggyBank::setOwnerName(string name) {
    this->owner = name;
}
bool PiggyBank::isBroken() {
    return broken;
}
int PiggyBank::getBalance(int & amount) {
    amount = balance;
    if (!broken) {
        return 0;
    }
    return -1;
}
void PiggyBank::depositMoney(int amount) {
    if (!broken)
        balance += amount;
}
int PiggyBank::smash() {
    broken = true;
    int oldBalance = this->balance;
    balance = 0;
    return oldBalance;
}
int PiggyBank::getId() {
    return id;
}
int PiggyBank::counter{ 1 };
int PiggyBank::getLastId() {
    return PiggyBank::counter;
}
ofstream& operator<< (ofstream& out, PiggyBank& piggyBank) {
    // use '\n' instead of <<endl to avoid flushing the buffer for better performance
    out << piggyBank.id << '\n' << piggyBank.owner << '\n' << piggyBank.balance << '\n' << piggyBank.broken << endl;
    return out;
}
ostream& operator<< (ostream& out, PiggyBank& piggyBank) {
    // use '\n' instead of <<endl to avoid flushing the buffer for better performance
    out << piggyBank.id << '\n' << piggyBank.owner << '\n' << piggyBank.balance << '\n' << piggyBank.broken << endl;
    return out;
}
ifstream& operator>> (ifstream& in, PiggyBank& piggyBank) {
    in >> piggyBank.id >> piggyBank.owner >> piggyBank.balance >> piggyBank.broken;
    return in;
}
