﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPaperwork : GAction
{
    public override bool PrePerform()
    {
        return true; 
    }

    public override bool PostPerform()
    {
        beliefs.RemoveState("needsPapers");
        return true;
    }
}
