using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;


namespace DAL
{

    public interface Idal
    {
         bool FindTester(int TesterID);
         void AddTester(Tester T); 
         void DeleteTester(int TesterID);  
         void UpdateTester(Tester T);   
         Tester GetTester(int numT);  
         IEnumerable<Tester> GetAllTesters(Func<Tester, bool> predicat = null);


         bool FindTrainee(int TraineeID);
         void AddTrainee(Trainee T);   
         void DeleteTrainee(int TraineeID);   
         void UpdateTrainee(Trainee T);  
         Trainee GetTrainee(int numT);
         IEnumerable<Trainee> GetAllTrainees(Func<Trainee, bool> predicat = null);


         bool FindTest(Test T);
         void AddTest(Test T);  
         void DeleteTest(int TestID);   
         void UpdateTest(Test T);   
         IEnumerable<Test> GetAllTests(Func<Test, bool> predicat = null);



        List<Test> GetListTests();      
        List<Tester> GetListTesters();          
        List<Trainee> GetListTrainees();  


    }

}
