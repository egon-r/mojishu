using System;
using System.Collections.Generic;
using System.IO;
using Games.Shared.Util;
using UnityEditor;

namespace Games.Shared.Data
{
    public class CSVReader
    {
        public CSVReader()
        {
        }

        public void ReadFields(string line, Action<string> fieldAction = null, Action<string, int> fieldIndexedAction = null)
        {
            var lineChars = line.ToCharArray();
            var field = "";
            var fieldCount = 0;
            var isString = false;
            var fieldCompleted = new Action(() =>
            {
                fieldAction?.Invoke(field);
                fieldIndexedAction?.Invoke(field, fieldCount);
                field = "";
                fieldCount++;
            });
            
            for (var i = 0; i < lineChars.Length; i++)
            {
                var c = lineChars[i];
                var nextC = lineChars.GetValueOrNull(i + 1);
                if (c == '"' && nextC != '"')
                {
                    isString = !isString;
                }

                if (c == ',' && !isString)
                {
                    fieldCompleted.Invoke();
                }
                else
                {
                    field += c;
                }
            }
            fieldCompleted.Invoke();
        }

        public IList<string> GetFields(string line)
        {
            var fields = new List<string>();
            ReadFields(line, fields.Add);
            return fields;
        }
    }
}