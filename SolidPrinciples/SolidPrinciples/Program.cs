using SolidPrinciples.SOLID.Single_Responsibility_Principle.With_SRP;
using SolidPrinciples.SOLID.Single_Responsibility_Principle.Without_SRP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Without Single Responsibility Principle :-
            ////Every thing is wrapped into single class.
            //Employee ObjEmp = new Employee();
            //ObjEmp.EmloyeeId = 1;
            //ObjEmp.EmployeeName = "Avinash";
            //if (ObjEmp.InsertEmployeeDetails(ObjEmp))
            //{
            //    ObjEmp.GenerateEmployeeImage(ObjEmp);
            //}

            ////Single Responsibility Principle :-
            ////Employee Related functionality in Employee Class.
            ////Image Generation Related functionality in ImageGeneration Class.
            //EmployeeSRP ObjEmpSrp = new EmployeeSRP();
            //ObjEmpSrp.EmloyeeId = 1;
            //ObjEmpSrp.EmployeeName = "Avinash";
            //if (ObjEmpSrp.InsertEmployeeDetails(ObjEmpSrp))
            //{
            //    ImageGeneration ObjImageGeneration = new ImageGeneration();
            //    ObjImageGeneration.GenerateEmployeeImage(ObjEmpSrp);
            //}

            //Employee Objemp = new Employee();
            //Objemp.EmloyeeId = 1;
            //Objemp.EmployeeName = "Avinash";
            //ImageGeneration Obj = new ImageGeneration();


        }
    }
}
