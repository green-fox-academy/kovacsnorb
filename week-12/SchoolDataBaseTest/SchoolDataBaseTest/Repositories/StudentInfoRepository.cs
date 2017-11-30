using SchoolDataBaseTest.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDataBaseTest.Repositories
{
    public class StudentInfoRepository
    {
        StudentInfoContext studentInfoContext;

        public StudentInfoRepository(StudentInfoContext studentInfoContext)
        {
            this.studentInfoContext = studentInfoContext;
        }
    }
}
