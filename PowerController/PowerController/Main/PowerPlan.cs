using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerController.Main
{
    public  class PowerPlan
    {
        public string strName { get; set; }
        public string strGuid { get; set; }
        public PowerPlan(string strName,string strGuid)
        {
            this.strName = strName;
            this.strGuid = strGuid;
        }
    }
}
