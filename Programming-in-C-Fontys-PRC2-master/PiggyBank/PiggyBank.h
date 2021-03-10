#ifndef PIGGYBANK_H
#define PIGGYBANK_H
#include <iostream>
#include <fstream>

using namespace std;

class PiggyBank {
private:
    int id;
    string owner;
    int balance;
    bool broken;
    static int counter;
public:
    PiggyBank(void);
    PiggyBank(string name);
    PiggyBank(string name, int startBalance);
    string getOwnerName();
    void setOwnerName(string name);
    bool isBroken();
    int getBalance(int & amount);
    void depositMoney(int amount);
    int smash();
    int getId();
    static int getLastId();
    friend ofstream& operator<< (ofstream& out, PiggyBank& piggyBank);
    friend ostream& operator<< (ostream& out, PiggyBank& piggyBank);
    friend ifstream& operator>> (ifstream& in, PiggyBank& piggyBank);
};

#endif //PIGGYBANK_H
