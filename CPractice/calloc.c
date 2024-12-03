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


    free(ptr);
    return 0;
}