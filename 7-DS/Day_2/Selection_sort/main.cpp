#include <iostream>

using namespace std;

int index_min_value(int arr[],int start,int End)
{
    int index = arr[start];
    for(int i=start;i<End;i++)
    {
        if(arr[i]<arr[index])
            index = i;
    }
    return index;
}
void Selection_Sort(int arr[],int n)
{
    int index;
    for(int i=0;i<n;i++)
    {
        index = index_min_value(arr,i,n);
        swap(arr[index],arr[i]);
    }

}
//5 4 3 2 1

int main()
{
    int n;
    cout<<"Enter Number of elements :";
    cin>>n;
    cout<<"Enter elements :\n";
    int *arr=new int[n];
    for(int i=0;i<n;i++)
        cin>>arr[i];

    Selection_Sort(arr,n);
    cout<<"Sorted Elements :";
    for(int i=0;i<n;i++)
    {
        cout<<arr[i]<<" ";
    }

    return 0;
}
