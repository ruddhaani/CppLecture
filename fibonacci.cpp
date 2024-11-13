#include <iostream>
using namespace std;

int fibonacci(int n) {
    if(n <= 1){
        return n;
    }else{
        return fibonacci(n - 1) + fibonacci(n - 2);
    }
    
}

void displayFibonacci(int n){

    for(int i=0; i<n; i++){
        cout << fibonacci(i) << " ";
    }

}

int main() {
    displayFibonacci(5);
}
