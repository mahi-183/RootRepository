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
        public string FileReader(string path)
        {
            StreamReader reader = File.OpenText(path);
            string json = reader.ReadToEnd();
            reader.Close();
            return json;
        }
    }
    
}
