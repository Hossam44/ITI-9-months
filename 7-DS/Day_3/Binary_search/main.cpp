#include <iostream>

using namespace std;
int arr[10] = {1,2,3,4,5,6,7,8,9,10},n=10;
int binary_search_iterative(int value)
{
    int start=0,last=n-1,mid;
    while(start<=last)
    {
        mid = (start+last)/2;
        if(arr[mid]==value)
            return mid;
        else if(arr[mid]>value)
            last = mid-1;
        else
            start = mid +1;
    }
    return -1;
}
int binary_search_recursive(int start,int last,int value)
{
    int mid;
    if(start<=last)
    {
        mid = (start+last)/2;
        if(arr[mid]==value)
            return mid;
        else if(arr[mid]>value)
            return binary_search_recursive(start,last-1,value);
        else if(arr[mid]<value)
            return binary_search_recursive(start+1,last,value);
    }
    return -1;
}
int main()
{
    int m;
    cout<<"Enter Number :";
    cin>>m;
    m=binary_search_recursive(0,n-1,m);
    if(m!=-1)
    {
        cout<<"\nYour Number in Position :";
        cout<<m<<endl;
    }
    else
        cout<<"\n------ NOT Exist ------\n";
    return 0;
}
