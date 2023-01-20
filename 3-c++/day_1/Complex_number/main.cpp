#include <iostream>

using namespace std;

class Complex{
private:
    int real;
    int imaginary;
public:
     static int i;

     int get_real()
     {
         return real;
     }
     int get_ima()
     {
         return imaginary;
     }
     void set_real(int _real)
     {
         real = _real;
     }
     void set_imaginary(int _imaginary)
     {
         imaginary = _imaginary;
     }
     void print()
     {
         if(real!=0 && imaginary>0  )
            cout<<real<<"+"<<imaginary<<"i"<<endl;
         else if(real!=0 && imaginary<0)
            cout<<real<<imaginary<<"i"<<endl;
         else if(real==0 && imaginary!=0)
            cout<<imaginary<<"i"<<endl;
         else if(real!=0 && imaginary==0)
            cout<<real<<endl;
         else
            cout<<"0"<<endl;
     }
     Complex add(Complex c1)
     {
         Complex result;
         result.real = real + c1.real;
         result.imaginary = imaginary + c1.imaginary;
         return result;
     }
     Complex sub(Complex c1)
     {
         Complex result;
         result.real = real - c1.real;
         result.imaginary = imaginary - c1.imaginary;
         return result;
     }
     ~Complex()
     {
         cout<<"\n"<<this<<endl;
         cout<<"\nNumer :"<<++i<<endl;
     }
};
int Complex::i = 0;


Complex add_complex(Complex c1 ,Complex c2)
{
    Complex c3;
    c3.set_imaginary(c1.get_ima()+c2.get_ima());
    c3.set_real(c1.get_real()+c2.get_real());
    return c3;
}
int main()
{
    Complex c1,c2,c3;
    c1.set_real(6);
    c1.set_imaginary(5);
    c2.set_real(4);
    c2.set_imaginary(3);

    cout<<"Sum :";
    c3=c1.add(c2);

    c3.print();

    //c3 = add_complex(c1,c2);
    //c3.print();

    return 0;
}
