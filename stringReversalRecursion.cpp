#include <iostream>
#include <string.h>

using namespace std;

void reverseString(char str[] , int start, int end){
    if(start >= end){
        return;
    }

    char temp = str[start];
    str[start] = str[end];
    str[end] = temp;

    reverseString(str , start+1 , end-1);
}

int main(){

    char str[] = "Aniruddha Ramane";

    reverseString(str, 0 , strlen(str)-1);

    cout << str;

    return 0;
}