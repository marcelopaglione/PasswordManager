
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PasswordManager.Entities
{
    public class PasswordHistory
    {
        public int ID { get; set; }

        public User User { get; set; }
        public int UserID { get; set; }

        public string NameBefore { get; set; }
        public string EmailBefore { get; set; }
        public string UsernameBefore { get; set; }
        public string WebsiteBefore { get; set; }
        public string TextBefore { get; set; }
        public string NotesBefore { get; set; }

        public string DateModifiedBefore { get; set; }

        public string NameAfter { get; set; }
        public string EmailAfter { get; set; }
        public string UsernameAfter { get; set; }
        public string WebsiteAfter { get; set; }
        public string TextAfter { get; set; }
        public string NotesAfter { get; set; }

        public string DateModifiedAfter { get; set; }

        public string GetToString()
        {
            StringBuilder passwordHistory = new StringBuilder();
            passwordHistory.Append($"{nameof(ID)}: ").Append(ID).Append(Environment.NewLine);
            if (NameBefore != null)
            {
                passwordHistory.Append($"{nameof(NameBefore)}: ").Append(NameBefore).Append(Environment.NewLine);
            }
            if (NameAfter != null)
            {
                passwordHistory.Append($"{nameof(NameAfter)}: ").Append(NameAfter).Append(Environment.NewLine);
            }

            if (EmailBefore != null)
            {
                passwordHistory.Append($"{nameof(EmailBefore)}: ").Append(EmailBefore).Append(Environment.NewLine);
            }
            if (EmailAfter != null)
            {
                passwordHistory.Append($"{nameof(EmailAfter)}: ").Append(EmailAfter).Append(Environment.NewLine);
            }

            if (UsernameBefore != null)
            {
                passwordHistory.Append($"{nameof(UsernameBefore)}: ").Append(UsernameBefore).Append(Environment.NewLine);
            }
            if (UsernameAfter != null)
            {
                passwordHistory.Append($"{nameof(UsernameAfter)}: ").Append(UsernameAfter).Append(Environment.NewLine);
            }

            if (WebsiteBefore != null)
            {
                passwordHistory.Append($"{nameof(WebsiteBefore)}: ").Append(WebsiteBefore).Append(Environment.NewLine);
            }
            if (WebsiteAfter != null)
            {
                passwordHistory.Append($"{nameof(WebsiteAfter)}: ").Append(WebsiteAfter).Append(Environment.NewLine);
            }

            if (TextBefore != null)
            {
                passwordHistory.Append($"{nameof(TextBefore)}: ").Append(TextBefore).Append(Environment.NewLine);
            }
            if (TextAfter != null)
            {
                passwordHistory.Append($"{nameof(TextAfter)}: ").Append(TextAfter).Append(Environment.NewLine);
            }

            if (NotesBefore != null)
            {
                passwordHistory.Append($"{nameof(NotesBefore)}: ").Append(NotesBefore).Append(Environment.NewLine);
            }
            if (NotesAfter != null)
            {
                passwordHistory.Append($"{nameof(NotesAfter)}: ").Append(NotesAfter).Append(Environment.NewLine);
            }

            if (passwordHistory.Length > 0)
            {
                passwordHistory.Append(Environment.NewLine);
            }

            return passwordHistory.ToString();
        }
    }
}