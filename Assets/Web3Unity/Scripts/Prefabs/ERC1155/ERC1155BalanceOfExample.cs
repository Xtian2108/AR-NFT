using System.Collections;
using System.Numerics;
using System.Collections.Generic;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class ERC1155BalanceOfExample : MonoBehaviour
{
    async void Start()
    {
        string chain = "ethereum";
        string network = "rinkeby";
        string contract = "0x88b48f654c30e99bc2e4a1559b4dcf1ad93fa656";
        string account = PlayerPrefs.GetString("Account");
        string tokenId = "68097713221331394305288366584829292296340766581605097826805820294879527305217";

        BigInteger balanceOf = await ERC1155.BalanceOf(chain, network, contract, account, tokenId);
        print(balanceOf);

        if (balanceOf > 1)
        {
            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphere.transform.position = Vector3.zero;
        }
    }
}
