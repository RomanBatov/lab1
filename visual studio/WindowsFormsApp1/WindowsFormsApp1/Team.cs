using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Team
    {
        public int teamId;
        public String name;
        String abbr;
        public String logo;


        public void setAll (int teamId, String name, String abbr, String logo)
        {
            this.teamId = teamId;
            this.name = name;
            this.abbr = abbr;
            this.logo = logo;
        }

    }
}
