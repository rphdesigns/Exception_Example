using System;
using System.Collections.Generic;
using Exception_Example;
using Exception_Example.Types_Examples;
using Exception_Example.Inheritance;
using Exception_Example.Class_Hierarchies;
using Exception_Example.Delegates;
using Exception_Example.Events;
using Exception_Example.Asyn_Programming;

namespace Exception_Example
{
    class Program
    {
        static void Main(string[] args) =>
        #region Basics
            //CollectionsandArrays.CollectionsandArrays_Method();

            //Exception_Example.Exception_Example_Method();

            //StringBuilderExample.StringBuilderExample_Method();

            //StringReadWrite.StringReadWrite_Runner();

        #endregion

        #region Type Examples

            //Using_Properties_and_Fields.Using_Prop_and_Fields();

            //Constructor_Example.ConstructorExample();

            //Static_Example static_ = new Static_Example();
            //static_.Static_Example_Main();

            //Struct_Example struct_Example = new Struct_Example(6,7);
            //struct_Example.DoThis();

            //Generics_Example generics_ = new Generics_Example();
            //generics_.Generics();

            //CastAndConvertExample.CastAndConvertExample1();
            //CastAndConvertExample.CastAndConvertExample2();
            //CastAndConvertExample.CastAndConvertExample3();

            //BoxingAndUnboxing.BoxingAndUnboxing_Example1();

            //Indexers.Indexers_Example();

        #endregion

        #region Class Hierarchies

            //InheritanceExample.InheritanceExample1();

            //Method_Overloading.Method_Overloading_Example();

            //Override_Example.Override_Example1();

            //Extension_Method.Extension_Method_Example();

            //Creating_an_Interface.Example1();

            //Explicit_Implementation_Example.Example1();

            //IEnumerable_Example.IEnumerable_Example1();

        #endregion

        #region Delegates

            //Delegate_Example.Delegate_Example1();

            //Multicast_Delegate_Example.Multicast_Delegate_Example1();

        #endregion

        #region Events

            //Basic_Event_Example.Basic_Event_Example1();

        #endregion

        #region Asynchronous Programming

            Multithreading_Example.Multithreading_Example1();

        #endregion


    }

    
}
