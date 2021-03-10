#ifndef SCAN_H
#define SCAN_H

class Scan {
private:
    int serialNumber;
    int timesRecycled;
    Scan* next;

public:
    Scan(int number);
    virtual ~Scan();
    int getSerialNumber();
    Scan* getNext();
    void setNext(Scan* nextScan);
    void recycle();
    int getTimesRecycled();
};


#endif //SCAN_H
