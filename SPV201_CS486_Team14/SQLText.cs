using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPV201_CS486_Team14
{
    class SQLText
    {
        public string DisplayContestants = "select * from dbo.fn_displayContestant()";
        public string DisplayExaminers = "select * from dbo.fn_displayExaminer()";
        public string DisplayOfficialMembers = "select * from dbo.fn_displayOfficialMember()";
        public string DisplayReserveMembers = "select * from dbo.fn_displayReserveMember()";
    }
}
