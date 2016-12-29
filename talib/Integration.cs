using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using talib;
using TicTacTec.TA.Library;
using static TicTacTec.TA.Library.Core;

public class Integration
{
    public async Task<dynamic> Execute(IDictionary<string, object> values)
    {
        var method = typeof(Talib).GetMethod((string)values["name"]);
        var finalDictionary = new Dictionary<string, object>();

        var tParams = method.GetParameters();

        foreach (var item in tParams)
        {
            finalDictionary.Add(item.Name, values[item.Name]);
        }

        object[] parameters;

        ConvertParameters(finalDictionary, out parameters, method);
        var status = method.Invoke(null, parameters);

        var rParameters = new Dictionary<string, object>();
        for (int i = 0; i < parameters.Count(); i++)
        {
            var name = finalDictionary.Keys.ToList()[i];
            rParameters.Add(name, parameters[i]);
        }

        return await Task.FromResult(new
        {
            status,
            result = rParameters
        });
    }

    public static void ConvertParameters(IDictionary<string, object> values, out object[] parameters, MethodInfo info)
    {
        var mParams = info.GetParameters();
        var rParam = values.Values.ToList();
        var index = 0;

        foreach (var item in values)
        {
            if (item.Value is object[])
            {
                var p = mParams.FirstOrDefault(c => c.Name == item.Key);

                var method = typeof(Integration).GetMethod("ConvertToArray", BindingFlags.Public | BindingFlags.Static);
                rParam[index] = method.MakeGenericMethod(p.ParameterType.GetElementType()).Invoke(null, new object[] { (object[])item.Value });
            }            

            index++;
        }
        

        parameters = rParam.ToArray();
    }    

    public static T[] ConvertToArray<T>(object[] values)
    {
        var list = new List<T>();
        foreach (var item in values)
        {
            if (item != null)
            {
                list.Add((T)Convert.ChangeType(item, typeof(T)));
            }
            else
            {
                list.Add(default(T));
            }
        }

        return list.ToArray();
    }
}
