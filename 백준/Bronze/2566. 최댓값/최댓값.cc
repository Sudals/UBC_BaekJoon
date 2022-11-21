#include<iostream>
#define N 9
using namespace std;
 
int y, x;      
int result;      
 
void Solution(){
    int tmp;
    for(int i=0; i<N; i++){
        for(int j=0; j<N; j++){
            cin >> tmp;
 
            if(tmp > result){
                y = i;
                x = j;
                result = tmp;
            }
        }
    }
 
}
 
void Output(){
    cout << result << endl;
    cout << y+1 << " " << x+1;
}
 
int main(void){
 
    Solution();
    Output();
 
    return 0;
}
