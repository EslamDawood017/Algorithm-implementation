#include <iostream>
#include <vector>
using namespace std;

int binarySearch(vector<int> arr , int value)
{
    int low = 0 ;
    int high = arr.size() -1 ;
    int mid ;
    while(low <= high)
    {
        mid = (low + high) / 2 ;
        if(arr[mid] == value)
            return mid ;
        else if(arr[mid] < value)
            low = mid + 1 ;
        else
            high = mid - 1 ;
    }
    return -1 ;
}
int main()
{
    vector<int> Numbers = {1,2,3,4,5,6,7,8};
    cout << binarySearch(Numbers , 4);
    return 0;
}
