using UnityEngine;

public class TestScript : MonoBehaviour
{
    [SerializeField] private int m_Count = 0;
    public static TestScript instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }


    public void PrintLog()
    {
        Debug.Log(m_Count);
        m_Count++;
    }
}
