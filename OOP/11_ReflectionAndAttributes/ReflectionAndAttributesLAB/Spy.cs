using System;
using System.Collections.Generic;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using  System.Linq;

public class Spy
{
    public string StealFieldInfo(string className, params string[] fields)
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Class under investigation: {className}");

        var type = Type.GetType(className);

        var hackerInstance = Activator.CreateInstance(type);

        for (int i = 0; i < fields.Length; i++)
        {
            var cuurentFiled = type.GetField(fields[i],
                BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic);

            var value = cuurentFiled.GetValue(hackerInstance);

            sb.AppendLine($"{cuurentFiled.Name} = {value}");
        }

        return sb.ToString().TrimEnd();
    }

    public string AnalyzeAcessModifiers(string className)
    {
        StringBuilder sb = new StringBuilder();
        var type = Type.GetType(className);

        var hackerInstance = Activator.CreateInstance(type);

        var allFielsd = type.GetFields((BindingFlags) 62);

        var privateMethods = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);

        type.GetMethods(BindingFlags.Public | BindingFlags.Instance)
            .Where(x => x.Name.StartsWith("set"))
            .ToList()
            .ForEach(x => sb.AppendLine($"{x.Name} have to be private!"));

        foreach (var fieldInfo in allFielsd)
        {
            if (fieldInfo.IsPublic)
            {
                sb.AppendLine($"{fieldInfo.Name} must be private!");
            }
        }

        foreach (var privateMethod in privateMethods)
        {
            if (privateMethod.Name.StartsWith("get"))
            {
                sb.AppendLine($"{privateMethod.Name} have to be public!");
            }
        }

        return sb.ToString().TrimEnd();
    }
}

