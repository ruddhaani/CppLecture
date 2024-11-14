#include <iostream>
#include <string.h>

using namespace std;

class Time{
    static int count;

    public:
        Time(){
            count++;
        }

        void getCount(){
            cout << count << endl;
        }


};


int Time::count = 0;

int main(){
    Time t1;
    Time t2;
    Time t3;
    Time t4;

    t4.getCount();
    t1.getCount();
}