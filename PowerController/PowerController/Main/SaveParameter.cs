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
        public int cmbActive_selectIndex = 0;
        public int cmbIdle_selectIndex = 0;
        public int cmbExecute_selectIndex = 0;
        public int cmbCountDown_selectIndex = 0;
        public int cmbWakeup_selectIndex = 0;
    }
}
