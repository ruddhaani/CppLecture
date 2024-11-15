#include <iostream>

using namespace std;

class Node{
    int data;
    Node * next;

    public:
        Node(){
            data = 0;
            next = nullptr;
        }

        Node(int data){
            this->data = data;
            this->next = nullptr;
        }

        void setData(int data){
            this->data = data;
        }

        int getData() {
            return data;
        }

        void setNext(Node * next){
            this->next = next;
        }

        Node * getNext(){
            return next;
        }
};