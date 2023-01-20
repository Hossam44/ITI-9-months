#include <iostream>

using namespace std;
class base
{
    int x;
protected:
    int y;
public:
    int z;
    base()
    {
        x=y=z=0;
    }
    base(int _x,int _y,int _z)
    {
        x=_x;
        y=_y;
        z=_z;
    }
    int fun()
    {
        x=1;
        y=1;
        z=1;
        return 0;
    }
};
class delivred_1 : public base
{
    int a;
protected:
    int b;
public:
    int c;
    delivred_1():base()
    {
        a=b=c=0;
    }
    delivred_1(int _a,int _b,int _c,int _x,int _y,int _z):base(_x,_y,_z)
    {
        a=_a;
        b=_b;
        c=_c;
    }
    int fun()
    {
        //x=1;      not valid
        y=1;
        z=1;
        a=1;
        b=1;
        c=1;
        return 0;

    }
};
class delivred_2 : public delivred_1
{
    int k;
protected:
    int l;
public:
    int m;
    delivred_2():delivred_1()
    {
        k=l=m=0;
    }
    delivred_2(int _k,int _l,int _m,int _a,int _b,int _c,int _x,int _y,int _z):delivred_1(_a,_b,_c,_x,_y,_z)
    {
        k=_k;
        l=_l;
        m=_m;
    }
    int fun()
    {
        //x=1;      not valid
        y=1;
        z=1;
        //a=1;      not valid
        b=1;
        c=1;
        k=1;
        l=1;
        m=1;
        return 0;
    }
};
int main()
{
    delivred_2 d2(1,1,1,1,1,1,1,1,1);

    d2.c=0;
    return 0;
}
