#include<windows.h>
#include <iostream>
#include "C:\Program Files (x86)\CodeBlocks\MinGW\include\graphics.h"
#include <conio.h>
#define NormalPen 0x0F
#define HighLightPen 0xc0
using namespace std;

void gotoxy1( int column, int line ){
  COORD coord;
  coord.X = column;
  coord.Y = line;
  SetConsoleCursorPosition(
    GetStdHandle( STD_OUTPUT_HANDLE ),
    coord
    );
}

void textattr (int i){
	SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), i);
}

void Print_small_trinagle(int x,int y){     //45   8


    gotoxy1(x,y);
    printf("%c",201);
    for(int i=0;i<2;i++)
    {
        gotoxy1(x,y+1+i);
        printf("%c",186);
    }
    gotoxy1(x,y+2);
    printf("%c",200);

    //first row =
    for(int i=0;i<19;i++)
    {
        gotoxy1(x+1+i,y);
        printf("%c",205);
    }
    //last row =
    for(int i=0;i<19;i++)
    {
        gotoxy1(x+1+i,y+2);
        printf("%c",205);
    }


    gotoxy1(x+20,y);
    printf("%c",187);
    for(int i=0;i<1;i++)
    {
        gotoxy1(x+20,y+1+i);
        printf("%c",186);
    }
    gotoxy1(x+20,y+2);
    printf("%c",188);
    gotoxy1(0,23);

}

void Load_Bar(){


    char firstName[9]="LOADING ",LastName[9]="NOTEPAD ";
    /*                               print all colors
    gotoxy(40,2);
    for(int i=0;i<50;i++)
    {
        SetColor(i);
        printf("%c",254);
    }
    */


    int sm=254,bi=219;                 //small and big char for print
    printf("\n");
    //
    //1<----------------------------------->       For first "H"
    gotoxy1(49,10);
    textattr(22);
    printf(" H ");
    textattr(NormalPen);


    textattr(97);                                  //For last H in the begging
    printf(" H ");
    textattr(NormalPen);
    //1<----------------------------------->

    //2<----------------------------------->       print Loading
    Sleep(80);
    gotoxy1(52,10);
    printf(" ");
    for(int i=0;i<8;i++)
    {
        textattr(97);
        gotoxy1(52+i+1,10);
        printf(" H ");
        Sleep(80);
        gotoxy1(52+i+1,10);
        textattr(6);
        printf("%c",firstName[i]);
    }
    textattr(97);
    printf(" H ");
    Sleep(80);
    //2<----------------------------------->

    //3<----------------------------------->       print NotePAD
    gotoxy1(98,10);
    textattr(NormalPen);
    printf(" ");
    for(int i=0;i<8;i++)
    {
        textattr(97);
        gotoxy1(60+i+1,10);
        printf(" H ");
        Sleep(80);
        gotoxy1(60+i+1,10);
        textattr(9);
        printf("%c",LastName[i]);
    }
    gotoxy1(69,10);
    textattr(97);
    printf(" H ");
    textattr(NormalPen);
    //3<----------------------------------->

    {
    /*
        //2<----------------------------------->       Print The words
        textattr(6);
        printf(" LOADING");
        textattr(15);
        printf(" ");
        textattr(9);
        printf("NOTEPAD ");
        textattr(15);
        //2<----------------------------------->

        //3<----------------------------------->       For Last "H"
        textattr(97);
        printf(" H ");
        textattr(NormalPen);
        //3<----------------------------------->

    */
    }

    //4<------------------------------------>      first print
    gotoxy1(20,12);
    textattr(8);
    for(int i=0;i<80;i++)
    {
        printf("%c",sm);
    }
    //4<----------------------------------->

    //5<------------------------------------>      overWrite in the print and restore it
    gotoxy1(20,12);
    for(int i=0;i<80;i++)
    {
        textattr(9);
        printf("%c",bi);
        Sleep(40);
        gotoxy1(20+i,12);
        textattr(6);
        printf("%c",sm);
        //textattr(NormalPen);
    }
    textattr(9);
    printf("%c",bi);
    textattr(NormalPen);

    textattr(9);
    Print_small_trinagle(50,15);
    textattr(NormalPen);

    gotoxy1(54,16);
    textattr(97);
    printf("    START    ");
    textattr(NormalPen);
    gotoxy1(0,0);

    getch();
    system("cls");
}

/// ------------------------------- Class Color ------------------------------------- ///

class Color
{
protected:
    int color;
public:
    Color()
    {
        color=0;
    }
    Color(int _color)
    {
        color=_color;
    }
    void set_color(int _color)
    {
        color=_color;
    }
    int getcolor()
    {
        return color;
    }
};
/// ------------------------------- Class Point ------------------------------------- ///
class Point
{
    int x, y;
public:

    Point()
    {
        x=y=0;
    }
    Point (int _x, int _y)
    {
        x = _x;
        y = _y;
    }
    int GetX()
    {
        return x;
    }
    int GetY()
    {
        return y;
    }
    void SetX(int _x)
    {
        x = _x;
    }
    void SetY(int _y)
    {
        y = _y;
    }

};

/// ------------------------------- Class Rectangle ------------------------------------- ///

class Rect : public Color
{
    Point UL;
    Point LR;
public:

     // Constructor and Destructor ...
    Rect()
    :UL(),LR()
    {
        color = 0;
        //cout<<"dasdas"<<endl;
    }
    Rect(int x1, int y1, int x2, int y2, int c)
    :UL(x1,y1),LR(x2,y2),Color(c)
    {}
    void Draw()
    {
        int heigh,wiedth;
        setcolor(0);
        rectangle(UL.GetX(), UL.GetY(), LR.GetX(), LR.GetY());
        setcolor(color);
        int i=0,j=0;
        while(1)//(UL.GetX()+i!=LR.GetX()-i)&&(UL.GetY()+j!=LR.GetY()-j))
        {
            if((UL.GetX()+i!=LR.GetX()-i))
            {
                i++;
            }
            if((UL.GetY()+j!=LR.GetY()-j) )
            {
                j++;
            }

            //cout<<UL.GetX()+i<<"  "<<LR.GetX()-i<<endl;

            rectangle(UL.GetX()+i, UL.GetY()+j, LR.GetX()-i, LR.GetY()-j);
            if(UL.GetX()+i+1==LR.GetX()-i || UL.GetY()+j==LR.GetY()-j)
                break;
            //cout<<"sdada"<<endl;
        }

    }
};


/// ------------------------------- Class Circle ------------------------------------- ///

class Circle : public Color
{
    Point Center ;
    int Raduis ;

public:

     // Constructor and Destructor ...
    Circle():Center(),Color()
    {
        int Raduis = 0;
        int color = 0;
    }
    Circle(int x1, int y1, int rad , int col)
    :Center(x1,y1),Color(col)
    {
        Raduis =rad;
    }

    void Draw()
    {
        setcolor(0);
        circle(Center.GetX(),Center.GetY(),Raduis);
        circle(Center.GetX(),Center.GetY(),Raduis-1);

        setcolor(color);
        for(int i=Raduis-2;i>=0;i--)
            circle(Center.GetX(),Center.GetY(),i);
    }
};


/// ------------------------------- Class Line ------------------------------------- ///

class Line : public Color
{
    Point Head ;
    Point Tail ;

public:

    Line():Head(),Tail(),Color()
    {
        int color = 0;
    }
    Line(int x1, int y1, int x2 ,int y2, int col)
    : Head(x1,y1),Tail(x2,y2),Color(col)
    {}

    void Draw()
    {
        setcolor(color);
        line(Head.GetX(),Head.GetY(),Tail.GetX(),Tail.GetY());
    }

};


/// ------------------------------- Class Triangle ------------------------------------- ///

class Triangle : public Color
{
    Point Left ;
    Point Right ;
    Point Upper;
public:

     // Constructor  ...
    Triangle():Color()
    {}

    Triangle(int x1, int y1, int x2 ,int y2,int x3,int y3, int col)
    : Left(x1,y1),Right(x2,y2),Upper(x3,y3),Color(col)
    {}

    void Draw()
    {
        setcolor(color);
        for(int i=0;i<160;i++)
        {
            line(Left.GetX()+i,Left.GetY(),Right.GetX(),Right.GetY()+i);            //left
            //line(Left.GetX()+i,Left.GetY()-i,Upper.GetX()-i,Upper.GetY()-i);              //down
            line(Right.GetX(),Right.GetY()+i,Upper.GetX()-i,Upper.GetY());                  //right

        }
    }

};



int main()
{
    //Load_Bar();
    getch();

    initgraph();






    Rect R1(300,230,781,528,13);
    R1.Draw();
    Rect R2(700,120,781,230,13);
    R2.Draw();

    Rect R3(670,100,811,120,6);
    R3.Draw();

    Triangle T1(265,230,540,70,816,230,4);
    T1.Draw();
    Rect door(490,350,590,528,4);
    door.Draw();


    Rect door_down(450,518,630,540,13);
    door_down.Draw();

    Rect window1(630,280,740,380,4);
    window1.Draw();
    Rect window2(340,280,450,380,4);
    window2.Draw();

    Rect window_slide1(392,280,400,380,13);
    window_slide1.Draw();
    Rect window_slide2(340,325,450,333,13);
    window_slide2.Draw();

    Rect window_slide3(683,280,691,380,13);
    window_slide3.Draw();
    Rect window_slide4(630,325,740,333,13);
    window_slide4.Draw();


    Rect window_down1(610,378,760,400,6);
    window_down1.Draw();
    Rect window_down2(320,378,470,400,6);
    window_down2.Draw();


    Circle C1(505,430,12,6);
    C1.Draw();
    //Circle C2(358,119,20,20);
    //C2.Draw();

    //Line L1(331,317,331,230,3);
    //L1.Draw();

    //Line L2(387,317,387,230,3);
    //L2.Draw();

    //Line L3(387,188,367,117,3);
    //L3.Draw();

    //Line L4(325,194,348,117,3);
    //L4.Draw();


    getch();
    system("cls");

    //line(200, 200, 300, 300);
    //circle(300, 300, 50);
    //line(110,120,130,120);
    //line(110,120,115,140);
    //line(130,120,115,140);

    return 0;
}
