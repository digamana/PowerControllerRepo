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
        public int isStop = 0;  // 0: ()停用   1:(V)停用
        public int ActiveComputerStart = 0; // 0: ()開機時啟動   1:(V)開機時啟動
        public int CloseHide = 0; // 0: ()關閉時，右下角隱藏   1:(V)關閉時，右下角隱藏
    }
}
