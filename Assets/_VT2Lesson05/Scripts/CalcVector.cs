using UnityEngine;

public class CalcVector : MonoBehaviour
{
    public Vector3 A = new Vector3(-2, 3, -4);
    public Vector3 B = new Vector3(5, 3, 6);
    public Vector3 Result = Vector3.zero;
    public float DotResult;
    void Start()
    {

    }

    void Update()
    {
        Result = CrossMultiply(A, B);
        DotResult = DotMultiply(A, B);
    }

    /// <summary>
    /// ベクトルの足し算
    /// ※ A と B を合成したベクトル
    /// </summary>
    public Vector3 Additive(Vector3 a, Vector3 b)
    {
        var result = a + b;

        // ベクトルを可視化
        // Debug.DrawRay(始点, 方向, 描画色, 描画時間, 深度設定)
        Debug.DrawRay(Vector3.zero, a, Color.red, 0, false);
        Debug.DrawRay(a, b, Color.blue, 0, false);
        Debug.DrawRay(Vector3.zero, result, Color.green, 0, false);

        return result;
    }

    public Vector3 Subtract(Vector3 a, Vector3 b)
    {
        var result = a - b;

        // ベクトルの可視化
        Debug.DrawRay(Vector3.zero, a, Color.red, 0, false);
        Debug.DrawRay(Vector3.zero, b, Color.blue, 0, false);
        Debug.DrawRay(b, result, Color.green, 0, false);

        return result;
    }

    /// <summary>
    /// それぞれの要素を掛け算
    /// </summary>
    public Vector3 Multiply(Vector3 a, Vector3 b)
    {
        var result = Vector3.zero;

        //result.x = a.x * b.x;
        //result.y = a.y * b.y;
        //result.z = a.z * b.z;

        result = Vector3.Scale(a, b);

        return result;
    }

    /// <summary>
    /// 内積
    /// </summary>
    public float DotMultiply(Vector3 a, Vector3 b)
    {
        //var result = (a.x * b.x) + (a.y * b.y) + (a.z * b.z);
        var result = Vector3.Dot(a, b);

        Debug.Log($"{a}と{b}の内積 = {result}");

        return result;
    }

    /// <summary>
    /// 外積
    /// </summary>
    public Vector3 CrossMultiply(Vector3 a, Vector3 b)
    {
        var result = Vector3.zero;

        //result.x = (a.y * b.z) - (a.z * b.y);
        //result.y = (a.z * b.x) - (a.x * b.z);
        //result.z = (a.x * b.y) - (a.y * b.x);

        result = Vector3.Cross(a, b).normalized;

        // ベクトルの可視化
        Debug.DrawRay(Vector3.zero, a, Color.red, 0, false);
        Debug.DrawRay(Vector3.zero, b, Color.blue, 0, false);
        Debug.DrawRay(Vector3.zero, result, Color.green, 0, false);

        return result;
    }
}

