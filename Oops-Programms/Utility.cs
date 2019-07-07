// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Mahesh Aurad"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Oops_Programms
{
    using System.IO;
    using System;
    /// <summary>
    /// 
    /// </summary>
    public class Utility
    {
        public static string FileReader(string path)
        {
            StreamReader StreamReader = File.OpenText(path);
            string json = StreamReader.ReadToEnd();
            StreamReader.Close();
            return json;
        }

    }
    
}
