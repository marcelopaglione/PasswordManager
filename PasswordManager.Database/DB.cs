using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordManager.Entities;
using System.Data.SqlClient;

using System.Data.SQLite;

namespace PasswordManager.Database
{
    /// <summary>
    /// This class gives direct access to Functions with SQL Queries to Database.
    /// </summary>
    public class DB
    {
        private static DB _instance;
        private string ConnectionString;

        protected DB()
        {
            ConnectionString = Properties.Settings.Default["PasswordManagerDBConnection"].ToString();
            //ConnectionString = Properties.Settings.Default["PasswordManagerSQLiteDBConnection"].ToString();
            //ConnectionString = Globals.DatabaseConnection.Instance().GetValue();
        }

        public static DB Instance()
        {
            if (_instance == null)
            {
                _instance = new DB();
            }

            return _instance;
        }
        
        /// <summary>
        /// Add New User with Settings and PasswordOptions
        /// </summary>
        /// <param name="user">User Entity.</param>
        /// <param name="settings">Settings Entity.</param>
        /// <param name="passwordOptions">PasswordOptions Entity.</param>
        /// <returns>Number of Rows Affected.</returns>
        public int AddNewUser(User user)
        {
            int AffectedRows = -1;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                SqlTransaction userTransaction = connection.BeginTransaction();

                command.Connection = connection;
                command.Transaction = userTransaction;

                try
                {
                    //Adding New User Values
                    command.CommandText = "Insert into Users (Name, Username, Email, Master) values (@Name, @Username, @Email, @Master)";
                    command.Parameters.Add(new SqlParameter("Name", user.Name));
                    command.Parameters.Add(new SqlParameter("Username", user.Username));
                    command.Parameters.Add(new SqlParameter("Email", user.Email));
                    command.Parameters.Add(new SqlParameter("Master", user.Master));

                    //Add User to Database
                    AffectedRows = command.ExecuteNonQuery();
                    // Attempt to commit the transaction.
                    userTransaction.Commit();
                }
                catch
                {
                    userTransaction.Rollback();

                    return 0;
                }
            }

            return AffectedRows;
        }
        
        /// <summary>
        /// Get User from Database
        /// </summary>
        /// <param name="userID">User ID to select User.</param>
        /// <returns>User Entity.</returns>
        public User GetUserByID(int userID)
        {
            User user = null;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from Users where ID = @ID", con))
                {
                    cmd.Parameters.Add(new SqlParameter("@ID", userID));

                    con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    user = new User();

                    while (reader.Read())
                    {
                        user.ID = Convert.ToInt32(reader["ID"]);
                        user.Name = reader["Name"].ToString();
                        user.Username = reader["Username"].ToString();
                        user.Email = reader["Email"].ToString();
                        user.Master = reader["Master"].ToString();
                    }
                }
            }

            return user;
        }

        /// <summary>
        /// Get User from Database via Email
        /// </summary>
        /// <param name="Email">User Email to select User.</param>
        /// <returns>User Entity.</returns>
        public User GetUserByEmail(string Email)
        {
            User user = null;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from Users where Email = @Email", con))
                {
                    cmd.Parameters.Add(new SqlParameter("@Email", Email));
                    con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        user = new User();
                        user.ID = Convert.ToInt32(reader["ID"]);
                        user.Name = reader["Name"].ToString();
                        user.Username = reader["Username"].ToString();
                        user.Email = Email;
                        user.Master = reader["Master"].ToString();
                    }                    
                }
            }
            return user;
        }

        /// <summary>
        /// Get User from Database via Email
        /// </summary>
        /// <param name="Username">User Email to select User.</param>
        /// <returns>User Entity.</returns>
        public User GetUserByUsename(string Username)
        {
            User user = null;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from Users where Username = @Username", con))
                {
                    cmd.Parameters.Add(new SqlParameter("@Username", Username));
                    con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        user = new User();
                        user.ID = Convert.ToInt32(reader["ID"]);
                        user.Name = reader["Name"].ToString();
                        user.Username = reader["Username"].ToString();
                        user.Email = reader["Email"].ToString();
                        user.Master = reader["Master"].ToString();
                    }
                }
            }
            return user;
        }

        /// <summary>
        /// Update User
        /// </summary>
        /// <param name="user">User Entity to Update.</param>
        /// <returns>Number of Rows Affected.</returns>
        public int UpdateUser(User user)
        {
            int AffectedRows = -1;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("Update Users set Name= @Name, Username= @Username, @Email=@Email, Master= @Master where ID = @ID", connection))
                {
                    command.Parameters.Add(new SqlParameter("@ID", user.ID));
                    command.Parameters.Add(new SqlParameter("@Name", user.Name));
                    command.Parameters.Add(new SqlParameter("@Username", user.Username));
                    command.Parameters.Add(new SqlParameter("@Email", user.Email));
                    command.Parameters.Add(new SqlParameter("@Master", user.Master));

                    connection.Open();

                    AffectedRows = command.ExecuteNonQuery();
                }
            }
            return AffectedRows;
        }

        /// <summary>
        /// Add New Password to Database.
        /// </summary>
        /// <param name="userID">User ID to add Password for.</param>
        /// <param name="password">Password Entity to be saved.</param>
        /// <returns>Number of Rows Affected.</returns>
        public int AddNewPassword(int userID, Password password)
        {
            
            int AffectedRows = -1;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("Insert into Passwords (UserID, Name, Email, Username, Website, Text, Notes, DateCreated, DateModified) values (@UserID, @Name, @Email, @Username, @Website, @Text, @Notes, @DateCreated, @DateModified)", connection))                    
                {
                    command.Parameters.Add(new SqlParameter("UserID", userID));
                    command.Parameters.Add(new SqlParameter("Name", password.Name));
                    command.Parameters.Add(new SqlParameter("Email", password.Email));
                    command.Parameters.Add(new SqlParameter("Username", password.Username));
                    command.Parameters.Add(new SqlParameter("Website", password.Website));
                    command.Parameters.Add(new SqlParameter("Text", password.Text));
                    command.Parameters.Add(new SqlParameter("Notes", password.Notes));
                    command.Parameters.Add(new SqlParameter("DateCreated", password.DateCreated));
                    command.Parameters.Add(new SqlParameter("DateModified", password.DateModified));

                    connection.Open();

                    AffectedRows = command.ExecuteNonQuery();
                }
            }
            AddNewPasswordHistory(userID, password, "INSERT");
            return AffectedRows;
        }

        /// <summary>
        /// Add New Password to Database.
        /// </summary>
        /// <returns>Add History Password.</returns>
        public int AddNewPasswordHistory(int userID, Password passwordBefore, string operation)
        {
            Password passwordAfter;
            if (operation.Equals("DELETE"))
            {
                passwordAfter = null;
            }
            else
            if (operation.Equals("INSERT")){
                passwordAfter = GetPasswordByNameEmailAndUsername(passwordBefore.Name, passwordBefore.Email, passwordBefore.Username);
                passwordBefore.ID = passwordAfter.ID;
                passwordAfter = null;
            }
            else
            {
                passwordAfter = GetPasswordByID(passwordBefore.ID);
            }

            int AffectedRows = -1;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(
                    "Insert into [PasswordsHistory] ([PasswordID],[UserID]," +
                    "[NameBefore],[EmailBefore],[UsernameBefore],[WebsiteBefore],[TextBefore],[NotesBefore],[DateModifiedBefore]," +
                    "[NameAfter],[EmailAfter],[UsernameAfter],[WebsiteAfter],[TextAfter],[NotesAfter],[DateModifiedAfter],[Operation]) " +
                    "values (" +
                    "@PasswordID, @UserID, " +
                    "@NameBefore, @EmailBefore, @UsernameBefore, @WebsiteBefore, @TextBefore, @NotesBefore, @DateModifiedBefore," +
                    "@NameAfter, @EmailAfter, @UsernameAfter, @WebsiteAfter, @TextAfter, @NotesAfter, @DateModifiedAfter,@Operation)", connection))
                {
                    command.Parameters.Add(new SqlParameter("@UserID", userID));
                    command.Parameters.Add(new SqlParameter("@Operation", operation));
                    command.Parameters.Add(new SqlParameter("@PasswordID", passwordBefore.ID));
                    

                    AddSQLParameter(command, passwordBefore.Username, passwordAfter?.Username, "@Username");
                    AddSQLParameter(command, passwordBefore.Name, passwordAfter?.Name, "@Name");
                    AddSQLParameter(command, passwordBefore.Email, passwordAfter?.Email, "@Email");
                    AddSQLParameter(command, passwordBefore.Website, passwordAfter?.Website, "@Website");
                    AddSQLParameter(command, passwordBefore.Text, passwordAfter?.Text, "@Text");
                    AddSQLParameter(command, passwordBefore.Notes, passwordAfter?.Notes, "@Notes");
                    AddSQLParameter(command, passwordBefore.DateModified.ToString(), passwordAfter?.DateModified.ToString(), "@DateModified");                    

                    connection.Open();

                    AffectedRows = command.ExecuteNonQuery();
                }
            }

            return AffectedRows;
        }

        private void AddSQLParameter(SqlCommand command,string passwordBefore, string passwordAfter,string parameterName)
        {
            if (passwordAfter == null && passwordBefore != null)
            {
                command.Parameters.Add(new SqlParameter($"{parameterName.Replace("@","")}Before", passwordBefore));
                command.Parameters.Add(new SqlParameter($"{parameterName.Replace("@", "")}After", DBNull.Value));
            }
            else
            if (!ComparePasswordDetail(passwordBefore, passwordAfter))
            {
                command.Parameters.Add(new SqlParameter($"{parameterName.Replace("@", "")}Before", passwordBefore));
                command.Parameters.Add(new SqlParameter($"{parameterName.Replace("@", "")}After", passwordAfter));
            }            
            else
            {
                command.Parameters.Add(new SqlParameter($"{parameterName.Replace("@", "")}Before", DBNull.Value));
                command.Parameters.Add(new SqlParameter($"{parameterName.Replace("@", "")}After", DBNull.Value));
            }
        }

        private bool ComparePasswordDetail(string detailBefore, string detailAfter)
        {
            return detailAfter==detailBefore;
        }


        /// <summary>
        /// Get List of Passwords.
        /// </summary>
        /// <param name="userID">User ID for Passwords</param>
        /// <returns>List of Passwords.</returns>
        public Password GetPasswordByNameEmailAndUsername(string name, string email, string username)
        {
            List<Password> passwords = new List<Password>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string sql = "Select top 1 * from Passwords where Name = @Name AND Email = @Email AND Username = @Username";
                //string sqlNoFilter = "Select * from Passwords order by Name DESC";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add(new SqlParameter("@Name", name));
                    command.Parameters.Add(new SqlParameter("@Username", username));
                    command.Parameters.Add(new SqlParameter("@Email", email));

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    Password password;

                    while (reader.Read())
                    {
                        password = new Password();
                        password.ID = Convert.ToInt32(reader["ID"]);
                        password.UserID = Convert.ToInt32(reader["UserID"]);
                        password.Name = reader["Name"].ToString();
                        password.Email = reader["Email"].ToString();
                        password.Username = reader["Username"].ToString();
                        password.Website = reader["Website"].ToString();
                        password.Text = reader["Text"].ToString();
                        password.Notes = reader["Notes"].ToString();
                        password.DateCreated = Convert.ToDateTime(reader["DateCreated"].ToString());
                        password.DateModified = Convert.ToDateTime(reader["DateModified"].ToString());

                        passwords.Add(password);
                    }
                }
            }

            return passwords.FirstOrDefault();
        }

        /// <summary>
        /// Get List of Passwords.
        /// </summary>
        /// <param name="password ID"></param>
        /// <returns>List of Passwords.</returns>
        public Password GetPasswordByID(int ID)
        {
            List<Password> passwords = new List<Password>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string sql = "Select top 1 * from Passwords where ID = @Id";
                //string sqlNoFilter = "Select * from Passwords order by Name DESC";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add(new SqlParameter("@ID", ID));

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    Password password;

                    while (reader.Read())
                    {
                        password = new Password();
                        password.ID = Convert.ToInt32(reader["ID"]);
                        password.UserID = Convert.ToInt32(reader["UserID"]);
                        password.Name = reader["Name"].ToString();
                        password.Email = reader["Email"].ToString();
                        password.Username = reader["Username"].ToString();
                        password.Website = reader["Website"].ToString();
                        password.Text = reader["Text"].ToString();
                        password.Notes = reader["Notes"].ToString();
                        password.DateCreated = Convert.ToDateTime(reader["DateCreated"].ToString());
                        password.DateModified = Convert.ToDateTime(reader["DateModified"].ToString());

                        passwords.Add(password);
                    }
                }
            }

            return passwords.FirstOrDefault();
        }

        /// <summary>
        /// Add List of New Passwords to Database.
        /// </summary>
        /// <param name="userID">User ID to Add Passwords to.</param>
        /// <param name="passwords">List of Passwords.</param>
        /// <returns>Number of Rows Affected.</returns>
        public int AddNewPasswords(int userID, List<Password> passwords)
        {
            //use transaction in here -gul:0401171330

            int AffectedRows = 0;
            foreach (Password password in passwords)
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(
                        "Insert into Passwords (UserID, Name, Email, Username, Website, Text, Notes, DateCreated, DateModified) values (@UserID, @Name, @Email, @Username, @Website, @Text, @Notes, @DateCreated, @DateModified)", connection))
                    {
                        command.Parameters.Add(new SqlParameter("UserID", userID));
                        command.Parameters.Add(new SqlParameter("Name", password.Name));
                        command.Parameters.Add(new SqlParameter("Email", password.Email));
                        command.Parameters.Add(new SqlParameter("Username", password.Username));
                        command.Parameters.Add(new SqlParameter("Website", password.Website));
                        command.Parameters.Add(new SqlParameter("Text", password.Text));
                        command.Parameters.Add(new SqlParameter("Notes", password.Notes));
                        command.Parameters.Add(new SqlParameter("DateCreated", password.DateCreated));
                        command.Parameters.Add(new SqlParameter("DateModified", password.DateModified));

                        connection.Open();

                        AffectedRows += command.ExecuteNonQuery();
                    }
                }
            }

            return AffectedRows;
        }

        /// <summary>
        /// Get List of Passwords.
        /// </summary>
        /// <param name="userID">User ID for Passwords</param>
        /// <returns>List of Passwords.</returns>
        public List<Password> GetPasswordsByUserID(int userID)
        {
            List<Password> passwords = new List<Password>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string sql = "Select * from Passwords where UserID = @UserID order by Name DESC";
                //string sqlNoFilter = "Select * from Passwords order by Name DESC";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add(new SqlParameter("@UserID", userID));

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    Password password;

                    while (reader.Read())
                    {
                        password = new Password();
                        password.ID = Convert.ToInt32(reader["ID"]);
                        password.UserID = userID;
                        password.Name = reader["Name"].ToString();
                        password.Email = reader["Email"].ToString();
                        password.Username = reader["Username"].ToString();
                        password.Website = reader["Website"].ToString();
                        password.Text = reader["Text"].ToString();
                        password.Notes = reader["Notes"].ToString();
                        password.DateCreated = Convert.ToDateTime(reader["DateCreated"].ToString());
                        password.DateModified = Convert.ToDateTime(reader["DateModified"].ToString());

                        passwords.Add(password);
                    }
                }
            }

            return passwords;
        }

        /// <summary>
        /// Update the supplied Password
        /// </summary>
        /// <param name="userID">User ID for Password.</param>
        /// <param name="password">Password Entity to be updated.</param>
        /// <returns>Number of Rows Affected.</returns>
        public int UpdatePasswordByUserID(int userID, Password password)
        {
            Password passwordBefore = GetPasswordByID(password.ID);
            int AffectedRows = 0;            
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(
                "Update Passwords set Name= @Name, Email=@Email, Username= @Username, Website= @Website, Text= @Text, Notes= @Notes, DateCreated= @DateCreated, DateModified= @DateModified where ID = @ID AND UserID= @UserID", connection))
                {
                    command.Parameters.Add(new SqlParameter("ID", password.ID));
                    command.Parameters.Add(new SqlParameter("UserID", userID));
                    command.Parameters.Add(new SqlParameter("Name", password.Name));
                    command.Parameters.Add(new SqlParameter("Email", password.Email));
                    command.Parameters.Add(new SqlParameter("Username", password.Username));
                    command.Parameters.Add(new SqlParameter("Website", password.Website));
                    command.Parameters.Add(new SqlParameter("Text", password.Text));
                    command.Parameters.Add(new SqlParameter("Notes", password.Notes));
                    command.Parameters.Add(new SqlParameter("DateCreated", password.DateCreated));
                    command.Parameters.Add(new SqlParameter("DateModified", password.DateModified));

                    connection.Open();

                    AffectedRows = command.ExecuteNonQuery();
                }
            }
            AddNewPasswordHistory(userID, passwordBefore, "UPDATE");
            return AffectedRows;
        }

        /// <summary>
        /// Updates List of Passwords.
        /// </summary>
        /// <param name="userID">User ID for Passwords.</param>
        /// <param name="passwords">List of Password Entities.</param>
        /// <returns>Number of Rows Affected.</returns>
        public int UpdatePasswordsByUserID(int userID, List<Password> passwords)
        {
            //we'll use transaction in here
            int AffectedRows = 0;

            foreach (Password password in passwords)
            {
                AffectedRows += UpdatePasswordByUserID(userID, password);
            }

            return AffectedRows;
        }

        /// <summary>
        /// Deletes the Password.
        /// </summary>
        /// <param name="userID">User ID for Password.</param>
        /// <param name="passwordID">Password ID for Password.</param>
        /// <returns>Number of Rows Affected.</returns>
        public int DeletePasswordByID(int userID, int passwordID)
        {
            int AffectedRows = 0;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(
                "Delete from Passwords where ID = @ID AND UserID = @UserID", connection))
                {
                    command.Parameters.Add(new SqlParameter("ID", passwordID));
                    command.Parameters.Add(new SqlParameter("UserID", userID));

                    connection.Open();

                    AffectedRows = command.ExecuteNonQuery();
                }
            }
            Password p = new Password()
            {
                ID = passwordID
            };
            AddNewPasswordHistory(userID, p, "DELETE");
            return AffectedRows;
        }

        /// <summary>
        /// Add Settings to Database for the User.
        /// </summary>
        /// <param name="userID">User ID for Settings.</param>
        /// <param name="settings">Settings Entity to Saved.</param>
        /// <returns>Number of Rows Affected.</returns>
        public int AddSettingsByUserID(int userID, Settings settings)
        {
            int AffectedRows = 0;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(
                "Insert into Settings (UserID, DateTimeFormat, ShowEmailColumn, ShowUsernameColumn, ShowPasswordColumn) values (@UserID, @DateTimeFormat, @ShowEmailColumn, @ShowUsernameColumn, @ShowPasswordColumn)", connection))
                {
                    command.Parameters.Add(new SqlParameter("UserID", userID));
                    command.Parameters.Add(new SqlParameter("DateTimeFormat", settings.DateTimeFormat));
                    command.Parameters.Add(new SqlParameter("ShowEmailColumn", settings.ShowEmailColumn));
                    command.Parameters.Add(new SqlParameter("ShowUsernameColumn", settings.ShowUsernameColumn));
                    command.Parameters.Add(new SqlParameter("ShowPasswordColumn", settings.ShowPasswordColumn));

                    connection.Open();

                    AffectedRows = command.ExecuteNonQuery();
                }
            }

            return AffectedRows;
        }

        /// <summary>
        /// Get Settings against the Supplied User ID
        /// </summary>
        /// <param name="userID">User ID for Settings</param>
        /// <returns>Settings Entity for User.</returns>
        public Settings GetSettingsByUserID(int userID)
        {
            Settings settings = null;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(
                "Select * from Settings where UserID = @UserID", connection))
                {
                    command.Parameters.Add(new SqlParameter("@UserID", userID));

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        settings = new PasswordManager.Entities.Settings();

                        settings.ID = Convert.ToInt32(reader["ID"]);
                        settings.UserID = userID;
                        settings.ShowEmailColumn = Convert.ToBoolean(reader["ShowEmailColumn"]);
                        settings.ShowUsernameColumn = Convert.ToBoolean(reader["ShowUsernameColumn"]);
                        settings.ShowPasswordColumn = Convert.ToBoolean(reader["ShowPasswordColumn"]);
                        settings.DateTimeFormat = reader["DateTimeFormat"].ToString();
                    }
                }
            }

            return settings;
        }

        /// <summary>
        /// Updates Settings for supplied User ID
        /// </summary>
        /// <param name="userID">User ID for Settings</param>
        /// <param name="settings">Settings Entity to be updated.</param>
        /// <returns>Number of Rows Affected.</returns>
        public int UpdateSettingsByUserID(int userID, Settings settings)
        {
            int AffectedRows = 0;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(
                "Update Settings set DateTimeFormat= @DateTimeFormat, ShowEmailColumn=@ShowEmailColumn, ShowUsernameColumn= @ShowUsernameColumn, ShowPasswordColumn = @ShowPasswordColumn where ID = @ID AND UserID = @UserID", connection))
                {
                    command.Parameters.Add(new SqlParameter("ID", settings.ID));
                    command.Parameters.Add(new SqlParameter("UserID", userID));
                    command.Parameters.Add(new SqlParameter("DateTimeFormat", settings.DateTimeFormat));
                    command.Parameters.Add(new SqlParameter("ShowEmailColumn", settings.ShowEmailColumn));
                    command.Parameters.Add(new SqlParameter("ShowUsernameColumn", settings.ShowUsernameColumn));
                    command.Parameters.Add(new SqlParameter("ShowPasswordColumn", settings.ShowPasswordColumn));

                    connection.Open();

                    AffectedRows = command.ExecuteNonQuery();
                }
            }
            return AffectedRows;
        }


        public int AddPasswordOptionsBySettingsID(int settingsID, PasswordOptions passwordOptions)
        {
            int AffectedRows = 0;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(@"Insert into PasswordOptions (SettingsID, AllowLowercaseCharacters, AllowUppercaseCharacters, AllowNumberCharacters, AllowSpecialCharacters, AllowUnderscoreCharacters, AllowSpaceCharacters, AllowOtherCharacters, RequireLowercaseCharacters, RequireUppercaseCharacters, RequireNumberCharacters, RequireSpecialCharacters, RequireUnderscoreCharacters, RequireSpaceCharacters, RequireOtherCharacters, MinimumCharacters, MaximumCharacters ) values (@SettingsID, @AllowLowercaseCharacters, @AllowUppercaseCharacters, @AllowNumberCharacters, @AllowSpecialCharacters, @AllowUnderscoreCharacters, @AllowSpaceCharacters, @AllowOtherCharacters, @RequireLowercaseCharacters, @RequireUppercaseCharacters, @RequireNumberCharacters, @RequireSpecialCharacters, @RequireUnderscoreCharacters, @RequireSpaceCharacters, @RequireOtherCharacters, @MinimumCharacters, @MaximumCharacters)", connection))
                {
                    command.Parameters.Add(new SqlParameter("SettingsID", settingsID));
                    command.Parameters.Add(new SqlParameter("AllowLowercaseCharacters", passwordOptions.AllowLowercaseCharacters));
                    command.Parameters.Add(new SqlParameter("AllowUppercaseCharacters", passwordOptions.AllowUppercaseCharacters));
                    command.Parameters.Add(new SqlParameter("AllowNumberCharacters", passwordOptions.AllowNumberCharacters));
                    command.Parameters.Add(new SqlParameter("AllowSpecialCharacters", passwordOptions.AllowSpecialCharacters));
                    command.Parameters.Add(new SqlParameter("AllowUnderscoreCharacters", passwordOptions.AllowUnderscoreCharacters));
                    command.Parameters.Add(new SqlParameter("AllowSpaceCharacters", passwordOptions.AllowSpaceCharacters));
                    command.Parameters.Add(new SqlParameter("AllowOtherCharacters", passwordOptions.AllowOtherCharacters));
                    command.Parameters.Add(new SqlParameter("RequireLowercaseCharacters", passwordOptions.RequireLowercaseCharacters));
                    command.Parameters.Add(new SqlParameter("RequireUppercaseCharacters", passwordOptions.RequireUppercaseCharacters));
                    command.Parameters.Add(new SqlParameter("RequireNumberCharacters", passwordOptions.RequireNumberCharacters));
                    command.Parameters.Add(new SqlParameter("RequireSpecialCharacters", passwordOptions.RequireSpecialCharacters));
                    command.Parameters.Add(new SqlParameter("RequireUnderscoreCharacters", passwordOptions.RequireUnderscoreCharacters));
                    command.Parameters.Add(new SqlParameter("RequireSpaceCharacters", passwordOptions.RequireSpaceCharacters));
                    command.Parameters.Add(new SqlParameter("RequireOtherCharacters", passwordOptions.RequireOtherCharacters));
                    command.Parameters.Add(new SqlParameter("MinimumCharacters", passwordOptions.MinimumCharacters));
                    command.Parameters.Add(new SqlParameter("MaximumCharacters", passwordOptions.MaximumCharacters));

                    connection.Open();

                    AffectedRows = command.ExecuteNonQuery();
                }
            }

            return AffectedRows;
        }

        /// <summary>
        /// Get PasswordOptions from Database.
        /// </summary>
        /// <param name="userID">User ID for PasswordOptions</param>
        /// <returns>PasswordOptions Entity.</returns>
        public PasswordOptions GetPasswordOptionsByID(int userID)
        {
            PasswordOptions passwordOptions = null;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(
                "Select * from PasswordOptions where SettingsID = @SettingsID", connection))
                {
                    //this method is rough right now. It will be removed later.
                    command.Parameters.Add(new SqlParameter("@SettingsID", userID));

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        passwordOptions = new PasswordOptions();
                        passwordOptions.AllowLowercaseCharacters = Convert.ToBoolean(reader["AllowLowercaseCharacters"]);
                        passwordOptions.AllowUppercaseCharacters = Convert.ToBoolean(reader["AllowUppercaseCharacters"]);
                        passwordOptions.AllowNumberCharacters = Convert.ToBoolean(reader["AllowNumberCharacters"]);
                        passwordOptions.AllowSpecialCharacters = Convert.ToBoolean(reader["AllowSpecialCharacters"]);
                        passwordOptions.AllowUnderscoreCharacters = Convert.ToBoolean(reader["AllowUnderscoreCharacters"]);
                        passwordOptions.AllowSpaceCharacters = Convert.ToBoolean(reader["AllowSpaceCharacters"]);
                        passwordOptions.AllowOtherCharacters = Convert.ToBoolean(reader["AllowOtherCharacters"]);
                        passwordOptions.RequireLowercaseCharacters = Convert.ToBoolean(reader["RequireLowercaseCharacters"]);
                        passwordOptions.RequireUppercaseCharacters = Convert.ToBoolean(reader["RequireUppercaseCharacters"]);
                        passwordOptions.RequireNumberCharacters = Convert.ToBoolean(reader["RequireNumberCharacters"]);
                        passwordOptions.RequireSpecialCharacters = Convert.ToBoolean(reader["RequireSpecialCharacters"]);
                        passwordOptions.RequireUnderscoreCharacters = Convert.ToBoolean(reader["RequireUnderscoreCharacters"]);
                        passwordOptions.RequireSpaceCharacters = Convert.ToBoolean(reader["RequireSpaceCharacters"]);
                        passwordOptions.RequireOtherCharacters = Convert.ToBoolean(reader["RequireOtherCharacters"]);
                        passwordOptions.MinimumCharacters = Convert.ToInt32(reader["MinimumCharacters"]);
                        passwordOptions.MaximumCharacters = Convert.ToInt32(reader["MaximumCharacters"]);
                        passwordOptions.OtherCharacters = Convert.ToString(reader["OtherCharacters"]);
                    }
                }
            }

            return passwordOptions;
        }

        /// <summary>
        /// Get PasswordOptions by Setting ID
        /// </summary>
        /// <param name="settingsID">Settings ID for PasswordOptions</param>
        /// <returns>PasswordOptions Entity.</returns>
        public PasswordOptions GetPasswordOptionsBySettingsID(int settingsID)
        {
            PasswordOptions passwordOptions = null;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(
                "Select * from PasswordOptions where SettingsID = @SettingsID", connection))
                {
                    command.Parameters.Add(new SqlParameter("@SettingsID", settingsID));

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        passwordOptions = new PasswordOptions();
                        passwordOptions.ID = Convert.ToInt32(reader["ID"]);
                        passwordOptions.SettingsID = settingsID;
                        passwordOptions.AllowLowercaseCharacters = Convert.ToBoolean(reader["AllowLowercaseCharacters"]);
                        passwordOptions.AllowUppercaseCharacters = Convert.ToBoolean(reader["AllowUppercaseCharacters"]);
                        passwordOptions.AllowNumberCharacters = Convert.ToBoolean(reader["AllowNumberCharacters"]);
                        passwordOptions.AllowSpecialCharacters = Convert.ToBoolean(reader["AllowSpecialCharacters"]);
                        passwordOptions.AllowUnderscoreCharacters = Convert.ToBoolean(reader["AllowUnderscoreCharacters"]);
                        passwordOptions.AllowSpaceCharacters = Convert.ToBoolean(reader["AllowSpaceCharacters"]);
                        passwordOptions.AllowOtherCharacters = Convert.ToBoolean(reader["AllowOtherCharacters"]);
                        passwordOptions.RequireLowercaseCharacters = Convert.ToBoolean(reader["RequireLowercaseCharacters"]);
                        passwordOptions.RequireUppercaseCharacters = Convert.ToBoolean(reader["RequireUppercaseCharacters"]);
                        passwordOptions.RequireNumberCharacters = Convert.ToBoolean(reader["RequireNumberCharacters"]);
                        passwordOptions.RequireSpecialCharacters = Convert.ToBoolean(reader["RequireSpecialCharacters"]);
                        passwordOptions.RequireUnderscoreCharacters = Convert.ToBoolean(reader["RequireUnderscoreCharacters"]);
                        passwordOptions.RequireSpaceCharacters = Convert.ToBoolean(reader["RequireSpaceCharacters"]);
                        passwordOptions.RequireOtherCharacters = Convert.ToBoolean(reader["RequireOtherCharacters"]);
                        passwordOptions.MinimumCharacters = Convert.ToInt32(reader["MinimumCharacters"]);
                        passwordOptions.MaximumCharacters = Convert.ToInt32(reader["MaximumCharacters"]);
                        passwordOptions.OtherCharacters = Convert.ToString(reader["OtherCharacters"]);
                    }
                }
            }

            return passwordOptions;
        }

        /// <summary>
        /// Updates PasswordOptions for the Supplied Settings ID.
        /// </summary>
        /// <param name="settingsID">Settings ID for PasswordOptions.</param>
        /// <param name="passwordOptions">PasswordOptions Entity to be updated.</param>
        /// <returns>Number of Rows Affected.</returns>
        public int UpdatePasswordOptionsBySettingsID(int settingsID, PasswordOptions passwordOptions)
        {
            int AffectedRows = 0;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(
                @"Update PasswordOptions set
                  AllowLowercaseCharacters     = @AllowLowercaseCharacters,
                  AllowUppercaseCharacters     = @AllowUppercaseCharacters,
                  AllowNumberCharacters        = @AllowNumberCharacters,
                  AllowSpecialCharacters       = @AllowSpecialCharacters,
                  AllowUnderscoreCharacters    = @AllowUnderscoreCharacters,
                  AllowSpaceCharacters         = @AllowSpaceCharacters,
                  AllowOtherCharacters         = @AllowOtherCharacters,
                  RequireLowercaseCharacters   = @RequireLowercaseCharacters,
                  RequireUppercaseCharacters   = @RequireUppercaseCharacters,
                  RequireNumberCharacters      = @RequireNumberCharacters,
                  RequireSpecialCharacters     = @RequireSpecialCharacters,
                  RequireUnderscoreCharacters  = @RequireUnderscoreCharacters,
                  RequireSpaceCharacters       = @RequireSpaceCharacters,
                  RequireOtherCharacters       = @RequireOtherCharacters,
                  MinimumCharacters            = @MinimumCharacters,
                  MaximumCharacters            = @MaximumCharacters,
                  OtherCharacters              = @OtherCharacters
                  where SettingsID = @SettingsID
                ", connection))
                {
                    command.Parameters.Add(new SqlParameter("SettingsID", settingsID));
                    command.Parameters.Add(new SqlParameter("AllowLowercaseCharacters", passwordOptions.AllowLowercaseCharacters));
                    command.Parameters.Add(new SqlParameter("AllowUppercaseCharacters", passwordOptions.AllowUppercaseCharacters));
                    command.Parameters.Add(new SqlParameter("AllowNumberCharacters", passwordOptions.AllowNumberCharacters));
                    command.Parameters.Add(new SqlParameter("AllowSpecialCharacters", passwordOptions.AllowSpecialCharacters));
                    command.Parameters.Add(new SqlParameter("AllowUnderscoreCharacters", passwordOptions.AllowUnderscoreCharacters));
                    command.Parameters.Add(new SqlParameter("AllowSpaceCharacters", passwordOptions.AllowSpaceCharacters));
                    command.Parameters.Add(new SqlParameter("AllowOtherCharacters", passwordOptions.AllowOtherCharacters));
                    command.Parameters.Add(new SqlParameter("RequireLowercaseCharacters", passwordOptions.RequireLowercaseCharacters));
                    command.Parameters.Add(new SqlParameter("RequireUppercaseCharacters", passwordOptions.RequireUppercaseCharacters));
                    command.Parameters.Add(new SqlParameter("RequireNumberCharacters", passwordOptions.RequireNumberCharacters));
                    command.Parameters.Add(new SqlParameter("RequireSpecialCharacters", passwordOptions.RequireSpecialCharacters));
                    command.Parameters.Add(new SqlParameter("RequireUnderscoreCharacters", passwordOptions.RequireUnderscoreCharacters));
                    command.Parameters.Add(new SqlParameter("RequireSpaceCharacters", passwordOptions.RequireSpaceCharacters));
                    command.Parameters.Add(new SqlParameter("RequireOtherCharacters", passwordOptions.RequireOtherCharacters));
                    command.Parameters.Add(new SqlParameter("MinimumCharacters", passwordOptions.MinimumCharacters));
                    command.Parameters.Add(new SqlParameter("MaximumCharacters", passwordOptions.MaximumCharacters));
                    command.Parameters.Add(new SqlParameter("OtherCharacters", passwordOptions.OtherCharacters));

                    connection.Open();

                    AffectedRows = command.ExecuteNonQuery();
                }
            }

            return AffectedRows;
        }

    }
}
