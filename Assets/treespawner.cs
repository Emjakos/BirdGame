using UnityEngine;

public class treespawner : MonoBehaviour
{
    int c;
    public GameObject tree1, tree2, tree3, tree4;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(c = 0; c <= 40; c++)
        {
            //first tree randomizer
            Vector3 randompspawnpoint1 = new Vector3(Random.Range(-10, 40), Random.Range(-10, 40), 0);
            Instantiate(tree1, randompspawnpoint1, Quaternion.identity);
            //second tree randomizer
            Vector3 randompspawnpoint2 = new Vector3(Random.Range(-10, 40), Random.Range(-10, 40), 0);
            Instantiate(tree2, randompspawnpoint2, Quaternion.identity);
            //third tree randomizer
            Vector3 randompspawnpoint3 = new Vector3(Random.Range(-10, 40), Random.Range(-10, 40), 0);
            Instantiate(tree3, randompspawnpoint3, Quaternion.identity);
            //fourth tree randomizer
            Vector3 randompspawnpoint4 = new Vector3(Random.Range(-10, 40), Random.Range(-10, 40), 0);
            Instantiate(tree4, randompspawnpoint4, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
