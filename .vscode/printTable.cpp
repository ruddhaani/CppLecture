#include <iostream>

using namespace std;

void printTable(int n , int i = 1){
    if(i>10){
        return;
    }

    cout << n << " x " << i << " = " << n*i << endl;

    printTable(n, i+1);

}

int main(){
    printTable(10);
}