using System;

class Test{
    public static void Main(String[] args){
        int x=10;
        Test.MyMethod(ref x);
        //Test.MyMethod(x);
        Console.WriteLine(x);
    }
    //error CS0825: The contextual keyword `var' may only appear within a local variable declaration
    static void MyMethod(ref var i){
        i=i+20;
    }
}