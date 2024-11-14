#include <iostream>
#include <string.h>

using namespace std;

class DeQueue{
    int front , rear , arr[5];

    int isFull(){
        if(front == 0 && rear == 5){
            return 1;
        }else{
            return 0;
        }
    }

    int isEmpty(){
        if(front == rear){
            return 1;
        }else {
            return 0;
        }
    }

    public:
        DeQueue(){
            front = 0;
            rear = 0;
        }

        void insertFront(int num){
            if(isFull()){
                cout << "Queue is full" << endl;
            }else{
                if(front == 0){
                    cout << "Try inserting from rear" << endl;
                }else{
                    front--;
                    arr[front] = num;
                    cout << num << " is inserted at indice " << front << endl;
                }
            }
        }

        void deleteFront(){
            if(isEmpty()){
                cout << "Queue is empty." << endl;
            }else{
                cout << "Number " << arr[front] << " has been deleted." << endl;
                front ++;
            }
        }

        void insertRear(int num){
            if(isFull()){
                cout << "Queue is full." << endl;
            }else{
                if(rear == 5){
                    cout << "Try inserting from front." << endl;
                }else{
                    cout << num << " is inserted at indice " << rear << endl;
                    arr[rear] = num;
                    rear ++;
                }
            }
        }

        void deleteRear(){
            if(isEmpty()){
                cout << "Queue is empty." << endl;
            }else{
                rear--;
                cout << "Number " << arr[rear] << " is removed.";
            }
        }

        void traverse(){
            if(!isEmpty()){
                int i = front;
                for(i; i<rear; i++){
                    cout << arr[i] << endl;
                }
            }
        }


};

int main(){

    DeQueue queue;
    queue.insertFront(10);
    queue.insertRear(10);
    queue.insertRear(20);
    queue.deleteFront();
    queue.insertFront(40);

    queue.traverse();

    return 0;
}