#ifndef PERSON_H
#define PERSON_H

#include <string>
#include <fstream>

using namespace std;

class Person
{
protected:
    string name;
    int age;

public:
    virtual ~Person() {};
    Person();
    Person(string s, int age);

    friend ofstream& operator<< (ofstream &out, Person &person);
    friend ifstream& operator>> (ifstream &in, Person &person);

    string getName();
    int getAge();

    virtual string getData();
};

#endif //PERSON_H
