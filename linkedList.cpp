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

class LinkedList{
    Node * head;

    public:

        LinkedList(){
            head = nullptr;
        }

        void insertBeginning(int num){
            Node * temp = new Node(num);
            temp->setNext(head);
            head = temp;
        }

        void insertEnd(int num){
            Node * temp = new Node(num);
            if(head == nullptr){
                head = temp;
            }else{
                Node * traverse = head;

                while(traverse->getNext() != NULL){
                    traverse = traverse->getNext();
                }

                traverse->setNext(temp);
            }
        }

        void deleteBeginning(){
            if(head == NULL){
                cout << "Empty linked list. Cannot delete." << endl;
            }else{
                Node * temp = head->getNext();
                delete head;
                head = temp;
            }
            
        }

        void deleteEnd(){
            if(head == NULL){
                cout << "Empty linked list. Cannot delete." << endl;
            }else{
                if(head->getNext() == NULL){
                    delete head;
                    head = NULL;
                }else{
                    Node * previous , * present;
                    previous = head;
                    present = head;

                    while(present->getNext() != NULL){
                        previous = present;
                        present = present->getNext();
                    }

                    delete present;
                    previous->setNext(NULL);
                }
            }
        }

        void traverse(){
            if(head == NULL){
                cout << "Empty Linked list. Cannot traverse." << endl;
            }else{
                Node * trav = head;
                while(trav != NULL){
                    cout << trav->getData() << endl;
                    trav = trav->getNext();
                }
            }    
        }

};

int main() {

    LinkedList list;

    list.deleteBeginning();
    list.deleteEnd();

    list.insertEnd(10);
    list.insertEnd(20);
    list.insertEnd(30);
    list.insertBeginning(40);
    list.deleteEnd();

    list.traverse();

    return 0;
}

