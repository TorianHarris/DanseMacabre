﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDisplay : MonoBehaviour {

    public Card card;

	void Start () 
    {
        print(card.name);
        card.effect.Activate();
	}
}
