#ifndef MODULEGRADE_H
#define MODULEGRADE_H

#include <string>

class ModuleGrade
{
private:
    std::string moduleName;
    int moduleGrade;

public:
    ModuleGrade(std::string modName, int modGrade);
    void showModule();
    std::string getName();
    int getGrade();
};


#endif //MODULEGRADE_H
