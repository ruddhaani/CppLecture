#include <stdio.h>
#include <stdlib.h>

void changeNumber(int *);

int main(){

    int x = 10;

    printf("%d\n" , x);

    changeNumber(&x);

    printf("%d" , x);

    return 0;
}

void changeNumber(int *num){
    (*num)++;
}