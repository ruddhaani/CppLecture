#include <iostream>
using namespace std;

class Arithmetic{

    public:
        Arithmetic(){

        }

        // here i created a virtual function , this is not purely virtual function , this function just helps create virtual table.
        virtual void Add(int a , int b){
            cout << a+b << endl;
        }

        /*on the other hand this is a purely virtual function,
        it makes the class an abstract class, which means it should be overloaded in the derived class.*/
        virtual void calculateSquare(int a) = 0;

        void Greeting(){
            cout << "Hello" ;
        }
};

class Algebra: public Arithmetic{
    public:
        Algebra(){

        }

        // now we overloaded this normal virtual function ,and you will get why later.
        void Add(int a , int b){
            cout << a*b << endl;
        }

        //this was a pure virtual function in base class so it had to be defined in the derived class.
        void calculateSquare(int a){
            cout << a*a << endl;
        }

        void Greeting2(){
            cout << "Good Morning";
        }
};

int main(){

    //Here comes runtime polymorphism in play.

    //this is a base class pointer and it can hold its derived class object's address too
    Arithmetic *ptr;

    //so we create an object of the derived class
    Algebra obj;

    // we store the object's address in base class' pointer.
    ptr = &obj;

    /*However when we call this function if there would have not been a simple virtual Add function
    in base class, it would have called the base class Add() function and not the derived class' overloaded
    Add() function, at runtime when we call this, the pointer goes to the base class' function Add() and sees that
    there is a virtual written so it checks the virtual tables too and calls the derived class' overloaded Add() function.*/
    ptr->Add(10,20);

    //this doesnt work
    //ptr->Greeting2(); 
}
