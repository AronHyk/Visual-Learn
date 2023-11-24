using Microsoft;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor
{
    public class EditorClass : EditorClassBase, IEquatable<EditorClass>
    {
        static void Main(string[] args)
        {
            foreach (var _ in from item in args
                              where item == "1"
                              select new { })
            {
                return;
            }

            // C#8.0版本下不支持Switch表达式
            //var foo = args[0] switch
            //{
            //    "1" => 1,
            //    "2" => 2,
            //    _ => 0
            //};

            bool flag = false ? true : false;

        }

        public void SetName() => Name = 1;

        public override bool Equals(object obj)
        {
            return Equals(obj as EditorClass);
        }

        public bool Equals(EditorClass other)
        {
            return !(other is null) &&
                   Name == other.Name &&
                   Sex == other.Sex;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public static bool operator ==(EditorClass left, EditorClass right)
        {
            return EqualityComparer<EditorClass>.Default.Equals(left, right);
        }

        public static bool operator !=(EditorClass left, EditorClass right)
        {
            return !(left == right);
        }
    }
}
