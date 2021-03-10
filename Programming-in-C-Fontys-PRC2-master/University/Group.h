#ifndef GROUP_H
#define GROUP_H

#include <vector>
#include <string>
#include <fstream>
#include "Student.h"

class Group {
private:
    vector<Student*> studentList;

public:
    Group();
    ~Group();

    void showStudents();
    Student* getStudent(int studentNumber);
    void addStudent(string name, int age, int studentNumber);
    bool removeStudent(int studentNumber);
    bool addModuleGrade(int studentNumber, string module, int grade);

    friend ofstream& operator<< (ofstream &out, Group &group);
    friend ifstream& operator>> (ifstream &in, Group &group);
};


#endif //GROUP_H
