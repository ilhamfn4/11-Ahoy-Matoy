using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyNetworkManager : NetworkManager {

    public void MyStartHost() {
        StartHost();
        print("Start host : " + Time.timeSinceLevelLoad);
    }

    public override void OnStartHost() {
        print("On Start host : " + Time.timeSinceLevelLoad);

    }

    public override void OnStartClient(NetworkClient client) {
        print("On Client start : " + Time.timeSinceLevelLoad);
    }

    public override void OnClientConnect(NetworkConnection conn) {
        print("Client connect to IP : " + conn.address + " " + Time.timeSinceLevelLoad);
    }

}
