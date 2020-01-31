using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team5_Pop
{
    public class PopService
    {
        public List<PopVO> PopGetData()
        {
            PopDAC dac = new PopDAC();
            return dac.PopGetData();
        }
    }
}
