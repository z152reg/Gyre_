interface ISomeInterface  
{  
 void Call();  
}  
struct SomeStruct : ISomeInterface  
{  
 public void Call()  
 { }  
}  
class SomeClass  
{  
 public void Run()  
 {  
 var someStruct = new SomeStruct();  
 SomeMethod(someStruct);  
 }  
 public void SomeMethod(ISomeInterface @interface)  
 {  
 @interface.Call();  
 }  
 //Т.н. "боксинг" происходит когда делается "обертка" для value-type данных (каст к классу/интерфейсу).
//Можно сделать generic-метод для решения данного вопроса
    public void SomeMethod2<T>(T val) where T : ISomeInterface
    {

    }
}
