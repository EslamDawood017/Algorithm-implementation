#include <iostream>
#include <vector>
using namespace std;

void merge(int Numbers[] , int start , int mid , int end)
{
    int i , j ,  k ;

    int left_Length = mid - start + 1 ;
    int Right_Length = end - mid ;

    int Left_arr[left_Length] ;
    int right_arr[Right_Length] ;

    for(i = 0 ; i < left_Length ; i++)
    {
        Left_arr[i] = Numbers[start + i] ;
    }
    for(j = 0 ; j < Right_Length ; j++)
    {
        right_arr[j] = Numbers[mid + 1 + j] ;
    }
    i = 0 ;
    j = 0 ;
    k = start ;
    while(i < left_Length && Left_arr[i] <= 0 )
    {
        Numbers[k] = Left_arr[i] ;
        i++ ;
        k++ ;
    }
    while(j < Right_Length && right_arr[j] <= 0 )
    {
        Numbers[k] = right_arr[j] ;
        j++ ;
        k++ ;
    }

    while(i < left_Length)
    {
        Numbers[k] = Left_arr[i] ;
        i++ ;
        k++ ;
    }
    while(j < Right_Length )
    {
        Numbers[k] = right_arr[j] ;
        j++ ;
        k++ ;
    }
}
void SegregateNumbers(int Numbers[] , int start , int end)
{
    if(end <= start ) return ;

    int mid = (start + end) / 2 ;

    SegregateNumbers(Numbers , start , mid) ;
    SegregateNumbers(Numbers , mid +1 , end) ;
    merge(Numbers , start , mid , end) ;
}

int main()
{

    int Num[] = {1,-2 ,3 ,-4 , 5 , -1} ;
    for(int n : Num )
    {
        cout << n << " " ;
    }
    cout << endl ;

    SegregateNumbers(Num , 0 , 5) ;
    for(int n : Num )
    {
        cout << n << " " ;
    }
    cout << endl << endl ;
    return 0;
}
