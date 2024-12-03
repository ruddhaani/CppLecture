#include <stdio.h>
#include <string.h>
#include <stdlib.h>

int main(){
    int *ptr , size;
    
    printf("Enter size: \n");
    scanf("%d" , &size);

    ptr = (int*)malloc(size * sizeof(int));

    if(ptr == NULL){
        printf("Memory allocation failed");
        exit(0);
    }

    printf("\n");
    printf("##########################################\n");
    printf("Enter elements of the array: \n");

    for(int i = 0; i<size ; i++){
        scanf("%d" , &ptr[i]);
    }

    printf("\n");
    printf("##########################################\n");
    printf("The elements of the array are: \n");

    for(int i = 0; i<size ; i++){
        printf("%d\n" , ptr[i]);
    }


    return 0;
}