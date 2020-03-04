using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YLibrary
{

    using CSVArray = List<Dictionary<string, object>>;

    public class YCSVLoader
    {

        public static Dictionary<string, CSVArray> CSVDatas
            = new Dictionary<string, CSVArray>();

        public static CSVArray Get(string file_path)
        {

            if (!CSVDatas.ContainsKey(file_path))
                CSVDatas.Add(file_path, CSVReader.Read(file_path));

            return CSVDatas[file_path];

        }

    }

}
