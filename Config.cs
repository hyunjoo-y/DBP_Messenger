using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace on_off_proj
{
    class Config
    {
        string strconn = "Server=27.96.130.41;Port=3306;Database=s5671252;Uid=s5671252;Pwd=s5671252";

        public static Config getInstance()
        {
            Config config = new Config();
            return config;
        }

        public string getAddress()
        {
            return strconn;
        }
    }
}
