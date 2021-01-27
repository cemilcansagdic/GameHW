using System;
using System.Collections.Generic;
using System.Text;

namespace GameHW.Interface
{
    public interface ISalesService<T>:IManagerService<T>
    {

        public void Add(T input,Campaign campaign);

    }
}
