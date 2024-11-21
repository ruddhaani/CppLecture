#include <iostream>

using namespace std;

class Node{
    Node * lChild , * rChild;
    int data;

    public:
        Node(){
            lChild = NULL;
            rChild = NULL;
            data = 0;
        }

        Node(int data){
            lChild = NULL;
            rChild = NULL;
            this->data = data;
        }

        void setData(int data){
            this->data = data;
        }

        void setLChild(Node * temp){
            lChild = temp;
        }

        void setRChild(Node * temp){
            rChild = temp;
        }

        int getData(){
            return data;
        }

        Node * getLChild(){
            return lChild;
        }

        Node * getRChild(){
            return rChild;
        }

};

class BinaryTree{
    Node * root;

    public:
        BinaryTree(){
            root = NULL;
        }

        void insertData(int data) {
        Node *temp = new Node(data); 

        if (root == NULL) { 
            root = temp;
            cout << "Added as root: " << data << endl;
            return;
        }

        Node *prev = NULL;
        Node *pres = root;

        while (pres != NULL) {
            prev = pres;
            if (data < pres->getData()) {
                pres = pres->getLChild();
            } else if (data > pres->getData()) {
                pres = pres->getRChild();
            } else {
                cout << "No duplicate entries allowed: " << data << endl;
                return;
            }
        }

        if (data < prev->getData()) {
            prev->setLChild(temp);
            cout << "Added as left child of: " << prev->getData() << endl;
        } else {
            prev->setRChild(temp);
            cout << "Added as right child of: " << prev->getData() << endl;
        }
    }


    void deleteData(int data){
        if(root == NULL){
            cout << "Empty" << endl;
            return;
        }

        Node * prev = root;
        Node * pres = root;

        while(pres->getData() != data){
            prev = pres;

            if(data < pres->getData()){
                pres = pres->getLChild();
            }else{
                pres = pres->getRChild();
            }
        }

        if(pres->getLChild() == NULL && pres->getRChild() == NULL){
            if(pres->getData() < prev->getData()){
                prev->setLChild(NULL);
            }else{
                prev->setRChild(NULL);
            }

            delete pres;
        }else if(pres->getLChild()!=NULL && pres->getRChild() == NULL){
            if(pres->getData() < prev->getData()){
                prev->setLChild(pres->getLChild());
            }else{
                prev->setRChild(pres->getLChild());
            }

            delete pres;
        }else if(pres->getLChild()==NULL && pres->getRChild() != NULL){
            if(pres->getData() < prev->getData()){
                prev->setLChild(pres->getRChild());
            }else{
                prev->setRChild(pres->getRChild());
            }

            delete pres;
        }
    }
};

int main(){
    BinaryTree binarytree;

    binarytree.insertData(10);
    binarytree.insertData(10);
    binarytree.insertData(20);
    binarytree.insertData(19);
    binarytree.insertData(7);
    binarytree.insertData(9);
    binarytree.insertData(5);
    
}