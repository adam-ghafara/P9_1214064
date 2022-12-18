using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9_1214064.model
{
    class logsys
    {
        string user, pass;

        public string User { get => user; set => user = value; }
        public string Pass { get => pass; set => pass = value; }

        public logsys(string user, string pass)
        {
            this.User = user;
            this.Pass = pass;
        }

        public logsys()
        {

        }
    }
}
