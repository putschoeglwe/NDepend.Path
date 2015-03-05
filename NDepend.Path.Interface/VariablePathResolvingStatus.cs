﻿namespace NDepend.Path.Interface
{
    using NDepend.Path.Interface.Core;
    using NDepend.Path.Interface.Variable;

    ///<summary>
    ///Defines the result of the <see cref="IVariablePath"/>.<see cref="IVariablePath.TryResolve(System.Collections.Generic.IEnumerable{System.Collections.Generic.KeyValuePair{string,string}},out IAbsolutePath)"/> method.
    ///</summary>
    public enum VariablePathResolvingStatus
    {
        ///<summary> 
        ///All variables have been resolved, and the resulting path is a valid absolute path. 
        ///</summary>
        Success,

        ///<summary> 
        ///One or several variables cannot be resolved. 
        ///</summary>
        ErrorUnresolvedVariable,

        ///<summary> 
        ///All variables have been resolved but the resulting path is not a valid absolute path. 
        ///</summary>
        ErrorVariableResolvedButCannotConvertToAbsolutePath
    }
}