﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Images : MonoBehaviour
{

    public List<Sprite> sprites;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Sprite GetSprite(int value)
    {
        return this.sprites[value];
    }
}
