#include <iostream>
#include <vector>
#include <string>


using namespace std;

const int Max = 100;

vector<string> Lebals = { "A" , "B" , "C" , "D" , "E" , "F" , "G" , "H" , "I" , "J" };

vector<vector<int>> _data = {
    {0, 2, 4, 3, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 7, 4, 6, 0, 0, 0},
    {0, 0, 0, 0, 3, 2, 4, 0, 0, 0},
    {0, 0, 0, 0, 4, 1, 5, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 1, 4, 0},
    {0, 0, 0, 0, 0, 0, 0, 6, 3, 0},
    {0, 0, 0, 0, 0, 0, 0, 3, 3, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 3},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 4},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
};

struct State 
{
    string from;
    string to;
    int Cost;
};


int main()
{
    int n = _data.size(); 
    vector<State>States(n);

    States[n - 1].from = "";
    States[n - 1].to = "";
    States[n - 1].Cost = 0;

    for (int i = n - 2; i >= 0; i--)
    {
        States[i] = { Lebals[i] , "" , INT_MAX };

        for (int j = i + 1; j < n; j++)
        {
            if (_data[i][j] == 0) continue;

            int newCost = _data[i][j] + States[j].Cost; 

            if (newCost < States[i].Cost)
            {
                States[i].to = Lebals[j];
                States[i].Cost = newCost;

            }
        }
    }

    cout <<  "Minimum Cost " << States[0].Cost;
}

