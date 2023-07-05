#include <iostream>
#include <cmath>

using namespace std;
float Correlation(float xPoints[] ,float Ypoints[] ,int n )
{
    float SumXY = 0 ,SumX = 0 , SumY = 0 , SumXX = 0 , SumYY = 0 ;
    float a = 0 , b = 0 ;
    for(int i = 0 ; i < n ; i++)
    {
        SumXY += (xPoints[i] * Ypoints[i]) ;
        SumX += xPoints[i] ;
        SumY += Ypoints[i] ;
        SumXX += xPoints[i] * xPoints[i] ;
        SumYY += Ypoints[i] * Ypoints[i] ;
    }


    a = n *SumXY - SumX * SumY  ;
    b = sqrt(n * SumXX - SumX * SumX) * sqrt(n * SumYY - SumY * SumY) ;


    return (a/b) ;


}
int main()
{

    int n ;
    cout << "Enter Number of Point " ;
    cin >> n ;
    float xPoints[n] ;
    float Ypoints[n];
    for(int i = 0 ; i < n ; i++)
    {
        cout << "\n\nEnter Point number [" << i + 1 << "] \n" ;
        cout << "X = " ;
        cin >> xPoints[i] ;
        cout << "Y = " ;
        cin >> Ypoints[i] ;
    }
    cout << Correlation(xPoints , Ypoints , n ) ;

    return 0;
}
