#region License
// ====================================================
// Project Porcupine Copyright(C) 2016 Team Porcupine
// This program comes with ABSOLUTELY NO WARRANTY; This is free software, 
// and you are welcome to redistribute it under certain conditions; See 
// file LICENSE, which is part of this source code package, for details.
// ====================================================
#endregion
using System.Collections;
using UnityEngine;

public class Path_Node<T>
{
    public T data;

    // Nodes leading OUT from this node.
    public Path_Edge<T>[] edges;
}
