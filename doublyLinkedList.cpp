#include <iostream>

using namespace std;

class Node{
    Node * prev , * next;
    int data;

    public:
        Node() {
            prev = NULL;
            next = NULL;
            data = 0;
        }

        Node(int data){
            prev = NULL;
            next = NULL;
            this->data = data;
        }

        int getData(){
            return data;
        }

        void setData(int data){
            this->data = data;
        }

        Node * getPrevious(){
            return prev;
        }

        void setPrevious(Node * temp){
            prev = temp;
        }

        Node * getNext() {
            return next;
        }

        void setNext(Node * temp){
            next = temp;
        }
};

class DoublyLinkedList{
    Node * head;

    public:
        DoublyLinkedList(){
            head = NULL;
        }

        void insertBeginning(int data){
            Node * temp = new Node(data);
            if(head == NULL){
                head = temp;
                return;
            }else {
                temp->setNext(head);
                head->setPrevious(temp);
                head = temp;
            }
        }

        void insertEnd(int data){
            Node * temp = new Node(data);
            if(head == NULL){
                head = temp;
                return;
            }else{
                Node * trav = head;
                while(trav->getNext()){
                    trav = trav->getNext();
                }

                trav->setNext(temp);
                temp->setPrevious(trav);
            }
        }

        void insertBetween(int data , int pos){
            if(pos<=0){
                cout << "Invalid position" << endl;
                return;
            }else if(pos == 1){
                insertBeginning(data);
                return;
            }else{
                Node * trav = head;
                Node * prev = head;
                int i = 0;

                while(i < pos-1){
                    if(trav != NULL){
                        prev = trav;
                        trav = trav->getNext();
                        i++;
                    }else{
                        cout << "Invalid position" << endl;
                        return;
                    }
                }
                if(trav!=NULL){
                    Node * temp = new Node(data);
                    prev->setNext(temp);
                    trav->setPrevious(temp);
                    temp->setPrevious(prev);
                    temp->setNext(trav);
                }else{
                    cout << "Invalid position" << endl;
                }
            }
        }

        void deleteBeginning(){
            if(head == NULL){
                cout << "Linked list empty." << endl;
                return;
            }else{
                if(head->getNext() == NULL){
                    delete head;
                    head = NULL;
                }else{
                    Node * temp = head;
                    head = head->getNext();
                    head->setPrevious(NULL);
                    delete temp;
                }
            }
        }

        void deleteEnd(){
            if(head == NULL){
                cout << "Empty Linked list";
                return;
            }else{
                if(head->getNext() == NULL){
                    delete head;
                    head = NULL;
                }else{
                    Node * prev = head;
                    Node * pres = head;

                    while(pres->getNext() != NULL){
                        prev = pres;
                        pres = pres->getNext();
                    }

                    delete pres;
                    prev->setNext(NULL);
                }
            }
        }

        void deleteBetween(int pos) {
            if (head == NULL) {
                cout << "Linked list empty." << endl;
                return;
            }

            if (pos <= 0) {
                cout << "Invalid position" << endl;
                return;
            } else if (pos == 1) {
                deleteBeginning();
                return;
            } else {
                Node* prev = head;
                Node* pres = head;
                int i = 1; 

                while (i < pos && pres != NULL) {
                    prev = pres;
                    pres = pres->getNext();
                    i++;
                }

                if (pres == NULL) {
                    cout << "Invalid position." << endl;
                    return;
                }

                prev->setNext(pres->getNext());
                if (pres->getNext() != NULL) {
                    pres->getNext()->setPrevious(prev);
                }
                delete pres;
            }
        }


        void traverse() {
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

int main(){

    DoublyLinkedList list;

    list.insertBeginning(10);
    list.insertBeginning(20);
    list.insertEnd(30);
    list.insertBetween(100,3);
    list.deleteBetween(2);

    list.traverse();

    return 0;
}