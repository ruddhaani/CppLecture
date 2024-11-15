#include <iostream>
#include <string.h>

using namespace std;

class CircularQueue{
    int front , rear , count , arr[5];

    int isFull(){
        if(count == 5){
            return 1;
        }else{
            return 0;
        }
    }

    int isEmpty(){
        if(count == 0){
            return 1;
        }else {
            return 0;
        }
    }
    
    public:
        CircularQueue(){
            front = 0;
            rear = 0;
            count = 0;
        }

        void offer(int num){
            if(isFull()){
                cout << "Queue is full." << endl;
            }else {
                arr[rear] = num;
                cout << num <<" is inserted at indice " << rear << endl;
                rear ++;
                rear = rear%5;
                count++;
            }
        }

        void poll(){
            if(isEmpty()){
                cout << "Queue is empty." << endl;
            }else {
                cout << "Number " << arr[front] << " is deleted" << endl;
                front ++;
                front %= 5;
                count --;
            }
        }

        void traverse(){
            if(isEmpty()){
                cout << "Queue is empty." << endl;
            }else {
                int i = 0;
                int n = front;

                while(i<count){
                    cout << arr[n] << endl;
                    n++;
                    i++;
                    n %= 5;
                }
            }  
        }
};

int main(){

    CircularQueue queue;
    queue.poll();
    queue.offer(10);
    queue.offer(20);
    queue.offer(30);
    queue.offer(40);
    queue.offer(50);
    queue.poll();
    queue.offer(60);

    queue.traverse();

    return 0;
}