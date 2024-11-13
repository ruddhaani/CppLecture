#include <iostream>
#include <cstring>
using namespace std;

// Compile Time Polymorphism

class Person {
    private:
        char name[100];

    public:
        Person(char *name){
            strcpy(this->name, name);
        }

        void display(char *prefix){
            cout << prefix << " " << name << endl;
        }

        void display(){
            cout << this->name << endl;
        }
};

int main(){
    Person p("John");

    p.display();
    p.display("Mr. ");
    return 0;
}