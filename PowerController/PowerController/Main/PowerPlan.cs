using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerController.Main
{
    public class PowerPlan
    {
        public List<PowerPlanInfo> lstPowerPlanInfo {get;private set; }
        public Dictionary<string, string> dictPowerPlanInfo { get; private set; }
        public PowerPlan()
        {
            lstPowerPlanInfo = new List<PowerPlanInfo>();
            dictPowerPlanInfo = new Dictionary<string, string>();
            getlstPowerPlanInfo();
        }

        /// <summary>
        /// 獲得該電腦中的所有電源計畫及對應的Guid
        /// </summary>
        /// <returns></returns>
        public List<PowerPlanInfo> getlstPowerPlanInfo()
        {
            lstPowerPlanInfo.Clear();
            dictPowerPlanInfo.Clear();
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "powercfg.exe",
                    Arguments = "/list",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };
            proc.Start();
            while (!proc.StandardOutput.EndOfStream)
            {
                string line = proc.StandardOutput.ReadLine();
                if (line.Contains("GUID"))
                {
                    line=line.Replace("(","");
                    line=line.Replace(")", "");
                    string[] arrTemp = line.Split(' ');
                   
                    lstPowerPlanInfo.Add(new PowerPlanInfo(arrTemp[4],arrTemp[2]));
                    dictPowerPlanInfo.Add(arrTemp[4], arrTemp[2]);
                }
                
                // do something with line
            }
            return lstPowerPlanInfo;
        }
        /// <summary>
        /// 取得控制台電源計畫的名稱及唯一碼
        /// </summary>
        /// <returns></returns>
        public string[] getCurrentPowerPlan()
        {
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "powercfg.exe",
                    Arguments = "/getactivescheme",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };
            proc.Start();
            while (!proc.StandardOutput.EndOfStream)
            {
                string line = proc.StandardOutput.ReadLine();
                if (line.Contains("GUID"))
                {
                    line = line.Replace("(", "");
                    line = line.Replace(")", "");
                    string[] arrTemp = line.Split(' ');

                    //lstPowerPlanInfo.Add(new PowerPlanInfo(arrTemp[4], arrTemp[2]));
                    //dictPowerPlanInfo.Add(arrTemp[4], arrTemp[2]);
                    return new string[] { arrTemp[4], arrTemp[2] };
                }

                // do something with line
            }
            
            return new string[] { };
        }

        public void ChangePowerPlan()
        { 
        
        }
        
    }
}
