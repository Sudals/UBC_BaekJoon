#include <iostream>

int main()
{
    int result = 0;
    double A, B, V;

    std::cin >> A >> B >> V;

    double Middle = (V - B) / (A - B);

    if (Middle - (int)Middle == 0) result = (int)Middle;
    else result = (int)Middle + 1;

    std::cout << result;

}