// Online C compiler to run C program online
#include <stdio.h>

void findLargestNumber(int *, int);

int main() {
    
    int n;
    printf("Enter size of the array: ");
    scanf("%d" , &n);

    int scores[n];
    
    for(int i=0 ; i<n ; i++){
        scanf("%d" , &scores[i]);
    }
    
    printf("\n");
    printf("\n");
    printf("###########################################\n");
    for(int i = 0; i<n ; i++){
        printf("%d\n" , scores[i]);
    }
    
    int * ptr = scores;
    findLargestNumber(ptr , n);
    return 0;
}

void findLargestNumber(int *ptr , int size){
    int max = *ptr;
    
    for(int i = 0; i < size ; i++){
        if(max < *ptr){
            max = *ptr;
        }
        ptr++;
    }
    
    printf("Largest number is: %d" , max);
}

