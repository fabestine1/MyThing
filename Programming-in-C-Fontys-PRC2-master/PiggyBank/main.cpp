#include <iostream>
#include <fstream>
#include <list>
#include "PiggyBank.h"

using namespace std;

int main() {
    std::list<PiggyBank> piggyBanks;
    PiggyBank currentPiggyBank;

    ifstream ifs;
    ofstream ofs;

    cout << "Piggy Bank";

    int choice = -1, code;
    while (choice != 0)
    {
        cout << "\n\nMENU\n====\n";
        cout << "1: Load data \n";
        cout << "2: Select a piggy bank \n";
        cout << "3: Show selected piggy bank \n";
        cout << "4: Show all piggy banks \n";
        cout << "5: Save data \n";
        cout << "6: Create piggy bank \n";
        cout << "7: Show owner \n";
        cout << "8: Change owner \n";
        cout << "9: Show broken status \n";
        cout << "10: Get balance \n";
        cout << "11: Deposit money \n";
        cout << "12: Smash \n";
        cout << "13: Get last piggy bank ID \n";
        cout << "0: quit \n\n";

        cout << "Enter an option: ";
        cin >> choice;

        string owner = "";
        int balance = 0;
        std::list<PiggyBank>::iterator it;
        PiggyBank tmp;

        switch (choice)
        {
            case 1:
                piggyBanks.clear();
                cout << "Load data\n";
                ifs.open("data.txt");
                while (ifs >> tmp) {
                    code = tmp.getBalance(balance);
                    cout << "ID: " << tmp.getId() << "\n" << "Is broken: "
                         << tmp.isBroken() << "\n"
                         << "Owner: " << tmp.getOwnerName() << "\n" << "Balance: " << balance
                         << "\n\n";

                    piggyBanks.push_back(tmp);
                }
                ifs.close();
                break;
            case 2:
                cout << "Select a piggy bank (ORDER IN LIST, NOT ID)\n";
                int id;
                cout << "Enter order number: ";
                cin >> id;

                // Create iterator pointing to first element
                it = piggyBanks.begin();

                if (id > 0 && id <= piggyBanks.size())
                {
                    // Advance the iterator by n-1 positions
                    std::advance(it, id - 1);

                    currentPiggyBank = *it;
                }
                else cerr << "ERROR: This ID does not exist.\n\n";
                break;
            case 3:
                if (!currentPiggyBank.getOwnerName().empty()) {
                    code = currentPiggyBank.getBalance(balance);
                    cout << "ID: " << currentPiggyBank.getId() << "\n" << "Is broken: "
                         << currentPiggyBank.isBroken() << "\n"
                         << "Owner: " << currentPiggyBank.getOwnerName() << "\n" << "Balance: " << balance
                         << "\n\n";
                }
                break;
            case 4:
                for (it = piggyBanks.begin(); it != piggyBanks.end(); ++it){
                    code = it->getBalance(balance);
                    cout << "ID: " << it->getId() << "\n" << "Is broken: "
                         << it->isBroken() << "\n"
                         << "Owner: " << it->getOwnerName() << "\n" << "Balance: " << balance
                         << "\n\n";
                }
                break;
            case 5:
                ofs.open("data.txt", ios::app);
                for (it = piggyBanks.begin(); it != piggyBanks.end(); ++it){
                    cout << *it;
                }
                ofs.close();
                break;
            case 6: {
                cout << "Enter owner name: ";
                cin >> owner;

                cout << "Enter balance: ";
                cin >> balance;

                PiggyBank newTmp(owner, balance);
                piggyBanks.push_back(newTmp);

                cout << "Piggy bank created.";
                break;
            }
            case 7:
                cout << currentPiggyBank.getOwnerName();
                break;
            case 8:
                cout << "Current owner name: " << currentPiggyBank.getOwnerName() << "\n";
                cout << "Enter new owner name: ";
                cin >> owner;
                currentPiggyBank.setOwnerName(owner);
                break;
            case 9:
                cout << "Status: " << currentPiggyBank.isBroken();
                break;
            case 10:
                code = tmp.getBalance(balance);
                if (code == -1)
                    clog << "Piggy bank is broken.";
                cout << "Balance is: " << balance;
                break;
            case 11:
                cout << "Enter amount to deposit: ";
                cin >> balance;
                currentPiggyBank.depositMoney(balance);
                cout << "Deposited " << balance << ".";
                currentPiggyBank.getBalance(balance);
                cout << "New balance: " << balance;
                break;
            case 12:
                currentPiggyBank.smash();
                break;
            case 13:
                cout << "Last ID is: " << PiggyBank::getLastId();
                break;
            case 0:
                break;
            default:
                cerr << "\nERROR: invalid choice: " << choice << "\n";
        }
    }

    return 0;
}
