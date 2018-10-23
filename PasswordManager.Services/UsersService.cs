using PasswordManager.Data;
using PasswordManager.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace PasswordManager.Services
{
    /// <summary>
    /// Provides access to User related objects and data.
    /// </summary>
    public class UsersService
    {
        private static UsersService _instance;

        protected UsersService()
        {
        }

        public static UsersService Instance()
        {
            if (_instance == null)
            {
                _instance = new UsersService();
            }

            return _instance;
        }

        /// <summary>
        /// Determines wether User already exists or not.
        /// </summary>
        /// <param name="user">User to check.</param>
        /// <returns>Boolean: True if User exists, False if not.</returns>
        public Task<bool> UserExistAsync(User user)
        {
            return Task.Factory.StartNew(() =>
            {
                if (ValidationService.Instance().User(user))
                {
                    if (UsersData.Instance().LoginUser(user) != null)
                        return true;
                    else return false;
                }
                else return false;
            });
        }

        /// <summary>
        /// Registers the new User.
        /// </summary>
        /// <param name="user">User to be registered.</param>
        /// <returns>User: The newly registered user with Default Settings.</returns>
        public Task<User> RegisterUserAsync(User user)
        {
            return Task.Factory.StartNew(() =>
            {
                if (ValidationService.Instance().User(user))
                {
                    if (UsersData.Instance().AddNewUser(user, Globals.Defaults.Settings, Globals.Defaults.PasswordOptions) > 0)
                    {
                        return LoginUser(user);
                    }
                    else return null;
                }
                else return null;
            });
        }

        public Task<List<Reminder>> ShowUserReminders(User user, NotifyIcon popupNotifier)
        {
            return Task.Factory.StartNew(() =>
            {
                if (ValidationService.Instance().User(user))
                {
                    List<Reminder> reminders = UsersData.Instance().ShowUserReminders(user);
                    if (reminders.Count > 0)
                    {
                        DateTime today = DateTime.Now;
                        reminders.ForEach(reminder =>
                        {
                        if (DateTime.Compare(today, reminder.ShowReminderDate) >= 1)
                        {
                            popupNotifier.Visible = true;
                            Password pw = (CryptoService.Instance().DecryptUserPassword(user, reminder.ReminderPassword));
                            popupNotifier.ShowBalloonTip(2000, "Bearpass Notification Center", $"Password for {pw.Name} Requires your attention! {reminder.ReminderText}", ToolTipIcon.Info);
                        }
                        });
                        return reminders;
                    }
                    else return null;
                }
                else return null;
            });
        }

        /// <summary>
        /// Login the User.
        /// </summary>
        /// <param name="user">User to be Login.</param>
        /// <returns>User: The logged in User.</returns>
        public Task<User> LoginUserAsync(User user)
        {
            return Task.Factory.StartNew(() =>
            {
                if (ValidationService.Instance().User(user))
                {
                    User UserFromDB = UsersData.Instance().LoginUser(user);
                    if (ValidationService.Instance().User(UserFromDB) && PasswordsService.Instance().IsSame(UserFromDB.Master, user.Master))
                    {
                        return PopulateUserData(UserFromDB);
                    }
                    else return null;
                }
                else return null;
            });
        }

        /// <summary>
        /// Login the User.
        /// </summary>
        /// <param name="user">User to be Login.</param>
        /// <returns>User: The logged in User.</returns>
        public User LoginUser(User user)
        {
            if (ValidationService.Instance().User(user))
            {
                User UserFromDB = UsersData.Instance().LoginUser(user);
                if (ValidationService.Instance().User(UserFromDB) && PasswordsService.Instance().IsSame(UserFromDB.Master, user.Master))
                {
                    return PopulateUserData(UserFromDB);
                }
                else return null;
            }
            else return null;
        }

        /// <summary>
        /// Updates the given User.
        /// </summary>
        /// <param name="user">User to be updated.</param>
        /// <returns>User: updated User.</returns>
        public Task<User> UpdateUserAsync(User user)
        {
            return Task.Factory.StartNew(() =>
            {
                if (ValidationService.Instance().User(user))
                {
                    if (UsersData.Instance().UpdateUser(user) > 0)
                    {
                        return user;
                    }
                    else return user;
                }
                else return null;
            });
        }


        /// <summary>
        /// Updates the given User.
        /// </summary>
        /// <param name="user">User to be updated.</param>
        /// <returns>User: updated User.</returns>
        public User UpdateUser(User user)
        {
            if (ValidationService.Instance().User(user))
                {
                    if (UsersData.Instance().UpdateUser(user) > 0)
                    {
                        return user;
                    }
                    else return user;
                }
                else return null;
        }

        /// <summary>
        /// Populates the User with Passwords and Settings.
        /// </summary>
        /// <param name="user">User to be populated.</param>
        /// <returns>User: User with its Passwords and Settings.</returns>
        public Task<User> PopulateUserDataAsync(User user)
        {
            return Task.Factory.StartNew(() =>
            {
                if (ValidationService.Instance().User(user))
                {
                    user.Passwords = CryptoService.Instance().DecryptUserPasswords(user, PasswordsData.Instance().GetUserPasswords(user));
                    user.Settings = SettingsData.Instance().GetUserSettings(user);
                    user.Settings.PasswordOptions = PasswordOptionsData.Instance().GetPasswordOptionsBySettings(user.Settings);

                    return user;
                }
                else return null;
            });
        }

        /// <summary>
        /// Populates the User with Passwords and Settings.
        /// </summary>
        /// <param name="user">User to be populated.</param>
        /// <returns>User: User with its Passwords and Settings.</returns>
        public User PopulateUserData(User user)
        {
            if (ValidationService.Instance().User(user))
            {
                user.Passwords = CryptoService.Instance().DecryptUserPasswords(user, PasswordsData.Instance().GetUserPasswords(user));
                //user.Settings = (SettingsData.Instance().GetUserSettings(user) == null) ? Globals.Defaults.Settings : SettingsData.Instance().GetUserSettings(user);
                user.Settings = SettingsData.Instance().GetUserSettings(user);
                user.Settings.PasswordOptions = PasswordOptionsData.Instance().GetPasswordOptionsBySettings(user.Settings);

                return user;
            }
            else return null;
        }
    }
}
