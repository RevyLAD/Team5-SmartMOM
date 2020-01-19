using Project_DAC;
using Project_VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team5_SmartMOM.BaseForm
{
    public class CommonCodeService
    {
        public List<CommonCodeVO> GetAllCommonCode()
        {
            CommonCodeDAC dac = new CommonCodeDAC();
            return dac.GetAllCommonCode();
        }

        public List<CompanyCodeVO> GetAllCompanyCode()
        {
            CommonCodeDAC dac = new CommonCodeDAC();
            return dac.GetAllCompanyCode();
        }

        public List<ItemCodeVO> GetAllItemCode()
        {
            CommonCodeDAC dac = new CommonCodeDAC();
            return dac.GetAllItemCode();
        }
    }
}
