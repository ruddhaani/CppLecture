#include <iostream>
#include <string.h>

using namespace std;

class Employee{
    protected:
        int eid;
        char name[20];

    public:
        Employee(char * name, int eid){
            this->eid = eid;
            strcpy(this->name , name);
        }

        virtual double calculateSalary(double base) = 0;

        void display(){
            cout << "Name: " << name << " Eid: " <<eid << endl;
        }
};

class Developer:public Employee{
    double bonus;
    char projectName[100];

    public:

        Developer(double bonus , char *projectName , char *name , int eid): Employee(name , eid){
            this->bonus = bonus;
            strcpy(this->projectName , projectName);
        }

        double calculateSalary(double base){
            return (base + (base*0.15) + (base*0.1) + bonus);
        }
};

// class A {
//     public:
//     A(int a){}
// };

// class B: public A{
//     public:
//     B(int a):A(a){

//     }
// };

int main(){
    // Employee obj;

    Developer dev1(10000, ".NET Netflix" , "Aniruddha" , 1);
    double salary = dev1.calculateSalary(100000);

    cout << salary << endl;

    dev1.display();
}