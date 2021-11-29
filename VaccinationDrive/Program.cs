using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccinationDrive
{
    class Program
    {
        //creating list
        private static List<BenificiaryDetails> benificiaries = new List<BenificiaryDetails>();
        
        
        
        static void Main(string[] args)
        {
            Program beneficiary = new Program();
           
            
            var data1 = new BenificiaryDetails("Ranjitha R", 8976564356, "Perambalur", 22,1002);
            var data2 = new BenificiaryDetails("Shivya S", 8976564356, "Perambalur", 17,1003);
            benificiaries.Add(data1);
            benificiaries.Add(data2);
           

            string choose;
            do
            {
                Console.WriteLine("-------------Welcome to the VaccinationDrive------------ ");
                Console.WriteLine("Choose the following in the list:\n1.BeneficiaryRgistration \n 2.Vaccination \n 3.Exit");
                Console.WriteLine("Choose the option:");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        beneficiary.BeneficiaryRgistration();
                        break;
                    case 2:
                        beneficiary.Vaccination();
                        break;
                    case 3:
                        beneficiary.Exit();
                        break;
                    default:
                        Console.WriteLine("Enter a valid number:");
                        break;
                }
                Console.WriteLine("Do you want to continue 'yes' or 'no'?");
                choose = Console.ReadLine();


            } while (choose == "yes" );
            Console.WriteLine("Thank you the VaccinationDrive");
            Console.ReadLine();
           

            Console.ReadKey();
        }
        public void BeneficiaryRgistration()
        {
            int doses = 2;
            string choose;
            do
            {
                Console.WriteLine("Enter the Name:");
                string name = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter the City:");
                string city = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter the Gender:\n 1.Unknown\n 2.Male\n 3.Female");
                int Gender = int.Parse(Console.ReadLine());

                Console.WriteLine("Do you want to continue ? 'yes' or 'no'?");
                choose = Console.ReadLine();



            } while (choose=="yes");
            

           





        }
        public void Vaccination()
        {
            
            Console.WriteLine("Enter the RegistrationNumber");
            int registrationNumber =int.Parse(Console.ReadLine());

            int RegistrationId = 1000;


            string pick;
            do {
                if (RegistrationId==1000)
                {
                    Console.WriteLine("What you want to search? \n 1.Take vaccination\n 2.Vaccination history\n3.NextDueDate\n 4.Exit ");
                    int selection = int.Parse(Console.ReadLine());
                }
                else
                    Console.WriteLine("Enter a valid input");



                Console.WriteLine("Do you want  to continue\n 'yes' or 'no'?");
                pick = Console.ReadLine();
            } while (pick == "yes");



        }

        public void Exit()
        {
            Console.WriteLine("---------------->Closing the application<---------------------");
            Console.ReadLine();

        }
       
    }
}
