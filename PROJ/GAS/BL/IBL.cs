using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BL
{
    public interface IBL
    {
        #region Tester
        /// <summary>
        /// Functions
        /// </summary>
        void AddTester(Tester T); //Add Tester
        void DeleteTester(int TesterID); //Delete Tester
        void UpdateTester(Tester T); //Update Tester
        IEnumerable<Tester> GetAllTester(Func<Tester, bool> predicat = null);
        
        
   
        #endregion
       
        #region Trainee
        /// <summary>
        /// Functions
        /// </summary>
        void AddTrainee(Trainee T); //Add Trainee
        void DeleteTrainee(int TraineeID); //Delete Trainee
        void UpdateTrainee(Trainee T);  //Update Trainee
        Trainee GetTrainee(int numT);
        IEnumerable<Trainee> GetAllTrainee(Func<Trainee, bool> predicate = null);
        
        
	

	}
        #endregion
        
        #region Test
        /// <summary>
        /// Functions
        /// </summary>
        void AddTest(Test T); //Add Test
        void DeleteTest(Test T); //Delete Test
        void Updatetest(Test T); //Update Test
        IEnumerable<Test> GetAllTest(Func<Test, bool> predicat = null);

    #endregion


}
}
