#include <iostream>
#include <string>
using namespace std;

int powerOfNumber(int number , int power){
    if(power > 1){
        return number * powerOfNumber(number , power - 1);
    }else {
        return number;
    }
}

int main() {

    int powerOf3 = powerOfNumber(3,3);
    cout << "3 raised to 3 is: " << powerOf3;

    return 0;
}