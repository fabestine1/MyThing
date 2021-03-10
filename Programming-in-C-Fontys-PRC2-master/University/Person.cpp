#include "Person.h"

Person::Person() {
    this->name = "Unknown";
    this->age = -1;
}

Person::Person(string s, int age) {
    this->name = s;
    this->age = age;
}

ofstream& operator<< (ofstream &out, Person &person) {
    out << person.name << '\n' << person.age << endl;
    return out;
}

ifstream& operator>> (ifstream &in, Person &person) {
    in >> person.name >> person.age;
    return in;
}

string Person::getData() {
    return "Name: " + this->name + '\n' + "Age: " + to_string(this->age);
}

string Person::getName() {
    return this->name;
}

int Person::getAge() {
    return this->age;
}
