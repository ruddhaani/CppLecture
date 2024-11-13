#include <iostream>

using namespace std;

int sumOfNumbers(int n){
    if(n>0){
        return n + sumOfNumbers(n-1);
    }else{
        return 0;
    }
}

int main(){
    int sum = sumOfNumbers(5);
    cout << sum;
}