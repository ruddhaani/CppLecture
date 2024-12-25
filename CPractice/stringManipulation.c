// Online C compiler to run C program online
#include <stdio.h>

int stringSize(char * ptr);
void stringReverse(char * ptr);
int compareStrings(char * str1 , char * str2);

int main(){
    char name[11] = "Aniruddha";
    char name2[11] = "Aniruddha";
    int size = stringSize(name);
    printf("%d\n" , size);
    
    // stringReverse(name);
    puts(name);
    
    // int asci = (int)name[0];
    // printf("%d" , asci);
    
    int check = compareStrings(name , name2);
    printf("%d\n" , check);
}

//String size

int stringSize(char * ptr){
    int count = 0;
    int i = 0;
    while(ptr[i] != '\0'){
        count++;
        i++;
    }
    
    return count;
}

//stringReverse
void stringReverse(char * ptr){
    int count = stringSize(ptr);
    char temp;
    for(int i = 0 ; i<count/2 ; i++){
        temp = ptr[i];
        ptr[i] = ptr[count - i - 1];
        ptr[count-i-1] = temp;
    }
}

//string Compare
int compareStrings(char * str1 , char * str2){
    if(stringSize(str1) == stringSize(str2)){
        int i = 0;
        while(str1[i] != '\0'){
            if((int)str1[i] != (int)str2[i]){
                return 0;
            }
            i++;
        }
    }
    
    return 1;
}

