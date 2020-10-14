using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;
using Model;

namespace BAL
{
    public class EmployeeDetail_BAL
    {

        EmployeeDetail_DAL dal = new EmployeeDetail_DAL();
        EmployeeDetail_Model model = new EmployeeDetail_Model();

       
        public int SaveEmployeeDetail(EmployeeDetail_Model model)
        {

            return dal.SaveEmployeeDetail(model);
        }

        public DataTable FillFirstName()
        {

            return dal.FillFirstName();
        }

        public DataTable SearchEmployeeDetail(int EmpId)
        {
            return dal.SearchEmployeeDetail(EmpId);
        }

        public int UpdateEmployeeDetail(EmployeeDetail_Model model)
        {

            return dal.UpdateEmployeeDetail(model);
        }


        public int DeleteEmployeeDetail(EmployeeDetail_Model model)
        {

            return dal.DeleteEmployeeDetail(model);
        }


    }
}
