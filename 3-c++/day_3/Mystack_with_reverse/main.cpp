#include <iostream>
#include<windows.h>
#include <conio.h>
#define NormalPen 0x0F
#define HighLightPen 0xc0
using namespace std;

void gotoxy( int column, int line ){
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
void Print_small_rectangle(int x,int y){     //45   8


    gotoxy(x,y);
    printf("%c",201);
    for(int i=0;i<2;i++)
    {
        gotoxy(x,y+1+i);
        printf("%c",186);
    }
    gotoxy(x,y+2);
    printf("%c",200);

    //first row =
    for(int i=0;i<19;i++)
    {
        gotoxy(x+1+i,y);
        printf("%c",205);
    }
    //last row =
    for(int i=0;i<19;i++)
    {
        gotoxy(x+1+i,y+2);
        printf("%c",205);
    }


    gotoxy(x+20,y);
    printf("%c",187);
    for(int i=0;i<1;i++)
    {
        gotoxy(x+20,y+1+i);
        printf("%c",186);
    }
    gotoxy(x+20,y+2);
    printf("%c",188);
    gotoxy(0,23);

}

void print_main_rectangle(){

    //first col =
    gotoxy(40,2);
    printf("%c",201);
    for(int i=0;i<21;i++)
    {
        gotoxy(40,3+i);
        printf("%c",186);
    }
    gotoxy(40,24);
    printf("%c",200);

    //first row =
    for(int i=0;i<30;i++)
    {
        gotoxy(41+i,2);
        printf("%c",205);
    }
    //last row =
    for(int i=0;i<30;i++)
    {
        gotoxy(41+i,24);
        printf("%c",205);
    }


    gotoxy(70,2);
    printf("%c",187);
    for(int i=0;i<21;i++)
    {
        gotoxy(70,3+i);
        printf("%c",186);
    }
    gotoxy(70,24);
    printf("%c",188);
    gotoxy(0,0);

}

void print_data(int current){


    string words[5]={"  Push  ","  POP   ","  Peak  ","  Count ","  Exit  "};
    for(int i=0;i<5;i++)
    {
        if(i==1)
            gotoxy(51,5+(4*i));
        else
            gotoxy(51,5+(4*i));
        if(i==current)
        {
            textattr(HighLightPen);
        }
        else
        {
            textattr(8);
        }
        cout<<words[i];
        gotoxy(0,0);
    }
}

void view(int x,int y,int k){

    system("cls");
    gotoxy(x,y);

    textattr(6);
    if(k==0)
        printf("Enter Your Number:");
    else
        printf("Your Number:");

    textattr(NormalPen);

    textattr(8);
    Print_small_rectangle(x+20,y-1);
    textattr(NormalPen);

    gotoxy(x+22,y);

}

void print_shape(int current){



        textattr(11);
        print_main_rectangle();
        Print_small_rectangle(45,4);
        Print_small_rectangle(45,8);
        Print_small_rectangle(45,12);
        Print_small_rectangle(45,16);
        Print_small_rectangle(45,20);
        print_data(current);
        textattr(NormalPen);

}

void Load_Bar(){

    char firstName[9]="LOADING ",LastName[9]="MYstack ";
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
    gotoxy(49,10);
    textattr(22);
    printf(" H ");
    textattr(NormalPen);


    textattr(97);                                  //For last H in the begging
    printf(" H ");
    textattr(NormalPen);
    //1<----------------------------------->

    //2<----------------------------------->       print Loading
    Sleep(80);
    gotoxy(52,10);
    printf(" ");
    for(int i=0;i<8;i++)
    {
        textattr(97);
        gotoxy(52+i+1,10);
        printf(" H ");
        Sleep(80);
        gotoxy(52+i+1,10);
        textattr(6);
        printf("%c",firstName[i]);
    }
    textattr(97);
    printf(" H ");
    Sleep(80);
    //2<----------------------------------->

    //3<----------------------------------->       print NotePAD
    gotoxy(98,10);
    textattr(NormalPen);
    printf(" ");
    for(int i=0;i<8;i++)
    {
        textattr(97);
        gotoxy(60+i+1,10);
        printf(" H ");
        Sleep(80);
        gotoxy(60+i+1,10);
        textattr(9);
        printf("%c",LastName[i]);
    }
    gotoxy(69,10);
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
    gotoxy(20,12);
    textattr(8);
    for(int i=0;i<80;i++)
    {
        printf("%c",sm);
    }
    //4<----------------------------------->

    //5<------------------------------------>      overWrite in the print and restore it
    gotoxy(20,12);
    for(int i=0;i<80;i++)
    {
        textattr(9);
        printf("%c",bi);
        Sleep(40);
        gotoxy(20+i,12);
        textattr(6);
        printf("%c",sm);
        //textattr(NormalPen);
    }
    textattr(9);
    printf("%c",bi);
    textattr(NormalPen);

    textattr(9);
    Print_small_rectangle(50,15);
    textattr(NormalPen);

    gotoxy(54,16);
    textattr(97);
    printf("    START    ");
    textattr(NormalPen);
    gotoxy(0,0);

    getch();
    system("cls");
}

class My_Stack
{
    static int i,j;

    int *num_element,top,len_stack;
public:
    My_Stack()
    {
        cout<<"Constracor :"<<++i<<" with address :"<<this<<endl;
        top=-1;
        len_stack=5;
        num_element = new int[len_stack];
    }
    My_Stack(int len)
    {
        cout<<"Constracor :"<<++i<<" with address :"<<this<<endl;
        top=-1;
        len_stack=len;
        num_element = new int[len_stack];
    }

/*
    My_Stack(My_Stack &s1)
    {
        cout<<"Constracor :"<<++i<<" with address :"<<this<<endl;
        top=s1.top;
        len_stack=s1.len_stack;
        num_element = new int[len_stack];
        for(int i=0;i<=top;i++)
        {
            num_element[i]=s1.num_element[i];
        }
    }
*/

    int is_full()
    {
        return (top==len_stack-1);
    }
    int Is_Empty()
    {
        return (top==-1);
    }
    void Push_elemnt(int n)
    {
        if(!is_full())
            num_element[++top]=n;
    }
    int pop_element()
    {
        if(!Is_Empty())
            return num_element[top--];
        else
        {
            return -1;
        }
    }
    int peak()
    {
        if(!Is_Empty())
            return num_element[top];
        else
        {
            return -1;
        }
    }
    int get_count()
    {
        return top+1;
    }

    My_Stack Reverse()
    {
        My_Stack result;
        result.top=top;
        for(int i=0;i<=top;i++)
        {
            result.num_element[i]=num_element[top-i];
        }

        return result;
    }

    ~My_Stack()
    {
        for(int i=0;i<=top;i++)
            cout<<num_element[i]<<" ";
        cout<<"\n"<<endl;
        cout<<"Destracor :"<<++j<<" with address :"<<this<<endl;
        delete []num_element;
        num_element=NULL;
    }
    friend void vcontent(My_Stack);
};
int My_Stack::i = 0;
int My_Stack::j = 0;

void vcontent(My_Stack s1)
{
    cout<<"My_Stack :";
    for(int i=0;i<=s1.top;i++)
    {
        cout<<s1.num_element[i]<<" ";
    }

    cout<<"\n---------------"<<endl<<endl;


}



int main()
{
    My_Stack s1;
    for(int i=0;i<5;i++)
        s1.Push_elemnt(i+1);
    //vcontent(s1);
    //vcontent(s1);

    //vcontent(s2);
    //My_Stack s2(s1);
    cout<<s1.peak()<<endl;


    cout<<s1.Reverse().pop_element()<<endl;

    /*


    //reverse     copy +  rvo   ------   ok but there same constructor and desstactor
    //reverse     !copy + rvo   ------  ok but with the same constructor and desstactor
    //reverse     copy +  !rvo   ------   ok but there new constructor and desstactor for return
    //reverse     !copy + !rvo   ------  error beacuse the array but with the same number of constracor

    //vcontent     copy +  &   ------   ok no increase
    //vcontent     !copy + &   ------  ok  no  //
    //vcontent     copy +  byvalue   ------   ok no error incease constractor and destractor
    //vcontent     !copy + byvalue   ------  no error  //


    Load_Bar();
    int i=0,m,ex=0;
    char ch;


    My_Stack s1(5);

    print_shape(i);

    do{
        ch=getch();
        gotoxy(0,0);
        switch(ch)
        {
        case 13:
            {
                gotoxy(0,0);
                switch(i)
                {
                case 0:                                      //Push
                    {
                        view(40,6,i);
                        textattr(3);
                        cin>>m;
                        textattr(NormalPen);
                        s1.Push_elemnt(m);
                        system("cls");
                        print_shape(i);
                        break;
                    }
                case 1:                                              //pop
                    {
                        view(40,6,i);
                        textattr(3);
                        cout<<s1.pop_element();
                        textattr(NormalPen);
                        gotoxy(0,0);
                        getch();
                        system("cls");
                        print_shape(i);
                        break;
                    }
                case 2:                                             //peak
                    {
                        view(40,6,i);
                        textattr(3);
                        cout<<s1.peak();
                        gotoxy(0,0);
                        getch();
                        system("cls");
                        print_shape(i);
                        break;
                    }
                case 3:                                                 //count
                    {
                        view(40,6,i);
                        textattr(3);
                        cout<<s1.get_count();
                        gotoxy(0,0);
                        getch();
                        system("cls");
                        print_shape(i);
                        textattr(NormalPen);

                        break;
                    }
                case 4:
                    {                                                   //exit
                        textattr(NormalPen);
                        system("cls");
                        ex=1;
                        exit(0);
                        break;
                    }
                }
                break;
            }

            case 71:                            //home
                {
                    i=0;
                    print_data(i);
                    break;
                }
            case 79:                             //End
                {
                    i=4;
                    print_data(i);
                    break;
                }
            case 72:                             //up
                {
                    i--;
                    if(i==-1)
                        i=4;
                    print_data(i);
                    break;
                }
            case 80:                             //down
                {
                    i++;
                    if(i==5)
                        i=0;
                    print_data(i);
                    break;
                }
        }


}while(ex!=1);

*/
}
