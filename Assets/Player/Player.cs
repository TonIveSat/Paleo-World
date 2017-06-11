using UnityEngine;

public class Player : MonoBehaviour
{
    private float currentHealthPoints;

    [SerializeField]
    float maxHealthPoints;

    public float healthAsPercentage
    {
        get { return currentHealthPoints / maxHealthPoints; } 
    }

	// Use this for initialization
	void Start ()
    {
        currentHealthPoints = 80f;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
