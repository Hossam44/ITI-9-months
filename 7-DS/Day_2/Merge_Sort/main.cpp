#include <iostream>

using namespace std;
int n;
void Merge(int arr[],int f_first,int l_first,int f_last,int l_last)
{
    int size_temp = l_last-f_first+1;
    int *temp = new int[size_temp];
    int index = 0;
    int save_first = f_first;

    while((f_first<=l_first)&&(f_last<=l_last))
    {
        if(arr[f_first]<arr[f_last])
        {
            temp[index++]=arr[f_first++];
        }
        else
        {
            temp[index++]=arr[f_last++];
        }
    }
    while(f_first<=l_first)
    {
        temp[index++]=arr[f_first++];
    }
    while(f_last<=l_last)
    {
        temp[index++]=arr[f_last++];
    }
    for(int i=0;i<size_temp;i++)
    {
        arr[i+save_first]=temp[i];
    }
}

void merge_sort(int arr[],int first,int last)
{
    if(first<last)
    {
        int mid = (first+last)/2;
        merge_sort(arr,first,mid);
        merge_sort(arr,mid+1,last);
        Merge(arr,first,mid,mid+1,last);
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

    merge_sort(arr,0,n-1);
    cout<<"Sorted Elements Asc:";
    for(int i=0;i<n;i++)
    {
        cout<<arr[i]<<" ";
    }

    return 0;
}
