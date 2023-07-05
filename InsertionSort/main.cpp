#include <iostream>
#include <vector>
using namespace std;
void InsertionSort(vector<int> &numbers)
{
    int value ;
    for(int i = 1 ; i < numbers.size() ; i++)
    {
        value = numbers[i] ;
        for(int j = i - 1 ; j >= 0 ; j-- )
        {
            if(value < numbers[j])
            {
                numbers[j+1] = numbers[j] ;
                numbers[j] = value ;
            }
            else
            {
                break ;
            }
        }
    }

}
int main()
{
    vector<int> num = {1 , 9, 3, 5 , 7 , 33,2 ,6} ;
    for(int i= 0 ; i < num.size() ; i++)
    {
        cout << num.at(i) << " " ;
    }
    return 0;
}
