#include <iostream>
#include <vector>
#include <cmath>

using namespace std;

float StandardDeviation(int arr[], int  n)
{
    int avg = 0 , sum = 0 ;
    float a = 0 , sd;
    for(int i = 0 ; i < n; i++)
    {
        avg += arr[i];
    }
    avg = avg / n ;
    for(int i = 0 ; i < n ; i++)
    {
        a += (arr[i]-avg) * (arr[i]-avg);
    }
    sd = sqrt(a/n);
    return sd ;

}

int main()
{
    int n ;
    cout << "Enter Number of Items" << endl ;
    cin >> n ;
    int arr[n] ;
    for(int i = 0 ; i < n ; i++)
    {
        cout << "Enter item number [" << i+1 << "]" << endl ;
        cin >> arr[i]  ;
    }
    cout << StandardDeviation(arr , n) ;
    return 0;
}
