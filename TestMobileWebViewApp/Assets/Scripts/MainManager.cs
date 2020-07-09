using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Net;

public class MainManager : MonoBehaviour
{

    void Start()
    {
        Debug.Log(IPManager.GetIP(ADDRESSFAM.IPv4));
        var strHostName = "";
        strHostName = System.Net.Dns.GetHostName();

        var ipEntry = System.Net.Dns.GetHostEntry(strHostName);

        var addr = ipEntry.AddressList;

        var ip = addr[addr.Length - 1].ToString();
        Debug.Log(ip);
    }

    
    private void GoToGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    private void GoWeb()
    {
        SceneManager.LoadScene("WebViewScene");
    }
}
