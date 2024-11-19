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

        static void binarySearch(int * arr , int size , int data){
            int beg = 0;
            int end = size-1;
            int mid;
            while(beg <= end){
                mid = (beg + end)/2;

                if(data < arr[mid]){
                    end = mid-1;
                }else if(data > arr[mid]){
                    beg = mid + 1;
                }else if(data == arr[mid]){
                    cout << "Element found at index: " << mid << endl;
                    return;
                } 
            }

            cout << "Element not found." << endl;
        }
};


int main(){
    int arr[5] = {10,20,30,40,50};

    Searching::linearSearch(arr , 5 , 70);

    Searching::binarySearch(arr , 5 , 100);
    return 0;
}
