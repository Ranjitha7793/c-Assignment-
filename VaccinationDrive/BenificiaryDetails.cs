using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccinationDrive
{
    class BenificiaryDetails
    {
        public string beneficiaryName { get; set; }
        public long mobileNumber { get; set; }
        public string city { get; set; }
        public int age { get; set; }

        public int Gender { get; }
        private int registrationId = 1001;
       
        
        public BenificiaryDetails(string BeneficiaryName, long MobileNumber, string City, int Age,int RegistrationId)
        {
            this.beneficiaryName = BeneficiaryName;
            this.mobileNumber = MobileNumber;
            this.city = City;
            this.age = Age;
            this.registrationId = RegistrationId;


            registrationId++;


            

        }
        public void VaccineDetails()
        {
            string click;
            do
            {
                
                Console.WriteLine("Enter the dosage do you want ?\n 1. FirstDose \n 2.SecondDose ?:");
                Console.WriteLine("choose the option:");
                int dose = int.Parse(Console.ReadLine());
                switch (dose)
                {
                    case 1:
                      Console.WriteLine("Your FirstDose Completed");
                        break;
                    case 2:
                        Console.WriteLine("Your secondDoseCompleted");
                        break;               
               

                }
                Console.WriteLine("Do you want to continue ? 'yes' or 'no'?");
                click = Console.ReadLine();

            } while (click == "yes");




            
             

        }
          

            

     
      
     



    }

  
    public enum Gender
    {
        Unknown=1,
        Male=2,
        Female=3,

     

    }
  
  
 
}
