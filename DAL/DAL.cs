using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DS;

namespace DAL
{

    public class DAL : Idal
    {
        #region Tester
        /// <summary>
        /// Check if Tester is in Database
        /// </summary>
        /// <param name="TesterID"></param>
        public bool findTester(int TesterID)
        {
            if (DataSource.Testers.Count == 0)
                return false;
            foreach (Tester item in DataSource.Testers)
                if (TesterID == item.ID)
                    return true;
            return false;
        }
        /// <summary>
        /// Add a New Tester 
        /// </summary>
        /// <param name="T"></param>
        public void AddTest(Tester T)
        {
            if (!findTester(T.ID))
                DataSource.Testers.Add(T);
            else
                throw new Exception("Tester Already in Database");
        }
        /// <summary>
        /// Delete a Tester
        /// </summary>
        /// <param name="TesterID"></param>
        public void DeleteTest(int TesterID)
        {
            for (int i = 0; i < DataSource.Testers.Count; i++)
            {
                if (TesterId == DataSource.Testers[i].ID)
                {
                    DataSource.Testers.RemoveAt(i);
                    DataSource.Tests.RemoveAll(Tst => TesterId == Tst.ID);
                }
            }
        }
        /// <summary>
        /// Update Tester Info
        /// </summary>
        /// <param name="T"></param>
        public void updateTester(Tester T)
        {
            for (int i = 0; i < DataSource.Testers.Count; i++)
                if (DataSource.Testers[i].dishId == T.Id)
                    DataSource.Testers[i] = T;
            throw new Exception("Tester Not In Database");
        }
        public Tester GetTester(int numT)
        {
            return DataSource.Testers.FirstOrDefault(T => T.ID == numT);
        }//***********************
        public IEnumerable<Tester> GetAllTester(Func<Tester, bool> predicat = null)
        {
            if (predicat == null)
                return DataSource.Testers.AsEnumerable();
            return DataSource.Testers.Where(predicat);
        }

        #endregion
       
        #region Trainee
        /// <summary>
        /// Check if Trainee is in Database
        /// </summary>
        /// <param name="TraineeID"></param>
        public bool FindTrainee(int TraineeID)
        {
            if (DataSource.Trainees.Count == 0)
                return false;
            foreach (Trainee item in DataSource.Trainees)
                if (TraineeID == item.ID)
                    return true;
            return false;
        }
        /// <summary>
        /// Add trainee
        /// </summary>
        /// <param name="T"></param>
        public void AddTrainee(Trainee T)
        {
            if (!FindTrainee(T.ID))
                DataSource.Trainees.Add(T);
            else
                throw new Exception("Trainee Already in Database");
        }
        /// <summary>
        /// Delete Trainee
        /// </summary>
        /// <param name="TraineeID"></param>
        public void DeleteTrainee(int TraineeID)
        {
            if (!FindTrainee(TraineeID))
                throw new Exception("Trainee Not In Database");
            DataSource.Tests.RemoveAll(Tst => Tst.ID == TraineeID);
            DataSource.Trainees.RemoveAll(Tr => Tr.ID == numberBr);
        }
        /// <summary>
        /// Update Trainee Info
        /// </summary>
        /// <param name="T"></param>
        public void UpdateTrainee(Trainee T)
        {
            bool flag = false;
            for (int i = 0; i < DataSource.Trainees.Count; i++)
                if (DataSource.Trainees[i].ID == T.ID)
                {
                    DataSource.Trainees[i] = T;
                    flag = true;
                }
            if (!flag)
                throw new Exception("Trainee Not In Database");
        }
        public Trainee GetTrainee(int numT)
        {
            return DataSource.Trainees.FirstOrDefault(T => T.branchNumber == numT);
        }
        public IEnumerable<Trainee> GetAllTrainees(Func<Trainee, bool> predicat = null)
        {
            if (predicat == null)
                return DataSource.Trainees.AsEnumerable();
            return DataSource.Trainees.Where(predicat);
        }


        #endregion
       
        #region Test
        /// <summary>
        /// Check if Test is in Database
        /// </summary>
        /// <param name="T"></param>
        /// <returns></returns>
        public bool FindTest(Test T)
        {
            if (DataSource.Tests.Count == 0)
                return false;
            foreach (Test item in DataSource.Tests)
                if (T.ID == item.ID)
                    return true;
            return false;
        }
        /// <summary>
        /// Add Test
        /// </summary>
        /// <param name="T"></param>
        public void AddTest(Test T)
        {
            foreach (Test item in DataSource.Tests)
            {
                Console.WriteLine(item.ToString());
            }
            if (!FindTest(T))
                DataSource.Tests.Add(T);
            else
                throw new Exception("Test Already in Database");
        }
        /// <summary>
        /// Update Test Info
        /// </summary>
        /// <param name="T"></param>
        public void UpdateTesr(Test T)
        {
            for (int i = 0; i < DataSource.Tests.Count; i++)
                if (DataSource.Tests[i].ID == T.ID)
                    DataSource.Tests[i] = T;
            throw new Exception("Test Not In Database");
        }

        #endregion
   
        #region Lists
        public List<Tester> getListTesters()
        {
            return DataSource.testers;
        }
        public List<Trainee> getListTrainees()
        {
            return DataSource.Trainees;
        }
        public List<Test> getListOrderTests()
        {
            return DataSource.Tests;
        }
        #endregion

    }
}
