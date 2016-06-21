﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breeze.PocoMetadata
{
    public static class Extensions
    {
        /// <summary>
        /// Return the matching value, or null if not found.
        /// </summary>
        /// <param name=""></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static object Get(this Dictionary<string, object> map, string key)
        {
            object obj;
            if (map.TryGetValue(key, out obj))
                return obj;
            return null;
        }
    }
}