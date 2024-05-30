using System.Diagnostics.SymbolStore;
using System.Xml.Linq;

namespace Method_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, surName, fatherName,finCode,phoneNumber,position;
            int age,salary;
            while (true)
            {
                Console.Write("adinizi daxil edin:");
                name = Console.ReadLine()!;
                if (correctName(name) == -1) Console.WriteLine("ad uzunlugu (2-20) arasinda olmalidir!");
                else if (correctName(name) == -2) Console.WriteLine("Adin bas herfi boyuk daxil edilmelidir!");
                else if (correctName(name) == -3) Console.WriteLine("ad icerisinde yalniz herfler istifade olunmalidir!");
                else if (correctName(name) == 1) break;
            }

            while (true)
            {
                Console.Write("soyadinizi daxil edin:");
                surName = Console.ReadLine()!;
                if (correctSurName(surName) == -1) Console.WriteLine("soyad uzunlugu (2-35) arasinda olmalidir!");
                else if (correctSurName(surName) == -2) Console.WriteLine("soyadin bas herfi boyuk daxil edilmelidir!");
                else if (correctSurName(surName) == -3) Console.WriteLine("soyad icerisinde yalniz herfler istifade olunmalidir!");
                else if (correctSurName(surName) == 1) break;
            }

            while (true)
            {
                Console.Write("ata adinizi daxil edin:");
                fatherName = Console.ReadLine()!;
                if (correctFatherName(fatherName) == -1) Console.WriteLine(" ata adi uzunlugu (2-20) arasinda olmalidir!");
                else if (correctFatherName(fatherName) == -2) Console.WriteLine("ata adinin bas herfi boyuk daxil edilmelidir!");
                else if (correctFatherName(fatherName) == -3) Console.WriteLine("ata adinin icerisinde yalniz herfler istifade olunmalidir!");
                else if (correctFatherName(fatherName) == 1) break;
            }

            while (true)
            {
                Console.Write("yasinizi daxil edin:");
                age = int.Parse(Console.ReadLine())!;
                if (correctage(age)) break;
                else Console.WriteLine("yas araligi 18-65 arasinda olmalidir");
            }

            while (true)
            {
                Console.Write("fin kodunuzu daxil edin:");
                finCode = Console.ReadLine()!;
                if (correctFinCode(finCode) == -1) Console.WriteLine("fin kod 7 simvoldan ibaret olmalidir!");
                else if (correctFinCode(finCode) == -2) Console.WriteLine("fin kod yalnizca boyuk herflerden ve reqemlerden ibaret olmalidir!");
                else if (correctFinCode(finCode) == 1) break;
            }

            while (true)
            {
                Console.Write("mobil nomrenizi daxil edin:");
                phoneNumber = Console.ReadLine()!;
                if (correctPhoneNumber(phoneNumber) == -1) Console.WriteLine("mobil nomre 13 simvoldan ibaret olmalidir!");
                else if (correctPhoneNumber(phoneNumber) == -2) Console.WriteLine("Mobil nomre '+994' ile baslamalidir");
                else if (correctPhoneNumber(phoneNumber) == -3) Console.WriteLine("mobil nomre yalnizca reqemlerden ibaret olmalidir!");
                else if (correctPhoneNumber(phoneNumber) == 1) break;
            }

            while (true)
            {
                Console.Write("vezifenizi daxil edin:");
                position=Console.ReadLine()!;
                if (correctPosition(position)) break;
                else Console.WriteLine("Vezifeler yalniza (HR,Engineer ve Audit) ola biler!");
            }

            while (true)
            {
                Console.Write("maasinizi daxil edin:");
                salary = int.Parse(Console.ReadLine())!;
                if (correctSalary(salary)) break;
                else Console.WriteLine("maas araligi 1500-5000 olmalidir");
            }

            Console.WriteLine($"{name} {surName} istifadeci adi sisteme elave olundu!");




        }

        private static int correctName(string name) 
        {
            if(name.Length<2 || name.Length > 20) return -1;

            if (name[0]<65 || name[0] > 90) return -2;
           
            foreach(char item in name) 
            {
                if(!((item>=65 && item<=90) || (item>=97 && item <= 122))) return -3;
            }

            return 1;
        }
        private static int correctSurName(string surName)
        {
            if (surName.Length < 2 || surName.Length > 35) return -1;

            if (surName[0] < 65 || surName[0] > 90) return -2;

            foreach (char item in surName)
            {
                if (!((item >= 65 && item <= 90) || (item >= 97 && item <= 122))) return -3;
            }

            return 1;
        }
        private static int correctFatherName(string fatherName)
        {
            if (fatherName.Length < 2 || fatherName.Length > 20) return -1;

            if (fatherName[0] < 65 || fatherName[0] > 90) return -2;

            foreach (char item in fatherName)
            {
                if (!((item >= 65 && item <= 90) || (item >= 97 && item <= 122))) return -3;
            }

            return 1;
        }
        private static bool correctage(int age)
        {
            if(age<18 || age > 65) return false;
            
            return true;
        }
        private static int correctFinCode(string code)
        {
            if (code.Length !=7) return -1;
            foreach(char item in code)
            {
                if(!((item>=65 && item<=90) || (item>=48 && item<=57))) return -2;
            }
            return 1;
        }
        private static int correctPhoneNumber(string number)
        {
            if (number.Length != 13) return -1;

            if (!(number[0] == '+' && number[1] == '9' && number[2] == '9' && number[3] == '4')) return -2;

            for(int i=1; i<number.Length; i++)
            {
                if (!(number[i] >= 48 && number[i] <= 57)) return -3;
            }

            return 1;
        }
        private static bool correctPosition(string position)
        {
            if (!(position == "HR" || position == "Engineer" || position == "Audit")) return false;
            else return true;
        }
        private static bool correctSalary(int salary)
        {
            if (salary < 1500 || salary > 5000) return false;

            return true;
        }

    }
}