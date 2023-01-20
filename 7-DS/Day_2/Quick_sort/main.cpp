#include <iostream>

using namespace std;
int n;

int Patation(int arr[],int first,int last)
{
    int i=first;
    int j=last;
    int pivloc = i;
    while(1)
    {
        while(arr[pivloc]<=arr[j] && pivloc != j)
            j--;
        if(pivloc==j)
            break;
        else if(arr[pivloc]>arr[j])
        {
            swap(arr[pivloc],arr[j]);
            pivloc=j;
        }
        while(arr[pivloc]>=arr[i] && pivloc != i)
            i++;
        if(pivloc==i)
            break;
        else if(arr[pivloc]<arr[i])
        {
            swap(arr[pivloc],arr[i]);
            pivloc=i;
        }
    }
    return pivloc;
}
void Quick_sort(int arr[],int first,int last)
{
    if(first<last)
    {
        int piv = Patation(arr,first,last);
        Quick_sort(arr,first,piv-1);
        Quick_sort(arr,piv+1,last);
    }
}

int main()
{
    cout<<"Enter Number of elements :";
    cin>>n;
    cout<<"Enter elements :\n";
    int *arr=new int[n];
    for(int i=0;i<n;i++)
        cin>>arr[i];

    Quick_sort(arr,0,n-1);
    cout<<"Sorted Elements Asc:";
    for(int i=0;i<n;i++)
    {
        cout<<arr[i]<<" ";
    }

    return 0;
}
