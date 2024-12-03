#include <stdio.h>
#include <stdlib.h>

int main(){

    int *ptr , size;

    printf("Enter size of the array: \n");
    scanf("%d" , &size);

    ptr = (int*) calloc(size, sizeof(int));

    printf("\n");
    printf("########################################\n");
    for(int i = 0 ; i<size ; i++){
        printf("%d\n" , ptr[i]);
    }

    int newSize;
    printf("Enter size of the array: \n");
    scanf("%d" , &newSize);

    ptr = (int*) realloc(ptr , newSize * sizeof(int));

    printf("\n");
    printf("########################################\n");
    int newest = newSize + size;
    for(int i = 0 ; i<newest ; i++){
        printf("%d\n" , ptr[i]);
    }

    free(ptr);
    return 0;
}