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
    void deleteAll(){
        if(head == NULL){
            cout << "Already empty." << endl;
        }else{
                Node * trav = head;
                Node * prev;
                while(trav != NULL){
                    prev = trav;
                    trav = trav->getNext();
                    delete prev;
                    cout << "Deleted" << endl;
                }
            }
        }

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

        void insertBetween(int data , int pos){
            if(pos <= 0){
                cout << "Invalid Syntax" << endl;
                return;
            }else if(pos == 1){
                insertBeginning(data);
                return;
            }else{
                int i = 1;
                Node * trav = head;

                while(i<pos - 1){
                    if(trav != NULL){
                        trav = trav->getNext();
                        i++;
                    }else {
                        cout << "Invalid position." << endl;
                        return;
                    }
                }

                Node * temp = new Node(data);
                temp->setNext(trav->getNext());
                trav->setNext(temp);
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

        void deleteBetween(int pos){
            if(head == NULL){
                cout << "Empty linked list." << endl;
                return;
            }else{
                if(pos <=0){
                    cout << "Invalid position" << endl;
                    return;
                }else if(pos == 1){
                    deleteBeginning();
                    return;
                }else{
                    Node * prev , * pres;
                    prev = head;
                    pres = head;
                    int i = 0;
                    while (i < pos-1){
                        if(pres != NULL){
                            prev = pres;
                            pres = pres->getNext();
                            i++;
                        }else {
                            cout << "Invalid position" << endl;
                            return;
                        }
                    }

                    if(pres != NULL){
                        prev->setNext(pres->getNext());
                        delete pres;
                    }else {
                        cout << "Invalid position." << endl;
                        return;
                    }
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

        ~LinkedList(){
            deleteAll();
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
    list.insertBetween(50,2);
    list.deleteEnd();

    list.deleteBetween(2);

    list.traverse();

    return 0;
}

