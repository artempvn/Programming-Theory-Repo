using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    [SerializeField] private int m_EatenLevel;
    public int EatenLevel // ENCAPSULATION
    {
        get
        {
            return m_EatenLevel;
        }
        set
        {
            if (value > -1 && value < 11)
            {
                m_EatenLevel = value;
            }
            else
            {
                Debug.Log("Can't set Eaten Level to " + value);
            }
        }
    }

    public abstract string Talk();

    public virtual string GoEating()
    {
        return name + " is going to eat.";
    }
}
