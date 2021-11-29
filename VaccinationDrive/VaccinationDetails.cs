using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccinationDrive
{
    class VaccinationDetails
    {

        private List<VaccinationDetails> Doses = new List<VaccinationDetails>();
        

    }
    public enum VaccinationType
    {
        Covaxin=1,
        Covidsheil=2,
        Sputnik =3
    }
    public enum Dosage
    {
        FirstDose=1,
        SecondDose=2
    }
    public enum Datetime
    {
        Datetime_date,
    }
        

   


}
