using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    public GameObject PnlSkillSelection;
    public UIScore pnlScore;

    private void Awake()
    {
        Instance = this;
    }

    private void UpdateUI()
    { 
        
    }
}
