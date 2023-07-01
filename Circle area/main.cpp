#include <iostream>

using namespace std;

float CircleArea(float r)
{
    return  3.1415 * (r * r);
}
float parallelogramArea(float Base , float height)
{
    return Base * height ;
}
float TrapezoidArea(float base1 , float base2 , float height)
{

    return (base1 + base2) * .5 * height ;
}
int main()
{
    cout << TrapezoidArea(16,20.5,5);

    return 0;
}
