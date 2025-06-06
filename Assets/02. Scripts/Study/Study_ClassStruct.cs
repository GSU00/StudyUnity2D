using UnityEngine;

public class Study_Class
{
    public int number;

    // 持失切 : 持失吃 �� 叔楳鞠澗 敗呪
    public Study_Class(int number) 
    {
        this.number = number;
    }
}

public struct Study_Struct
{
    public int number;

    public Study_Struct(int number)
    {
        this.number = number;
    }
}

public class Study_ClassStruct : MonoBehaviour
{
    void Start()
    {
        Debug.Log("適掘什 ----------------------------------");
        Study_Class c1 = new Study_Class(10);
        Study_Class c2 = c1;
        Debug.Log($"c1 : {c1.number} / c2 : {c2.number}"); // 10 10
        c1.number = 100;
        Debug.Log($"c1 : {c1.number} / c2 : {c2.number}"); // 100 100

        Debug.Log("姥繕端 ----------------------------------");
        Study_Struct s1 = new Study_Struct(10);
        Study_Struct s2 = s1;
        Debug.Log($"c1 : {s1.number} / c2 : {s2.number}"); // 10 10
        s1.number = 100;
        Debug.Log($"c1 : {s1.number} / c2 : {s2.number}"); // 100 10
    }
}
