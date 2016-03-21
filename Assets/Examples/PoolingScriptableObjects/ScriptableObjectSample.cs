using UnityEngine;
using System.Collections;

public class SampleData : ScriptableObject
{
    public int price;
    public string name;
}

/// <summary>
/// A sample class to present pooling of ScriptableObject derived class instance.
/// </summary>
public class ScriptableObjectSample : MonoBehaviour
{

	void Start () 
    {
        var data = ScriptableObject.CreateInstance<SampleData>();
        data.price = 100;
        data.name = "custom";

        // preload
        PoolManager.WarmPool(data, 5);

        // retrieves from the pool not by instantiating which needs memory allocation.
        var clone = PoolManager.SpawnObject(data);
	}
	
}
