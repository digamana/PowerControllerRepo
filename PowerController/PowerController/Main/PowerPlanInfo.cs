using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerController.Main
{
    public  class PowerPlanInfo
    {
        public string strName { get; set; }
        public string strGuid { get; set; }
        public PowerPlanInfo(string strName,string strGuid)
        {
            this.strName = strName;
            this.strGuid = strGuid;
        }
    }
}
