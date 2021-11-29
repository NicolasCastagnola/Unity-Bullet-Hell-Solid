﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffManager : MonoBehaviour
{
    [SerializeField] private BuffSetter buffSetter;
    private BuffFactory _buffFactory;

    public static BuffManager Instance { get { return _instance; } }

    private static BuffManager _instance;

    private void Awake()
    {
        if (_instance != null && _instance != this) Destroy(gameObject);

        else _instance = this;

        _buffFactory = new BuffFactory(Instantiate(buffSetter));
    }

    public void GetBuff(string id)
    {
        _buffFactory.Create(id);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            GetBuff("Heal");
        }
    }
}