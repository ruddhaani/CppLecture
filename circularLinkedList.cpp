#include <iostream>

using namespace std;

class Node {
    int data;
    Node* next;

public:
    Node() {
        next = NULL;
        data = 0;
    }

    Node(int data) {
        this->data = data;
        next = NULL;
    }

    void setData(int data) {
        this->data = data;
    }

    void setNext(Node* next) {
        this->next = next;
    }

    int getData() {
        return data;
    }

    Node* getNext() {
        return next;
    }
};

class CircularLinkedList {
    Node* tail;

public:
    CircularLinkedList() {
        tail = NULL;
    }

    void insertBeginning(int data) {
        Node* temp = new Node(data);
        if (tail == NULL) {
            tail = temp;
            tail->setNext(temp);
            return;
        }

        temp->setNext(tail->getNext()); 
        tail->setNext(temp); 
    }

    void insertEnd(int data){
        if(tail == NULL){
            insertBeginning(data);
            return;
        }

        Node * temp = new Node(data);
        temp->setNext(tail->getNext());
        tail->setNext(temp);
        tail = temp;
    }

    void insertBetween(int data , int position){
        if(position <= 0){
            cout << "Invalid position." << endl;
            return;
        }

        if(position == 1){
            insertBeginning(data);
            return;
        }

        Node * temp = new Node(data);
        Node * trav = tail->getNext();
        int count = 1;
        while(count < position - 1){
            if(trav->getNext() == tail->getNext()){
                cout << "Invalid position" << endl;
                delete temp;
                return;
            }

            trav = trav->getNext();
            count++;
        }

        temp->setNext(trav->getNext());
        trav->setNext(temp);
    }

    void deleteBeginning(){
        if(tail == NULL){
            cout << "List is Empty" << endl;
            return;
        }else if(tail->getNext() == tail){
            delete tail;
            tail = NULL;
            return;
        }

        tail->setNext(tail->getNext()->getNext());
        delete tail->getNext();
    }

    void deleteEnd(){
        if(tail == NULL){
            cout << "Empty list" << endl;
            return;
        }else if(tail->getNext() == tail){
            delete tail;
            tail = NULL;
            return;
        }

        Node * prev = tail->getNext();
        Node * pres = tail->getNext();

        while(pres!=tail){
            prev = pres;
            pres = pres->getNext();
        }

        prev->setNext(pres->getNext());
        tail = prev;
        delete pres;
    }

    void traverse() {
        if (tail == NULL) {
            cout << "Empty" << endl;
            return;
        }

        Node* trav = tail->getNext(); 
        do {
            cout << trav->getData() << endl;
            trav = trav->getNext(); 
        } while (trav != tail->getNext()); 
    }
};

int main() {
    CircularLinkedList cll;

    cll.insertBeginning(10);
    cll.insertBeginning(20);
    cll.insertBeginning(30);

    cll.traverse();

    return 0;
}
