using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yemektariflerii.Enums
{
    
    
        public enum UserType
        {
            SuperAdmin,
            Admin,
            Teacher,
            Student
        }

        public enum UserState
        {
            WaitingActivation,
            Active,
            Passive
        }
}