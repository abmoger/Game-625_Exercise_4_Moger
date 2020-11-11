﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nurse : GAgent
{
    // Start is called before the first frame update
    new void Start()
    {
        base.Start();
        SubGoal s1 = new SubGoal("treatPatient", 1, false);
        goals.Add(s1, 3);

        SubGoal s2 = new SubGoal("rested", 1, false);
        goals.Add(s2, 1);

        SubGoal s3 = new SubGoal("hasPaperwork", 1, false);
        goals.Add(s3, 1);

        Invoke("GetTired", Random.Range(10, 20));

        Invoke("NeedPaperwork", Random.Range(40, 60));
    }

    void GetTired()
    {
        beliefs.ModifyState("exhausted", 0);
        Invoke("GetTired", Random.Range(10, 20));
    }

    void NeedPaperwork()
    {
        beliefs.ModifyState("needsPapers", 0);
        Invoke("NeedPaperwork", Random.Range(40, 60));
    }
}
