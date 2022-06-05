using UnityEngine;

public class Logger : MonoBehaviour
{
    public void Log(string text)
    {
        Debug.Log(text);
    }
	
	public void LogError(string text)
	{
		Debug.LogError(text);
	}
}
