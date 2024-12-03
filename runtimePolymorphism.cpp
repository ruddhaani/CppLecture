#include <iostream>
using namespace std;

class Arithmetic{

    public:
        Arithmetic(){

        }

        virtual void Add(int a , int b){
            cout << a+b << endl;
        }

        virtual void calculateSquare(int a) = 0;

};

class Algebra: public Arithmetic{
    public:
        Algebra(){

        }

        void Add(int a , int b){
            cout << a*b << endl;
        }

        void calculateSquare(int a){
            cout << a*a << endl;
        }
};

int main(){
    Arithmetic *ptr;
    Algebra obj;

    ptr = &obj;

    ptr->Add(10,20);
}
