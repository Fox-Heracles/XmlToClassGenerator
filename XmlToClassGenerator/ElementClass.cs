using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XmlToClassGenerator
{
    /// <summary>
    /// Xml与C#实体类对应关系类
    /// </summary>
    public class ElementClass
    {
        /// <summary>
        /// 类名称
        /// </summary>
        public string className = string.Empty;
        /// <summary>
        /// 基本类型  string  int 等  key  类型  value  变量名
        /// </summary>
        public List<KeyValuePair<string, string>> baseType = new List<KeyValuePair<string, string>>();
        /// <summary>
        /// 引用类型  类
        /// </summary>
        public List<ElementClass> classType = new List<ElementClass>();
        /// <summary>
        /// 集合类型  键值对 key 为子节点对应类  value 为类名
        /// </summary>
        public List<ElementClass> listType = new List<ElementClass>();
    }
}
