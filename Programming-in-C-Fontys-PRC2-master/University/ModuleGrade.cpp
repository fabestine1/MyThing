#include <iostream>
#include <string>
#include "ModuleGrade.h"

ModuleGrade::ModuleGrade(std::string modName, int modGrade) {
    this->moduleName = modName;
    this->moduleGrade = modGrade;
}

void ModuleGrade::showModule() {
    std::cout << moduleName << "\n" << moduleGrade << std::endl;
}

std::string ModuleGrade::getName() {
    return moduleName;
}

int ModuleGrade::getGrade() {
    return moduleGrade;
}
