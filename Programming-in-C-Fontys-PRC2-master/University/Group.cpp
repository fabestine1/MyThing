#include <iostream>
#include "Group.h"

Group::Group() {
}

Group::~Group() {
    for (size_t i = 0; i < this->studentList.size(); i++)
    {
        delete this->studentList[i];
    }
}

void Group::showStudents() {
    for (size_t i = 0; i < this->studentList.size(); i++) {
        cout << this->studentList[i]->getData();
        cout << "\n\nGrades:\n";
        this->studentList[i]->showGradeList();
        cout << endl;
    }
}

Student* Group::getStudent(int studentNumber) {
    for (size_t i = 0; i < this->studentList.size(); i++)
    {
        if (this->studentList[i]->getStudentNumber() == studentNumber)
        {
            return this->studentList[i];
        }
    }
    return nullptr;
}

void Group::addStudent(string name, int age, int studentNumber) {
    // Check if a student with the same student number exists. If yes, then stop method execution.
    for (size_t i = 0; i < this->studentList.size(); i++) {
        if (this->studentList[i]->getStudentNumber() == studentNumber) {
            return;
        }
    }

    Student* student;
    student = new Student(name, age, studentNumber);

    this->studentList.push_back(student);
}

bool Group::removeStudent(int studentNumber) {
    for (size_t i = 0; i < this->studentList.size(); i++)
    {
        if (this->studentList[i]->getStudentNumber() == studentNumber)
        {
            this->studentList.erase(this->studentList.begin() + i);
            delete this->studentList[i];
            return true;
        }
    }
    return false;
}

bool Group::addModuleGrade(int studentNumber, string module, int grade) {
    Student * student = getStudent(studentNumber);

    if (student != nullptr) {
        student->addModule(module, grade);
        return true;
    }
    return false;
}

ofstream& operator<< (ofstream &out, Group &group) {
    for (size_t i = 0; i < group.studentList.size(); i++)
    {
        out << *(group.studentList[i]);
    }
    return out;
}

ifstream& operator>> (ifstream &in, Group &group) {
    for (size_t i = 0; i < group.studentList.size(); i++)
    {
        delete group.studentList[i];
    }
    group.studentList.clear();

    Student* student;
    while (in >> *student) {
        group.studentList.push_back(student);
    }
    return in;
}
