#include "Student.h"

Student::Student() {

}

Student::Student(string s, int age, int nr) : Person(s, age) {
    this->studentNumber = nr;
}

Student::~Student() {
    for (size_t i = 0; i < this->gradeList.size(); i++)
    {
        delete this->gradeList[i];
    }
}

void Student::addModule(string modName, int modGrade) {
    ModuleGrade* moduleGrade;
    moduleGrade = new ModuleGrade(modName, modGrade);

    this->gradeList.push_back(moduleGrade);
}

void Student::showGradeList() {
    for (size_t i = 0; i < this->gradeList.size(); i++)
    {
        this->gradeList[i]->showModule();
    }
}

Student::Student(const Student &student) : Person(student) {
    this->studentNumber = student.studentNumber;
    for (size_t i = 0; i < student.gradeList.size(); i++)
    {
        ModuleGrade* moduleGrade;
        moduleGrade = new ModuleGrade(
                student.gradeList[i]->getName(),
                student.gradeList[i]->getGrade()
                );
        this->gradeList.push_back(moduleGrade);
    }
}

Student& Student::operator=(const Student &student) {
    if (this == &student)
        return *this;

    Person::operator=(student);
    this->studentNumber = student.studentNumber;

    for (size_t i = 0; i < this->gradeList.size(); i++)
    {
        delete this->gradeList[i];
    }
    this->gradeList.clear();

    ModuleGrade* moduleGrade;
    for (size_t i = 0; i < student.gradeList.size(); i++)
    {
        moduleGrade = new ModuleGrade(*(student.gradeList[i]));
        this->gradeList.push_back(moduleGrade);
    }

    return *this;
}

ofstream& operator<< (ofstream &out, Student &student) {
    out << student.name << '\n' << student.age << '\n' << student.studentNumber << std::endl;
    return out;
}

ifstream& operator>> (ifstream &in, Student &student) {
    in >> student.name >> student.age >> student.studentNumber;
    return in;
}

string Student::getData()  {
    return Person::getData() + '\n' + "Student number: " + to_string(this->studentNumber);
}

int Student::getStudentNumber() {
    return this->studentNumber;
}
