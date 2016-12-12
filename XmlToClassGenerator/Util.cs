using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace XmlToClassGenerator
{
    public  class Util
    {
        /// <summary>
        /// 命名空间格式
        /// </summary>
        public static string classFormat = @"using System;
        using System.Collections.Generic;
        using System.ComponentModel;
        using System.Data;
        using System.Drawing;
        using System.Linq;
        using System.Text;
        using System.Windows.Forms;
        using System.Xml;
                
        namespace {0}
        {{
            public class {1}
            {{
                {2}
            }} 
                    
        }}";

        /// <summary>
        /// 引用类型格式
        /// </summary>
        public static string classTypeFormat = @"
                        public class {0}
                        {{
                            {1}
                        }} ";
        /// <summary>
        /// 基本类型
        /// </summary>
        public static string baseTypeFormat = @"
                        public {0} {1} {{get;set;}}
            ";
        public static string baseClassTypeFormat = @"
                        public {0} _{0} =new {0}();
            ";
        /// <summary>
        /// 集合类型格式
        /// </summary>
        public static string listTypeFormat = @"
                        public List<{0}> {1}=new List<{0}>();
            ";
        /// <summary>
        /// ElementClass生成.cs文件
        /// </summary>
        /// <param name="ec"></param>
        /// <param name="strBuildertmp"></param>
        /// <returns></returns>
        public static void ClassToCs(ElementClass ec, ref StringBuilder strBuildertmp)
        {

            //基本类型
            for (int i = 0; i < ec.baseType.Count; i++)
            {
                strBuildertmp.Append(string.Format(baseTypeFormat, ec.baseType[i].Key, ec.baseType[i].Value));
            }
            //引用类型
            for (int i = 0; i < ec.classType.Count; i++)
            {
                StringBuilder sb = new StringBuilder();
                //添加类变量
                strBuildertmp.Append(string.Format(baseClassTypeFormat, ec.classType[i].className));
                //转化类代码
                ClassToCs(ec.classType[i], ref sb);
                //合并类代码
                strBuildertmp.Append(string.Format(classTypeFormat, ec.classType[i].className, sb.ToString()));
            }
            //集合类型
            for (int i = 0; i < ec.listType.Count; i++)
            {
                StringBuilder sb = new StringBuilder();
                //添加类变量
                //此处生成集合变量里面集合实体类而非集合变量本身,集合变量本身不生成类,而
                //仅仅是作为List<T> 集合类型的名称
                strBuildertmp.Append(string.Format(listTypeFormat, ec.listType[i].classType[0].className, ec.listType[i].className));
                //转化类代码
                ClassToCs(ec.listType[i].classType[0], ref sb);
                //合并类代码
                strBuildertmp.Append(string.Format(classTypeFormat, ec.listType[i].classType[0].className, sb.ToString()));
            }
        }
        public bool IsPropertyElement(XElement element)
        {
            if (element.Parent.Elements(element.Name).Count() == 1 &&
                element.Attributes().Count() == 0 &&
                element.Elements().Count() == 0)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// 是否是集合节点
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public static bool IsCollectionElement(XElement element)
        {
            IEnumerable<string> elementNames = element.Elements().Select(x => x.Name.LocalName);
            //如果是集合变量,则其子集合数量大于等于1,而子集合类型必定相等
            return elementNames.Distinct().Count() == 1 &&
                elementNames.Count() >= 1;
        }
        /// <summary>
        /// xml文件生成格式化类
        /// </summary>
        /// <param name="xe"></param>
        /// <param name="elementClass"></param>
        public static void XmlToClass(XElement xe, ref ElementClass elementClass)
        {
            elementClass.className = xe.Name.LocalName;//类名
            foreach (XElement element in xe.Elements())
            {
                if (!element.HasElements)//单节点
                {
                    elementClass.baseType.Add(new KeyValuePair<string, string>("string", element.Name.LocalName));
                }
                else//多节点
                {
                    //集合类型变量
                    if (IsCollectionElement(element))
                    {
                        ElementClass ec = new ElementClass();
                        XmlToClass(element, ref ec);
                        if (!elementClass.listType.Contains(ec))
                        { elementClass.listType.Add(ec); }
                    }
                    else//类类型
                    {
                        ElementClass ec = new ElementClass();
                        XmlToClass(element, ref ec);
                        elementClass.classType.Add(ec);
                    }
                }
            }
        }
    }
}
