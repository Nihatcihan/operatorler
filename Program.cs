﻿// See https://aka.ms/new-console-template for more information

// atama ve işlemli atama

    int x =3;
    int y =3;
    y = y+2;
    Console.WriteLine(y);

    y += 2;
    Console.WriteLine(y);
    y /=1;
    Console.WriteLine(y);

    x *=2;
    Console.WriteLine(x);
    Console.WriteLine("****mantiksal operatorler****");    

    //mantiksal operatorler
    // ||, &&, !

    bool isSuccess = true;
    bool isCompleted = false;

    if(isSuccess && isCompleted) // ve
    Console.WriteLine("Perfect");

    if(isSuccess || isCompleted) // veya
    Console.WriteLine("Great");    

    if(isSuccess && !isCompleted) // iscompleted'in tersini aldi true true oldu
    Console.WriteLine("Fine");    
    Console.WriteLine("****iliskisel operatorler****");    

    // ilişkisel operatörler
    // <, >, <=, >=, ==, !=

    int a = 3;
    int b = 4;
    bool sonuc = a<b;
    Console.WriteLine(sonuc);
    sonuc = a>b;
    Console.WriteLine(sonuc);
    sonuc = a>=b;
    Console.WriteLine(sonuc);
    sonuc = a<=b;
    Console.WriteLine(sonuc);
    sonuc = a==b;
    Console.WriteLine(sonuc);
    sonuc = a!=b;
    Console.WriteLine(sonuc);
    
    Console.WriteLine("****aritmetik operatorler****");    

    // /,*,+,-

    int sayi1 =10;
    int sayi2 =5;
    int sonuc1 = sayi1/sayi2;
    Console.WriteLine(sonuc1);
    sonuc1 =sayi1 * sayi2;
    Console.WriteLine(sonuc1);
    sonuc1 =sayi1 + sayi2;
    Console.WriteLine(sonuc1);
    sonuc1 =++sayi1;
    Console.WriteLine(sonuc1);

    // % mod alir
    int sonuc2 =20%3;
    Console.WriteLine(sonuc2);
