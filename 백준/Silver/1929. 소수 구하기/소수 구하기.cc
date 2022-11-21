#include <iostream>
using namespace std;

int arr[1000001];
void prime() {
    for (int i = 2; i <= 1000000; i++)
    {
        arr[i] = i;
    }
    for (int i = 2; i <= 1000; i++) {
        if (arr[i] == 0) {
            continue;
        }
        for (int j = i * i; j <= 1000000; j += i) {
            arr[j] = 0;
        }
    }
}
int main() {
    prime();
    int M, N;
    cin >> M >> N;
    for (int i = M; i <= N; i++) {
        if (arr[i] != 0) {
            cout << i << "\n";
        }
    }
    return 0;
}