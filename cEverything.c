#include <stdio.h>
#include <stdlib.h>

double areaCircle(double);

int factorial(int); // recursive function

int largestValue(int *, int);

const float PI = 3.14;

int main() {
    double areaOfCircle = areaCircle(2);
    printf("Area of the circle is %.2lf \n", areaOfCircle);

    
    int factorized = factorial(3);
    printf("Factorial of 3 is %d\n", factorized);
    
    int arr[] = {10,53,11,34,14,23,22};
    int *ptr;
    ptr = arr;
    
    int max = largestValue(ptr, 7);
    printf("Largest number is %d", max);
    
}

int largestValue(int *ptr , int size){
    int maximum = *ptr;
    for (int i = 0; i < size ; i++){
        if(*ptr > maximum){
            maximum = *ptr;
        }
        ptr ++;
    }
    
    return maximum;
}

int factorial(int num) {
    if (num > 0) {
        return num * factorial(num - 1);  // Using num - 1 instead of --num
    } else {
        return 1;
    }
}

double areaCircle(double r) {
    return (PI * r * r);
}



