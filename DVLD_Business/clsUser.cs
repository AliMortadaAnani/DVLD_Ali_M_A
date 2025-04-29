using DVLD_Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsUser
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int ID { get; set; }

        public int PersonID { get; set; }
        public string UserName { get; set; }

        public string Password { get; set; }

        public bool IsActive { get; set; }


        public clsUser()
        {
            ID = -1;
            PersonID = -1;
            UserName = "";
            Password = "";
            IsActive = false;
            Mode = enMode.AddNew;
        }

        private clsUser(int ID, int PersonID, string UserName, string Password, bool IsActive)
        {
            this.ID = ID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;
            Mode = enMode.Update;
        }

        private bool _AddNewUser()
        {
            this.ID = clsUsersData.AddNewUser(this.PersonID, this.UserName, this.Password, this.IsActive);
            return (this.ID != -1);
        }

        private bool _UpdateUser()
        {
            return clsUsersData.UpdateUser(this.ID, this.PersonID, this.UserName, this.Password, this.IsActive);
        }

        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateUser();

            }
            return false;
        }



        public static clsUser Find(int ID)
        {
            int PersonID = -1;
            string UserName = "", Password = "";
            bool IsActive = false;
            if (clsUsersData.GetUserInfoByID(ID, ref PersonID, ref UserName, ref Password, ref IsActive))
                return new clsUser(ID, PersonID, UserName, Password, IsActive);
            else
                return null;
        }




        public static bool DeleteUser(int ID)
        {
            if (clsUsersData.CheckUserIntegrity(ID))
            {
                return false;
            }
            else
            {
                return clsUsersData.DeleteUser(ID);
            }
        }



        public static bool IsUserExist(int ID)
        {
            return clsUsersData.IsUserExist(ID);
        }


        public static int GetUsersCount()
        {
            return clsUsersData.TotalUsersCount();
        }

        public static DataTable GetAllUsers()
        {
            return clsUsersData.GetAllUsers();
        }

        public static DataTable GetUsersByID(int ID)
        {
            return clsUsersData.GetUsersByUserID(ID);
        }

        public static DataTable GetUsersByPersonID(int PersonID)
        {
            return clsUsersData.GetUsersByPersonID(PersonID);
        }

        public static DataTable GetUsersByUserName(string UserName)
        {
            return clsUsersData.GetUsersByUserName(UserName);
        }

        public static DataTable GetUsersByIsActive(string IsActive)
        {
            return clsUsersData.GetUsersByIsActive(IsActive);
        }

      

        public static bool IsUsernameExist(string UserName)
        {
            return clsUsersData.IsUserNameExist(UserName);
        }

        public static bool IsUserExist(string UserName, string Password)
        {
            return (clsUsersData.IsUserExist(UserName, Password)) ;
        }

        public static bool ChangePassword(int ID, string Password)
        {

            return clsUsersData.UpdateUserPassword(ID, Password);

        }

        public static clsUser FindCurrentUser(string Username, string Password)

        {
            if (IsUserExist(Username, Password))
            {
                return Find(clsUsersData.GetUserIDByUserNameAndPassword(Username, Password));
            }
            else
            {
                return null;
            }

        }


        public static DataTable GetUsersByFirstName(string FirstName)
        {
            return clsUsersData.GetAllUsersByFirstName(FirstName);
        }

        public static DataTable GetUsersByLastName(string LastName)
        {
            return clsUsersData.GetAllUsersByLastName(LastName);
        }

    }
}
