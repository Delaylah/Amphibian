using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amphibian_WPF.Core;

namespace Amphibian_WPF.Shell
{
    public class History
    {
        internal History() { }

        public T addItem<T>(object arg)
        {
            var method = from m in GetType().GetMethods()
                         where m.Name == "addItem"
                               && m.GetParameters().Length == 1
                               && arg.GetType().IsAssignableFrom
                                                 (m.GetParameters()[0].GetType())
                               && m.ReturnType == typeof(T)
                         select m;

            return (T)method.Single().Invoke(this, new object[] { arg });   
        }
        public T removeItem<T>(object arg)
        {
            var method = from m in GetType().GetMethods()
                         where m.Name == "removeItem"
                               && m.GetParameters().Length == 1
                               && arg.GetType().IsAssignableFrom
                                                 (m.GetParameters()[0].GetType())
                               && m.ReturnType == typeof(T)
                         select m;

            return (T)method.Single().Invoke(this, new object[] { arg });
        }

        public virtual void saveData() { throw new NotImplementedException("Not implemented"); }
        public virtual void clearData() { throw new NotImplementedException("Not implemented"); }

        public T getHistory<T>(object arg)
        {
            var method = from m in GetType().GetMethods()
                         where m.Name == "getHistory"
                               && m.GetParameters().Length == 1
                               && arg.GetType().IsAssignableFrom
                                                 (m.GetParameters()[0].GetType())
                               && m.ReturnType == typeof(T)
                         select m;

            return (T)method.Single().Invoke(this, new object[] { arg });
        }
    }
}
