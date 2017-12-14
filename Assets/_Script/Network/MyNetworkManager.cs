using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyNetworkManager : NetworkManager {

    public void MyStartHost() {
        StartHost();
    }

    public override void OnStartHost() {
        print("When host started what to do");
    }

}
