#include <iostream>
#include <string.h>
using namespace std;

class Time {
    int hour , min , sec;

    public:
        Time(){

        }

        Time(int hour, int min , int sec){
            this->hour = hour;
            this->min = min;
            this->sec = sec;
        }

        Time operator+ (Time &K){
            
            Time temp;

            temp.hour = hour + K.hour;
            temp.min = min + K.min;
            temp.sec = sec + K.sec;

            return temp;

        }

        void display(){
            cout << hour << " " << min << " " << sec << endl;
        }


};

int main(){

    Time t1(1,2,3);
    Time t2(10,11,12);

    Time t3;
    t3 = t2 + t1;
    t3.display();

    return 0;
}