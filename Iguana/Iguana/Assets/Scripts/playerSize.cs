using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSize : MonoBehaviour
{
    // Start is called before the first frame update

    private Vector3 scaleChange;
    private GameObject player;

    public float mean;
    public float variance;
    public int maxIterations;
    public int numRects;

    private float size;

    void Start()
    {
        // ==================================
        // this is where we reference the probabilities class and use a normal distribution to determin
        // - the size of the player within a certain range
        size = Probabilities.RandomNormalVariable(mean, variance, maxIterations, numRects);

        scaleChange = new Vector3(size, size, size);

        player = GameObject.FindGameObjectWithTag("Player");
        player.transform.localScale = scaleChange;
        // ==================================

    }

    // Update is called once per frame
    void Update()
    {

    }
}
