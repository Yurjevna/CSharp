﻿int [] array = {1,12,31,4,15,16,17,16};

int n = array.Length;
int find=16;

int index=0;

while(index<n)
{
    if(array[index]==find)
{
    Console.WriteLine(index);
    break;
    }    

    index= index+1;
}