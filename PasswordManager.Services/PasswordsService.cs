﻿using PasswordManager.Data;
using PasswordManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Services
{
    /// <summary>
    /// Provides access to User related Passwords and data.
    /// </summary>
    public class PasswordsService
    {
        private static PasswordsService _instance;

        protected PasswordsService()
        {
        }

        public static PasswordsService Instance()
        {
            if (_instance == null)
            {
                _instance = new PasswordsService();
            }

            return _instance;
        }

        /// <summary>
        /// Gets All Passwords for the Supplied User.
        /// </summary>
        /// <param name="user">User for whom Passwords are required.</param>
        /// <returns>List of Passwords for the supplied User.</returns>
        public Task<List<Password>> GetAllUserPasswordsAsync(User user)
        {
            return Task.Factory.StartNew(() =>
            {
                if (ValidationService.Instance().User(user))
                {
                    //List<Password> passwords = CryptoService.Instance().Decrypt(user, PasswordsData.Instance().GetUserPasswords(user));
                    List<Password> passwords = PasswordsData.Instance().GetUserPasswords(user);

                    if (passwords != null)//i am not using the validation service here because passwords are not yet decrypted and may return false when validation called -gul:0401171228
                    {
                        passwords = CryptoService.Instance().DecryptUserPasswords(user, passwords);

                        if (ValidationService.Instance().Passwords(passwords))
                        {
                            return passwords;
                        }
                        else return null;
                    }
                    else return null;
                }
                else return null;
            });
        }

        public List<PasswordHistory> GetAllUserPasswordHistory(User user, Password password)
        {
            if (ValidationService.Instance().User(user))
            {
                //List<Password> passwords = CryptoService.Instance().Decrypt(user, PasswordsData.Instance().GetUserPasswords(user));
                List<PasswordHistory> passwords = PasswordsData.Instance().GetPasswordsHistoryByUserID(user, password);

                if (passwords != null)//i am not using the validation service here because passwords are not yet decrypted and may return false when validation called -gul:0401171228
                {
                    return passwords = CryptoService.Instance().DecryptUserPasswords(user, passwords);                    
                }
                else return null;
            }
            else return null;
        }


        /// <summary>
        /// Gets All Passwords for the Supplied User.
        /// </summary>
        /// <param name="user">User for whom Passwords are required.</param>
        /// <returns>List of Passwords for the supplied User.</returns>
        private List<Password> GetAllUserPasswords(User user)
        {
            if (ValidationService.Instance().User(user))
            {
                //List<Password> passwords = CryptoService.Instance().Decrypt(user, PasswordsData.Instance().GetUserPasswords(user));
                List<Password> passwords = PasswordsData.Instance().GetUserPasswords(user);

                if (passwords != null)//i am not using the validation service here because passwords are not yet decrypted and may return false when validation called -gul:0401171228
                {
                    passwords = CryptoService.Instance().DecryptUserPasswords(user, passwords);

                    if (ValidationService.Instance().Passwords(passwords))
                    {
                        return passwords;
                    }
                    else return null;
                }
                else return null;
            }
            else return null;
        }
        /// <summary>
        /// Saves a new Password for the supplied User
        /// </summary>
        /// <param name="user">User for whom Password is to be stored.</param>
        /// <param name="password">Password to be saved.</param>
        /// <returns>Password: The newly saved Password.</returns>
        public Task<Password> SaveNewUserPasswordAsync(User user, Password password)
        {
            return Task.Factory.StartNew(() =>
            {
                if (ValidationService.Instance().User(user) && ValidationService.Instance().Password(password))
                {
                    if (PasswordsData.Instance().SaveNewUserPassword(user, CryptoService.Instance().EncryptUserPassword(user, password)) > 0)
                    {
                        return password;
                    }
                    else return null;
                }
                else return null;
            });
        }

        /// <summary>
        /// Saves List of new Passwords for the supplied User
        /// </summary>
        /// <param name="user">User for whom Password is to be stored.</param>
        /// <param name="passwords">Passwords List to be saved.</param>
        /// <returns>List of Password: The newly saved Passwords.</returns>
        public Task<List<Password>> SaveNewUserPasswordsAsync(User user, List<Password> passwords)
        {
            return Task.Factory.StartNew(() =>
            {
                if (ValidationService.Instance().User(user) && ValidationService.Instance().Passwords(passwords))
                {
                    if (PasswordsData.Instance().SaveNewUserPasswords(user, CryptoService.Instance().EncryptUserPasswords(user, passwords)) > 0)
                    {
                        return passwords;
                    }
                    else return null;
                }
                else return null;
            });
        }

        /// <summary>
        /// Updates the supplied Password.
        /// </summary>
        /// <param name="user">User for whom the Password is to be updated.</param>
        /// <param name="password">Password to be updated.</param>
        /// <returns>Password: The updated password.</returns>
        public Task<Password> UpdateUserPasswordAsync(User user, Password password)
        {
            return Task.Factory.StartNew(() =>
            {
                if (ValidationService.Instance().User(user) && ValidationService.Instance().Password(password))
                {
                    if (PasswordsData.Instance().UpdateUserPassword(user, CryptoService.Instance().EncryptUserPassword(user, password)) > 0)
                    {
                        return password;
                    }
                    else return null;
                }
                else return null;
            });
        }

        /// <summary>
        /// Updates the supplied List of Passwords.
        /// </summary>
        /// <param name="user">User for whom the Password is to be updated.</param>
        /// <param name="passwords">List of Passwords to be updated.</param>
        /// <returns>List of Password: The updated passwords.</returns>
        public Task<List<Password>> UpdateUserPasswordsAsync(User user, List<Password> passwords)
        {
            return Task.Factory.StartNew(() =>
            {
                if (ValidationService.Instance().User(user) && ValidationService.Instance().Passwords(passwords))
                {
                    if (PasswordsData.Instance().UpdateUserPasswords(user, CryptoService.Instance().EncryptUserPasswords(user, passwords)) > 0)
                    {
                        return passwords;
                    }
                    else return null;
                }
                else return null;
            });
        }

        /// <summary>
        /// Updates the supplied List of Passwords.
        /// </summary>
        /// <param name="user">User for whom the Password is to be updated.</param>
        /// <param name="passwords">List of Passwords to be updated.</param>
        /// <returns>List of Password: The updated passwords.</returns>
        public Task<User> ChangeMasterEncryption(User user, string NewMaster)
        {
            return Task.Factory.StartNew(() =>
            {
                if (ValidationService.Instance().User(user))
                {
                    List<Password> allPasswords = GetAllUserPasswords(user);
                    
                    user.Master = NewMaster;
                    user = UsersService.Instance().UpdateUser(user);
                    
                    if (PasswordsData.Instance().UpdateUserPasswords(user, CryptoService.Instance().EncryptUserPasswords(user, allPasswords)) > 0)
                    {
                        return user;
                    }
                    else return null;
                }
                else return null;
            });
        }

        /// <summary>
        /// Removes Password from the Supplied User.
        /// </summary>
        /// <param name="user">User for whom Password is to be removed.</param>
        /// <param name="password">Password to be removed.</param>
        /// <returns>Boolean: True if Password Deleted otherwise False.</returns>
        public Task<bool> RemoveUserPasswordAsync(User user, Password password)
        {
            return Task.Factory.StartNew(() =>
            {
                if (ValidationService.Instance().User(user) && ValidationService.Instance().Password(password))
                {
                    /* No need for decrypting password. We only need ID in the Delete method for work */
                    if (PasswordsData.Instance().DeleteUserPassword(user, password) > 0)
                        return true;
                    else return false;
                }
                else return false;
            });
        }

        /// <summary>
        /// Searches the Required Passwords
        /// </summary>
        /// <param name="user">User whose Passwords are used as source for Search.</param>
        /// <param name="Search">Search Keyword</param>
        /// <param name="LooksFor">Looks for Password Name, Email or Username</param>
        /// <param name="Options">Options for Search Keywords Matched either Equals or Contains </param>
        /// <returns>List of Password: Passwords matching the search criteria.</returns>
        public Task<List<Password>> SearchUserPasswordsAsync(User user, string Search, string LooksFor, string Options)
        {
            //we can send the search query to database -gul:0301171513

            return Task.Factory.StartNew(() =>
            {
                List<Password> AllPasswords = GetAllUserPasswords(user);
                if (ValidationService.Instance().Passwords(AllPasswords))
                {
                    List<Password> searchedPasswords = null;

                    if (string.IsNullOrEmpty(Search))
                    {
                        return AllPasswords;
                    }
                    else
                    {
                        string notContains = string.Empty;
                        string contains = string.Empty;
                        int indexPosition = Search.ToLower().LastIndexOf('^');
                        if (indexPosition > 0)
                        {
                            contains = Search.ToLower().Substring(0, Search.ToLower().LastIndexOf('^')).Trim();
                            notContains = Search.ToLower().Substring(Search.ToLower().LastIndexOf('^')).Replace("^", "").Trim();
                        }
                        else
                        {
                            contains = Search.ToLower();
                        }
                        
                        switch (Options)
                        {
                            case "Contains":
                                if (LooksFor == "Username")
                                {                                   
                                    searchedPasswords = AllPasswords.Where(p => contains.Split(' ').Any(inner => p.Username.ToLower().Trim().Contains(inner))).ToList();
                                    if (indexPosition > 0)
                                    {
                                        searchedPasswords.RemoveAll(p => notContains.Split(' ').Any(inner => p.Username.ToLower().Trim().Contains(inner)));
                                    }
                                }
                                else if (LooksFor == "Email")
                                {
                                    searchedPasswords = AllPasswords.Where(p => contains.Split(' ').Any(inner => p.Email.ToLower().Trim().Contains(inner))).ToList();
                                    if (indexPosition > 0)
                                    {
                                        searchedPasswords.RemoveAll(p => notContains.Split(' ').Any(inner => p.Email.ToLower().Trim().Contains(inner)));
                                    }
                                }
                                else
                                {
                                    searchedPasswords = AllPasswords.Where(p => contains.Split(' ').Any(inner => p.Name.ToLower().Trim().Contains(inner))).ToList();
                                    if (indexPosition > 0)
                                    {
                                        searchedPasswords.RemoveAll(p => notContains.Split(' ').Any(inner => p.Name.ToLower().Trim().Contains(inner)));
                                    }
                                }
                                break;
                            case "Equals":
                                if (LooksFor == "Username")
                                {
                                    searchedPasswords = AllPasswords.Where(p => p.Username.ToLower().Equals(Search.ToLower())).ToList();
                                }
                                else if (LooksFor == "Email")
                                {
                                    searchedPasswords = AllPasswords.Where(p => p.Email.ToLower().Equals(Search.ToLower())).ToList();
                                }
                                else
                                {
                                    searchedPasswords = AllPasswords.Where(p => p.Name.ToLower().Equals(Search.ToLower())).ToList();
                                }
                                break;
                        }
                        return searchedPasswords;
                    }
                }
                else return null;
            });
        }

        /// <summary>
        /// Generates a new Random Password
        /// </summary>
        /// <param name="user">User whose PasswordOptions settings is used.</param>
        /// <returns>String: Random Characters to be used as Password.</returns>
        public Task<string> GeneratePasswordAsync(User user)
        {
            return Task.Factory.StartNew(() =>
            {
                PasswordOptions passwordOptions = null;

                if (ValidationService.Instance().User(user))
                {
                    passwordOptions = PasswordOptionsData.Instance().GetPasswordOptionsBySettings(user.Settings);
                }
                else passwordOptions = Globals.Defaults.PasswordOptions;

                // Make a list of allowed characters.
                string allowed = "";

                if (passwordOptions.AllowLowercaseCharacters) allowed += passwordOptions.LowercaseCharacters;
                if (passwordOptions.AllowUppercaseCharacters) allowed += passwordOptions.UppercaseCharacters;
                if (passwordOptions.AllowNumberCharacters) allowed += passwordOptions.NumberCharacters;
                if (passwordOptions.AllowSpecialCharacters) allowed += passwordOptions.SpecialCharacters;
                if (passwordOptions.AllowUnderscoreCharacters) allowed += passwordOptions.UnderscoreCharacters;
                if (passwordOptions.AllowSpaceCharacters) allowed += passwordOptions.SpaceCharacters;
                if (passwordOptions.AllowOtherCharacters) allowed += passwordOptions.OtherCharacters;

                Random random = new Random();

                int RequiredLength = random.Next(passwordOptions.MinimumCharacters, passwordOptions.MaximumCharacters);

                // Satisfy requirements.
                string password = "";

                password = GenerateRandomWord(RequiredLength-(int)(RequiredLength*0.5));

                if (passwordOptions.RequireLowercaseCharacters &&
                    (password.IndexOfAny(passwordOptions.LowercaseCharacters.ToCharArray()) == -1))
                    password += RandomCharacter(passwordOptions.LowercaseCharacters, random);
                if (passwordOptions.RequireUppercaseCharacters &&
                    (password.IndexOfAny(passwordOptions.UppercaseCharacters.ToCharArray()) == -1))
                    password = AddUpperCaseOnString(password);
                if (passwordOptions.RequireNumberCharacters &&
                    (password.IndexOfAny(passwordOptions.NumberCharacters.ToCharArray()) == -1))
                    password += RandomCharacter(passwordOptions.NumberCharacters, random);
                if (passwordOptions.RequireSpecialCharacters &&
                    (password.IndexOfAny(passwordOptions.SpecialCharacters.ToCharArray()) == -1))
                    password = RandomCharacter(passwordOptions.SpecialCharacters, random)+password;
                if (passwordOptions.RequireUnderscoreCharacters &&
                    (password.IndexOfAny(passwordOptions.UnderscoreCharacters.ToCharArray()) == -1))
                    password += passwordOptions.UnderscoreCharacters;
                if (passwordOptions.RequireSpaceCharacters &&
                    (password.IndexOfAny(passwordOptions.SpaceCharacters.ToCharArray()) == -1))
                    password += passwordOptions.SpaceCharacters;
                if (passwordOptions.RequireOtherCharacters &&
                    (password.IndexOfAny(passwordOptions.OtherCharacters.ToCharArray()) == -1))
                    password += passwordOptions.OtherCharacters;

                password = GenerateRandomWord(RequiredLength - password.Length) + password;
                
                while (password.Length < RequiredLength)
                    password += allowed.Substring(
                        random.Next(0, allowed.Length - 1), 1);                

                return password;
            });
        }

        private string AddUpperCaseOnString(string randomc)
        {
            //a-z -> 97-122
            //A-Z -> 65-90            
            Random random = new Random();

            int randBetweenMax = random.Next(randomc.Length);
            randomc = randBetweenMax >= 0 ? randomc.Insert(randBetweenMax, @""): randomc;

            if (randomc.ElementAt(randBetweenMax) >= 97 && randomc.ElementAt(randBetweenMax) <= 122)
            {
                randomc = ReplaceFirstOccurrance(randomc, randomc.ElementAt(randBetweenMax).ToString(), ((char)(randomc.ElementAt(randBetweenMax) - 32)).ToString());
            }
            else
            {
                randomc = ReplaceFirstOccurrance(randomc, randomc.ElementAt(randBetweenMax).ToString(), ((char)(randomc.ElementAt(randBetweenMax) + 32)).ToString());
            }
            return randomc;
        }

        public static string ReplaceFirstOccurrance(string original, string oldValue, string newValue)
        {
            if (String.IsNullOrEmpty(original))
                return String.Empty;
            if (String.IsNullOrEmpty(oldValue))
                return original;
            if (String.IsNullOrEmpty(newValue))
                newValue = String.Empty;
            int loc = original.IndexOf(oldValue);
            return original.Remove(loc, oldValue.Length).Insert(loc, newValue);
        }

        private string GenerateRandomWord(int requestedLength)
        {
            Random rnd = new Random();
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "y", "z" };
            string[] vowels = { "a", "e", "i", "o", "u" };

            string word = "";

            if (requestedLength == 1)
            {
                word = GetRandomLetter(rnd, vowels);
            }
            else
            {
                for (int i = 0; i < requestedLength; i += 2)
                {
                    word += GetRandomLetter(rnd, consonants) + GetRandomLetter(rnd, vowels);
                }

                word = word.Replace("q", "qu").Substring(0, requestedLength);
            }

            return word;
        }

        private static string GetRandomLetter(Random rnd, string[] letters)
        {
            return letters[rnd.Next(0, letters.Length - 1)];
        }

        /// <summary>
        /// Select Random Character
        /// </summary>
        /// <param name="str">String from which a substring is selected.</param>
        /// <param name="random">Random object for index position</param>
        /// <returns>String: A random string.</returns>
        private string RandomCharacter(string str, Random random)
        {
            return str.Substring(random.Next(0, str.Length - 1), 1);
        }

        /// <summary>
        /// String Randomizer.
        /// </summary>
        /// <param name="str">String which is to be randomize.</param>
        /// <param name="random">Random object for Positioning.</param>
        /// <returns>String: A randomized string.</returns>
        private string RandomizeString(string str, Random random)
        {
            string result = "";
            while (str.Length > 0)
            {
                // Pick a random character.
                int i = random.Next(0, str.Length - 1);
                result += str.Substring(i, 1);
                str = str.Remove(i, 1);
            }
            return result;
        }

        /// <summary>
        /// Determines weather the Supplied Passwords are Same or Not.
        /// </summary>
        /// <param name="Pass1">Password to be Matched.</param>
        /// <param name="Pass2">Password to be Matched With.</param>
        /// <returns>Boolean: True if Same otherwise False.</returns>
        public Task<bool> IsSameAsync(string Pass1, string Pass2)
        {
            //this need a little refactoring in a more better way i think. -gul:0301171513
            return Task.Factory.StartNew(() =>
            {
                return string.Equals(Pass1, Pass2);
            });
        }

        /// <summary>
        /// Determines weather the Supplied Passwords are Same or Not.
        /// </summary>
        /// <param name="Pass1">Password to be Matched.</param>
        /// <param name="Pass2">Password to be Matched With.</param>
        /// <returns>Boolean: True if Same otherwise False.</returns>
        public bool IsSame(string Pass1, string Pass2)
        {
            return string.Equals(Pass1, Pass2);
        }
    }
}
