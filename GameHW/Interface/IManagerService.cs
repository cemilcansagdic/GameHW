using System;
using System.Collections.Generic;
using System.Text;

namespace GameHW.Interface
{
    public interface IManagerService<T>
    {
        public void Add(T input);
        public void Delete(int ID);
        public void Update(T input);
    }
}
