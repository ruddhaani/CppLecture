#include <iostream>
#include <string.h>
using namespace std;

class LinearQueue{
    int front , rear , arr[5];

    int isFull(){
        if(rear == 5){
            return 1;
        }else{
            return 0;
        }
    }

    int isEmpty(){
        if(front == rear){
            return 1;
        }else{
            return 0;
        }
    }

    public:
        LinearQueue(){
            front = 0;
            rear = 0;
        }

        void offer(int num){
            if(!isFull()){
                arr[rear] = num;
                cout << num << " is inserted at indice " << rear << endl;
                rear++;
            }else{
                cout << "Queue is full" << endl;
            }
        }

        void poll(){
            if(!isEmpty()){
                cout << "Number " << arr[front] << " is removed" << endl;
                front ++;
            }else {
                cout << "Queue is empty." << endl;
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
    LinearQueue queue;

    queue.offer(10);
    queue.poll();
    queue.offer(20);
    queue.offer(30);
    queue.traverse();

    return 0;
}