// See https://aka.ms/new-console-template for more information
//using System.Diagnostics;
using System.Reflection;

Console.WriteLine("Hello, World!");

//1. dynamically loading an assembly

Assembly loadedAssembly = Assembly.LoadFile(@"D:\training\siemens-dotnetcore-18thNov2024\codes\day-2\ReflectionDemo\CalculationLibrary\bin\Debug\net8.0\CalculationLibrary.dll");

Console.WriteLine($"Name:{loadedAssembly.FullName}");

//Process p = Process.GetCurrentProcess();
//Console.WriteLine($"ProcessName={p.ProcessName}, Id={p.Id}");

//ProcessModuleCollection processModuleCollection = p.Modules;
//foreach (var item in processModuleCollection)
//{
//    Console.WriteLine($"{item}");
//}


//2. runtime type discovery
Type[] allTypes = loadedAssembly.GetTypes();
foreach (var singleType in allTypes)
{
    Console.WriteLine($"Name={singleType.Name}");
    Console.WriteLine($"Is Class={singleType.IsClass}");
    Console.WriteLine($"Is Interface={singleType.IsInterface}");
    Console.WriteLine($"Is Value={singleType.IsValueType}");
    Console.WriteLine("\n");
}

Type? clsType = loadedAssembly.GetType("CalculationLibrary.Calculation");

if (clsType != null)
{
    MethodInfo[] allMethods = clsType.GetMethods();
    foreach (var item in allMethods)
    {
        Console.WriteLine($"Name={item.Name}");
        Console.WriteLine($"Return Type={item.ReturnType}");

        ParameterInfo[] allParams = item.GetParameters();
        Console.WriteLine("\nParameters\n");
        if (allParams.Length > 0)
        {
            foreach (var item1 in allParams)
            {
                Console.WriteLine($"Name:{item1.Name}");
                Console.WriteLine($"Type:{item1.ParameterType}");
                Console.WriteLine($"Pos:{item1.Position}");
            }
        }
        Console.WriteLine("\n");

        //3. dynalically create instance from metedata of the type
        object? obj = Activator.CreateInstance(clsType);

        if (obj != null)
        {
            MethodInfo? subInfo = clsType.GetMethod("Subtract");
            if (subInfo != null)
            {
                //4. dynalically invoke method using metedata of the method
                object? res = subInfo.Invoke(obj, [12, 3]);
                Console.WriteLine(res);
            }
            MethodInfo? addInfo = clsType.GetMethod("Add");
            if (addInfo != null)
            {
                //4. dynalically invoke method using metedata of the method
                addInfo.Invoke(obj, [12, 3]);
            }

            PropertyInfo? resultPropInfo = clsType.GetProperty("Results");
            if (resultPropInfo != null)
            {
                object? history = resultPropInfo.GetValue(obj, null);
                if (history != null)
                {
                    List<int> list = (List<int>)history;
                    foreach (var r in list)
                    {
                        Console.WriteLine(r);
                    }
                }
            }
        }
    }
}