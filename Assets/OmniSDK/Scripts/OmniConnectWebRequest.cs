using UnityEngine;
using System.Collections;
using System;
using System.Text;
using UnityEngine.Networking;

public class OmniConnectWebRequest : MonoBehaviour
{
    public static IEnumerator CoroutinePostRequest(string url, byte[] postRequest, System.Action<string> result)
    {
        using (UnityWebRequest web = UnityWebRequest.Post(url, postRequest.ToString()))
        {
            yield return web.SendWebRequest();

            if (web.isNetworkError || web.isHttpError)
            {
                Debug.LogError("OmniSDK: OmniConnectWebRequest failed post request at " + url + ": " + web.error + ". Ensure that Omni Connect is installed and running on your system.");
                result("Error");
            }
            else
            {
                Debug.Log("OmniSDK: SetOmniConnectGamepadMode Post Request Successful at " + url + web.downloadHandler.text);
                result(web.downloadHandler.text);
            }
        }
    }

    public static IEnumerator CoroutineGetRequest(string url, System.Action<string> result)
    {
        using (UnityWebRequest web = UnityWebRequest.Get(url))
        {
            yield return web.SendWebRequest();

            if (web.isNetworkError || web.isHttpError)
            {
                Debug.LogError("OmniSDK: OmniConnectWebRequest failed get request at " + url + ": " + web.error + ". Ensure that Omni Connect is installed and running on your system.");
                result("Error");
            }
            else
            {
                Debug.Log("OmniSDK: OmniConnectWebRequest successful get request at " + url + ": " + web.downloadHandler.text);
                result(web.downloadHandler.text);
            }

        }
    }

}

[Serializable]
public class OmniConnectMode
{
    public string Data;
}
