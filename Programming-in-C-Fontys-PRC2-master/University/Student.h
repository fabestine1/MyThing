#ifndef STUDENT_H
#define STUDENT_H

#include <string>
#include <vector>
#include <fstream>
#include "Person.h"
#include "ModuleGrade.h"

class Student : public Person
{
private:
    int studentNumber;
    vector<ModuleGrade*> gradeList;

public:
    Student();
    Student(string s, int age, int nr);
    ~Student();
    void addModule(string modName, int modGrade);
    void showGradeList();
    Student(const Student &student);
    Student& operator= (const Student& student);
    friend ofstream& operator<< (ofstream& out, Student& student);
    friend ifstream& operator>> (ifstream& in, Student& student);
    string getData() override;
    int getStudentNumber();
};

#endif //STUDENT_H
