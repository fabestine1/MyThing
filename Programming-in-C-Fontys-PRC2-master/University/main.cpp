#include <iostream>
#include <string>
#include <fstream>
#include "Student.h"
#include "ModuleGrade.h"
#include "Group.h"

using namespace std;

int main() {
    Group group;

    ifstream ifs;
    ofstream ofs;

    cout << "University";

    group.addStudent("John", 22, 252673);
    group.addStudent("Ana", 21, 257273);
    group.addStudent("Smith", 23, 252662);

    int choice = -1;
    while (choice != 0) {
        cout << "\n\nMENU\n====\n";
        cout << "1: Show students \n";
        cout << "2: Get student by student number \n";
        cout << "3: Add student \n";
        cout << "4: Remove student \n";
        cout << "5: Add module grade \n";
        cout << "6: Load group (without grades) \n";
        cout << "7: Save group (without grades) \n";
        cout << "0: quit \n\n";

        cout << "Enter an option: ";
        cin >> choice;

        string name, module;
        int age, studentNumber, grade;
        Student* student;

        switch (choice) {
            case 1:
                group.showStudents();
                break;
            case 2:
                cout << "\nEnter student number to search: ";
                cin >> studentNumber;
                student = group.getStudent(studentNumber);
                cout << student->getData();
                break;
            case 3:
                cout << "\nEnter name: ";
                cin >> name;
                cout << "\nEnter age: ";
                cin >> age;
                cout << "\nEnter student number: ";
                cin >> studentNumber;
                group.addStudent(name, age, studentNumber);
                break;
            case 4:
                cout << "\nRemove student by student number: ";
                cin >> studentNumber;
                if (group.removeStudent(studentNumber)) {
                    cout << "Student with student number " << studentNumber << " has been removed successfully.";
                }
                else {
                    cout << "Student with student number " << studentNumber << " does not exist.";
                }
                break;
            case 5:
                cout << "\nEnter student number: ";
                cin >> studentNumber;
                cout << "\nEnter module: ";
                cin >> module;
                cout << "\nEnter grade: ";
                cin >> grade;
                group.addModuleGrade(studentNumber, module, grade);
                break;
            case 6:
                ifs.open("data.txt");
                ifs >> group;
                ifs.close();
                break;
            case 7:
                ofs.open("data.txt");
                ofs << group;
                ofs.close();
                break;
            case 0:
                break;
            default:
                cerr << "\nERROR: invalid choice: " << choice << "\n";
        }
    }

    return 0;
}
