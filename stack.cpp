#include <iostream>
#include <string>
using namespace std;

class Stack {

    int top;
    int arr[5];

    int isEmpty(){
        if(top == 0){
            return 1;
        }else{
            return 0;
        }
    }

    int isFull(){
        if(top == 5){
            return 1;
        }else{
            return 0;
        }
    }

    public:
        Stack(){
            top = 0;
        }

        void push(int number){
            if(!isFull()){
                arr[top] = number;
                top++;
                cout << "Number: " << number << " is added to the stack" << endl;
            }else {
                cout << "Stack is full" << endl;
            }
        }

        void pop(){
            if(!isEmpty()){
                top -= 1;
                cout << "The element at the indice " << top << " is popped" <<endl;
            }else {
                cout << "Stack is empty" << endl;
            }
        }

        int peek(){
            if(!isEmpty()){
                return arr[top-1];
            }
            else{
                return -1;
            }
        }

        void traverse(){
            if(!isEmpty()){
            int i = top-1;
            for(i; i>=0; i--){
                    cout << arr[i] << endl;
                }
            }else {
                cout << "The stack is empty" << endl;
            }
        }
};

int main(){

    Stack stack;

    stack.pop();
    stack.push(10);
    stack.push(20);
    stack.push(30);
    stack.push(40);

    stack.pop();
    stack.traverse();

    int peekValue = stack.peek();
    cout << "Peek Value is: " << peekValue << endl;

    return 0;

}