#include <iostream>
#include "ScanList.h"

using namespace std;

void printList(Scan* scans)
{
    while (scans != NULL)
    {
        cout << "Serial number: " << scans->getSerialNumber() << "\n" << "Times recycled: " << scans->getTimesRecycled() << "\n\n";
        scans = scans->getNext();
    }
}

void getBySerialNumber(Scan* scans, int serialNumber) {
    while (scans != NULL)
    {
        if (scans->getSerialNumber() == serialNumber)
            cout << "Serial number: " << scans->getSerialNumber() << "\n" << "Times recycled: " << scans->getTimesRecycled() << endl;
        scans = scans->getNext();
    }
}

int main() {
    ScanList scanList;
    cout << "The recycling factory";

    scanList.AddScan(8);
    scanList.AddScan(1);
    scanList.AddScan(9);
    scanList.AddScan(2);
    scanList.AddScan(6);
    scanList.AddScan(3);
    scanList.AddScan(6);
    scanList.AddScan(3);

    int choice = -1;
    while (choice != 0) {
        cout << "\n\nMENU\n====\n";
        cout << "1: Show data \n";
        cout << "2: Get by serial number \n";
        cout << "3: Add scan \n";
        cout << "4: Get times recycled \n";
        cout << "5: Remove scan \n";
        cout << "0: quit \n\n";

        cout << "Enter an option: ";
        cin >> choice;

        int serialNumber;

        switch (choice) {
            case 1:
                printList(scanList.getScans());
                break;
            case 2:
                cout << "\nEnter serial number to search: ";
                cin >> serialNumber;
                getBySerialNumber(scanList.getScans(), serialNumber);
                break;
            case 3:
                cout << "\nEnter serial number: ";
                cin >> serialNumber;
                scanList.AddScan(serialNumber);
                break;
            case 4: {
                cout << "\nGet times recycled for a serial number: ";
                cin >> serialNumber;
                int code = scanList.getTimesRecycled(serialNumber);
                if (code == 0) {
                    cout << "Scan with the serial number " << serialNumber << " does not exist.";
                }
                else {
                    cout << "Scan with serial number " << serialNumber << " has been recycled " << scanList.getTimesRecycled(serialNumber) << " times.";
                }
                break;
            }
            case 5:
                cout << "\nRemove scan by serial number: ";
                cin >> serialNumber;
                if (scanList.removeScan(serialNumber)) {
                    cout << "Scan with serial number " << serialNumber << " has been removed successfully.";
                }
                else {
                    cout << "Scan with serial number " << serialNumber << " does not exist.";
                }
                break;
            case 0:
                break;
            default:
                cerr << "\nERROR: invalid choice: " << choice << "\n";
        }
    }

    return 0;
}
