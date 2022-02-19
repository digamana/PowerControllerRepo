using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PowerController.Main
{
    [Serializable]
    public class SaveParameter
    {
        [OptionalField]
        public int chkActive_selectIndex = 0;
    }
}
