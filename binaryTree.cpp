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

    void preOrderTraversal(Node * temp){
        if(temp != NULL){
            cout << temp->getData() << " ";
            preOrderTraversal(temp->getLChild());
            preOrderTraversal(temp->getRChild());
        }
    }

    void inOrderTraversal(Node * temp){
        if(temp != NULL){
            inOrderTraversal(temp->getLChild());
            cout << temp->getData() << " ";
            inOrderTraversal(temp->getRChild());
        }
    }

    void postOrderTraversal(Node * temp){
        if(temp != NULL){
            postOrderTraversal(temp->getLChild());
            postOrderTraversal(temp->getRChild());
            cout << temp -> getData() << " ";
        }
    }

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
        }else if(pres->getLChild() !=NULL && pres->getRChild()!=NULL){
            if(pres->getData() < prev->getData()){
                prev->setLChild(pres->getLChild());
            }else{
                prev->setRChild(pres->getLChild());
            }

            Node * trav = pres;

            while(trav->getRChild() != NULL){
                trav = trav->getRChild();
            }

            trav->setRChild(pres->getRChild());
            delete pres;
        }
    }

    void preOrderTraversal(){
        preOrderTraversal(root);
    }

    void inOrderTraversal(){
        inOrderTraversal(root);
    }

    void postOrderTraversal(){
        postOrderTraversal(root);
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

    cout << "Pre-order" <<endl;
    binarytree.preOrderTraversal();

    cout << endl;
    cout << "In-order" << endl; 
    binarytree.inOrderTraversal();

    cout << endl;
    cout << "Post-order" << endl; 
    binarytree.postOrderTraversal();
}