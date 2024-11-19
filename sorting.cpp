#include <iostream>

using namespace std;

class Sorting{
    public:

    static void bubbleSort(int * arr , int size){
        int n = size - 1;

        for(int i = 0 ; i<n ; i++){
            for(int j = 0; j<n-i; j++){
                if(arr[j] > arr[j+1]){
                    int temp = arr[j];
                    arr[j] = arr[j+1];
                    arr[j+1] = temp;
                }
            }
        }
    }

};

int main(){
    int arr[5] = {20,10,50,79,1};

    Sorting::bubbleSort(arr , 5);

    for(int i=0 ; i<5; i++){
        cout << i << " : " << arr[i] << endl;
    }

    return 0;
}