using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    [SerializeField] private int m_type;//load in the unity editor which kind of collectable it is

    [SerializeField] private GameObject m_exp = null;

    private void Start() 
    {
    m_type = (int)Random.Range(1.0f,3.5f);//load a collectable in a random way between 1 and 3
    }

    public int GetCollectableType() //precise which type of collectable it is
    {
        return(m_type);
    }

    public void explode()
    {
        GameObject _exp = Instantiate(m_exp, transform.position, transform.rotation);
        Destroy(_exp,3);
    }
}
