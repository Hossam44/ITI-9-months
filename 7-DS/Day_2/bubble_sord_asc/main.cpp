#include <iostream>

using namespace std;

void Bubble_Sort_Asc(int arr[],int n)
{
    int sorted = 0;
    for(int i=0;(i<n)&&!(sorted);i++)
    {
        sorted = 1;
        for(int j=0;j<n-1;j++)
        {
            sorted = 0;
            if(arr[j]>arr[j+1])
                swap(arr[j],arr[j+1]);
        }
    }
}

void Bubble_Sort_Desc(int arr[],int n)
{
    int sorted = 0;
    for(int i=0;(i<n)&&!(sorted);i++)
    {
        sorted = 1;
        for(int j=0;j<n-1;j++)
        {
            sorted = 0;
            if(arr[j]<arr[j+1])
                swap(arr[j],arr[j+1]);
        }
    }
}
int main()
{
    int n;
    cout<<"Enter Number of elements :";
    cin>>n;
    cout<<"Enter elements :\n";
    int *arr=new int[n];
    for(int i=0;i<n;i++)
        cin>>arr[i];

    Bubble_Sort_Asc(arr,n);
    cout<<"Sorted Elements Asc:";
    for(int i=0;i<n;i++)
    {
        cout<<arr[i]<<" ";
    }
    Bubble_Sort_Desc(arr,n);
    cout<<"\nSorted Elements Desc:";
    for(int i=0;i<n;i++)
    {
        cout<<arr[i]<<" ";
    }
    return 0;
}
