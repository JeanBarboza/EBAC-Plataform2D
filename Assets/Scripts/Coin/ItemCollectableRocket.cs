using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollectableRocket : ItemCollectableBase
{
    protected override void OnCollect()
    {
        base.OnCollect();
        ItemManager.Instance.AddRocket();
    }
}
