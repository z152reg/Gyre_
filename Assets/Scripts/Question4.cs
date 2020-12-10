using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
public struct ApiSetup<T> 
{
    
} 
class Api 
{ 
 public ApiSetup<T> For<T>(T obj) 
 { 
 return new ApiSetup<T>(); 
 } 
} 
public interface ISomeInterfaceA 
{ 
    
} 
public interface ISomeInterfaceB 
{ 
    
} 
public static class ApiSetupExtensions
{
    public static void SetupObjectA<T>(this ApiSetup<T> obj) where T : ISomeInterfaceA
    {
        
    }
    public static void SetupObjectB<T>(this ApiSetup<T> obj) where T : ISomeInterfaceB
    {
        
    }
}
public class ObjectA : ISomeInterfaceA 
{ 
    
} 
public class ObjectB : ISomeInterfaceB 
{ 
    
} 
class SomeClass2 
{ 
 public void Setup() 
 { 
 Api apiObject = new Api(); 
 apiObject.For(new ObjectA()).SetupObjectA(); 
 apiObject.For(new ObjectB()).SetupObjectB(); 
 } 
}