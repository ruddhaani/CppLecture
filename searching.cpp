#include <iostream>

using namespace std;

class Searching{

    public:
        static void linearSearch(int arr[] , int size , int data){
            for(int i = 0; i<size ; i++){
                if(arr[i] == data){
                    cout << "Element " << data << " found at indice " << i << endl; 
                    return;
                }
            }

            cout << "Element "<< data << " not present in the array" << endl;
        }
};


int main(){
    int arr[5] = {10,20,30,40,50};

    Searching::linearSearch(arr , 5 , 70);
    return 0;
}
