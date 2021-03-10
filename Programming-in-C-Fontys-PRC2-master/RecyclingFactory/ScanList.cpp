#include "ScanList.h"
#include "Scan.h"

#include <iostream>

// 8.06 Morning
// 9.06 13:00 Meeting

ScanList::ScanList() {
    this->scans = nullptr;
}

ScanList::~ScanList() {
    Scan* current = this->scans;
    while (current != nullptr) {
        Scan* next = current->getNext();
        delete current;
        current = next;
    }
}

void ScanList::AddScan(int serialNumber) {
    Scan* newScan = new Scan(serialNumber);

    if (this->scans == nullptr || this->scans->getSerialNumber() > serialNumber) {
        newScan->setNext(this->scans);
        this->scans = newScan;
    }
    else {
        Scan* current = this->scans;

        while (current->getNext() != nullptr && current->getNext()->getSerialNumber() <= serialNumber) {
            current = current->getNext();
        }
        if (current->getSerialNumber() == serialNumber) {
            current->recycle();
        }
        else {
            newScan->setNext(current->getNext());
            current->setNext(newScan);
        }
    }
}

bool ScanList::removeScan(int serialNumber) {
    Scan* current = this->scans;

    while (current != nullptr) {
        Scan* next = current->getNext();

        if (current->getSerialNumber() == serialNumber) {
            this->scans = next;
            delete current;
            return true;
        }

        if (next != nullptr && next->getSerialNumber() == serialNumber) {
            current->setNext(next->getNext());
            delete next;
            return true;
        }
        current = next;
    }
    return false;
}

int ScanList::getTimesRecycled(int serialNumber) {
    Scan* current = this->scans;
    while (current != nullptr) {
        if (current->getSerialNumber() == serialNumber)
            return current->getTimesRecycled();
        current = current->getNext();
    }
    return 0;
}

Scan* ScanList::getScans() {
    return this->scans;
}