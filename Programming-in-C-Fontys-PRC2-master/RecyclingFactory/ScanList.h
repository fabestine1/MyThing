#ifndef SCANLIST_H
#define SCANLIST_H

#include "Scan.h"

class ScanList {
private:
    Scan* scans;

public:
    ScanList();
    virtual ~ScanList();
    void AddScan(int serialNumber);
    bool removeScan(int serialNumber);
    int getTimesRecycled(int serialNumber);
    Scan* getScans();
};

#endif //SCANLIST_H
