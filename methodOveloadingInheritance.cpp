#include <iostream>
#include <cstring>
using namespace std;

// Drawback of Cpp

class Person {
    protected:
        char name[100];

    public:
        Person(char *name){
            strcpy(this->name, name);
        }

        void display(){
            cout << this->name << endl;
        }
};

class Employee : public Person {
    private:
        int eid;

    public:

    Employee( char *name , int eid): Person(name){
        strcpy(this->name, name);
        this->eid = eid;
    }

    
    void display(char *prefix){
            cout << prefix << " " << name << endl;
    }
    
};

int main(){
    Employee p("John" , 11);

    p.display();
    p.display("Mr. ");
    return 0;
}