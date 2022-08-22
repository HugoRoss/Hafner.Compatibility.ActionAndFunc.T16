namespace System {

    /// <summary>Encapsulates a method that has 1 parameter and does not return a value.</summary>
    /// <typeparam name="T1">The type of parameter 1 of the method this delegate encapsulates.</typeparam>
    /// <param name="arg1">Parameter 1 of the method that this delegate encapsulates.</param>
    public delegate void Action<in T1>(T1 arg1);

}
