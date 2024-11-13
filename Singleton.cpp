#include <iostream>
#include <string.h>
using namespace std;

class Singleton{

    int a;

    static Singleton *ptr;

    Singleton() {
        a = 0;
    };

    public:
        static Singleton* getObject(){
            if (ptr == NULL){
                ptr = new Singleton();
                cout << "New Object created" << endl;
            }

            return ptr;
        }

        void display(){
            cout << "a = " << a <<endl;
        }

};

Singleton* Singleton::ptr = nullptr;

int main(){
    Singleton *p = Singleton::getObject();
    Singleton *n = Singleton::getObject();
    Singleton *x = Singleton::getObject();
}